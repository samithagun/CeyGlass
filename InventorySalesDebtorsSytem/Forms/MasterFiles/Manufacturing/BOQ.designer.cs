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
            this.itemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDamageQty = new System.Windows.Forms.TextBox();
            this.txtUOM = new System.Windows.Forms.TextBox();
            this.txtUsableQty = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.masterFileToolBar1 = new InventorySalesDebtorsSytem.MasterFileToolBar();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingNavigator)).BeginInit();
            this.itemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemBindingNavigator
            // 
            this.itemBindingNavigator.AddNewItem = null;
            this.itemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemBindingNavigator.DeleteItem = null;
            this.itemBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.itemBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.itemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.itemBindingNavigator.Location = new System.Drawing.Point(348, 35);
            this.itemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemBindingNavigator.Name = "itemBindingNavigator";
            this.itemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemBindingNavigator.Size = new System.Drawing.Size(202, 28);
            this.itemBindingNavigator.TabIndex = 66;
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
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Raw Materials";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.TotalQty});
            this.dataGridView1.Location = new System.Drawing.Point(15, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 153);
            this.dataGridView1.TabIndex = 64;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 150;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 220;
            // 
            // TotalQty
            // 
            this.TotalQty.HeaderText = "Total Qty";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.Width = 115;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Location = new System.Drawing.Point(400, 161);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(100, 20);
            this.txtTotalQty.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(273, 164);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 13);
            label4.TabIndex = 62;
            label4.Text = "Total Qty :";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(400, 135);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(273, 138);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 13);
            label5.TabIndex = 60;
            label5.Text = "Standard Cost per Item :";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(400, 109);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(273, 114);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 13);
            label6.TabIndex = 58;
            label6.Text = "Duration (min) :";
            // 
            // txtDamageQty
            // 
            this.txtDamageQty.Location = new System.Drawing.Point(121, 161);
            this.txtDamageQty.Name = "txtDamageQty";
            this.txtDamageQty.Size = new System.Drawing.Size(100, 20);
            this.txtDamageQty.TabIndex = 57;
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
            // txtUOM
            // 
            this.txtUOM.Location = new System.Drawing.Point(121, 135);
            this.txtUOM.Name = "txtUOM";
            this.txtUOM.Size = new System.Drawing.Size(100, 20);
            this.txtUOM.TabIndex = 55;
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
            // txtUsableQty
            // 
            this.txtUsableQty.Location = new System.Drawing.Point(121, 109);
            this.txtUsableQty.Name = "txtUsableQty";
            this.txtUsableQty.Size = new System.Drawing.Size(100, 20);
            this.txtUsableQty.TabIndex = 53;
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
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(121, 83);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 20);
            this.txtItemCode.TabIndex = 50;
            // 
            // masterFileToolBar1
            // 
            this.masterFileToolBar1.Location = new System.Drawing.Point(12, 12);
            this.masterFileToolBar1.Name = "masterFileToolBar1";
            this.masterFileToolBar1.Size = new System.Drawing.Size(333, 51);
            this.masterFileToolBar1.TabIndex = 49;
            // 
            // BOQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 377);
            this.Controls.Add(this.itemBindingNavigator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtCost);
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
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.masterFileToolBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BOQ";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Of Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingNavigator)).EndInit();
            this.itemBindingNavigator.ResumeLayout(false);
            this.itemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasterFileToolBar masterFileToolBar1;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtUsableQty;
        private System.Windows.Forms.TextBox txtUOM;
        private System.Windows.Forms.TextBox txtDamageQty;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.BindingNavigator itemBindingNavigator;
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