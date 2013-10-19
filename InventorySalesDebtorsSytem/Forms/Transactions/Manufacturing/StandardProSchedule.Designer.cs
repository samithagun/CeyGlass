namespace InventorySalesDebtorsSytem.Forms.Transactions.Manufacturing
{
    partial class StandardProSchedule
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardProSchedule));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.SPSDataGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.SPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.dateTimeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeToPicker = new System.Windows.Forms.DateTimePicker();
            this.SPSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.txtItemCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.transactionToolBar1 = new InventorySalesDebtorsSytem.TransactionToolBar();
            this.SPSDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBranchCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.formInitializer1 = new InventorySalesDebtorsSytem.ReusableComponents.FormInitializer();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            referenceNoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SPSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPSBindingNavigator)).BeginInit();
            this.SPSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPSDetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // referenceNoLabel
            // 
            referenceNoLabel.AutoSize = true;
            referenceNoLabel.Location = new System.Drawing.Point(10, 80);
            referenceNoLabel.Name = "referenceNoLabel";
            referenceNoLabel.Size = new System.Drawing.Size(77, 13);
            referenceNoLabel.TabIndex = 97;
            referenceNoLabel.Text = "Reference No:";
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
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(225, 107);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(354, 20);
            this.txtItemName.TabIndex = 94;
            // 
            // SPSDataGridView
            // 
            this.SPSDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SPSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SPSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Quantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SPSDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SPSDataGridView.Location = new System.Drawing.Point(75, 190);
            this.SPSDataGridView.Name = "SPSDataGridView";
            this.SPSDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPSDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SPSDataGridView.Size = new System.Drawing.Size(454, 208);
            this.SPSDataGridView.TabIndex = 89;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 250;
            // 
            // Quantity
            // 
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 160;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SPSBindingSource, "Qty", true));
            this.txtTotalQty.Location = new System.Drawing.Point(95, 133);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(124, 20);
            this.txtTotalQty.TabIndex = 78;
            // 
            // SPSBindingSource
            // 
            this.SPSBindingSource.DataSource = typeof(DBLayer.SPSHed);
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.Location = new System.Drawing.Point(95, 76);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.ReadOnly = true;
            this.referenceNoTextBox.Size = new System.Drawing.Size(124, 20);
            this.referenceNoTextBox.TabIndex = 95;
            // 
            // dateTimeFromPicker
            // 
            this.dateTimeFromPicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SPSBindingSource, "FromDate", true));
            this.dateTimeFromPicker.Location = new System.Drawing.Point(95, 159);
            this.dateTimeFromPicker.Name = "dateTimeFromPicker";
            this.dateTimeFromPicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFromPicker.TabIndex = 99;
            // 
            // dateTimeToPicker
            // 
            this.dateTimeToPicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SPSBindingSource, "ToDate", true));
            this.dateTimeToPicker.Location = new System.Drawing.Point(379, 159);
            this.dateTimeToPicker.Name = "dateTimeToPicker";
            this.dateTimeToPicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeToPicker.TabIndex = 101;
            this.dateTimeToPicker.ValueChanged += new System.EventHandler(this.dateTimeToPicker_ValueChanged);
            // 
            // SPSBindingNavigator
            // 
            this.SPSBindingNavigator.AddNewItem = null;
            this.SPSBindingNavigator.BindingSource = this.SPSBindingSource;
            this.SPSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.SPSBindingNavigator.DeleteItem = null;
            this.SPSBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.SPSBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SPSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.SPSBindingNavigator.Location = new System.Drawing.Point(395, 26);
            this.SPSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.SPSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.SPSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.SPSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.SPSBindingNavigator.Name = "SPSBindingNavigator";
            this.SPSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.SPSBindingNavigator.Size = new System.Drawing.Size(202, 28);
            this.SPSBindingNavigator.TabIndex = 102;
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
            // txtItemCode
            // 
            this.txtItemCode.codeFieldName = null;
            this.txtItemCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SPSBindingSource, "ItemCode", true));
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
            // txtBranchCode
            // 
            this.txtBranchCode.codeFieldName = null;
            this.txtBranchCode.filterCondition = null;
            this.txtBranchCode.Location = new System.Drawing.Point(429, 76);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(150, 20);
            this.txtBranchCode.sortOrder = null;
            this.txtBranchCode.TabIndex = 103;
            this.txtBranchCode.Text = "100";
            this.txtBranchCode.valid = true;
            this.txtBranchCode.varList = null;
            this.txtBranchCode.Visible = false;
            // 
            // formInitializer1
            // 
            this.formInitializer1.Location = new System.Drawing.Point(568, 190);
            this.formInitializer1.Name = "formInitializer1";
            this.formInitializer1.Size = new System.Drawing.Size(10, 10);
            this.formInitializer1.TabIndex = 104;
            // 
            // StandardProSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 412);
            this.Controls.Add(this.formInitializer1);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(this.SPSBindingNavigator);
            this.Controls.Add(this.dateTimeToPicker);
            this.Controls.Add(label3);
            this.Controls.Add(this.dateTimeFromPicker);
            this.Controls.Add(referenceNoLabel);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.transactionToolBar1);
            this.Controls.Add(this.SPSDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(itemCodeLabel);
            this.Controls.Add(this.txtTotalQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StandardProSchedule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Production Schedule";
            this.Load += new System.EventHandler(this.SPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPSBindingNavigator)).EndInit();
            this.SPSBindingNavigator.ResumeLayout(false);
            this.SPSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPSDetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private MasterDataTextBox txtItemCode;
        private TransactionToolBar transactionToolBar1;
        private System.Windows.Forms.DataGridView SPSDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox referenceNoTextBox;
        private System.Windows.Forms.DateTimePicker dateTimeToPicker;
        private System.Windows.Forms.DateTimePicker dateTimeFromPicker;
        private System.Windows.Forms.BindingNavigator SPSBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.BindingSource SPSDetBindingSource;
        private System.Windows.Forms.BindingSource SPSBindingSource;
        private MasterDataTextBox txtBranchCode;
        private ReusableComponents.FormInitializer formInitializer1;
    }
}