using ASWERP.Models;
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
            this.cmsDvgAssets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpAssetsMgt = new System.Windows.Forms.TabPage();
            this.dgvAssetsMgt = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PurchasedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WarrantyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tpProviders = new System.Windows.Forms.TabPage();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpAssetHandover = new System.Windows.Forms.TabPage();
            this.AccessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.XLite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.More = new System.Windows.Forms.DataGridViewLinkColumn();
            EmployeeSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(EmployeeSource)).BeginInit();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.cmsDvgAssets.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpAssetsMgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsMgt)).BeginInit();
            this.tpProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.tpAssetHandover.SuspendLayout();
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
            this.tsmiUsersMgt.Size = new System.Drawing.Size(131, 22);
            this.tsmiUsersMgt.Text = "Employees";
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
            this.dgvAssets.Location = new System.Drawing.Point(6, 6);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.Size = new System.Drawing.Size(1494, 679);
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
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpAssetsMgt);
            this.tcMain.Controls.Add(this.tpProviders);
            this.tcMain.Controls.Add(this.tpAssetHandover);
            this.tcMain.Location = new System.Drawing.Point(12, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1514, 717);
            this.tcMain.TabIndex = 3;
            // 
            // tpAssetsMgt
            // 
            this.tpAssetsMgt.Controls.Add(this.dgvAssetsMgt);
            this.tpAssetsMgt.Controls.Add(this.button3);
            this.tpAssetsMgt.Controls.Add(this.button2);
            this.tpAssetsMgt.Location = new System.Drawing.Point(4, 22);
            this.tpAssetsMgt.Name = "tpAssetsMgt";
            this.tpAssetsMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssetsMgt.Size = new System.Drawing.Size(1506, 691);
            this.tpAssetsMgt.TabIndex = 0;
            this.tpAssetsMgt.Text = "Assets Management";
            this.tpAssetsMgt.UseVisualStyleBackColor = true;
            // 
            // dgvAssetsMgt
            // 
            this.dgvAssetsMgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetsMgt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AssetType,
            this.AssetName,
            this.Code,
            this.Tag,
            this.Status,
            this.Location,
            this.PurchasedOn,
            this.InvoiceNo,
            this.Provider,
            this.WarrantyDate,
            this.Remarks});
            this.dgvAssetsMgt.Location = new System.Drawing.Point(6, 35);
            this.dgvAssetsMgt.Name = "dgvAssetsMgt";
            this.dgvAssetsMgt.Size = new System.Drawing.Size(1494, 650);
            this.dgvAssetsMgt.TabIndex = 3;
            this.dgvAssetsMgt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssetsMgt_CellClick);
            this.dgvAssetsMgt.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssetsMgt_CellEndEdit);
            this.dgvAssetsMgt.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAssetsMgt_UserDeletedRow);
            this.dgvAssetsMgt.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvAssetsMgt_UserDeletingRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            // 
            // AssetType
            // 
            this.AssetType.DataPropertyName = "Type";
            this.AssetType.HeaderText = "Type";
            this.AssetType.Name = "AssetType";
            this.AssetType.Width = 120;
            // 
            // AssetName
            // 
            this.AssetName.DataPropertyName = "Name";
            this.AssetName.HeaderText = "Name";
            this.AssetName.Name = "AssetName";
            this.AssetName.Width = 300;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Items.AddRange(new object[] {
            "Assigned",
            "Available"});
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Items.AddRange(new object[] {
            "Lim",
            "GP",
            "AB"});
            this.Location.Name = "Location";
            // 
            // PurchasedOn
            // 
            this.PurchasedOn.DataPropertyName = "PurchasedOn";
            this.PurchasedOn.HeaderText = "PurchasedOn";
            this.PurchasedOn.Name = "PurchasedOn";
            this.PurchasedOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "Invoice No.";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Width = 110;
            // 
            // Provider
            // 
            this.Provider.DataPropertyName = "Provider";
            this.Provider.HeaderText = "Provider";
            this.Provider.Name = "Provider";
            this.Provider.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Provider.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // WarrantyDate
            // 
            this.WarrantyDate.DataPropertyName = "WarrantyDate";
            this.WarrantyDate.HeaderText = "WarrantyDate";
            this.WarrantyDate.Name = "WarrantyDate";
            this.WarrantyDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 500;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Export To Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tpProviders
            // 
            this.tpProviders.Controls.Add(this.dgvProviders);
            this.tpProviders.Location = new System.Drawing.Point(4, 22);
            this.tpProviders.Name = "tpProviders";
            this.tpProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tpProviders.Size = new System.Drawing.Size(1506, 691);
            this.tpProviders.TabIndex = 2;
            this.tpProviders.Text = "Providers";
            this.tpProviders.UseVisualStyleBackColor = true;
            // 
            // dgvProviders
            // 
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.ContactName,
            this.ContactTel,
            this.Contact});
            this.dgvProviders.Location = new System.Drawing.Point(6, 6);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.Size = new System.Drawing.Size(1494, 679);
            this.dgvProviders.TabIndex = 0;
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "ContactId";
            this.ContactId.HeaderText = "Id";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            this.ContactId.Width = 64;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "Name";
            this.ContactName.Name = "ContactName";
            this.ContactName.Width = 300;
            // 
            // ContactTel
            // 
            this.ContactTel.DataPropertyName = "ContactTel";
            this.ContactTel.HeaderText = "Phone";
            this.ContactTel.Name = "ContactTel";
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.Width = 300;
            // 
            // tpAssetHandover
            // 
            this.tpAssetHandover.Controls.Add(this.dgvAssets);
            this.tpAssetHandover.Location = new System.Drawing.Point(4, 22);
            this.tpAssetHandover.Name = "tpAssetHandover";
            this.tpAssetHandover.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssetHandover.Size = new System.Drawing.Size(1506, 691);
            this.tpAssetHandover.TabIndex = 1;
            this.tpAssetHandover.Text = "Asset Handover";
            this.tpAssetHandover.UseVisualStyleBackColor = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 756);
            this.Controls.Add(this.tcMain);
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
            this.tcMain.ResumeLayout(false);
            this.tpAssetsMgt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsMgt)).EndInit();
            this.tpProviders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.tpAssetHandover.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpAssetsMgt;
        private System.Windows.Forms.TabPage tpAssetHandover;
        private System.Windows.Forms.DataGridView dgvAssetsMgt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tpProviders;
        private System.Windows.Forms.DataGridView dgvProviders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessId;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn XLite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewLinkColumn More;

    }
}