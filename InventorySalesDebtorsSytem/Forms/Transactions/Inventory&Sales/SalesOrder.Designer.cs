﻿namespace InventorySalesDebtorsSytem
{
    partial class SalesOrder
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label branchCodeLabel;
            System.Windows.Forms.Label locationCodeLabel;
            System.Windows.Forms.Label hedDiscPerLabel;
            System.Windows.Forms.Label manualNoLabel;
            System.Windows.Forms.Label referenceNoLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label customerCodeLabel;
            System.Windows.Forms.Label txnDateLabel;
            System.Windows.Forms.Label hedDiscTotValLabel;
            System.Windows.Forms.Label itemDiscTotValLabel;
            System.Windows.Forms.Label nBTValLabel;
            System.Windows.Forms.Label totalValLabel;
            System.Windows.Forms.Label vATValLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrder));
            this.HeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.numHedDiscPer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numItemDiscPer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cusDataGridView = new System.Windows.Forms.DataGridView();
            this.RecordNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QOH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NBTVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.manualNoTextBox = new System.Windows.Forms.TextBox();
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.txnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HeaderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCustomerCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.transactionToolBar1 = new InventorySalesDebtorsSytem.TransactionToolBar();
            this.txtLocationCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.txtBranchCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.hedDiscTotValTextBox = new System.Windows.Forms.TextBox();
            this.itemDiscTotValTextBox = new System.Windows.Forms.TextBox();
            this.nBTValTextBox = new System.Windows.Forms.TextBox();
            this.totalValTextBox = new System.Windows.Forms.TextBox();
            this.vATValTextBox = new System.Windows.Forms.TextBox();
            this.txtRepName = new System.Windows.Forms.TextBox();
            this.txtRepCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.txtQuotNo = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            branchCodeLabel = new System.Windows.Forms.Label();
            locationCodeLabel = new System.Windows.Forms.Label();
            hedDiscPerLabel = new System.Windows.Forms.Label();
            manualNoLabel = new System.Windows.Forms.Label();
            referenceNoLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            customerCodeLabel = new System.Windows.Forms.Label();
            txnDateLabel = new System.Windows.Forms.Label();
            hedDiscTotValLabel = new System.Windows.Forms.Label();
            itemDiscTotValLabel = new System.Windows.Forms.Label();
            nBTValLabel = new System.Windows.Forms.Label();
            totalValLabel = new System.Windows.Forms.Label();
            vATValLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHedDiscPer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemDiscPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderBindingNavigator)).BeginInit();
            this.HeaderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(526, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 13);
            label4.TabIndex = 3;
            label4.Text = "Disc Percentage:";
            // 
            // branchCodeLabel
            // 
            branchCodeLabel.AutoSize = true;
            branchCodeLabel.Location = new System.Drawing.Point(17, 89);
            branchCodeLabel.Name = "branchCodeLabel";
            branchCodeLabel.Size = new System.Drawing.Size(72, 13);
            branchCodeLabel.TabIndex = 27;
            branchCodeLabel.Text = "Branch Code:";
            // 
            // locationCodeLabel
            // 
            locationCodeLabel.AutoSize = true;
            locationCodeLabel.Location = new System.Drawing.Point(17, 115);
            locationCodeLabel.Name = "locationCodeLabel";
            locationCodeLabel.Size = new System.Drawing.Size(79, 13);
            locationCodeLabel.TabIndex = 28;
            locationCodeLabel.Text = "Location Code:";
            // 
            // hedDiscPerLabel
            // 
            hedDiscPerLabel.AutoSize = true;
            hedDiscPerLabel.Location = new System.Drawing.Point(264, 190);
            hedDiscPerLabel.Name = "hedDiscPerLabel";
            hedDiscPerLabel.Size = new System.Drawing.Size(148, 13);
            hedDiscPerLabel.TabIndex = 3;
            hedDiscPerLabel.Text = "Header Discount Percentage:";
            // 
            // manualNoLabel
            // 
            manualNoLabel.AutoSize = true;
            manualNoLabel.Location = new System.Drawing.Point(17, 190);
            manualNoLabel.Name = "manualNoLabel";
            manualNoLabel.Size = new System.Drawing.Size(62, 13);
            manualNoLabel.TabIndex = 11;
            manualNoLabel.Text = "Manual No:";
            // 
            // referenceNoLabel
            // 
            referenceNoLabel.AutoSize = true;
            referenceNoLabel.Location = new System.Drawing.Point(17, 63);
            referenceNoLabel.Name = "referenceNoLabel";
            referenceNoLabel.Size = new System.Drawing.Size(77, 13);
            referenceNoLabel.TabIndex = 15;
            referenceNoLabel.Text = "Reference No:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(17, 216);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 17;
            remarksLabel.Text = "Remarks:";
            // 
            // customerCodeLabel
            // 
            customerCodeLabel.AutoSize = true;
            customerCodeLabel.Location = new System.Drawing.Point(17, 164);
            customerCodeLabel.Name = "customerCodeLabel";
            customerCodeLabel.Size = new System.Drawing.Size(82, 13);
            customerCodeLabel.TabIndex = 19;
            customerCodeLabel.Text = "Customer Code:";
            // 
            // txnDateLabel
            // 
            txnDateLabel.AutoSize = true;
            txnDateLabel.Location = new System.Drawing.Point(268, 63);
            txnDateLabel.Name = "txnDateLabel";
            txnDateLabel.Size = new System.Drawing.Size(33, 13);
            txnDateLabel.TabIndex = 23;
            txnDateLabel.Text = "Date:";
            // 
            // hedDiscTotValLabel
            // 
            hedDiscTotValLabel.AutoSize = true;
            hedDiscTotValLabel.Location = new System.Drawing.Point(490, 519);
            hedDiscTotValLabel.Name = "hedDiscTotValLabel";
            hedDiscTotValLabel.Size = new System.Drawing.Size(117, 13);
            hedDiscTotValLabel.TabIndex = 45;
            hedDiscTotValLabel.Text = "Header Discount Total:";
            // 
            // itemDiscTotValLabel
            // 
            itemDiscTotValLabel.AutoSize = true;
            itemDiscTotValLabel.Location = new System.Drawing.Point(222, 519);
            itemDiscTotValLabel.Name = "itemDiscTotValLabel";
            itemDiscTotValLabel.Size = new System.Drawing.Size(102, 13);
            itemDiscTotValLabel.TabIndex = 47;
            itemDiscTotValLabel.Text = "Item Discount Total:";
            // 
            // nBTValLabel
            // 
            nBTValLabel.AutoSize = true;
            nBTValLabel.Location = new System.Drawing.Point(222, 545);
            nBTValLabel.Name = "nBTValLabel";
            nBTValLabel.Size = new System.Drawing.Size(59, 13);
            nBTValLabel.TabIndex = 49;
            nBTValLabel.Text = "Total NBT:";
            // 
            // totalValLabel
            // 
            totalValLabel.AutoSize = true;
            totalValLabel.Location = new System.Drawing.Point(553, 571);
            totalValLabel.Name = "totalValLabel";
            totalValLabel.Size = new System.Drawing.Size(54, 13);
            totalValLabel.TabIndex = 51;
            totalValLabel.Text = "Net Total:";
            // 
            // vATValLabel
            // 
            vATValLabel.AutoSize = true;
            vATValLabel.Location = new System.Drawing.Point(549, 545);
            vATValLabel.Name = "vATValLabel";
            vATValLabel.Size = new System.Drawing.Size(58, 13);
            vATValLabel.TabIndex = 53;
            vATValLabel.Text = "Total VAT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(17, 140);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 13);
            label6.TabIndex = 56;
            label6.Text = "Sales Rep Code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(527, 63);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 13);
            label5.TabIndex = 59;
            label5.Text = "Quotation No:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(503, 188);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 13);
            label7.TabIndex = 61;
            label7.Text = "Delivery Date:";
            // 
            // HeaderBindingSource
            // 
            this.HeaderBindingSource.DataSource = typeof(DBLayer.SalesOrderHed);
            this.HeaderBindingSource.CurrentChanged += new System.EventHandler(this.HeaderBindingSource_CurrentChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(259, 160);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(498, 20);
            this.txtCustomerName.TabIndex = 37;
            // 
            // numHedDiscPer
            // 
            this.numHedDiscPer.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.HeaderBindingSource, "HedDiscPer", true));
            this.numHedDiscPer.DecimalPlaces = 2;
            this.numHedDiscPer.Location = new System.Drawing.Point(434, 186);
            this.numHedDiscPer.Name = "numHedDiscPer";
            this.numHedDiscPer.Size = new System.Drawing.Size(68, 20);
            this.numHedDiscPer.TabIndex = 10;
            this.numHedDiscPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Controls.Add(this.numUnitPrice);
            this.groupBox1.Controls.Add(this.numItemDiscPer);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cusDataGridView);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtItemCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 273);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // numQty
            // 
            this.numQty.DecimalPlaces = 2;
            this.numQty.Location = new System.Drawing.Point(459, 20);
            this.numQty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(60, 20);
            this.numQty.TabIndex = 2;
            this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQty.ThousandsSeparator = true;
            this.numQty.Leave += new System.EventHandler(this.numQty_Leave);
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 2;
            this.numUnitPrice.Location = new System.Drawing.Point(296, 20);
            this.numUnitPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.numUnitPrice.TabIndex = 1;
            this.numUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUnitPrice.ThousandsSeparator = true;
            // 
            // numItemDiscPer
            // 
            this.numItemDiscPer.DecimalPlaces = 2;
            this.numItemDiscPer.Location = new System.Drawing.Point(622, 20);
            this.numItemDiscPer.Name = "numItemDiscPer";
            this.numItemDiscPer.Size = new System.Drawing.Size(60, 20);
            this.numItemDiscPer.TabIndex = 3;
            this.numItemDiscPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "UnitPrice:";
            // 
            // cusDataGridView
            // 
            this.cusDataGridView.AllowUserToAddRows = false;
            this.cusDataGridView.AutoGenerateColumns = false;
            this.cusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordNo,
            this.ItemCode,
            this.ItemName,
            this.UnitPrice,
            this.QOH,
            this.Quantity,
            this.DiscPer,
            this.DiscVal,
            this.NBTVal,
            this.VATVal,
            this.TotalVal});
            this.cusDataGridView.DataSource = this.itemGridBindingSource;
            this.cusDataGridView.Location = new System.Drawing.Point(11, 45);
            this.cusDataGridView.Name = "cusDataGridView";
            this.cusDataGridView.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.cusDataGridView.Size = new System.Drawing.Size(737, 220);
            this.cusDataGridView.TabIndex = 5;
            this.cusDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
            this.cusDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView_RowsRemoved);
            // 
            // RecordNo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RecordNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.RecordNo.Frozen = true;
            this.RecordNo.HeaderText = "Rec No";
            this.RecordNo.Name = "RecordNo";
            this.RecordNo.ReadOnly = true;
            this.RecordNo.Width = 75;
            // 
            // ItemCode
            // 
            this.ItemCode.Frozen = true;
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // QOH
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QOH.DefaultCellStyle = dataGridViewCellStyle3;
            this.QOH.HeaderText = "QOH";
            this.QOH.Name = "QOH";
            this.QOH.ReadOnly = true;
            // 
            // Quantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // DiscPer
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DiscPer.DefaultCellStyle = dataGridViewCellStyle5;
            this.DiscPer.HeaderText = "Discount Percentage";
            this.DiscPer.Name = "DiscPer";
            this.DiscPer.ReadOnly = true;
            // 
            // DiscVal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DiscVal.DefaultCellStyle = dataGridViewCellStyle6;
            this.DiscVal.HeaderText = "Discount Value";
            this.DiscVal.Name = "DiscVal";
            this.DiscVal.ReadOnly = true;
            // 
            // NBTVal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NBTVal.DefaultCellStyle = dataGridViewCellStyle7;
            this.NBTVal.HeaderText = "NBT Value";
            this.NBTVal.Name = "NBTVal";
            this.NBTVal.ReadOnly = true;
            // 
            // VATVal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.VATVal.DefaultCellStyle = dataGridViewCellStyle8;
            this.VATVal.HeaderText = "VAT Value";
            this.VATVal.Name = "VATVal";
            this.VATVal.ReadOnly = true;
            // 
            // TotalVal
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalVal.DefaultCellStyle = dataGridViewCellStyle9;
            this.TotalVal.HeaderText = "Total";
            this.TotalVal.Name = "TotalVal";
            this.TotalVal.ReadOnly = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(695, 18);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(50, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // txtItemCode
            // 
            this.txtItemCode.codeFieldName = null;
            this.txtItemCode.Enabled = false;
            this.txtItemCode.filterCondition = null;
            this.txtItemCode.Location = new System.Drawing.Point(79, 20);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(150, 20);
            this.txtItemCode.sortOrder = null;
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.valid = false;
            this.txtItemCode.varList = null;
            this.txtItemCode.Enter += new System.EventHandler(this.txtItemCode_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code:";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Enabled = false;
            this.txtLocationName.Location = new System.Drawing.Point(259, 111);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(498, 20);
            this.txtLocationName.TabIndex = 32;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Enabled = false;
            this.txtBranchName.Location = new System.Drawing.Point(259, 85);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(498, 20);
            this.txtBranchName.TabIndex = 31;
            // 
            // manualNoTextBox
            // 
            this.manualNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "ManualNo", true));
            this.manualNoTextBox.Location = new System.Drawing.Point(104, 186);
            this.manualNoTextBox.Name = "manualNoTextBox";
            this.manualNoTextBox.Size = new System.Drawing.Size(150, 20);
            this.manualNoTextBox.TabIndex = 9;
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "ReferenceNo", true));
            this.referenceNoTextBox.Location = new System.Drawing.Point(104, 59);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.ReadOnly = true;
            this.referenceNoTextBox.Size = new System.Drawing.Size(150, 20);
            this.referenceNoTextBox.TabIndex = 2;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(104, 212);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(653, 20);
            this.remarksTextBox.TabIndex = 11;
            // 
            // txnDateDateTimePicker
            // 
            this.txnDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.HeaderBindingSource, "TxnDate", true));
            this.txnDateDateTimePicker.Location = new System.Drawing.Point(308, 59);
            this.txnDateDateTimePicker.Name = "txnDateDateTimePicker";
            this.txnDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.txnDateDateTimePicker.TabIndex = 3;
            // 
            // HeaderBindingNavigator
            // 
            this.HeaderBindingNavigator.AddNewItem = null;
            this.HeaderBindingNavigator.BindingSource = this.HeaderBindingSource;
            this.HeaderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.HeaderBindingNavigator.DeleteItem = null;
            this.HeaderBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.HeaderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.HeaderBindingNavigator.Location = new System.Drawing.Point(411, 16);
            this.HeaderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.HeaderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.HeaderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.HeaderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.HeaderBindingNavigator.Name = "HeaderBindingNavigator";
            this.HeaderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.HeaderBindingNavigator.Size = new System.Drawing.Size(209, 25);
            this.HeaderBindingNavigator.TabIndex = 1;
            this.HeaderBindingNavigator.Text = "bindingNavigator1";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.codeFieldName = null;
            this.txtCustomerCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "CustomerCode", true));
            this.txtCustomerCode.filterCondition = null;
            this.txtCustomerCode.Location = new System.Drawing.Point(104, 160);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(150, 20);
            this.txtCustomerCode.sortOrder = null;
            this.txtCustomerCode.TabIndex = 8;
            this.txtCustomerCode.valid = false;
            this.txtCustomerCode.varList = null;
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
            this.txtLocationCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "LocationCode", true));
            this.txtLocationCode.filterCondition = null;
            this.txtLocationCode.Location = new System.Drawing.Point(104, 111);
            this.txtLocationCode.Name = "txtLocationCode";
            this.txtLocationCode.Size = new System.Drawing.Size(150, 20);
            this.txtLocationCode.sortOrder = null;
            this.txtLocationCode.TabIndex = 6;
            this.txtLocationCode.valid = false;
            this.txtLocationCode.varList = null;
            this.txtLocationCode.Enter += new System.EventHandler(this.txtLocationCode_Enter);
            this.txtLocationCode.Leave += new System.EventHandler(this.txtLocationCode_Leave);
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.codeFieldName = null;
            this.txtBranchCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "BranchCode", true));
            this.txtBranchCode.filterCondition = null;
            this.txtBranchCode.Location = new System.Drawing.Point(104, 85);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(150, 20);
            this.txtBranchCode.sortOrder = null;
            this.txtBranchCode.TabIndex = 5;
            this.txtBranchCode.valid = false;
            this.txtBranchCode.varList = null;
            this.txtBranchCode.Leave += new System.EventHandler(this.txtBranchCode_Leave);
            // 
            // hedDiscTotValTextBox
            // 
            this.hedDiscTotValTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "HedDiscTotVal", true));
            this.hedDiscTotValTextBox.Location = new System.Drawing.Point(612, 516);
            this.hedDiscTotValTextBox.Name = "hedDiscTotValTextBox";
            this.hedDiscTotValTextBox.ReadOnly = true;
            this.hedDiscTotValTextBox.Size = new System.Drawing.Size(150, 20);
            this.hedDiscTotValTextBox.TabIndex = 46;
            this.hedDiscTotValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemDiscTotValTextBox
            // 
            this.itemDiscTotValTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "ItemDiscTotVal", true));
            this.itemDiscTotValTextBox.Location = new System.Drawing.Point(328, 516);
            this.itemDiscTotValTextBox.Name = "itemDiscTotValTextBox";
            this.itemDiscTotValTextBox.ReadOnly = true;
            this.itemDiscTotValTextBox.Size = new System.Drawing.Size(150, 20);
            this.itemDiscTotValTextBox.TabIndex = 48;
            this.itemDiscTotValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nBTValTextBox
            // 
            this.nBTValTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "NBTVal", true));
            this.nBTValTextBox.Location = new System.Drawing.Point(328, 542);
            this.nBTValTextBox.Name = "nBTValTextBox";
            this.nBTValTextBox.ReadOnly = true;
            this.nBTValTextBox.Size = new System.Drawing.Size(150, 20);
            this.nBTValTextBox.TabIndex = 50;
            this.nBTValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalValTextBox
            // 
            this.totalValTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "TotalVal", true));
            this.totalValTextBox.Location = new System.Drawing.Point(612, 568);
            this.totalValTextBox.Name = "totalValTextBox";
            this.totalValTextBox.ReadOnly = true;
            this.totalValTextBox.Size = new System.Drawing.Size(150, 20);
            this.totalValTextBox.TabIndex = 52;
            this.totalValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vATValTextBox
            // 
            this.vATValTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "VATVal", true));
            this.vATValTextBox.Location = new System.Drawing.Point(612, 542);
            this.vATValTextBox.Name = "vATValTextBox";
            this.vATValTextBox.ReadOnly = true;
            this.vATValTextBox.Size = new System.Drawing.Size(150, 20);
            this.vATValTextBox.TabIndex = 54;
            this.vATValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRepName
            // 
            this.txtRepName.Enabled = false;
            this.txtRepName.Location = new System.Drawing.Point(259, 136);
            this.txtRepName.Name = "txtRepName";
            this.txtRepName.Size = new System.Drawing.Size(498, 20);
            this.txtRepName.TabIndex = 57;
            // 
            // txtRepCode
            // 
            this.txtRepCode.codeFieldName = null;
            this.txtRepCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "RepCode", true));
            this.txtRepCode.filterCondition = null;
            this.txtRepCode.Location = new System.Drawing.Point(104, 136);
            this.txtRepCode.Name = "txtRepCode";
            this.txtRepCode.Size = new System.Drawing.Size(150, 20);
            this.txtRepCode.sortOrder = null;
            this.txtRepCode.TabIndex = 7;
            this.txtRepCode.valid = false;
            this.txtRepCode.varList = null;
            // 
            // txtQuotNo
            // 
            this.txtQuotNo.codeFieldName = null;
            this.txtQuotNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HeaderBindingSource, "QuotationNo", true));
            this.txtQuotNo.filterCondition = null;
            this.txtQuotNo.Location = new System.Drawing.Point(607, 59);
            this.txtQuotNo.Name = "txtQuotNo";
            this.txtQuotNo.Size = new System.Drawing.Size(150, 20);
            this.txtQuotNo.sortOrder = null;
            this.txtQuotNo.TabIndex = 4;
            this.txtQuotNo.valid = false;
            this.txtQuotNo.varList = null;
            this.txtQuotNo.Enter += new System.EventHandler(this.txtQuotNo_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.HeaderBindingSource, "DelieveryDate", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 591);
            this.Controls.Add(label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtQuotNo);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtRepName);
            this.Controls.Add(this.txtRepCode);
            this.Controls.Add(label6);
            this.Controls.Add(hedDiscTotValLabel);
            this.Controls.Add(this.hedDiscTotValTextBox);
            this.Controls.Add(itemDiscTotValLabel);
            this.Controls.Add(this.itemDiscTotValTextBox);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(nBTValLabel);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.nBTValTextBox);
            this.Controls.Add(this.transactionToolBar1);
            this.Controls.Add(totalValLabel);
            this.Controls.Add(this.numHedDiscPer);
            this.Controls.Add(this.totalValTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(vATValLabel);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.vATValTextBox);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtLocationCode);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(branchCodeLabel);
            this.Controls.Add(locationCodeLabel);
            this.Controls.Add(hedDiscPerLabel);
            this.Controls.Add(manualNoLabel);
            this.Controls.Add(this.manualNoTextBox);
            this.Controls.Add(referenceNoLabel);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(customerCodeLabel);
            this.Controls.Add(txnDateLabel);
            this.Controls.Add(this.txnDateDateTimePicker);
            this.Controls.Add(this.HeaderBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesOrder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHedDiscPer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemDiscPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderBindingNavigator)).EndInit();
            this.HeaderBindingNavigator.ResumeLayout(false);
            this.HeaderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource HeaderBindingSource;
        private System.Windows.Forms.BindingNavigator HeaderBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox manualNoTextBox;
        private System.Windows.Forms.TextBox referenceNoTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.DateTimePicker txnDateDateTimePicker;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtBranchName;
        private MasterDataTextBox txtLocationCode;
        private MasterDataTextBox txtBranchCode;
        private System.Windows.Forms.BindingSource itemGridBindingSource;
        private System.Windows.Forms.DataGridView cusDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label2;
        private MasterDataTextBox txtItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numHedDiscPer;
        private TransactionToolBar transactionToolBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numItemDiscPer;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.TextBox txtCustomerName;
        private MasterDataTextBox txtCustomerCode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox hedDiscTotValTextBox;
        private System.Windows.Forms.TextBox itemDiscTotValTextBox;
        private System.Windows.Forms.TextBox nBTValTextBox;
        private System.Windows.Forms.TextBox totalValTextBox;
        private System.Windows.Forms.TextBox vATValTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QOH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBTVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVal;
        private System.Windows.Forms.TextBox txtRepName;
        private MasterDataTextBox txtRepCode;
        private MasterDataTextBox txtQuotNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}