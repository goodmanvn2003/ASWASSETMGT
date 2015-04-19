using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ASWERP.Models;
using ASWERPModels;
using ASWERPModels.Extensions;
using ASWERPModels.Utilities;
using ASWERPModels.ViewModels;

namespace ASWERP
{
    public partial class Main : Form
    {
        public Login login { get; set; }
        public List<Form> Forms = null;
        private List<ModDateTimePicker> oDateTimePickerList = new List<ModDateTimePicker>();

        public Main()
        {
            InitializeComponent();

            dgvAssets.AutoGenerateColumns = false;
            dgvAssets.DataSource = Loader.ReadDatabase();
            dgvAssetsMgt.AutoGenerateColumns = false;
            dgvAssetsMgt.DataSource = Loader.ReadAssets();

            Forms = new List<Form>();
        }

        private void oDateTimePicker_TextChanged(object sender, EventArgs e)
        {
            var _item = oDateTimePickerList.FirstOrDefault(x => x.Identifier == ((ModDateTimePicker)sender).Identifier);
            if (_item != null)
            {
                dgvAssetsMgt.Rows[_item.CurrentRow].Cells[_item.CurrentColumn].Value = _item.Text.ToString();
            }
        }

        private void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            var _item = oDateTimePickerList.FirstOrDefault(x => x.Identifier == ((ModDateTimePicker)sender).Identifier);
            if (_item != null)
            {
                _item.Visible = false;
                oDateTimePickerList.Remove(_item);
            }  
        }

        private void exitMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAssets_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dgvAssets_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAssets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /* if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("Id"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["Id"].Value);
                if (_value.Length == 0 && e.RowIndex != dgvAssets.NewRowIndex)
                    dgvAssets.Rows[e.RowIndex].Cells["Id"].Value = String.Format("{0}.{1}", AssetVM.ID_PREFIX, Utilities.GenerateAssetsId());
            }*/

            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("EmployeeName"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["EmployeeName"].Value);
                if (!_value.IsUpper())
                    dgvAssets.Rows[e.RowIndex].Cells["EmployeeName"].Value = _value.Trim().ToUpper();
            }

            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("ComputerName"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["ComputerName"].Value);
                if (!_value.ToLower().Contains("asw"))
                    dgvAssets.Rows[e.RowIndex].Cells["ComputerName"].Value = String.Format("ASW{0}", String.Empty).ToUpper();
            }

            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("EmailAddress"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["EmailAddress"].Value);
                if (!Utilities.IsValidEmail(_value))
                {
                    DataGridViewCell cell =
                        dgvAssets.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    e.CellStyle.BackColor = Color.FromArgb(250, 167, 167);
                    cell.ToolTipText = "A valid email should have at least \"@\" and permissible characters";
                }
            }

            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("XLite"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["XLite"].Value);
                if (!_value.HasAllNumbers())
                {
                    DataGridViewCell cell =
                        dgvAssets.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    e.CellStyle.BackColor = Color.FromArgb(250, 167, 167);
                    cell.ToolTipText = "The value must only contain digits";
                }
            }
        }

        private void dgvAssets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("More"))
            {
                if (e.RowIndex >= 0)
                {
                    var id = dgvAssets.Rows[e.RowIndex].Cells["AccessId"].Value;
                    var employeeName = dgvAssets.Rows[e.RowIndex].Cells["EmployeeName"].Value;

                    AssetsHandover assetsHandover = new AssetsHandover(this, Convert.ToInt32(id), Convert.ToString(employeeName));
                    Forms.Add(assetsHandover);

                    assetsHandover.Show();
                }
            }
        }

        private void assetsHandoverMnItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var form in Forms)
            {
                form.Close();
            }
            this.login.Show();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Forms = new List<Form>();
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
                 
        }

        private void dgvAssets_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var _guidNo = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["GuidNo"].Value);
            if (!String.IsNullOrEmpty(_guidNo))
            {
                var _dataId = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["AccessId"].Value);
                if (!String.IsNullOrEmpty(_dataId))
                    ExecuteSavingAssets(Convert.ToInt32(_dataId));
            }
            else
            {
                dgvAssets.Rows[e.RowIndex].Cells["GuidNo"].Value = ExecuteSavingAssets();
            }
                
        }

        private void dgvAssets_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private string ExecuteSavingAssets(int? _id = null)
        {
            var _guidNo = Guid.NewGuid().ToString();
            if (!_id.HasValue)
            {
                List<AssetVM> _details = new List<AssetVM>();
                for (var i = 0; i < dgvAssets.Rows.Count; i++)
                {
                    if (dgvAssets.Rows[i].Index != dgvAssets.NewRowIndex)
                    {
                        var _item = new AssetVM()
                        {
                            GuidNo = _guidNo,
                            AccessId = Convert.ToInt32(dgvAssets.Rows[i].Cells["AccessId"].Value),
                            EmployeeName = Convert.ToInt32(dgvAssets.Rows[i].Cells["EmployeeName"].Value),
                            XLite = Convert.ToString(dgvAssets.Rows[i].Cells["XLite"].Value),
                            ComputerName = Convert.ToString(dgvAssets.Rows[i].Cells["ComputerName"].Value),
                            ComputerType = Convert.ToString(dgvAssets.Rows[i].Cells["ComputerType"].Value),
                            EmailAddress = Convert.ToString(dgvAssets.Rows[i].Cells["EmailAddress"].Value)
                        };
                        _details.Add(_item);
                    }
                }
                Saver dbSaver = new Saver();
                dbSaver.Invoke<AssetVM>(Saver.TYPE_ASSETS, null, _details);

            } else
            {
                List<AssetVM> _details = Loader.ReadDatabase().ToList<AssetVM>();
                for (var i = 0; i < _details.Count(); i++)
                {
                    if (_details[i].AccessId == _id.Value)
                    {
                        for (var j = 0; j < dgvAssets.Rows.Count; j++)
                        {
                            if (Convert.ToInt32(dgvAssets.Rows[j].Cells["AccessId"].Value) == _id.Value)
                            {
                                _details[i].AccessId = Convert.ToInt32(dgvAssets.Rows[j].Cells["AccessId"].Value);
                                _details[i].EmployeeName = Convert.ToInt32(dgvAssets.Rows[j].Cells["EmployeeName"].Value);
                                _details[i].XLite = Convert.ToString(dgvAssets.Rows[j].Cells["XLite"].Value);
                                _details[i].ComputerName = Convert.ToString(dgvAssets.Rows[j].Cells["ComputerName"].Value);
                                _details[i].ComputerType = Convert.ToString(dgvAssets.Rows[j].Cells["ComputerType"].Value);
                                _details[i].EmailAddress = Convert.ToString(dgvAssets.Rows[j].Cells["EmailAddress"].Value);
                                break;
                            }
                        }
                        break;
                    }
                }

                Saver dbSaver = new Saver();
                dbSaver.Invoke<AssetVM>(Saver.TYPE_ASSETS, null, _details);
            }
            return _guidNo;
        }

        private void dgvAssets_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ExecuteSavingAssets();
        }

        private void dgvAssets_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
        }

        private void tsttDoSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string _key = tsttDoSearch.Text.Trim();
                if (_key.Length > 0)
                    dgvAssets.DataSource = Loader.ReadDatabaseWithSearch(_key);
                else
                    dgvAssets.DataSource = Loader.ReadDatabase();
            }
        }

        private void tsttDoSearch_TextChanged(object sender, EventArgs e)
        {
            string _key = tsttDoSearch.Text.Trim();
            if (_key.Length == 0)
                dgvAssets.DataSource = Loader.ReadDatabase();
        }

        private void tsttDoSearch_Leave(object sender, EventArgs e)
        {
        }

        private void searchToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
        }

        private void tsmiUsersMgt_Click(object sender, EventArgs e)
        {
            UsersMgt _userMgt = new UsersMgt();
            if (!Forms.Any(x => x.GetType().Name == _userMgt.GetType().Name)) {
                Forms.Add(_userMgt);
                _userMgt.Parent = this;

                _userMgt.Show();
            }
        }

        private void dgvAssets_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dlgResult = MessageBox.Show("Are you sure you'd like to delete \"" + Convert.ToString(e.Row.Cells[1].Value) + "\"?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void RefreshData()
        {
            this.EmployeeName.DataSource = Loader.UsersSelectList();
        }

        public void RemoveRegisteredForm(Form _form)
        {
            Forms.Remove(_form);
        }

        private void dgvAssetsMgt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime? currentValue = DateTime.Today;
            if (e.ColumnIndex == 6 || e.ColumnIndex == 9)
            {
                if (e.RowIndex >= 0)
                {
                    if (!String.IsNullOrEmpty(Convert.ToString(dgvAssetsMgt.Rows[e.RowIndex].Cells["PurchasedOn"].Value)))
                        currentValue = DateTime.Parse(Convert.ToString(dgvAssetsMgt.Rows[e.RowIndex].Cells["PurchasedOn"].Value));

                    ModDateTimePicker oDateTimePicker = new ModDateTimePicker();
                    oDateTimePicker.Value = currentValue.Value;
                    oDateTimePicker.Identifier = Guid.NewGuid().ToString();
                    oDateTimePicker.CurrentRow = e.RowIndex;
                    oDateTimePicker.CurrentColumn = e.ColumnIndex;

                    dgvAssetsMgt.Controls.Add(oDateTimePicker);

                    oDateTimePicker.Format = DateTimePickerFormat.Short;

                    Rectangle oRectangle = dgvAssetsMgt.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                    oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                    oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                    oDateTimePicker.TextChanged += new EventHandler(oDateTimePicker_TextChanged);

                    oDateTimePicker.Visible = true;

                    oDateTimePickerList.Add(oDateTimePicker);
                }
            }  
        }

        private void dgvAssetsMgt_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ExecuteSavingAssetSpecifier();
        }

        private void dgvAssetsMgt_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dlgResult = MessageBox.Show("Are you sure you'd like to delete \"" + Convert.ToString(e.Row.Cells[1].Value) + "\"?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvAssetsMgt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string _dataId = Convert.ToString(dgvAssetsMgt.Rows[e.RowIndex].Cells["Id"].Value);
            if (!String.IsNullOrEmpty(_dataId))
            {
                ExecuteSavingAssetSpecifier(_dataId);
            }
            else
            {
                dgvAssetsMgt.Rows[e.RowIndex].Cells["Id"].Value = ExecuteSavingAssetSpecifier();
            }
                
        }

        private string ExecuteSavingAssetSpecifier(string _id = null)
        {
            var _guidNo = Guid.NewGuid().ToString();
            if (String.IsNullOrEmpty(_id))
            {
                List<AssetSpecifierVM> _details = new List<AssetSpecifierVM>();
                for (var i = 0; i < dgvAssetsMgt.Rows.Count; i++)
                {
                    if (dgvAssetsMgt.Rows[i].Index != dgvAssetsMgt.NewRowIndex)
                    {
                        var _item = new AssetSpecifierVM()
                        {
                            Id = _guidNo,
                            Type = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["AssetType"].Value),
                            Name = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["AssetName"].Value),
                            Code = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Code"].Value),
                            Tag = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Tag"].Value),
                            Status = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Status"].Value),
                            Location = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Location"].Value),
                            PurchasedOn = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["PurchasedOn"].Value),
                            InvoiceNo = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["InvoiceNo"].Value),
                            WarrantyDate = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["WarrantyDate"].Value),
                            Provider = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Provider"].Value),
                            Remarks = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Remarks"].Value)
                        };
                        _details.Add(_item);
                    }
                }
                Saver dbSaver = new Saver();
                dbSaver.Invoke<AssetSpecifierVM>(Saver.TYPE_ASSETSSPECIFIER, null, _details);

            }
            else
            {
                List<AssetSpecifierVM> _details = Loader.ReadAssets().ToList<AssetSpecifierVM>();
                for (var i = 0; i < _details.Count(); i++)
                {
                    if (_details[i].Id == _id)
                    {
                        for (var j = 0; j < dgvAssetsMgt.Rows.Count; j++)
                        {
                            if (Convert.ToString(dgvAssetsMgt.Rows[j].Cells["Id"].Value) == _id)
                            {
                                _details[i].Type = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["AssetType"].Value);
                                _details[i].Name = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["AssetName"].Value);
                                _details[i].Code = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Code"].Value);
                                _details[i].Tag = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Tag"].Value);
                                _details[i].Status = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Status"].Value);
                                _details[i].Location = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Location"].Value);
                                _details[i].PurchasedOn = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["PurchasedOn"].Value);
                                _details[i].InvoiceNo = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["InvoiceNo"].Value);
                                _details[i].WarrantyDate = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["WarrantyDate"].Value);
                                _details[i].Provider = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Provider"].Value);
                                _details[i].Remarks = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Remarks"].Value);
                                break;
                            }
                        }
                        break;
                    }
                }

                Saver dbSaver = new Saver();
                dbSaver.Invoke<AssetSpecifierVM>(Saver.TYPE_ASSETSSPECIFIER, null, _details);
            }
            return _guidNo;
        }
    }
}
