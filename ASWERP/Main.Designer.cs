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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XLite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.More = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cmsDvgAssets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.cmsDvgAssets.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1352, 24);
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
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // dgvAssets
            // 
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmployeeName,
            this.XLite,
            this.ComputerName,
            this.ComputerType,
            this.EmailAddress,
            this.More});
            this.dgvAssets.Location = new System.Drawing.Point(12, 27);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.Size = new System.Drawing.Size(1328, 717);
            this.dgvAssets.TabIndex = 2;
            this.dgvAssets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellContentClick);
            this.dgvAssets.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellEndEdit);
            this.dgvAssets.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellEnter);
            this.dgvAssets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAssets_CellFormatting);
            this.dgvAssets.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAssets_RowsAdded);
            this.dgvAssets.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAssets_RowsRemoved);
            this.dgvAssets.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAssets_UserAddedRow);
            this.dgvAssets.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAssets_UserDeletedRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 150;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 312;
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
            this.ComputerType.Items.AddRange(new object[] {
            "Dell Inspiron 3847",
            "Lap HP Pro 4320s"});
            this.ComputerType.Name = "ComputerType";
            this.ComputerType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComputerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.ClientSize = new System.Drawing.Size(1352, 756);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn XLite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComputerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewLinkColumn More;
        private System.Windows.Forms.ContextMenuStrip cmsDvgAssets;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;

    }
}