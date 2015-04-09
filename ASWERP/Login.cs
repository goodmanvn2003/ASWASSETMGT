using ASWERP.Models;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Check for default directories and files
            Loader.Initilize();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticator authenticator = new Authenticator();

            if (authenticator.DoAuthentication(txtUserName.Text.Trim(), txtPasswords.Text.Trim()))
            {
                Main _mainForm = new Main();
                _mainForm.Show();
                _mainForm.login = this;

                this.Hide();
            }
            else
                MessageBox.Show("User name or passwords incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
