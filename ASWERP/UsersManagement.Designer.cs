namespace ASWERP
{
    partial class UsersMgt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.GuidNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XLite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuidNo,
            this.Id,
            this.EmployeeName,
            this.XLite,
            this.Assets,
            this.DomainId,
            this.Email,
            this.Department,
            this.Office});
            this.dgvUsers.Location = new System.Drawing.Point(12, 39);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(1278, 707);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellEndEdit);
            this.dgvUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsers_CellFormatting);
            this.dgvUsers.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvUsers_EditingControlShowing);
            this.dgvUsers.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvUsers_UserDeletedRow);
            this.dgvUsers.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvUsers_UserDeletingRow);
            // 
            // GuidNo
            // 
            this.GuidNo.DataPropertyName = "GuidNo";
            this.GuidNo.HeaderText = "GuidNo";
            this.GuidNo.Name = "GuidNo";
            this.GuidNo.ReadOnly = true;
            this.GuidNo.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MaxInputLength = 5;
            this.Id.Name = "Id";
            this.Id.Width = 64;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 300;
            // 
            // XLite
            // 
            this.XLite.DataPropertyName = "XLite";
            this.XLite.HeaderText = "XLite";
            this.XLite.Name = "XLite";
            this.XLite.Width = 92;
            // 
            // Assets
            // 
            this.Assets.DataPropertyName = "Assets";
            this.Assets.HeaderText = "Assets";
            this.Assets.Name = "Assets";
            this.Assets.Width = 500;
            // 
            // DomainId
            // 
            this.DomainId.DataPropertyName = "DomainId";
            this.DomainId.HeaderText = "DomainId";
            this.DomainId.Name = "DomainId";
            this.DomainId.Width = 128;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Items.AddRange(new object[] {
            "Development",
            "Accounting",
            "QA"});
            this.Department.Name = "Department";
            this.Department.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Department.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Department.Width = 160;
            // 
            // Office
            // 
            this.Office.DataPropertyName = "Office";
            this.Office.HeaderText = "Office";
            this.Office.Items.AddRange(new object[] {
            "Lim",
            "AB",
            "GP"});
            this.Office.Name = "Office";
            this.Office.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Office.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Office.Width = 92;
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(66, 12);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(254, 20);
            this.txtUserSearch.TabIndex = 1;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            this.txtUserSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserSearch_KeyDown);
            this.txtUserSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserSearch_KeyPress);
            this.txtUserSearch.Leave += new System.EventHandler(this.txtUserSearch_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keyword";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UsersMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 759);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserSearch);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsersMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersMgt_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuidNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn XLite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assets;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewComboBoxColumn Department;
        private System.Windows.Forms.DataGridViewComboBoxColumn Office;
    }
}