namespace InventorySalesDebtorsSytem
{
    partial class BOQ
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label itemCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOQ));
            this.label7 = new System.Windows.Forms.Label();
            this.BOQDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOQDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtStdCost = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDamageQty = new System.Windows.Forms.TextBox();
            this.txtUOM = new System.Windows.Forms.TextBox();
            this.txtUsableQty = new System.Windows.Forms.TextBox();
            this.BOQBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BOQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionToolBar1 = new InventorySalesDebtorsSytem.TransactionToolBar();
            this.txtItemCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtRawItemCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BOQDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOQDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOQBindingNavigator)).BeginInit();
            this.BOQBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BOQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(319, 164);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 13);
            label4.TabIndex = 62;
            label4.Text = "Total Qty :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(319, 138);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 13);
            label5.TabIndex = 60;
            label5.Text = "Standard Cost per Item :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(319, 114);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 13);
            label6.TabIndex = 58;
            label6.Text = "Duration (min) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 164);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 13);
            label3.TabIndex = 56;
            label3.Text = "Damage Qty :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 138);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 54;
            label2.Text = "UOM :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 13);
            label1.TabIndex = 52;
            label1.Text = "Usable Qty :";
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new System.Drawing.Point(12, 86);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(61, 13);
            itemCodeLabel.TabIndex = 51;
            itemCodeLabel.Text = "Item Code :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Raw Materials";
            // 
            // BOQDataGridView
            // 
            this.BOQDataGridView.AllowUserToAddRows = false;
            this.BOQDataGridView.AutoGenerateColumns = false;
            this.BOQDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BOQDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.Quantity});
            this.BOQDataGridView.DataSource = this.BOQDetBindingSource;
            this.BOQDataGridView.Location = new System.Drawing.Point(12, 242);
            this.BOQDataGridView.Name = "BOQDataGridView";
            this.BOQDataGridView.ReadOnly = true;
            this.BOQDataGridView.Size = new System.Drawing.Size(576, 153);
            this.BOQDataGridView.TabIndex = 64;
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
            // txtTotalQty
            // 
            this.txtTotalQty.Location = new System.Drawing.Point(446, 161);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(100, 20);
            this.txtTotalQty.TabIndex = 63;
            // 
            // txtStdCost
            // 
            this.txtStdCost.Location = new System.Drawing.Point(446, 135);
            this.txtStdCost.Name = "txtStdCost";
            this.txtStdCost.Size = new System.Drawing.Size(100, 20);
            this.txtStdCost.TabIndex = 61;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(446, 109);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 59;
            // 
            // txtDamageQty
            // 
            this.txtDamageQty.Location = new System.Drawing.Point(121, 161);
            this.txtDamageQty.Name = "txtDamageQty";
            this.txtDamageQty.Size = new System.Drawing.Size(100, 20);
            this.txtDamageQty.TabIndex = 57;
            // 
            // txtUOM
            // 
            this.txtUOM.Location = new System.Drawing.Point(121, 135);
            this.txtUOM.Name = "txtUOM";
            this.txtUOM.Size = new System.Drawing.Size(100, 20);
            this.txtUOM.TabIndex = 55;
            // 
            // txtUsableQty
            // 
            this.txtUsableQty.Location = new System.Drawing.Point(121, 109);
            this.txtUsableQty.Name = "txtUsableQty";
            this.txtUsableQty.Size = new System.Drawing.Size(100, 20);
            this.txtUsableQty.TabIndex = 53;
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
            this.BOQBindingNavigator.Location = new System.Drawing.Point(400, 23);
            this.BOQBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BOQBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BOQBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BOQBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BOQBindingNavigator.Name = "BOQBindingNavigator";
            this.BOQBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BOQBindingNavigator.Size = new System.Drawing.Size(202, 28);
            this.BOQBindingNavigator.TabIndex = 66;
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
            this.transactionToolBar1.Location = new System.Drawing.Point(6, 12);
            this.transactionToolBar1.mode = null;
            this.transactionToolBar1.Name = "transactionToolBar1";
            this.transactionToolBar1.primaryKeyControl = null;
            this.transactionToolBar1.primaryKeyField = null;
            this.transactionToolBar1.ReferenceID = null;
            this.transactionToolBar1.Size = new System.Drawing.Size(388, 52);
            this.transactionToolBar1.TabIndex = 67;
            // 
            // txtItemCode
            // 
            this.txtItemCode.codeFieldName = null;
            this.txtItemCode.filterCondition = null;
            this.txtItemCode.Location = new System.Drawing.Point(121, 83);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 20);
            this.txtItemCode.sortOrder = null;
            this.txtItemCode.TabIndex = 69;
            this.txtItemCode.valid = false;
            this.txtItemCode.varList = null;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(227, 83);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(319, 20);
            this.txtItemName.TabIndex = 70;
            // 
            // txtRawItemCode
            // 
            this.txtRawItemCode.codeFieldName = null;
            this.txtRawItemCode.Enabled = false;
            this.txtRawItemCode.filterCondition = null;
            this.txtRawItemCode.Location = new System.Drawing.Point(80, 217);
            this.txtRawItemCode.Name = "txtRawItemCode";
            this.txtRawItemCode.Size = new System.Drawing.Size(141, 20);
            this.txtRawItemCode.sortOrder = null;
            this.txtRawItemCode.TabIndex = 72;
            this.txtRawItemCode.valid = false;
            this.txtRawItemCode.varList = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Item Code :";
            // 
            // numQty
            // 
            this.numQty.DecimalPlaces = 2;
            this.numQty.Location = new System.Drawing.Point(315, 218);
            this.numQty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(60, 20);
            this.numQty.TabIndex = 73;
            this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQty.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Quantity :";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(400, 215);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(50, 23);
            this.btnAddItem.TabIndex = 75;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BOQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 408);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRawItemCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.transactionToolBar1);
            this.Controls.Add(this.BOQBindingNavigator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BOQDataGridView);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtStdCost);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtDamageQty);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtUOM);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtUsableQty);
            this.Controls.Add(label1);
            this.Controls.Add(itemCodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BOQ";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Of Quantity";
            this.Load += new System.EventHandler(this.BOQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BOQDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOQDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOQBindingNavigator)).EndInit();
            this.BOQBindingNavigator.ResumeLayout(false);
            this.BOQBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BOQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsableQty;
        private System.Windows.Forms.TextBox txtUOM;
        private System.Windows.Forms.TextBox txtDamageQty;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtStdCost;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DataGridView BOQDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingNavigator BOQBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource BOQBindingSource;
        private TransactionToolBar transactionToolBar1;
        private MasterDataTextBox txtItemCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.BindingSource BOQDetBindingSource;
        private MasterDataTextBox txtRawItemCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}