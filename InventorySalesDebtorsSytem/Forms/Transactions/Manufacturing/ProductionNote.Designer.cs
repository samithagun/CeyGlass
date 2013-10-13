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
            System.Windows.Forms.Label manualNoLabel;
            System.Windows.Forms.Label finishGoodTypeLabel;
            System.Windows.Forms.Label referenceNoLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label txnDateLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionNote));
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.PNBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manualNoTextBox = new System.Windows.Forms.TextBox();
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.txnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WasteQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtItemCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.txtProPlan = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.transactionToolBar1 = new InventorySalesDebtorsSytem.TransactionToolBar();
            this.txtBranchCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.PNDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            manualNoLabel = new System.Windows.Forms.Label();
            finishGoodTypeLabel = new System.Windows.Forms.Label();
            referenceNoLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            txnDateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PNBindingNavigator)).BeginInit();
            this.PNBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 197);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 77;
            label2.Text = "BOQ Qty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(293, 197);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 13);
            label3.TabIndex = 79;
            label3.Text = "Usable Qty:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(549, 197);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 13);
            label4.TabIndex = 81;
            label4.Text = "Damage Qty:";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // manualNoTextBox
            // 
            this.manualNoTextBox.Location = new System.Drawing.Point(606, 78);
            this.manualNoTextBox.Name = "manualNoTextBox";
            this.manualNoTextBox.Size = new System.Drawing.Size(148, 20);
            this.manualNoTextBox.TabIndex = 42;
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.Location = new System.Drawing.Point(123, 77);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.ReadOnly = true;
            this.referenceNoTextBox.Size = new System.Drawing.Size(131, 20);
            this.referenceNoTextBox.TabIndex = 40;
            // 
            // txnDateDateTimePicker
            // 
            this.txnDateDateTimePicker.Location = new System.Drawing.Point(334, 77);
            this.txnDateDateTimePicker.Name = "txnDateDateTimePicker";
            this.txnDateDateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.txnDateDateTimePicker.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 76;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(359, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 78;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(623, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 20);
            this.textBox4.TabIndex = 80;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.TotalQty,
            this.UsedQty,
            this.WasteQty});
            this.dataGridView1.Location = new System.Drawing.Point(21, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(733, 212);
            this.dataGridView1.TabIndex = 82;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 280;
            // 
            // TotalQty
            // 
            this.TotalQty.HeaderText = "Total Qty";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.ReadOnly = true;
            // 
            // UsedQty
            // 
            this.UsedQty.HeaderText = "Used Qty";
            this.UsedQty.Name = "UsedQty";
            this.UsedQty.ReadOnly = true;
            // 
            // WasteQty
            // 
            this.WasteQty.HeaderText = "Waste Qty";
            this.WasteQty.Name = "WasteQty";
            this.WasteQty.ReadOnly = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(260, 137);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(494, 20);
            this.textBox6.TabIndex = 84;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Location = new System.Drawing.Point(123, 164);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(131, 20);
            this.txtTotalQty.TabIndex = 85;
            // 
            // txtItemCode
            // 
            this.txtItemCode.codeFieldName = null;
            this.txtItemCode.filterCondition = null;
            this.txtItemCode.Location = new System.Drawing.Point(123, 136);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(131, 20);
            this.txtItemCode.sortOrder = null;
            this.txtItemCode.TabIndex = 71;
            this.txtItemCode.valid = false;
            this.txtItemCode.varList = null;
            // 
            // txtProPlan
            // 
            this.txtProPlan.codeFieldName = null;
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
            // txtBranchCode
            // 
            this.txtBranchCode.codeFieldName = null;
            this.txtBranchCode.filterCondition = null;
            this.txtBranchCode.Location = new System.Drawing.Point(606, 107);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(148, 20);
            this.txtBranchCode.sortOrder = null;
            this.txtBranchCode.TabIndex = 104;
            this.txtBranchCode.Text = "100";
            this.txtBranchCode.valid = true;
            this.txtBranchCode.varList = null;
            this.txtBranchCode.Visible = false;
            // 
            // PNBindingSource
            // 
            this.PNBindingSource.DataSource = typeof(DBLayer.ProductionNoteHed);
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
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtProPlan);
            this.Controls.Add(manualNoLabel);
            this.Controls.Add(finishGoodTypeLabel);
            this.Controls.Add(referenceNoLabel);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(txnDateLabel);
            this.Controls.Add(this.transactionToolBar1);
            this.Controls.Add(this.PNBindingNavigator);
            this.Controls.Add(this.manualNoTextBox);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(this.txnDateDateTimePicker);
            this.Name = "ProductionNote";
            this.Text = "ProductionNote";
            this.Load += new System.EventHandler(this.ProductionNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PNBindingNavigator)).EndInit();
            this.PNBindingNavigator.ResumeLayout(false);
            this.PNBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox manualNoTextBox;
        private System.Windows.Forms.TextBox referenceNoTextBox;
        private System.Windows.Forms.DateTimePicker txnDateDateTimePicker;
        private MasterDataTextBox txtProPlan;
        private MasterDataTextBox txtItemCode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn WasteQty;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtTotalQty;
        private MasterDataTextBox txtBranchCode;
        private System.Windows.Forms.BindingSource PNDetBindingSource;
        private System.Windows.Forms.BindingSource PNBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}