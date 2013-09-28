namespace InventorySalesDebtorsSytem
{
    partial class PurchaseOrderRequisition
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
            System.Windows.Forms.Label branchCodeLabel;
            System.Windows.Forms.Label locationCodeLabel;
            System.Windows.Forms.Label manualNoLabel;
            System.Windows.Forms.Label referenceNoLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label txnDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderRequisition));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pORequisitionHedBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pORequisitionHedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.txnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtManualNo = new System.Windows.Forms.TextBox();
            this.pORequisitionDetsDataGridView = new System.Windows.Forms.DataGridView();
            this.RecordNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QOH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poRequisitionDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionToolBar1 = new InventorySalesDebtorsSytem.TransactionToolBar();
            this.txtLocationCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.txtBranchCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.formInitializer1 = new InventorySalesDebtorsSytem.ReusableComponents.FormInitializer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            branchCodeLabel = new System.Windows.Forms.Label();
            locationCodeLabel = new System.Windows.Forms.Label();
            manualNoLabel = new System.Windows.Forms.Label();
            referenceNoLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            txnDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pORequisitionHedBindingNavigator)).BeginInit();
            this.pORequisitionHedBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pORequisitionHedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORequisitionDetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poRequisitionDetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // branchCodeLabel
            // 
            branchCodeLabel.AutoSize = true;
            branchCodeLabel.Location = new System.Drawing.Point(29, 84);
            branchCodeLabel.Name = "branchCodeLabel";
            branchCodeLabel.Size = new System.Drawing.Size(72, 13);
            branchCodeLabel.TabIndex = 1;
            branchCodeLabel.Text = "Branch Code:";
            // 
            // locationCodeLabel
            // 
            locationCodeLabel.AutoSize = true;
            locationCodeLabel.Location = new System.Drawing.Point(29, 110);
            locationCodeLabel.Name = "locationCodeLabel";
            locationCodeLabel.Size = new System.Drawing.Size(79, 13);
            locationCodeLabel.TabIndex = 3;
            locationCodeLabel.Text = "Location Code:";
            // 
            // manualNoLabel
            // 
            manualNoLabel.AutoSize = true;
            manualNoLabel.Location = new System.Drawing.Point(29, 136);
            manualNoLabel.Name = "manualNoLabel";
            manualNoLabel.Size = new System.Drawing.Size(62, 13);
            manualNoLabel.TabIndex = 5;
            manualNoLabel.Text = "Manual No:";
            // 
            // referenceNoLabel
            // 
            referenceNoLabel.AutoSize = true;
            referenceNoLabel.Location = new System.Drawing.Point(29, 58);
            referenceNoLabel.Name = "referenceNoLabel";
            referenceNoLabel.Size = new System.Drawing.Size(77, 13);
            referenceNoLabel.TabIndex = 7;
            referenceNoLabel.Text = "Reference No:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(29, 162);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 9;
            remarksLabel.Text = "Remarks:";
            // 
            // txnDateLabel
            // 
            txnDateLabel.AutoSize = true;
            txnDateLabel.Location = new System.Drawing.Point(359, 58);
            txnDateLabel.Name = "txnDateLabel";
            txnDateLabel.Size = new System.Drawing.Size(33, 13);
            txnDateLabel.TabIndex = 11;
            txnDateLabel.Text = "Date:";
            // 
            // pORequisitionHedBindingNavigator
            // 
            this.pORequisitionHedBindingNavigator.AddNewItem = null;
            this.pORequisitionHedBindingNavigator.BindingSource = this.pORequisitionHedBindingSource;
            this.pORequisitionHedBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pORequisitionHedBindingNavigator.DeleteItem = null;
            this.pORequisitionHedBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.pORequisitionHedBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.pORequisitionHedBindingNavigator.Location = new System.Drawing.Point(411, 16);
            this.pORequisitionHedBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pORequisitionHedBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pORequisitionHedBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pORequisitionHedBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pORequisitionHedBindingNavigator.Name = "pORequisitionHedBindingNavigator";
            this.pORequisitionHedBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pORequisitionHedBindingNavigator.Size = new System.Drawing.Size(209, 25);
            this.pORequisitionHedBindingNavigator.TabIndex = 1;
            this.pORequisitionHedBindingNavigator.Text = "bindingNavigator1";
            // 
            // pORequisitionHedBindingSource
            // 
            this.pORequisitionHedBindingSource.DataSource = typeof(DBLayer.PORequisitionHed);
            this.pORequisitionHedBindingSource.CurrentChanged += new System.EventHandler(this.pORequisitionHedBindingSource_CurrentChanged);
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
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pORequisitionHedBindingSource, "ReferenceNo", true));
            this.referenceNoTextBox.Location = new System.Drawing.Point(114, 54);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.ReadOnly = true;
            this.referenceNoTextBox.Size = new System.Drawing.Size(150, 20);
            this.referenceNoTextBox.TabIndex = 2;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pORequisitionHedBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(114, 158);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(484, 20);
            this.remarksTextBox.TabIndex = 7;
            // 
            // txnDateDateTimePicker
            // 
            this.txnDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pORequisitionHedBindingSource, "TxnDate", true));
            this.txnDateDateTimePicker.Location = new System.Drawing.Point(398, 54);
            this.txnDateDateTimePicker.Name = "txnDateDateTimePicker";
            this.txnDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.txnDateDateTimePicker.TabIndex = 3;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Enabled = false;
            this.txtBranchName.Location = new System.Drawing.Point(269, 80);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(329, 20);
            this.txtBranchName.TabIndex = 17;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Enabled = false;
            this.txtLocationName.Location = new System.Drawing.Point(269, 106);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(329, 20);
            this.txtLocationName.TabIndex = 18;
            // 
            // txtManualNo
            // 
            this.txtManualNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pORequisitionHedBindingSource, "ManualNo", true));
            this.txtManualNo.Location = new System.Drawing.Point(114, 132);
            this.txtManualNo.Name = "txtManualNo";
            this.txtManualNo.Size = new System.Drawing.Size(150, 20);
            this.txtManualNo.TabIndex = 6;
            // 
            // pORequisitionDetsDataGridView
            // 
            this.pORequisitionDetsDataGridView.AllowUserToAddRows = false;
            this.pORequisitionDetsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pORequisitionDetsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.pORequisitionDetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pORequisitionDetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordNo,
            this.itemCode,
            this.ItemName,
            this.QOH,
            this.quantity});
            this.pORequisitionDetsDataGridView.DataSource = this.poRequisitionDetBindingSource;
            this.pORequisitionDetsDataGridView.Location = new System.Drawing.Point(40, 236);
            this.pORequisitionDetsDataGridView.MultiSelect = false;
            this.pORequisitionDetsDataGridView.Name = "pORequisitionDetsDataGridView";
            this.pORequisitionDetsDataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.pORequisitionDetsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.pORequisitionDetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pORequisitionDetsDataGridView.Size = new System.Drawing.Size(546, 225);
            this.pORequisitionDetsDataGridView.TabIndex = 9;
            this.pORequisitionDetsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.pORequisitionDetsDataGridView_RowsAdded);
            this.pORequisitionDetsDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.pORequisitionDetsDataGridView_RowsRemoved);
            // 
            // RecordNo
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RecordNo.DefaultCellStyle = dataGridViewCellStyle9;
            this.RecordNo.FillWeight = 75F;
            this.RecordNo.Frozen = true;
            this.RecordNo.HeaderText = "Rec No";
            this.RecordNo.Name = "RecordNo";
            this.RecordNo.ReadOnly = true;
            this.RecordNo.Width = 70;
            // 
            // itemCode
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.itemCode.DefaultCellStyle = dataGridViewCellStyle10;
            this.itemCode.Frozen = true;
            this.itemCode.HeaderText = "ItemCode";
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            // 
            // ItemName
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ItemName.DefaultCellStyle = dataGridViewCellStyle11;
            this.ItemName.Frozen = true;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 180;
            // 
            // QOH
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QOH.DefaultCellStyle = dataGridViewCellStyle12;
            this.QOH.Frozen = true;
            this.QOH.HeaderText = "QOH";
            this.QOH.Name = "QOH";
            this.QOH.ReadOnly = true;
            this.QOH.Width = 75;
            // 
            // quantity
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle13;
            this.quantity.Frozen = true;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 75;
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
            this.transactionToolBar1.Location = new System.Drawing.Point(15, 2);
            this.transactionToolBar1.mode = null;
            this.transactionToolBar1.Name = "transactionToolBar1";
            this.transactionToolBar1.primaryKeyControl = null;
            this.transactionToolBar1.primaryKeyField = null;
            this.transactionToolBar1.ReferenceID = null;
            this.transactionToolBar1.Size = new System.Drawing.Size(388, 52);
            this.transactionToolBar1.TabIndex = 0;
            // 
            // txtLocationCode
            // 
            this.txtLocationCode.codeFieldName = null;
            this.txtLocationCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pORequisitionHedBindingSource, "LocationCode", true));
            this.txtLocationCode.filterCondition = null;
            this.txtLocationCode.Location = new System.Drawing.Point(114, 106);
            this.txtLocationCode.Name = "txtLocationCode";
            this.txtLocationCode.Size = new System.Drawing.Size(150, 20);
            this.txtLocationCode.TabIndex = 5;
            this.txtLocationCode.valid = false;
            this.txtLocationCode.varList = null;
            this.txtLocationCode.Enter += new System.EventHandler(this.txtLocationCode_Enter);
            this.txtLocationCode.Leave += new System.EventHandler(this.txtLocationCode_Leave);
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.codeFieldName = null;
            this.txtBranchCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pORequisitionHedBindingSource, "BranchCode", true));
            this.txtBranchCode.filterCondition = null;
            this.txtBranchCode.Location = new System.Drawing.Point(114, 80);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(150, 20);
            this.txtBranchCode.TabIndex = 4;
            this.txtBranchCode.valid = false;
            this.txtBranchCode.varList = null;
            this.txtBranchCode.Leave += new System.EventHandler(this.txtBranchCode_Leave);
            // 
            // formInitializer1
            // 
            this.formInitializer1.Location = new System.Drawing.Point(576, 15);
            this.formInitializer1.Name = "formInitializer1";
            this.formInitializer1.Size = new System.Drawing.Size(10, 10);
            this.formInitializer1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtItemCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 286);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(508, 24);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(50, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(323, 25);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtItemCode
            // 
            this.txtItemCode.codeFieldName = null;
            this.txtItemCode.Enabled = false;
            this.txtItemCode.filterCondition = null;
            this.txtItemCode.Location = new System.Drawing.Point(86, 25);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(150, 20);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.valid = false;
            this.txtItemCode.varList = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PurchaseOrderRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 478);
            this.Controls.Add(this.formInitializer1);
            this.Controls.Add(this.transactionToolBar1);
            this.Controls.Add(this.pORequisitionDetsDataGridView);
            this.Controls.Add(this.txtManualNo);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtLocationCode);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(branchCodeLabel);
            this.Controls.Add(locationCodeLabel);
            this.Controls.Add(manualNoLabel);
            this.Controls.Add(referenceNoLabel);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(txnDateLabel);
            this.Controls.Add(this.txnDateDateTimePicker);
            this.Controls.Add(this.pORequisitionHedBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrderRequisition";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Requisition";
            this.Load += new System.EventHandler(this.PurchaseOrderRequisition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pORequisitionHedBindingNavigator)).EndInit();
            this.pORequisitionHedBindingNavigator.ResumeLayout(false);
            this.pORequisitionHedBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pORequisitionHedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORequisitionDetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poRequisitionDetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pORequisitionHedBindingSource;
        private System.Windows.Forms.BindingNavigator pORequisitionHedBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox referenceNoTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.DateTimePicker txnDateDateTimePicker;
        private MasterDataTextBox txtBranchCode;
        private MasterDataTextBox txtLocationCode;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtManualNo;
        private System.Windows.Forms.DataGridView pORequisitionDetsDataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TransactionToolBar transactionToolBar1;
        private ReusableComponents.FormInitializer formInitializer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MasterDataTextBox txtItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.BindingSource poRequisitionDetBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QOH;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}