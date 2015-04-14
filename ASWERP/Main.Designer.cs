﻿using ASWERP.Models;
namespace ASWERP
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.BindingSource EmployeeSource;
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsersMgt = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsttDoSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.AccessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.XLite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.More = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cmsDvgAssets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            EmployeeSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(EmployeeSource)).BeginInit();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.cmsDvgAssets.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1538, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMnuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitMnuItem
            // 
            this.exitMnuItem.Name = "exitMnuItem";
            this.exitMnuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMnuItem.Text = "&Exit";
            this.exitMnuItem.Click += new System.EventHandler(this.exitMnuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsersMgt});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "&Management";
            // 
            // tsmiUsersMgt
            // 
            this.tsmiUsersMgt.Name = "tsmiUsersMgt";
            this.tsmiUsersMgt.Size = new System.Drawing.Size(102, 22);
            this.tsmiUsersMgt.Text = "Users";
            this.tsmiUsersMgt.Click += new System.EventHandler(this.tsmiUsersMgt_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsttDoSearch});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            this.searchToolStripMenuItem.DropDownClosed += new System.EventHandler(this.searchToolStripMenuItem_DropDownClosed);
            // 
            // tsttDoSearch
            // 
            this.tsttDoSearch.AcceptsReturn = true;
            this.tsttDoSearch.Name = "tsttDoSearch";
            this.tsttDoSearch.Size = new System.Drawing.Size(100, 23);
            this.tsttDoSearch.Leave += new System.EventHandler(this.tsttDoSearch_Leave);
            this.tsttDoSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsttDoSearch_KeyDown);
            this.tsttDoSearch.TextChanged += new System.EventHandler(this.tsttDoSearch_TextChanged);
            // 
            // dgvAssets
            // 
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccessId,
            this.EmployeeName,
            this.XLite,
            this.ComputerName,
            this.ComputerType,
            this.EmailAddress,
            this.More});
            this.dgvAssets.Location = new System.Drawing.Point(12, 27);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.Size = new System.Drawing.Size(1514, 717);
            this.dgvAssets.TabIndex = 2;
            this.dgvAssets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellContentClick);
            this.dgvAssets.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellEndEdit);
            this.dgvAssets.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellEnter);
            this.dgvAssets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAssets_CellFormatting);
            this.dgvAssets.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAssets_RowsAdded);
            this.dgvAssets.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAssets_RowsRemoved);
            this.dgvAssets.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAssets_UserAddedRow);
            this.dgvAssets.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAssets_UserDeletedRow);
            this.dgvAssets.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvAssets_UserDeletingRow);
            // 
            // AccessId
            // 
            this.AccessId.DataPropertyName = "AccessId";
            this.AccessId.HeaderText = "Id";
            this.AccessId.Name = "AccessId";
            this.AccessId.ReadOnly = true;
            this.AccessId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AccessId.Width = 64;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmployeeName.Width = 312;

            /* TODO: Custom codes, should be removed when saving designer */
            this.EmployeeName.DisplayMember = "EmployeeName";
            this.EmployeeName.ValueMember = "Id";
            this.EmployeeName.DataSource = Loader.UsersSelectList();
            /* */
            // 
            // XLite
            // 
            this.XLite.DataPropertyName = "XLite";
            this.XLite.HeaderText = "XLite";
            this.XLite.Name = "XLite";
            // 
            // ComputerName
            // 
            this.ComputerName.DataPropertyName = "ComputerName";
            this.ComputerName.HeaderText = "Computer Name";
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Width = 256;
            // 
            // ComputerType
            // 
            this.ComputerType.DataPropertyName = "ComputerType";
            this.ComputerType.HeaderText = "";
            this.ComputerType.Name = "ComputerType";
            this.ComputerType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComputerType.Width = 250;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Width = 256;
            // 
            // More
            // 
            this.More.HeaderText = "More...";
            this.More.Name = "More";
            this.More.Text = "More...";
            this.More.ToolTipText = "Click here for more information";
            this.More.UseColumnTextForLinkValue = true;
            // 
            // cmsDvgAssets
            // 
            this.cmsDvgAssets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemove});
            this.cmsDvgAssets.Name = "cmsDvgAssets";
            this.cmsDvgAssets.Size = new System.Drawing.Size(127, 26);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(126, 22);
            this.tsmiRemove.Text = "Remove...";
            this.tsmiRemove.Click += new System.EventHandler(this.tsmiRemove_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 756);
            this.Controls.Add(this.dgvAssets);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assets Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(EmployeeSource)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.cmsDvgAssets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMnuItem;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDvgAssets;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.ToolStripTextBox tsttDoSearch;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsersMgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessId;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn XLite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewLinkColumn More;

    }
}