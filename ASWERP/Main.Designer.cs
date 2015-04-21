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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpAssignment = new System.Windows.Forms.TabPage();
            this.dgvEmployeeAssetsAssignment = new System.Windows.Forms.DataGridView();
            this.AssignmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedAssetName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValidOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbUntilRequired = new System.Windows.Forms.CheckBox();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.cbFromRequired = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.tpProviders = new System.Windows.Forms.TabPage();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.GuidId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpAssetHandover = new System.Windows.Forms.TabPage();
            EmployeeSource = new System.Windows.Forms.BindingSource(this.components);
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.cmsDvgAssets.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAssetsAssignment)).BeginInit();
            this.tpAssetsMgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsMgt)).BeginInit();
            this.tpProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.tpAssetHandover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(EmployeeSource)).BeginInit();
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
            this.tsttDoSearch.Click += new System.EventHandler(this.tsttDoSearch_Click);
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
            this.EmployeeName.DataSource = ((object)(resources.GetObject("EmployeeName.DataSource")));
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpAssignment);
            this.tcMain.Controls.Add(this.tpAssetsMgt);
            this.tcMain.Controls.Add(this.tpProviders);
            this.tcMain.Controls.Add(this.tpAssetHandover);
            this.tcMain.Location = new System.Drawing.Point(12, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1514, 717);
            this.tcMain.TabIndex = 3;
            this.tcMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcMain_Selected);
            this.tcMain.TabIndexChanged += new System.EventHandler(this.tcMain_TabIndexChanged);
            // 
            // tpAssignment
            // 
            this.tpAssignment.Controls.Add(this.dgvEmployeeAssetsAssignment);
            this.tpAssignment.Controls.Add(this.cbUntilRequired);
            this.tpAssignment.Controls.Add(this.dtpUntil);
            this.tpAssignment.Controls.Add(this.cbFromRequired);
            this.tpAssignment.Controls.Add(this.label3);
            this.tpAssignment.Controls.Add(this.dtpFrom);
            this.tpAssignment.Controls.Add(this.label2);
            this.tpAssignment.Controls.Add(this.cbEmployee);
            this.tpAssignment.Controls.Add(this.label1);
            this.tpAssignment.Location = new System.Drawing.Point(4, 22);
            this.tpAssignment.Name = "tpAssignment";
            this.tpAssignment.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssignment.Size = new System.Drawing.Size(1506, 691);
            this.tpAssignment.TabIndex = 3;
            this.tpAssignment.Text = "Assignment";
            this.tpAssignment.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeeAssetsAssignment
            // 
            this.dgvEmployeeAssetsAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeAssetsAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentId,
            this.AssignedAssetName,
            this.ValidOn,
            this.ExpiredOn});
            this.dgvEmployeeAssetsAssignment.Location = new System.Drawing.Point(9, 39);
            this.dgvEmployeeAssetsAssignment.Name = "dgvEmployeeAssetsAssignment";
            this.dgvEmployeeAssetsAssignment.Size = new System.Drawing.Size(1491, 646);
            this.dgvEmployeeAssetsAssignment.TabIndex = 8;
            this.dgvEmployeeAssetsAssignment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeAssetsAssignment_CellClick);
            this.dgvEmployeeAssetsAssignment.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeAssetsAssignment_CellEndEdit);
            this.dgvEmployeeAssetsAssignment.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEmployeeAssetsAssignment_DataError);
            this.dgvEmployeeAssetsAssignment.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvEmployeeAssetsAssignment_UserAddedRow);
            this.dgvEmployeeAssetsAssignment.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvEmployeeAssetsAssignment_UserDeletedRow);
            this.dgvEmployeeAssetsAssignment.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmployeeAssetsAssignment_UserDeletingRow);
            // 
            // AssignmentId
            // 
            this.AssignmentId.DataPropertyName = "AssignmentId";
            this.AssignmentId.HeaderText = "AssignmentId";
            this.AssignmentId.Name = "AssignmentId";
            this.AssignmentId.ReadOnly = true;
            this.AssignmentId.Visible = false;
            // 
            // AssignedAssetName
            // 
            this.AssignedAssetName.DataPropertyName = "AssignedAssetName";
            this.AssignedAssetName.HeaderText = "Asset Name";
            this.AssignedAssetName.Name = "AssignedAssetName";
            this.AssignedAssetName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssignedAssetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AssignedAssetName.Width = 450;
            // 
            // ValidOn
            // 
            this.ValidOn.DataPropertyName = "ValidOn";
            this.ValidOn.HeaderText = "Valid On";
            this.ValidOn.Name = "ValidOn";
            // 
            // ExpiredOn
            // 
            this.ExpiredOn.DataPropertyName = "ExpiredOn";
            this.ExpiredOn.HeaderText = "Expired On";
            this.ExpiredOn.Name = "ExpiredOn";
            // 
            // cbUntilRequired
            // 
            this.cbUntilRequired.AutoSize = true;
            this.cbUntilRequired.Checked = true;
            this.cbUntilRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUntilRequired.Location = new System.Drawing.Point(927, 12);
            this.cbUntilRequired.Name = "cbUntilRequired";
            this.cbUntilRequired.Size = new System.Drawing.Size(15, 14);
            this.cbUntilRequired.TabIndex = 7;
            this.cbUntilRequired.UseVisualStyleBackColor = true;
            this.cbUntilRequired.CheckedChanged += new System.EventHandler(this.cbUntilRequired_CheckedChanged);
            // 
            // dtpUntil
            // 
            this.dtpUntil.Enabled = false;
            this.dtpUntil.Location = new System.Drawing.Point(721, 9);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(200, 20);
            this.dtpUntil.TabIndex = 6;
            // 
            // cbFromRequired
            // 
            this.cbFromRequired.AutoSize = true;
            this.cbFromRequired.Checked = true;
            this.cbFromRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFromRequired.Location = new System.Drawing.Point(663, 12);
            this.cbFromRequired.Name = "cbFromRequired";
            this.cbFromRequired.Size = new System.Drawing.Size(15, 14);
            this.cbFromRequired.TabIndex = 5;
            this.cbFromRequired.UseVisualStyleBackColor = true;
            this.cbFromRequired.CheckedChanged += new System.EventHandler(this.cbFromRequired_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Until:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(456, 9);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEmployee
            // 
            this.cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(68, 9);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(343, 21);
            this.cbEmployee.TabIndex = 1;
            this.cbEmployee.Text = "Pick an employee...";
            this.cbEmployee.SelectedValueChanged += new System.EventHandler(this.cbEmployee_SelectedValueChanged);
            this.cbEmployee.TextChanged += new System.EventHandler(this.cbEmployee_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee:";
            // 
            // tpAssetsMgt
            // 
            this.tpAssetsMgt.Controls.Add(this.dgvAssetsMgt);
            this.tpAssetsMgt.Controls.Add(this.button3);
            this.tpAssetsMgt.Controls.Add(this.btnExportExcel);
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
            this.dgvAssetsMgt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssetsMgt_CellContentClick);
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
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(117, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(6, 6);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(105, 23);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "&Export To Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
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
            this.GuidId,
            this.ProviderName,
            this.ProviderPhone,
            this.ProviderContact});
            this.dgvProviders.Location = new System.Drawing.Point(6, 6);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.Size = new System.Drawing.Size(1494, 679);
            this.dgvProviders.TabIndex = 0;
            this.dgvProviders.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProviders_CellEndEdit);
            this.dgvProviders.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvProviders_UserDeletedRow);
            this.dgvProviders.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvProviders_UserDeletingRow);
            // 
            // GuidId
            // 
            this.GuidId.DataPropertyName = "GuidId";
            this.GuidId.HeaderText = "GuidId";
            this.GuidId.Name = "GuidId";
            this.GuidId.ReadOnly = true;
            this.GuidId.Visible = false;
            // 
            // ProviderName
            // 
            this.ProviderName.DataPropertyName = "ProviderName";
            this.ProviderName.HeaderText = "Name";
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.Width = 300;
            // 
            // ProviderPhone
            // 
            this.ProviderPhone.DataPropertyName = "ProviderPhone";
            this.ProviderPhone.HeaderText = "Phone";
            this.ProviderPhone.Name = "ProviderPhone";
            // 
            // ProviderContact
            // 
            this.ProviderContact.DataPropertyName = "ProviderContact";
            this.ProviderContact.HeaderText = "Contact";
            this.ProviderContact.Name = "ProviderContact";
            this.ProviderContact.Width = 300;
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
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.cmsDvgAssets.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpAssignment.ResumeLayout(false);
            this.tpAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAssetsAssignment)).EndInit();
            this.tpAssetsMgt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsMgt)).EndInit();
            this.tpProviders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.tpAssetHandover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(EmployeeSource)).EndInit();
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
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.TabPage tpProviders;
        private System.Windows.Forms.DataGridView dgvProviders;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn GuidId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderContact;
        private System.Windows.Forms.TabPage tpAssignment;
        private System.Windows.Forms.CheckBox cbUntilRequired;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.CheckBox cbFromRequired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployeeAssetsAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentId;
        private System.Windows.Forms.DataGridViewComboBoxColumn AssignedAssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredOn;

    }
}