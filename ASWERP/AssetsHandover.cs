using ASWERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using ASWERPModels.Extensions;

namespace ASWERP
{
    public partial class AssetsHandover : Form
    {
        public Main Parent = null;

        public int Id { get; set; }
        public string Name { get; set; }

        private const string REGEX_CPU_DDRAM = "^(([a-zA-Z0-9 ]|[a-zA-Z0-9])+,([a-zA-Z0-9 ]|[a-zA-Z0-9])+){1}$";
        private const string REGEX_SCREEN = "^SCREEN [a-zA-Z0-9]+$";
        private const string REGEX_ASSETNAME_R1 = "^ASWVNWKS[A-Z0-9]+$";
        private const string REGEX_ASSETNAME_R2 = "^ASWVNMON[A-Z0-9]+$";
        private const string REGEX_ASSETNAME_R3 = "^ASW2VNHEA[A-Z0-9]+$";
        private const string REGEX_ASSETNAME_RD1 = "^ASW[A-Z0-9]+$";
        private const string REGEX_ASSETNAME_RD2 = "^ASW2[A-Z0-9]+$";
        private Regex _Regex = null;

        private const int MaxDetailsRowCount = 5;

        private AssetsHandoverVM ViewModel = null;

        public AssetsHandover(Main _parent, int _id, string _name)
        {
            InitializeComponent();

            Parent = _parent;

            txtName.Text = _name ?? String.Empty;

            // Put data into View Model
            ViewModel = new AssetsHandoverVM();

            // Load other data from JSON if any
            ViewModel = Loader.ReadAssetHandover(_id);
            ViewModel.AccessId = _id;
            ViewModel.Name = _name ?? String.Empty;

            // Show items to view
            cmbDeptName.Text = ViewModel.Department;
            txtGMName.Text = ViewModel.GroupManagerName;
            dtpHandedOverBy.Value = ViewModel.HandoverBy ?? DateTime.Today;
            dtpReceivedBy.Value = ViewModel.ReceivedBy ?? DateTime.Today;
            dtpRecordedBy.Value = ViewModel.RecordedBy ?? DateTime.Today;
            dtpAcknowledgedBy.Value = ViewModel.AcknowledgedBy ?? DateTime.Today;

            if (ViewModel.HandoverBy == null)
                cbxHandedoverBy.Checked = true;
            else
                cbxHandedoverBy.Checked = false;

            if (ViewModel.ReceivedBy == null)
                cbxReceivedBy.Checked = true;
            else
                cbxReceivedBy.Checked = false;

            if (ViewModel.RecordedBy == null)
                cbxRecordedBy.Checked = true;
            else
                cbxRecordedBy.Checked = false;

            if (ViewModel.AcknowledgedBy == null)
                cbxAcknowledgedBy.Checked = true;
            else
                cbxAcknowledgedBy.Checked = false;

            if (ViewModel.Details != null)
            {
                dvgAssetHandoverDetails.AutoGenerateColumns = false;
                dvgAssetHandoverDetails.DataSource = ViewModel.Details.ToDataTable<AssetHandoverDetails>();
            }

            CheckRowCount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Aggregate data
            ViewModel.Department = cmbDeptName.Text;
            ViewModel.GroupManagerName = txtGMName.Text;
            if (cbxHandedoverBy.Checked)
                ViewModel.HandoverBy = null;
            else
                ViewModel.HandoverBy = dtpHandedOverBy.Value;
            if (cbxReceivedBy.Checked)
                ViewModel.ReceivedBy = null;
            else 
                ViewModel.RecordedBy = dtpReceivedBy.Value;
            if (cbxRecordedBy.Checked)
                ViewModel.RecordedBy = null;
            else
                ViewModel.RecordedBy = dtpRecordedBy.Value;
            if (cbxAcknowledgedBy.Checked)
                ViewModel.AcknowledgedBy = null;
            else
                ViewModel.AcknowledgedBy = dtpAcknowledgedBy.Value;
            
            // Parse data grid view to List<>
            ExecuteSavingDetails();

            Saver ahSaver = new Saver();
            ahSaver.Invoke<AssetsHandoverVM>(Saver.TYPE_ASSETSHANDOVER, ViewModel);

            MessageBox.Show("Information saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExecuteSavingDetails()
        {
            List<AssetHandoverDetails> _details = new List<AssetHandoverDetails>();
            for (var i = 0; i < dvgAssetHandoverDetails.Rows.Count; i++)
            {
                if (dvgAssetHandoverDetails.Rows[i].Index != dvgAssetHandoverDetails.NewRowIndex)
                {
                    var _item = new AssetHandoverDetails()
                    {
                        No = i + 1,
                        AssetDescription = Convert.ToString(dvgAssetHandoverDetails.Rows[i].Cells["AssetDescription"].Value),
                        AssetName = Convert.ToString(dvgAssetHandoverDetails.Rows[i].Cells["AssetName"].Value),
                        Quantity = Convert.ToString(dvgAssetHandoverDetails.Rows[i].Cells["Quantity"].Value),
                        Location = Convert.ToString(dvgAssetHandoverDetails.Rows[i].Cells["Location"].Value),
                        Remarks = Convert.ToString(dvgAssetHandoverDetails.Rows[i].Cells["Remarks"].Value)
                    };
                    _details.Add(_item);
                }
            }
            ViewModel.Details = _details;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.PerformClick();

                if (String.IsNullOrEmpty(ViewModel.Name))
                    throw new Exception("Employee name must not be null or empty");

                DocumentParser _parser = new DocumentParser(Path.Combine(Loader.appPath, "Templates", "AssetsHandoverTPL.doc"));
                _parser.DoParse<AssetsHandoverVM>(DocumentParser.DOCUMENTTYPE_ASSETHANDOVER, Path.Combine(Loader.appPath, "Documents", String.Format("{0}.doc", ViewModel.Name.Trim())), ViewModel);

                MessageBox.Show("Export completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Process.Start("explorer.exe", Path.Combine(Loader.appPath, "Documents", String.Format("{0}.doc", ViewModel.Name.Trim())));
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when the request was processed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgAssetHandoverDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dvgAssetHandoverDetails.Columns[e.ColumnIndex].Name.Equals("No"))
            {
                string _value = Convert.ToString(dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["No"].Value);
                if (_value.Length == 0 && e.RowIndex != dvgAssetHandoverDetails.NewRowIndex)
                    dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["No"].Value = String.Format("{0}", Convert.ToString(e.RowIndex + 1));
            }

            if (dvgAssetHandoverDetails.Columns[e.ColumnIndex].Name.Equals("AssetDescription") && e.RowIndex == 0)
            {
                _Regex = new Regex(REGEX_CPU_DDRAM);
                string _value = Convert.ToString(dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetDescription"].Value);

                if (_Regex.IsMatch(_value))
                {
                    var _result = _value.Split(',');

                    dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetDescription"].Value = String.Format("CPU {0} DDRAM {1}", _result[0].Trim(), _result[1].Trim()).ToUpper();
                } else
                {
                    if (!_value.ToLower().Contains("cpu") || !_value.ToLower().Contains("ddram"))
                    {
                        dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetDescription"].Value = String.Format("CPU {0} DDRAM {1}", String.Empty, String.Empty).ToUpper();
                    }
                }
            }

            if (dvgAssetHandoverDetails.Columns[e.ColumnIndex].Name.Equals("AssetDescription") && e.RowIndex == 1)
            {
                string _value = Convert.ToString(dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetDescription"].Value);

                if (!_value.ToLower().Contains("screen"))
                    dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetDescription"].Value = String.Format("SCREEN {0}", String.Empty).ToUpper();
            }

            if (dvgAssetHandoverDetails.Columns[e.ColumnIndex].Name.Equals("AssetDescription") && e.RowIndex == 2)
            {
                string _value = Convert.ToString(dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetDescription"].Value);

                if (!_value.ToLower().Contains("headphone"))
                    dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetDescription"].Value = String.Format("HEADPHONE {0}", String.Empty).ToUpper();
            }

            if (dvgAssetHandoverDetails.Columns[e.ColumnIndex].Name.Equals("AssetName") && e.RowIndex == 0)
            {
                string _value = Convert.ToString(dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetName"].Value);

                if (!_value.ToLower().Contains("asw"))
                    dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetName"].Value = String.Format("ASW{0}", String.Empty).ToUpper();
            }

            if (dvgAssetHandoverDetails.Columns[e.ColumnIndex].Name.Equals("AssetName") && e.RowIndex == 1)
            {
                string _value = Convert.ToString(dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetName"].Value);

                if (!_value.ToLower().Contains("asw"))
                    dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetName"].Value = String.Format("ASW{0}", String.Empty).ToUpper();
            }

            if (dvgAssetHandoverDetails.Columns[e.ColumnIndex].Name.Equals("AssetName") && e.RowIndex == 2)
            {
                _Regex = new Regex(REGEX_ASSETNAME_R3);
                string _value = Convert.ToString(dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetName"].Value);

                if (!_value.ToLower().Contains("asw2"))
                    dvgAssetHandoverDetails.Rows[e.RowIndex].Cells["AssetName"].Value = String.Format("ASW2{0}", String.Empty).ToUpper();
            }
        }

        private void dvgAssetHandoverDetails_CellEnter(object sender, DataGridViewCellEventArgs e) { }

        private void dvgAssetHandoverDetails_CellLeave(object sender, DataGridViewCellEventArgs e) { }

        private void cbxHandedoverBy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHandedoverBy.Checked)
            {
                dtpHandedOverBy.Enabled = false;
            } else
            {
                dtpHandedOverBy.Enabled = true;
            }
            
        }

        private void cbxReceivedBy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxReceivedBy.Checked)
            {
                dtpReceivedBy.Enabled = false;
            }
            else
            {
                dtpReceivedBy.Enabled = true;
            }
        }

        private void cbxRecordedBy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRecordedBy.Checked)
            {
                dtpRecordedBy.Enabled = false;
            }
            else
            {
                dtpRecordedBy.Enabled = true;
            }
        }

        private void cbxAcknowledgedBy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAcknowledgedBy.Checked)
            {
                dtpAcknowledgedBy.Enabled = false;
            }
            else
            {
                dtpAcknowledgedBy.Enabled = true;
            }
        }

        private void AssetsHandover_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckRowCount()
        {
            if (dvgAssetHandoverDetails.Rows != null && dvgAssetHandoverDetails.Rows.Count > MaxDetailsRowCount)
            {
                dvgAssetHandoverDetails.AllowUserToAddRows = false;
            }
            else if (!dvgAssetHandoverDetails.AllowUserToAddRows)
            {
                dvgAssetHandoverDetails.AllowUserToAddRows = true;
            }
        } 

        private void dvgAssetHandoverDetails_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CheckRowCount();
        }

        private void dvgAssetHandoverDetails_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            CheckRowCount();
        }
    }
}
