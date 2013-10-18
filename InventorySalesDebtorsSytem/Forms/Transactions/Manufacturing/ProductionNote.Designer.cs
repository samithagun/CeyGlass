namespace InventorySalesDebtorsSytem.Forms.Transactions.Manufacturing
{
    partial class ProductionNote
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label manualNoLabel;
            System.Windows.Forms.Label finishGoodTypeLabel;
            System.Windows.Forms.Label referenceNoLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label txnDateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionNote));
            this.PNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PNDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formInitializer1 = new InventorySalesDebtorsSytem.ReusableComponents.FormInitializer();
            this.PNDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WasteQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBranchCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtDamageQty = new System.Windows.Forms.TextBox();
            this.txtUsableQty = new System.Windows.Forms.TextBox();
            this.txtBOQQty = new System.Windows.Forms.TextBox();
            this.txtItemCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.txtProPlan = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.transactionToolBar1 = new InventorySalesDebtorsSytem.TransactionToolBar();
            this.PNBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtManualNo = new System.Windows.Forms.TextBox();
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.txnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            manualNoLabel = new System.Windows.Forms.Label();
            finishGoodTypeLabel = new System.Windows.Forms.Label();
            referenceNoLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            txnDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNBindingNavigator)).BeginInit();
            this.PNBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 168);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 13);
            label1.TabIndex = 86;
            label1.Text = "Total Qty:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(549, 197);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 13);
            label4.TabIndex = 81;
            label4.Text = "Damage Qty:";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(293, 197);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 13);
            label3.TabIndex = 79;
            label3.Text = "Usable Qty:";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 197);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 77;
            label2.Text = "BOQ Qty:";
            label2.Visible = false;
            // 
            // manualNoLabel
            // 
            manualNoLabel.AutoSize = true;
            manualNoLabel.Location = new System.Drawing.Point(540, 82);
            manualNoLabel.Name = "manualNoLabel";
            manualNoLabel.Size = new System.Drawing.Size(62, 13);
            manualNoLabel.TabIndex = 43;
            manualNoLabel.Text = "Manual No:";
            // 
            // finishGoodTypeLabel
            // 
            finishGoodTypeLabel.AutoSize = true;
            finishGoodTypeLabel.Location = new System.Drawing.Point(18, 140);
            finishGoodTypeLabel.Name = "finishGoodTypeLabel";
            finishGoodTypeLabel.Size = new System.Drawing.Size(58, 13);
            finishGoodTypeLabel.TabIndex = 49;
            finishGoodTypeLabel.Text = "Item Code:";
            // 
            // referenceNoLabel
            // 
            referenceNoLabel.AutoSize = true;
            referenceNoLabel.Location = new System.Drawing.Point(18, 81);
            referenceNoLabel.Name = "referenceNoLabel";
            referenceNoLabel.Size = new System.Drawing.Size(77, 13);
            referenceNoLabel.TabIndex = 45;
            referenceNoLabel.Text = "Reference No:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(18, 109);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(102, 13);
            remarksLabel.TabIndex = 46;
            remarksLabel.Text = "Production Plan No:";
            // 
            // txnDateLabel
            // 
            txnDateLabel.AutoSize = true;
            txnDateLabel.Location = new System.Drawing.Point(297, 81);
            txnDateLabel.Name = "txnDateLabel";
            txnDateLabel.Size = new System.Drawing.Size(33, 13);
            txnDateLabel.TabIndex = 47;
            txnDateLabel.Text = "Date:";
            // 
            // PNBindingSource
            // 
            this.PNBindingSource.DataSource = typeof(DBLayer.ProductionNoteHed);
            // 
            // formInitializer1
            // 
            this.formInitializer1.Location = new System.Drawing.Point(273, 168);
            this.formInitializer1.Name = "formInitializer1";
            this.formInitializer1.Size = new System.Drawing.Size(10, 10);
            this.formInitializer1.TabIndex = 106;
            // 
            // PNDataGridView
            // 
            this.PNDataGridView.AllowUserToAddRows = false;
            this.PNDataGridView.AllowUserToResizeColumns = false;
            this.PNDataGridView.AllowUserToResizeRows = false;
            this.PNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.UsedQty,
            this.WasteQty,
            this.TotalQty});
            this.PNDataGridView.Location = new System.Drawing.Point(21, 193);
            this.PNDataGridView.Name = "PNDataGridView";
            this.PNDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PNDataGridView.Size = new System.Drawing.Size(733, 252);
            this.PNDataGridView.TabIndex = 105;
            this.PNDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PNDataGridView_CellContentClick);
            this.PNDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PNDataGridView_CellEndEdit);
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 120;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 210;
            // 
            // UsedQty
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.UsedQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.UsedQty.HeaderText = "Used Qty";
            this.UsedQty.Name = "UsedQty";
            this.UsedQty.Width = 120;
            // 
            // WasteQty
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.WasteQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.WasteQty.HeaderText = "Wasted Qty";
            this.WasteQty.Name = "WasteQty";
            this.WasteQty.Width = 120;
            // 
            // TotalQty
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.TotalQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalQty.HeaderText = "Total Qty";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.ReadOnly = true;
            this.TotalQty.Width = 120;
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.codeFieldName = null;
            this.txtBranchCode.filterCondition = null;
            this.txtBranchCode.Location = new System.Drawing.Point(606, 107);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(148, 20);
            this.txtBranchCode.sortOrder = null;
            this.txtBranchCode.TabIndex = 104;
            this.txtBranchCode.Text = "100       ";
            this.txtBranchCode.valid = true;
            this.txtBranchCode.varList = null;
            this.txtBranchCode.Visible = false;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PNBindingSource, "Quantity", true));
            this.txtTotalQty.Location = new System.Drawing.Point(123, 164);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(131, 20);
            this.txtTotalQty.TabIndex = 85;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(262, 136);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(492, 20);
            this.txtItemName.TabIndex = 84;
            // 
            // txtDamageQty
            // 
            this.txtDamageQty.Enabled = false;
            this.txtDamageQty.Location = new System.Drawing.Point(623, 193);
            this.txtDamageQty.Name = "txtDamageQty";
            this.txtDamageQty.Size = new System.Drawing.Size(131, 20);
            this.txtDamageQty.TabIndex = 80;
            this.txtDamageQty.Visible = false;
            // 
            // txtUsableQty
            // 
            this.txtUsableQty.Enabled = false;
            this.txtUsableQty.Location = new System.Drawing.Point(359, 193);
            this.txtUsableQty.Name = "txtUsableQty";
            this.txtUsableQty.Size = new System.Drawing.Size(131, 20);
            this.txtUsableQty.TabIndex = 78;
            this.txtUsableQty.Visible = false;
            // 
            // txtBOQQty
            // 
            this.txtBOQQty.Enabled = false;
            this.txtBOQQty.Location = new System.Drawing.Point(123, 193);
            this.txtBOQQty.Name = "txtBOQQty";
            this.txtBOQQty.Size = new System.Drawing.Size(131, 20);
            this.txtBOQQty.TabIndex = 76;
            this.txtBOQQty.Visible = false;
            // 
            // txtItemCode
            // 
            this.txtItemCode.codeFieldName = null;
            this.txtItemCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PNBindingSource, "ItemCode", true));
            this.txtItemCode.filterCondition = null;
            this.txtItemCode.Location = new System.Drawing.Point(123, 136);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(131, 20);
            this.txtItemCode.sortOrder = null;
            this.txtItemCode.TabIndex = 71;
            this.txtItemCode.valid = false;
            this.txtItemCode.varList = null;
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            // 
            // txtProPlan
            // 
            this.txtProPlan.codeFieldName = null;
            this.txtProPlan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PNBindingSource, "ProPlanNo", true));
            this.txtProPlan.filterCondition = null;
            this.txtProPlan.Location = new System.Drawing.Point(123, 107);
            this.txtProPlan.Name = "txtProPlan";
            this.txtProPlan.Size = new System.Drawing.Size(131, 20);
            this.txtProPlan.sortOrder = null;
            this.txtProPlan.TabIndex = 70;
            this.txtProPlan.valid = false;
            this.txtProPlan.varList = null;
            // 
            // transactionToolBar1
            // 
            this.transactionToolBar1.bindingNavigator = null;
            this.transactionToolBar1.branchCodeControl = null;
            this.transactionToolBar1.db = null;
            this.transactionToolBar1.detDataGrid = null;
            this.transactionToolBar1.detObjectBindingSource = null;
            this.transactionToolBar1.firstFocusControl = null;
            this.transactionToolBar1.hedObjectBindingSource = null;
            this.transactionToolBar1.HideAddButton = false;
            this.transactionToolBar1.HideDeleteButton = false;
            this.transactionToolBar1.HideEditButton = false;
            this.transactionToolBar1.HidePrintButton = false;
            this.transactionToolBar1.HideViewButton = false;
            this.transactionToolBar1.Location = new System.Drawing.Point(13, 9);
            this.transactionToolBar1.mode = null;
            this.transactionToolBar1.Name = "transactionToolBar1";
            this.transactionToolBar1.primaryKeyControl = null;
            this.transactionToolBar1.primaryKeyField = null;
            this.transactionToolBar1.ReferenceID = null;
            this.transactionToolBar1.Size = new System.Drawing.Size(388, 52);
            this.transactionToolBar1.TabIndex = 38;
            // 
            // PNBindingNavigator
            // 
            this.PNBindingNavigator.AddNewItem = null;
            this.PNBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.PNBindingNavigator.DeleteItem = null;
            this.PNBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.PNBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.PNBindingNavigator.Location = new System.Drawing.Point(415, 19);
            this.PNBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.PNBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.PNBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.PNBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.PNBindingNavigator.Name = "PNBindingNavigator";
            this.PNBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.PNBindingNavigator.Size = new System.Drawing.Size(209, 25);
            this.PNBindingNavigator.TabIndex = 39;
            this.PNBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtManualNo
            // 
            this.txtManualNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PNBindingSource, "ManualNo", true));
            this.txtManualNo.Location = new System.Drawing.Point(606, 78);
            this.txtManualNo.Name = "txtManualNo";
            this.txtManualNo.Size = new System.Drawing.Size(148, 20);
            this.txtManualNo.TabIndex = 42;
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.Location = new System.Drawing.Point(123, 77);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.ReadOnly = true;
            this.referenceNoTextBox.Size = new System.Drawing.Size(131, 20);
            this.referenceNoTextBox.TabIndex = 40;
            // 
            // txnDateTimePicker
            // 
            this.txnDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PNBindingSource, "TxnDate", true));
            this.txnDateTimePicker.Location = new System.Drawing.Point(334, 77);
            this.txnDateTimePicker.Name = "txnDateTimePicker";
            this.txnDateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.txnDateTimePicker.TabIndex = 41;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductionNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 457);
            this.Controls.Add(this.formInitializer1);
            this.Controls.Add(this.PNDataGridView);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtDamageQty);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtUsableQty);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtBOQQty);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtProPlan);
            this.Controls.Add(manualNoLabel);
            this.Controls.Add(finishGoodTypeLabel);
            this.Controls.Add(referenceNoLabel);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(txnDateLabel);
            this.Controls.Add(this.transactionToolBar1);
            this.Controls.Add(this.PNBindingNavigator);
            this.Controls.Add(this.txtManualNo);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(this.txnDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductionNote";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production Note";
            this.Load += new System.EventHandler(this.ProductionNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNBindingNavigator)).EndInit();
            this.PNBindingNavigator.ResumeLayout(false);
            this.PNBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private TransactionToolBar transactionToolBar1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.BindingNavigator PNBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtManualNo;
        private System.Windows.Forms.TextBox referenceNoTextBox;
        private System.Windows.Forms.DateTimePicker txnDateTimePicker;
        private MasterDataTextBox txtProPlan;
        private MasterDataTextBox txtItemCode;
        private System.Windows.Forms.TextBox txtBOQQty;
        private System.Windows.Forms.TextBox txtUsableQty;
        private System.Windows.Forms.TextBox txtDamageQty;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtTotalQty;
        private MasterDataTextBox txtBranchCode;
        private System.Windows.Forms.BindingSource PNBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource PNDetBindingSource;
        private System.Windows.Forms.DataGridView PNDataGridView;
        private ReusableComponents.FormInitializer formInitializer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn WasteQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
    }
}