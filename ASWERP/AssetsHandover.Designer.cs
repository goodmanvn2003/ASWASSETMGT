namespace ASWERP
{
    partial class AssetsHandover
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDeptName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGMName = new System.Windows.Forms.TextBox();
            this.dvgAssetHandoverDetails = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHandedOverBy = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpReceivedBy = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRecordedBy = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpAcknowledgedBy = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbxHandedoverBy = new System.Windows.Forms.CheckBox();
            this.cbxReceivedBy = new System.Windows.Forms.CheckBox();
            this.cbxRecordedBy = new System.Windows.Forms.CheckBox();
            this.cbxAcknowledgedBy = new System.Windows.Forms.CheckBox();
            this.cmsAssetsHandover = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAssetHandoverDetails)).BeginInit();
            this.cmsAssetsHandover.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(255, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // cmbDeptName
            // 
            this.cmbDeptName.FormattingEnabled = true;
            this.cmbDeptName.Items.AddRange(new object[] {
            "Development",
            "Accounting",
            "QA"});
            this.cmbDeptName.Location = new System.Drawing.Point(145, 41);
            this.cmbDeptName.Name = "cmbDeptName";
            this.cmbDeptName.Size = new System.Drawing.Size(171, 21);
            this.cmbDeptName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group Manager\'s Name";
            // 
            // txtGMName
            // 
            this.txtGMName.Location = new System.Drawing.Point(145, 73);
            this.txtGMName.Name = "txtGMName";
            this.txtGMName.Size = new System.Drawing.Size(255, 20);
            this.txtGMName.TabIndex = 5;
            // 
            // dvgAssetHandoverDetails
            // 
            this.dvgAssetHandoverDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAssetHandoverDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.AssetDescription,
            this.AssetName,
            this.Quantity,
            this.Location,
            this.Remarks});
            this.dvgAssetHandoverDetails.Location = new System.Drawing.Point(17, 113);
            this.dvgAssetHandoverDetails.Name = "dvgAssetHandoverDetails";
            this.dvgAssetHandoverDetails.Size = new System.Drawing.Size(1136, 472);
            this.dvgAssetHandoverDetails.TabIndex = 6;
            this.dvgAssetHandoverDetails.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAssetHandoverDetails_CellEnter);
            this.dvgAssetHandoverDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgAssetHandoverDetails_CellFormatting);
            this.dvgAssetHandoverDetails.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAssetHandoverDetails_CellLeave);
            this.dvgAssetHandoverDetails.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dvgAssetHandoverDetails_UserAddedRow);
            this.dvgAssetHandoverDetails.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dvgAssetHandoverDetails_UserDeletedRow);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Handed-over By:";
            // 
            // dtpHandedOverBy
            // 
            this.dtpHandedOverBy.Location = new System.Drawing.Point(550, 12);
            this.dtpHandedOverBy.Name = "dtpHandedOverBy";
            this.dtpHandedOverBy.Size = new System.Drawing.Size(200, 20);
            this.dtpHandedOverBy.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Received By:";
            // 
            // dtpReceivedBy
            // 
            this.dtpReceivedBy.Location = new System.Drawing.Point(550, 43);
            this.dtpReceivedBy.Name = "dtpReceivedBy";
            this.dtpReceivedBy.Size = new System.Drawing.Size(200, 20);
            this.dtpReceivedBy.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Recorded By:";
            // 
            // dtpRecordedBy
            // 
            this.dtpRecordedBy.Location = new System.Drawing.Point(550, 74);
            this.dtpRecordedBy.Name = "dtpRecordedBy";
            this.dtpRecordedBy.Size = new System.Drawing.Size(200, 20);
            this.dtpRecordedBy.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Acknowledged By:";
            // 
            // dtpAcknowledgedBy
            // 
            this.dtpAcknowledgedBy.Location = new System.Drawing.Point(914, 12);
            this.dtpAcknowledgedBy.Name = "dtpAcknowledgedBy";
            this.dtpAcknowledgedBy.Size = new System.Drawing.Size(200, 20);
            this.dtpAcknowledgedBy.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(98, 608);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbxHandedoverBy
            // 
            this.cbxHandedoverBy.AutoSize = true;
            this.cbxHandedoverBy.Location = new System.Drawing.Point(757, 15);
            this.cbxHandedoverBy.Name = "cbxHandedoverBy";
            this.cbxHandedoverBy.Size = new System.Drawing.Size(15, 14);
            this.cbxHandedoverBy.TabIndex = 17;
            this.cbxHandedoverBy.UseVisualStyleBackColor = true;
            this.cbxHandedoverBy.CheckedChanged += new System.EventHandler(this.cbxHandedoverBy_CheckedChanged);
            // 
            // cbxReceivedBy
            // 
            this.cbxReceivedBy.AutoSize = true;
            this.cbxReceivedBy.Location = new System.Drawing.Point(757, 46);
            this.cbxReceivedBy.Name = "cbxReceivedBy";
            this.cbxReceivedBy.Size = new System.Drawing.Size(15, 14);
            this.cbxReceivedBy.TabIndex = 18;
            this.cbxReceivedBy.UseVisualStyleBackColor = true;
            this.cbxReceivedBy.CheckedChanged += new System.EventHandler(this.cbxReceivedBy_CheckedChanged);
            // 
            // cbxRecordedBy
            // 
            this.cbxRecordedBy.AutoSize = true;
            this.cbxRecordedBy.Location = new System.Drawing.Point(757, 77);
            this.cbxRecordedBy.Name = "cbxRecordedBy";
            this.cbxRecordedBy.Size = new System.Drawing.Size(15, 14);
            this.cbxRecordedBy.TabIndex = 19;
            this.cbxRecordedBy.UseVisualStyleBackColor = true;
            this.cbxRecordedBy.CheckedChanged += new System.EventHandler(this.cbxRecordedBy_CheckedChanged);
            // 
            // cbxAcknowledgedBy
            // 
            this.cbxAcknowledgedBy.AutoSize = true;
            this.cbxAcknowledgedBy.Location = new System.Drawing.Point(1120, 15);
            this.cbxAcknowledgedBy.Name = "cbxAcknowledgedBy";
            this.cbxAcknowledgedBy.Size = new System.Drawing.Size(15, 14);
            this.cbxAcknowledgedBy.TabIndex = 20;
            this.cbxAcknowledgedBy.UseVisualStyleBackColor = true;
            this.cbxAcknowledgedBy.CheckedChanged += new System.EventHandler(this.cbxAcknowledgedBy_CheckedChanged);
            // 
            // cmsAssetsHandover
            // 
            this.cmsAssetsHandover.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemove});
            this.cmsAssetsHandover.Name = "cmsAssetsHandover";
            this.cmsAssetsHandover.Size = new System.Drawing.Size(127, 26);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(152, 22);
            this.tsmiRemove.Text = "Remove...";
            this.tsmiRemove.Click += new System.EventHandler(this.tsmiRemove_Click);
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 32;
            // 
            // AssetDescription
            // 
            this.AssetDescription.DataPropertyName = "AssetDescription";
            this.AssetDescription.HeaderText = "Asset Description";
            this.AssetDescription.Name = "AssetDescription";
            this.AssetDescription.Width = 350;
            // 
            // AssetName
            // 
            this.AssetName.DataPropertyName = "AssetName";
            this.AssetName.HeaderText = "Asset Name";
            this.AssetName.Name = "AssetName";
            this.AssetName.Width = 192;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Quantity.Width = 64;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Items.AddRange(new object[] {
            "Lim",
            "AB",
            "GP"});
            this.Location.Name = "Location";
            this.Location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Location.Width = 150;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 400;
            // 
            // AssetsHandover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 643);
            this.Controls.Add(this.cbxAcknowledgedBy);
            this.Controls.Add(this.cbxRecordedBy);
            this.Controls.Add(this.cbxReceivedBy);
            this.Controls.Add(this.cbxHandedoverBy);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpAcknowledgedBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpRecordedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpReceivedBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHandedOverBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgAssetHandoverDetails);
            this.Controls.Add(this.txtGMName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDeptName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AssetsHandover";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Handover";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssetsHandover_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAssetHandoverDetails)).EndInit();
            this.cmsAssetsHandover.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDeptName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGMName;
        private System.Windows.Forms.DataGridView dvgAssetHandoverDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHandedOverBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpReceivedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRecordedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpAcknowledgedBy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox cbxHandedoverBy;
        private System.Windows.Forms.CheckBox cbxReceivedBy;
        private System.Windows.Forms.CheckBox cbxRecordedBy;
        private System.Windows.Forms.CheckBox cbxAcknowledgedBy;
        private System.Windows.Forms.ContextMenuStrip cmsAssetsHandover;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}