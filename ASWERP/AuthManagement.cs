using ASWERP.Models;
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

namespace ASWERP
{
    public partial class AuthManagement : Form
    {
        public Main Parent = null;
        public bool IsCreatingNewUser = false;

        public AuthManagement()
        {
            InitializeComponent();

            lbUsers.ValueMember = "Guid";
            lbUsers.DisplayMember = "Login";
            lbUsers.DataSource = Loader.GetAuthenticators();

            lbRoles.ValueMember = "Role";
            lbRoles.DisplayMember = "Name";
            lbRoles.DataSource = Authenticator.Roles;
            lbRoles.ClearSelected();

            SetSelectedRoles();
        }

        private void SetSelectedRoles()
        {
            var _initialAuthenticator = Loader.GetAuthenticators().FirstOrDefault(x => x.Guid.Trim().ToLower() == Convert.ToString(lbUsers.SelectedValue).ToLower());
            if (_initialAuthenticator != null)
            {
                foreach (var _assignedRole in _initialAuthenticator.Roles)
                {
                    var _role = Authenticator.Roles.FirstOrDefault(m => m.Role == _assignedRole);
                    if (_role != null)
                    {
                        var _roleIndex = lbRoles.Items.IndexOf(_role);
                        if (_roleIndex >= 0)
                            lbRoles.SetSelected(_roleIndex, true);
                    }
                }
            }
        }

        private List<string> GetSelectedRoles()
        {
            List<string> _selectedRoles = new List<string>();
            foreach (var _selectedIndex in lbRoles.SelectedIndices)
            {
                var _selectedItem = (AuthenticatorRoleVM)lbRoles.Items[(int)_selectedIndex];
                if (_selectedItem != null)
                {
                    _selectedRoles.Add(_selectedItem.Role);
                }
            }
            return _selectedRoles;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var _dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_dialogResult == DialogResult.Yes)
            {
                // Delete user
                var _authenticators = Loader.GetAuthenticators();
                var _authenticator = _authenticators.FirstOrDefault(x => x.Guid.ToLower() == llUserId.Text.Trim().ToLower());
                if (_authenticator != null)
                {
                    _authenticators.Remove(_authenticator);

                    Saver _saver = new Saver();
                    _saver.Invoke(Saver.TYPE_AUTHENTICATOR, null, _authenticators);

                    lbUsers.DataSource = Loader.GetAuthenticators();
                } else
                {
                    MessageBox.Show("User doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            IsCreatingNewUser = false;
        }

        private void llSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool _refresh = false;
            bool _isPasswordsChanged = false;
            StringBuilder _validationMessage = new StringBuilder();

            if (IsCreatingNewUser)
            {
                if ((txtPasswords.Text.Length < 6 && txtPasswords.Text.Length >= 0) || txtPasswords.Text.Contains(' '))
                    _validationMessage.AppendLine("New passwords must have at least 6 characters, no spaces and must not be empty.");
                if ((txtLoginName.Text.Length < 5 && txtLoginName.Text.Length >= 0) || txtLoginName.Text.Contains(' '))
                    _validationMessage.AppendLine("New login name must have at least 5 characters, no spaces and must not be empty.");
            } else
            {
                if ((txtPasswords.Text.Length < 6 && txtPasswords.Text.Length > 0) || txtPasswords.Text.Contains(' '))
                    _validationMessage.AppendLine("New passwords must have at least 6 characters and no spaces.");
                if ((txtLoginName.Text.Length < 5 && txtLoginName.Text.Length >= 0) || txtLoginName.Text.Contains(' '))
                    _validationMessage.AppendLine("New login name must have at least 5 characters, no spaces and must not be empty.");
            }

            if (_validationMessage.Length > 0)
            {
                MessageBox.Show(_validationMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!String.IsNullOrEmpty(llUserId.Text))
            {
                var _authenticators = Loader.GetAuthenticators();
                if (llUserId.Text.ToLower() != "[userid]")
                {
                    if (_authenticators.Any())
                    {
                        foreach (var _auth in _authenticators)
                        {
                            if (_auth.Guid.Trim().ToLower() == llUserId.Text.Trim().ToLower())
                            {
                                _auth.Login = txtLoginName.Text.Trim();
                                if (!String.IsNullOrEmpty(txtPasswords.Text))
                                {
                                    _auth.Hash = (new Authenticator()).CalculateMD5Hash(txtPasswords.Text).ToLower();
                                    _isPasswordsChanged = true;
                                }
                                _auth.Roles = GetSelectedRoles();

                                _refresh = true;
                                break;
                            }
                        }

                        if (_refresh) {
                            Saver _saver = new Saver();
                            _saver.Invoke(Saver.TYPE_AUTHENTICATOR, null, _authenticators);

                            txtPasswords.Text = String.Empty;
                            lbUsers.DataSource = Loader.GetAuthenticators();

                            IsCreatingNewUser = false;
                        }

                        if (_isPasswordsChanged)
                            txtPasswords.Text = String.Empty;
                    }
                }
                else
                {
                    // New user
                    AuthVM _vm = new AuthVM()
                    {
                        Guid = Guid.NewGuid().ToString(),
                        Login = txtLoginName.Text.Trim(),
                        Hash = (new Authenticator()).CalculateMD5Hash(txtPasswords.Text.Trim()).ToLower(),
                        Roles = GetSelectedRoles()
                    };

                    if (!_authenticators.Any(x => x.Login.Trim().ToLower() == _vm.Login.Trim().ToLower()))
                    {
                        _authenticators.Add(_vm);

                        Saver _saver = new Saver();
                        _saver.Invoke(Saver.TYPE_AUTHENTICATOR, null, _authenticators);

                        txtPasswords.Text = String.Empty;
                        llUserId.Text = _vm.Guid;

                        lbUsers.DataSource = Loader.GetAuthenticators();
                        lbUsers.SelectedValue = _vm.Guid;

                        IsCreatingNewUser = false;
                    }
                    else
                        MessageBox.Show("There has already been a similar login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsCreatingNewUser = false;
            lbRoles.ClearSelected();
            SetSelectedRoles();

            var _authenticator = Loader.GetAuthenticators().FirstOrDefault(x => x.Guid == Convert.ToString(lbUsers.SelectedValue));
            if (_authenticator != null)
            {
                llUserId.Text = _authenticator.Guid.Trim();
                txtLoginName.Text = _authenticator.Login.Trim();
                txtPasswords.Text = String.Empty;

                if (_authenticator.Login.Trim() == "admin")
                {
                    txtLoginName.Enabled = false;
                    llDelete.Visible = false;
                }
                else
                {
                    llDelete.Visible = true;
                    txtLoginName.Enabled = true;
                }  
            }
        }

        private void AuthManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsCreatingNewUser = true;
            lbRoles.ClearSelected();
            lbUsers.ClearSelected();

            llUserId.Text = "[UserId]";
            txtLoginName.Enabled = true;
            txtLoginName.Text = String.Empty;
            txtPasswords.Text = String.Empty;
            llDelete.Visible = false;

            MessageBox.Show("Fill out the form in the right for new user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AuthManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
