namespace ASWERP
{
    partial class AuthManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llUserId = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtPasswords = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.llSave = new System.Windows.Forms.LinkLabel();
            this.llDelete = new System.Windows.Forms.LinkLabel();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRoles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(16, 35);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(180, 264);
            this.lbUsers.TabIndex = 1;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID #:";
            // 
            // llUserId
            // 
            this.llUserId.AutoSize = true;
            this.llUserId.Location = new System.Drawing.Point(305, 35);
            this.llUserId.Name = "llUserId";
            this.llUserId.Size = new System.Drawing.Size(44, 13);
            this.llUserId.TabIndex = 4;
            this.llUserId.TabStop = true;
            this.llUserId.Text = "[UserId]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Login Name:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(308, 56);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(204, 20);
            this.txtLoginName.TabIndex = 6;
            // 
            // txtPasswords
            // 
            this.txtPasswords.Location = new System.Drawing.Point(308, 84);
            this.txtPasswords.Name = "txtPasswords";
            this.txtPasswords.PasswordChar = '*';
            this.txtPasswords.Size = new System.Drawing.Size(204, 20);
            this.txtPasswords.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Passwords:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(437, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llSave
            // 
            this.llSave.AutoSize = true;
            this.llSave.Location = new System.Drawing.Point(234, 281);
            this.llSave.Name = "llSave";
            this.llSave.Size = new System.Drawing.Size(41, 13);
            this.llSave.TabIndex = 11;
            this.llSave.TabStop = true;
            this.llSave.Text = "Save...";
            this.llSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSave_LinkClicked);
            // 
            // llDelete
            // 
            this.llDelete.AutoSize = true;
            this.llDelete.Location = new System.Drawing.Point(281, 281);
            this.llDelete.Name = "llDelete";
            this.llDelete.Size = new System.Drawing.Size(47, 13);
            this.llDelete.TabIndex = 12;
            this.llDelete.TabStop = true;
            this.llDelete.Text = "Delete...";
            this.llDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDelete_LinkClicked);
            // 
            // llAdd
            // 
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(58, 13);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(35, 13);
            this.llAdd.TabIndex = 13;
            this.llAdd.TabStop = true;
            this.llAdd.Text = "Add...";
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Roles:";
            // 
            // lbRoles
            // 
            this.lbRoles.FormattingEnabled = true;
            this.lbRoles.Location = new System.Drawing.Point(237, 139);
            this.lbRoles.Name = "lbRoles";
            this.lbRoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRoles.Size = new System.Drawing.Size(275, 121);
            this.lbRoles.TabIndex = 15;
            // 
            // AuthManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 314);
            this.Controls.Add(this.lbRoles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.llAdd);
            this.Controls.Add(this.llDelete);
            this.Controls.Add(this.llSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPasswords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.llUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthManagement_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthManagement_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtPasswords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llSave;
        private System.Windows.Forms.LinkLabel llDelete;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbRoles;
    }
}