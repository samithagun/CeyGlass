namespace InventorySalesDebtorsSytem.Forms.Transactions.Manufacturing
{
    partial class ProductionPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionPlan));
            System.Windows.Forms.Label manualNoLabel;
            System.Windows.Forms.Label referenceNoLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label txnDateLabel;
            System.Windows.Forms.Label finishGoodTypeLabel;
            this.transactionToolBar1 = new InventorySalesDebtorsSytem.TransactionToolBar();
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
            this.manualNoTextBox = new System.Windows.Forms.TextBox();
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.txnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            manualNoLabel = new System.Windows.Forms.Label();
            referenceNoLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            txnDateLabel = new System.Windows.Forms.Label();
            finishGoodTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderBindingNavigator)).BeginInit();
            this.HeaderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.transactionToolBar1.Location = new System.Drawing.Point(12, 12);
            this.transactionToolBar1.mode = null;
            this.transactionToolBar1.Name = "transactionToolBar1";
            this.transactionToolBar1.primaryKeyControl = null;
            this.transactionToolBar1.primaryKeyField = null;
            this.transactionToolBar1.ReferenceID = null;
            this.transactionToolBar1.Size = new System.Drawing.Size(388, 52);
            this.transactionToolBar1.TabIndex = 2;
            // 
            // HeaderBindingNavigator
            // 
            this.HeaderBindingNavigator.AddNewItem = null;
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
            this.HeaderBindingNavigator.Location = new System.Drawing.Point(414, 22);
            this.HeaderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.HeaderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.HeaderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.HeaderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.HeaderBindingNavigator.Name = "HeaderBindingNavigator";
            this.HeaderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.HeaderBindingNavigator.Size = new System.Drawing.Size(209, 25);
            this.HeaderBindingNavigator.TabIndex = 3;
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
            // manualNoLabel
            // 
            manualNoLabel.AutoSize = true;
            manualNoLabel.Location = new System.Drawing.Point(518, 85);
            manualNoLabel.Name = "manualNoLabel";
            manualNoLabel.Size = new System.Drawing.Size(62, 13);
            manualNoLabel.TabIndex = 27;
            manualNoLabel.Text = "Manual No:";
            // 
            // manualNoTextBox
            // 
            this.manualNoTextBox.Location = new System.Drawing.Point(605, 81);
            this.manualNoTextBox.Name = "manualNoTextBox";
            this.manualNoTextBox.Size = new System.Drawing.Size(150, 20);
            this.manualNoTextBox.TabIndex = 26;
            // 
            // referenceNoLabel
            // 
            referenceNoLabel.AutoSize = true;
            referenceNoLabel.Location = new System.Drawing.Point(17, 84);
            referenceNoLabel.Name = "referenceNoLabel";
            referenceNoLabel.Size = new System.Drawing.Size(77, 13);
            referenceNoLabel.TabIndex = 29;
            referenceNoLabel.Text = "Reference No:";
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.Location = new System.Drawing.Point(123, 80);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.ReadOnly = true;
            this.referenceNoTextBox.Size = new System.Drawing.Size(131, 20);
            this.referenceNoTextBox.TabIndex = 24;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(15, 112);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 30;
            remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Location = new System.Drawing.Point(123, 107);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(632, 20);
            this.remarksTextBox.TabIndex = 28;
            // 
            // txnDateLabel
            // 
            txnDateLabel.AutoSize = true;
            txnDateLabel.Location = new System.Drawing.Point(268, 84);
            txnDateLabel.Name = "txnDateLabel";
            txnDateLabel.Size = new System.Drawing.Size(33, 13);
            txnDateLabel.TabIndex = 31;
            txnDateLabel.Text = "Date:";
            // 
            // txnDateDateTimePicker
            // 
            this.txnDateDateTimePicker.Location = new System.Drawing.Point(308, 80);
            this.txnDateDateTimePicker.Name = "txnDateDateTimePicker";
            this.txnDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.txnDateDateTimePicker.TabIndex = 25;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.codeFieldName = null;
            this.txtCustomerCode.filterCondition = null;
            this.txtCustomerCode.Location = new System.Drawing.Point(123, 135);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(150, 20);
            this.txtCustomerCode.sortOrder = null;
            this.txtCustomerCode.TabIndex = 32;
            this.txtCustomerCode.valid = false;
            this.txtCustomerCode.varList = null;
            // 
            // finishGoodTypeLabel
            // 
            finishGoodTypeLabel.AutoSize = true;
            finishGoodTypeLabel.Location = new System.Drawing.Point(17, 139);
            finishGoodTypeLabel.Name = "finishGoodTypeLabel";
            finishGoodTypeLabel.Size = new System.Drawing.Size(102, 13);
            finishGoodTypeLabel.TabIndex = 33;
            finishGoodTypeLabel.Text = "Finished Good Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(20, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 136);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Orders";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(424, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 136);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Standard Orders";
            // 
            // ProductionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(finishGoodTypeLabel);
            this.Controls.Add(manualNoLabel);
            this.Controls.Add(this.manualNoTextBox);
            this.Controls.Add(referenceNoLabel);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(txnDateLabel);
            this.Controls.Add(this.txnDateDateTimePicker);
            this.Controls.Add(this.transactionToolBar1);
            this.Controls.Add(this.HeaderBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductionPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionPlan";
            ((System.ComponentModel.ISupportInitialize)(this.HeaderBindingNavigator)).EndInit();
            this.HeaderBindingNavigator.ResumeLayout(false);
            this.HeaderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransactionToolBar transactionToolBar1;
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
        private MasterDataTextBox txtCustomerCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}