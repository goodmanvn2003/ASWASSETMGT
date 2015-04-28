using ASWERP.Models;
using ASWERPModels.Utilities;
using ASWERPModels.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ASWERPModels.Extensions;

namespace ASWERP
{
    public partial class UsersMgt : Form
    {
        private DataTable Users = null;

        public string IDENTIFIER = "UsersMgt";

        public Main Parent = null;

        public UsersMgt()
        {
            InitializeComponent();
            
            // Load data
            Users = Loader.ReadUsers();
            dgvUsers.DataSource = Users;
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name.Equals("Id"))
            {
                string _value = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Id"].Value);
                if (_value.Length == 0 && e.RowIndex != dgvUsers.NewRowIndex)
                    dgvUsers.Rows[e.RowIndex].Cells["Id"].Value =  Utilities.GenerateUserId(Users);
            }
        }

        private void dgvUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var _guidNo = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["GuidNo"].Value);
            if (!String.IsNullOrEmpty(_guidNo))
            {
                var _dataId = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Id"].Value);
                if (!String.IsNullOrEmpty(_dataId))
                    _guidNo = ExecuteSavingUsers(Convert.ToInt32(_dataId));
            }
            else
            {
                dgvUsers.Rows[e.RowIndex].Cells["GuidNo"].Value = ExecuteSavingUsers(); ;
            }      
        }

        private string ExecuteSavingUsers(int? _id = null)
        {
            var _guidNo = Guid.NewGuid().ToString();
            
            if (!_id.HasValue)
            {
                List<UserVM> _details = new List<UserVM>();
                for (var i = 0; i < dgvUsers.Rows.Count; i++)
                {
                    if (dgvUsers.Rows[i].Index != dgvUsers.NewRowIndex)
                    {
                        var _item = new UserVM()
                        {
                            GuidNo = _guidNo,
                            Id = Convert.ToInt32(dgvUsers.Rows[i].Cells["Id"].Value),
                            EmployeeName = Convert.ToString(dgvUsers.Rows[i].Cells["EmployeeName"].Value),
                            XLite = Convert.ToString(dgvUsers.Rows[i].Cells["XLite"].Value),
                            Assets = Convert.ToString(dgvUsers.Rows[i].Cells["Assets"].Value),
                            DomainId = Convert.ToString(dgvUsers.Rows[i].Cells["DomainId"].Value),
                            Email = Convert.ToString(dgvUsers.Rows[i].Cells["Email"].Value),
                            Department = Convert.ToString(dgvUsers.Rows[i].Cells["Department"].Value),
                            Office = Convert.ToString(dgvUsers.Rows[i].Cells["Office"].Value)
                        };
                        _details.Add(_item);
                    }
                }
                Saver dbSaver = new Saver();
                dbSaver.Invoke<UserVM>(Saver.TYPE_USERS, null, _details);
            }
            else
            {
                List<UserVM> _details = Loader.ReadUsers().ToList<UserVM>();
                for (var i = 0; i < _details.Count(); i++)
                {
                    if (_details[i].Id == _id.Value)
                    {
                        for (var j = 0; j < dgvUsers.Rows.Count; j++)
                        {
                            if (Convert.ToInt32(dgvUsers.Rows[j].Cells["Id"].Value) == _id.Value)
                            {
                                _details[i].Id = Convert.ToInt32(dgvUsers.Rows[j].Cells["Id"].Value);
                                _details[i].EmployeeName = Convert.ToString(dgvUsers.Rows[j].Cells["EmployeeName"].Value);
                                _details[i].XLite = Convert.ToString(dgvUsers.Rows[j].Cells["XLite"].Value);
                                _details[i].Assets = Convert.ToString(dgvUsers.Rows[j].Cells["Assets"].Value);
                                _details[i].DomainId = Convert.ToString(dgvUsers.Rows[j].Cells["DomainId"].Value);
                                _details[i].Email = Convert.ToString(dgvUsers.Rows[j].Cells["Email"].Value);
                                _details[i].Department = Convert.ToString(dgvUsers.Rows[j].Cells["Department"].Value);
                                _details[i].Office = Convert.ToString(dgvUsers.Rows[j].Cells["Office"].Value);

                                break;
                            }
                        }
                        break;
                    }
                }
                Saver dbSaver = new Saver();
                dbSaver.Invoke<UserVM>(Saver.TYPE_USERS, null, _details);
            }
            return _guidNo;
        }

        private void dgvUsers_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ExecuteSavingUsers();
        }

        private void dgvUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dlgResult = MessageBox.Show("Are you sure you'd like to delete \"" + Convert.ToString(e.Row.Cells[1].Value) + "\"?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtUserSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtUserSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtUserSearch.Text.Trim().Length > 0)
                dgvUsers.DataSource = Loader.ReadUsersWithSearch(txtUserSearch.Text.Trim());
            else
                dgvUsers.DataSource = Loader.ReadUsers();
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtUserSearch.Text.Trim().Length == 0)
                dgvUsers.DataSource = Loader.ReadUsers();
        }

        private void txtUserSearch_Leave(object sender, EventArgs e)
        {
        }

        private void UsersMgt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.RefreshData();
        }

        private void dgvUsers_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Id_KeyPress);
            if (dgvUsers.CurrentCell.ColumnIndex == dgvUsers.Columns["Id"].Index)
            {
                TextBox itemID = e.Control as TextBox;
                if (itemID != null)
                {
                    itemID.KeyPress += new KeyPressEventHandler(Id_KeyPress);
                }
            }
        }

        private void Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
