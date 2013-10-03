namespace InventorySalesDebtorsSytem.Forms.Transactions.Manufacturing
{
    partial class SPS
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label itemCodeLabel;
            System.Windows.Forms.Label referenceNoLabel;
            System.Windows.Forms.Label txnDateLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPS));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.transactionToolBar1 = new InventorySalesDebtorsSytem.TransactionToolBar();
            this.BOQDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUsableQty = new System.Windows.Forms.TextBox();
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.txnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BOQBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            referenceNoLabel = new System.Windows.Forms.Label();
            txnDateLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BOQDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOQBindingNavigator)).BeginInit();
            this.BOQBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(225, 107);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(354, 20);
            this.txtItemName.TabIndex = 94;
            // 
            // txtItemCode
            // 
            this.txtItemCode.codeFieldName = null;
            this.txtItemCode.filterCondition = null;
            this.txtItemCode.Location = new System.Drawing.Point(95, 107);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(124, 20);
            this.txtItemCode.sortOrder = null;
            this.txtItemCode.TabIndex = 93;
            this.txtItemCode.valid = false;
            this.txtItemCode.varList = null;
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
            this.transactionToolBar1.HideEditButton = true;
            this.transactionToolBar1.HidePrintButton = false;
            this.transactionToolBar1.HideViewButton = false;
            this.transactionToolBar1.Location = new System.Drawing.Point(4, 15);
            this.transactionToolBar1.mode = null;
            this.transactionToolBar1.Name = "transactionToolBar1";
            this.transactionToolBar1.primaryKeyControl = null;
            this.transactionToolBar1.primaryKeyField = null;
            this.transactionToolBar1.ReferenceID = null;
            this.transactionToolBar1.Size = new System.Drawing.Size(388, 52);
            this.transactionToolBar1.TabIndex = 92;
            // 
            // BOQDataGridView
            // 
            this.BOQDataGridView.AllowUserToAddRows = false;
            this.BOQDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BOQDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.Quantity});
            this.BOQDataGridView.Location = new System.Drawing.Point(10, 190);
            this.BOQDataGridView.Name = "BOQDataGridView";
            this.BOQDataGridView.ReadOnly = true;
            this.BOQDataGridView.Size = new System.Drawing.Size(576, 208);
            this.BOQDataGridView.TabIndex = 89;
            // 
            // ItemCode
            // 
            this.ItemCode.Frozen = true;
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 165;
            // 
            // ItemName
            // 
            this.ItemName.Frozen = true;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 250;
            // 
            // Quantity
            // 
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 115;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 162);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 13);
            label2.TabIndex = 79;
            label2.Text = "Date From :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 13);
            label1.TabIndex = 77;
            label1.Text = "Total Qty :";
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new System.Drawing.Point(10, 110);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(61, 13);
            itemCodeLabel.TabIndex = 76;
            itemCodeLabel.Text = "Item Code :";
            // 
            // txtUsableQty
            // 
            this.txtUsableQty.Location = new System.Drawing.Point(95, 133);
            this.txtUsableQty.Name = "txtUsableQty";
            this.txtUsableQty.Size = new System.Drawing.Size(124, 20);
            this.txtUsableQty.TabIndex = 78;
            // 
            // referenceNoLabel
            // 
            referenceNoLabel.AutoSize = true;
            referenceNoLabel.Location = new System.Drawing.Point(10, 80);
            referenceNoLabel.Name = "referenceNoLabel";
            referenceNoLabel.Size = new System.Drawing.Size(77, 13);
            referenceNoLabel.TabIndex = 97;
            referenceNoLabel.Text = "Reference No:";
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.Location = new System.Drawing.Point(95, 76);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.ReadOnly = true;
            this.referenceNoTextBox.Size = new System.Drawing.Size(124, 20);
            this.referenceNoTextBox.TabIndex = 95;
            // 
            // txnDateLabel
            // 
            txnDateLabel.AutoSize = true;
            txnDateLabel.Location = new System.Drawing.Point(340, 80);
            txnDateLabel.Name = "txnDateLabel";
            txnDateLabel.Size = new System.Drawing.Size(33, 13);
            txnDateLabel.TabIndex = 98;
            txnDateLabel.Text = "Date:";
            // 
            // txnDateDateTimePicker
            // 
            this.txnDateDateTimePicker.Location = new System.Drawing.Point(379, 76);
            this.txnDateDateTimePicker.Name = "txnDateDateTimePicker";
            this.txnDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.txnDateDateTimePicker.TabIndex = 96;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 99;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(379, 159);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 101;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(318, 162);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 13);
            label3.TabIndex = 100;
            label3.Text = "Date To :";
            // 
            // BOQBindingNavigator
            // 
            this.BOQBindingNavigator.AddNewItem = null;
            this.BOQBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.BOQBindingNavigator.DeleteItem = null;
            this.BOQBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.BOQBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BOQBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.BOQBindingNavigator.Location = new System.Drawing.Point(395, 26);
            this.BOQBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BOQBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BOQBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BOQBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BOQBindingNavigator.Name = "BOQBindingNavigator";
            this.BOQBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BOQBindingNavigator.Size = new System.Drawing.Size(202, 28);
            this.BOQBindingNavigator.TabIndex = 102;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 28);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // SPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 412);
            this.Controls.Add(this.BOQBindingNavigator);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(referenceNoLabel);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(txnDateLabel);
            this.Controls.Add(this.txnDateDateTimePicker);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.transactionToolBar1);
            this.Controls.Add(this.BOQDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(itemCodeLabel);
            this.Controls.Add(this.txtUsableQty);
            this.Name = "SPS";
            this.Text = "Standard Production Schedule";
            this.Load += new System.EventHandler(this.SPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BOQDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOQBindingNavigator)).EndInit();
            this.BOQBindingNavigator.ResumeLayout(false);
            this.BOQBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private MasterDataTextBox txtItemCode;
        private TransactionToolBar transactionToolBar1;
        private System.Windows.Forms.DataGridView BOQDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtUsableQty;
        private System.Windows.Forms.TextBox referenceNoTextBox;
        private System.Windows.Forms.DateTimePicker txnDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingNavigator BOQBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    }
}