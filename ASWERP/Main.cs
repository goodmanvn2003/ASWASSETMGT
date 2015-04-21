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

using ClosedXML.Excel;
using System.IO;
using System.Diagnostics;

namespace ASWERP
{
    public partial class Main : Form
    {
        public Login login { get; set; }
        public List<Form> Forms = null;
        private List<ModDateTimePicker> oDateTimePickerList = new List<ModDateTimePicker>();
        private List<ModDateTimePicker> oDateTimePickerList_EmployeeAssets = new List<ModDateTimePicker>();

        public Main()
        {
            InitializeComponent();

            dgvAssets.AutoGenerateColumns = false;
            dgvAssets.DataSource = Loader.ReadDatabase();
            dgvAssetsMgt.AutoGenerateColumns = false;
            dgvAssetsMgt.DataSource = Loader.ReadAssets();
            dgvProviders.AutoGenerateColumns = false;
            dgvProviders.DataSource = Loader.ReadProviders();
            dgvEmployeeAssetsAssignment.AutoGenerateColumns = false;

            this.EmployeeName.DisplayMember = "EmployeeName";
            this.EmployeeName.ValueMember = "Id";
            this.EmployeeName.DataSource = Loader.UsersSelectList();

            cbEmployee.DisplayMember = "EmployeeName";
            cbEmployee.ValueMember = "Id";
            cbEmployee.DataSource = Loader.UsersSelectList();
            cbEmployee.SelectedText = String.Empty;
            cbEmployee.SelectedValue = -1;

            this.AssignedAssetName.DisplayMember = "Name";
            this.AssignedAssetName.ValueMember = "Id";
            this.AssignedAssetName.DataSource = Loader.AssetsSelectList();

            Forms = new List<Form>();
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

                        if (String.IsNullOrEmpty(Convert.ToString(dgvAssets.Rows[i].Cells["GuidNo"].Value)))
                            _item.GuidNo = _guidNo;
                        else
                            _item.GuidNo = Convert.ToString(dgvAssets.Rows[i].Cells["GuidNo"].Value);

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
            if (e.ColumnIndex == 7 || e.ColumnIndex == 10)
            {
                DateTimeForm myDTForm = new DateTimeForm();
                if (myDTForm.ShowDialog() == DialogResult.OK)
                {
                    ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value = ((DateTime)myDTForm.Tag).DisplayDate("{0:MM/dd/yyyy}");
                    ((DataGridView)sender).Invalidate();
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

                        if (String.IsNullOrEmpty(Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Id"].Value)))
                            _item.Id = _guidNo;
                        else
                            _item.Id = Convert.ToString(dgvAssetsMgt.Rows[i].Cells["Id"].Value);

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

        private void tsttDoSearch_Click(object sender, EventArgs e)
        {}

        private void dgvProviders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string _dataId = Convert.ToString(dgvProviders.Rows[e.RowIndex].Cells["GuidId"].Value);
            if (!String.IsNullOrEmpty(_dataId))
            {
                ExecuteSavingProvider(_dataId);
            }
            else
            {
                dgvProviders.Rows[e.RowIndex].Cells["GuidId"].Value = ExecuteSavingProvider();
            }
        }

        private void dgvProviders_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ExecuteSavingProvider();
        }

        private void dgvProviders_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dlgResult = MessageBox.Show("Are you sure you'd like to delete \"" + Convert.ToString(e.Row.Cells[1].Value) + "\"?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private string ExecuteSavingProvider(string _id = null)
        {
            var _guidNo = Guid.NewGuid().ToString();
            if (String.IsNullOrEmpty(_id))
            {
                List<ProviderVM> _details = new List<ProviderVM>();
                for (var i = 0; i < dgvProviders.Rows.Count; i++)
                {
                    if (dgvProviders.Rows[i].Index != dgvProviders.NewRowIndex)
                    {
                        var _item = new ProviderVM()
                        {
                            ProviderName = Convert.ToString(dgvProviders.Rows[i].Cells["ProviderName"].Value),
                            ProviderPhone = Convert.ToString(dgvProviders.Rows[i].Cells["ProviderPhone"].Value),
                            ProviderContact = Convert.ToString(dgvProviders.Rows[i].Cells["ProviderContact"].Value),
                        };

                        if (String.IsNullOrEmpty(Convert.ToString(dgvProviders.Rows[i].Cells["GuidId"].Value)))
                            _item.GuidId = _guidNo;
                        else
                            _item.GuidId = Convert.ToString(dgvProviders.Rows[i].Cells["GuidId"].Value);

                        _details.Add(_item);
                    }
                }

                Saver dbSaver = new Saver();
                dbSaver.Invoke<ProviderVM>(Saver.TYPE_PROVIDERS, null, _details);
            }
            else
            {
                List<ProviderVM> _details = Loader.ReadProviders().ToList<ProviderVM>();
                for (var i = 0; i < _details.Count(); i++)
                {
                    if (_details[i].GuidId == _id)
                    {
                        for (var j = 0; j < dgvProviders.Rows.Count; j++)
                        {
                            if (Convert.ToString(dgvProviders.Rows[j].Cells["GuidId"].Value) == _id)
                            {
                                _details[i].ProviderName = Convert.ToString(dgvProviders.Rows[i].Cells["ProviderName"].Value);
                                _details[i].ProviderPhone = Convert.ToString(dgvProviders.Rows[i].Cells["ProviderPhone"].Value);
                                _details[i].ProviderContact = Convert.ToString(dgvProviders.Rows[i].Cells["ProviderContact"].Value);
                                break;
                            }
                        }
                        break;
                    }
                }

                Saver dbSaver = new Saver();
                dbSaver.Invoke<ProviderVM>(Saver.TYPE_PROVIDERS, null, _details);
            }
            return _guidNo;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Are you sure you would like to export to Excel file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                DoExportAssetsSpecifiers();
            }
        }

        private void DoExportAssetsSpecifiers()
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                string fileName = String.Format("{0}_{1}.xlsx", "assets", DateTime.Now.DisplayDate("{0:dd_MM_yyyy_hh_mm_ss}"));

                wb.Worksheets.Add(dgvAssetsMgt.DataSource as DataTable, "Assets");
                wb.SaveAs(Path.Combine(Loader.documentsPath, fileName));

                MessageBox.Show("Export completed!");

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "EXCEL.EXE";
                startInfo.Arguments = String.Format("\"{0}\"", Path.Combine(Loader.documentsPath, fileName));
                Process.Start(startInfo);
            }
        }

        private void cbFromRequired_CheckedChanged(object sender, EventArgs e)
        {
            var _checked = cbFromRequired.Checked;
            if (_checked)
                dtpFrom.Enabled = false;
            else
                dtpFrom.Enabled = true;
        }

        private void cbUntilRequired_CheckedChanged(object sender, EventArgs e)
        {
            var _checked = cbUntilRequired.Checked;
            if (_checked)
                dtpUntil.Enabled = false;
            else
                dtpUntil.Enabled = true;
        }

        private void dgvEmployeeAssetsAssignment_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ExecuteSavingEmployeeAssetsAssignment(Convert.ToInt32(cbEmployee.SelectedValue));
        }

        private void dgvEmployeeAssetsAssignment_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dlgResult = MessageBox.Show("Are you sure you'd like to delete these data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvEmployeeAssetsAssignment_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string _dataId = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[e.RowIndex].Cells["AssignmentId"].Value);
            if (!String.IsNullOrEmpty(_dataId))
            {
                ExecuteSavingEmployeeAssetsAssignment(Convert.ToInt32(cbEmployee.SelectedValue), _dataId);
            }
            else
            {
                dgvEmployeeAssetsAssignment.Rows[e.RowIndex].Cells["AssignmentId"].Value = ExecuteSavingEmployeeAssetsAssignment(Convert.ToInt32(cbEmployee.SelectedValue));
            }
        }

        private string ExecuteSavingEmployeeAssetsAssignment(int employeeId, string _id = null)
        {
            var _guidNo = Guid.NewGuid().ToString();
            if (String.IsNullOrEmpty(_id))
            {
                List<AssignmentVM> _details = new List<AssignmentVM>();
                for (var i = 0; i < dgvEmployeeAssetsAssignment.Rows.Count; i++)
                {
                    if (dgvEmployeeAssetsAssignment.Rows[i].Index != dgvEmployeeAssetsAssignment.NewRowIndex)
                    {
                        var _item = new AssignmentVM()
                        {
                            AssignedAssetName = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[i].Cells["AssignedAssetName"].Value),
                            ValidOn = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[i].Cells["ValidOn"].Value),
                            ExpiredOn = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[i].Cells["ExpiredOn"].Value),
                        };

                        if (String.IsNullOrEmpty(Convert.ToString(dgvEmployeeAssetsAssignment.Rows[i].Cells["AssignmentId"].Value)))
                            _item.AssignmentId = _guidNo;
                        else
                            _item.AssignmentId = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[i].Cells["AssignmentId"].Value);
                        _details.Add(_item);
                    }
                }
                Saver dbSaver = new Saver();
                dbSaver.Invoke<AssignmentVM>(Saver.TYPE_EMPLOYEE_ASSETS_ASSIGNMENT, null, _details, Convert.ToString(employeeId));
            }
            else
            {
                List<AssignmentVM> _details = Loader.ReadAssignment(employeeId).ToList<AssignmentVM>();
                for (var i = 0; i < _details.Count(); i++)
                {
                    if (_details[i].AssignmentId == _id)
                    {
                        for (var j = 0; j < dgvEmployeeAssetsAssignment.Rows.Count; j++)
                        {
                            if (Convert.ToString(dgvEmployeeAssetsAssignment.Rows[j].Cells["AssignmentId"].Value) == _id)
                            {
                                _details[i].AssignedAssetName = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[i].Cells["AssignedAssetName"].Value);
                                _details[i].ValidOn = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[i].Cells["ValidOn"].Value);
                                _details[i].ExpiredOn = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[i].Cells["ExpiredOn"].Value);
                                break;
                            }
                        }
                        break;
                    }
                }

                Saver dbSaver = new Saver();
                dbSaver.Invoke<AssignmentVM>(Saver.TYPE_EMPLOYEE_ASSETS_ASSIGNMENT, null, _details, Convert.ToString(employeeId));
            }
            return _guidNo;
        }

        private void cbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Convert.ToString(cbEmployee.SelectedValue)))
            {
                var _value = Convert.ToInt32(cbEmployee.SelectedValue);
                dgvEmployeeAssetsAssignment.DataSource = Loader.ReadAssignment(_value);
                dgvEmployeeAssetsAssignment.Enabled = true;
            } else
            {
                dgvEmployeeAssetsAssignment.Enabled = false;
                dgvEmployeeAssetsAssignment.DataSource = new DataTable();
            }
            
        }

        private void tcMain_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tcMain_Selected(object sender, TabControlEventArgs e)
        { 
            if (e.TabPage.Name == "tpAssignment")
                this.AssignedAssetName.DataSource = Loader.AssetsSelectList();
        }

        private void dgvEmployeeAssetsAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                DateTimeForm myDTForm = new DateTimeForm();
                if (myDTForm.ShowDialog() == DialogResult.OK)
                {
                    ((DataGridView)sender).CurrentCell = ((DataGridView)sender)[e.ColumnIndex, e.RowIndex];
                    ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value = ((DateTime)myDTForm.Tag).DisplayDate("{0:MM/dd/yyyy}");
                    ((DataGridView)sender).BeginEdit(true);
                    ((DataGridView)sender).Invalidate();
                }
            }
        }

        private void dgvAssetsMgt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbEmployee_TextChanged(object sender, EventArgs e)
        {
            var _text = cbEmployee.Text;
            var _list = ((List<MicroUserVM>)cbEmployee.DataSource);

            if (!_list.Any(x => x.EmployeeName == _text))
                dgvEmployeeAssetsAssignment.Enabled = false;
            else
                dgvEmployeeAssetsAssignment.Enabled = true;

            dgvEmployeeAssetsAssignment.Invalidate();
        }

        private void dgvEmployeeAssetsAssignment_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var _deletable = Convert.ToString(dgvEmployeeAssetsAssignment.Rows[e.RowIndex].Cells["AssignmentId"].Value);
            var _list = Loader.ReadAssignment(Convert.ToInt32(cbEmployee.SelectedValue)).ToList<AssignmentVM>();
            if (_deletable != null)
            {
                var _item = _list.FirstOrDefault(x => x.AssignmentId == _deletable);
                if (_item != null)
                {
                    _list.Remove(_item);
                    Saver _saver = new Saver();
                    _saver.Invoke<AssignmentVM>(Saver.TYPE_EMPLOYEE_ASSETS_ASSIGNMENT, null, _list, Convert.ToString(cbEmployee.SelectedValue));

                    dgvEmployeeAssetsAssignment.Rows[e.RowIndex].Visible = false;
                }
            }
        }

        private void dgvEmployeeAssetsAssignment_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvEmployeeAssetsAssignment.Invalidate();
        }
    }
}
