namespace InventorySalesDebtorsSytem
{
    partial class SalesReport
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.reportToolbar1 = new InventorySalesDebtorsSytem.ReportToolbar();
            this.multipleSelectorBarCustomers = new InventorySalesDebtorsSytem.MultipleSelectorBarCustomers();
            this.multipleSelectorBarItems = new InventorySalesDebtorsSytem.MultipleSelectorBarItems();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRepWise = new System.Windows.Forms.RadioButton();
            this.radItemWise = new System.Windows.Forms.RadioButton();
            this.radCustomerWise = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radSummary = new System.Windows.Forms.RadioButton();
            this.radDetail = new System.Windows.Forms.RadioButton();
            this.multipleSelectorBarBranch = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "Date From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 13);
            label2.TabIndex = 1;
            label2.Text = "Date To:";
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(168, 65);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateFrom.TabIndex = 2;
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(168, 91);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateTo.TabIndex = 3;
            // 
            // reportToolbar1
            // 
            this.reportToolbar1.Location = new System.Drawing.Point(2, 2);
            this.reportToolbar1.Name = "reportToolbar1";
            this.reportToolbar1.Size = new System.Drawing.Size(106, 50);
            this.reportToolbar1.TabIndex = 7;
            // 
            // multipleSelectorBarCustomers
            // 
            this.multipleSelectorBarCustomers.DataBaseEntity = null;
            this.multipleSelectorBarCustomers.Location = new System.Drawing.Point(4, 143);
            this.multipleSelectorBarCustomers.Name = "multipleSelectorBarCustomers";
            this.multipleSelectorBarCustomers.Size = new System.Drawing.Size(400, 98);
            this.multipleSelectorBarCustomers.TabIndex = 5;
            // 
            // multipleSelectorBarItems
            // 
            this.multipleSelectorBarItems.DataBaseEntity = null;
            this.multipleSelectorBarItems.Location = new System.Drawing.Point(4, 247);
            this.multipleSelectorBarItems.Name = "multipleSelectorBarItems";
            this.multipleSelectorBarItems.Size = new System.Drawing.Size(400, 176);
            this.multipleSelectorBarItems.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRepWise);
            this.groupBox1.Controls.Add(this.radItemWise);
            this.groupBox1.Controls.Add(this.radCustomerWise);
            this.groupBox1.Location = new System.Drawing.Point(114, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 30);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radRepWise
            // 
            this.radRepWise.AutoSize = true;
            this.radRepWise.Location = new System.Drawing.Point(214, 9);
            this.radRepWise.Name = "radRepWise";
            this.radRepWise.Size = new System.Drawing.Size(72, 17);
            this.radRepWise.TabIndex = 2;
            this.radRepWise.Text = "Rep Wise";
            this.radRepWise.UseVisualStyleBackColor = true;
            // 
            // radItemWise
            // 
            this.radItemWise.AutoSize = true;
            this.radItemWise.Location = new System.Drawing.Point(121, 9);
            this.radItemWise.Name = "radItemWise";
            this.radItemWise.Size = new System.Drawing.Size(72, 17);
            this.radItemWise.TabIndex = 1;
            this.radItemWise.Text = "Item Wise";
            this.radItemWise.UseVisualStyleBackColor = true;
            // 
            // radCustomerWise
            // 
            this.radCustomerWise.AutoSize = true;
            this.radCustomerWise.Checked = true;
            this.radCustomerWise.Location = new System.Drawing.Point(4, 9);
            this.radCustomerWise.Name = "radCustomerWise";
            this.radCustomerWise.Size = new System.Drawing.Size(96, 17);
            this.radCustomerWise.TabIndex = 0;
            this.radCustomerWise.TabStop = true;
            this.radCustomerWise.Text = "Customer Wise";
            this.radCustomerWise.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSummary);
            this.groupBox2.Controls.Add(this.radDetail);
            this.groupBox2.Location = new System.Drawing.Point(114, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 30);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radSummary
            // 
            this.radSummary.AutoSize = true;
            this.radSummary.Location = new System.Drawing.Point(170, 9);
            this.radSummary.Name = "radSummary";
            this.radSummary.Size = new System.Drawing.Size(68, 17);
            this.radSummary.TabIndex = 1;
            this.radSummary.Text = "Summary";
            this.radSummary.UseVisualStyleBackColor = true;
            // 
            // radDetail
            // 
            this.radDetail.AutoSize = true;
            this.radDetail.Checked = true;
            this.radDetail.Location = new System.Drawing.Point(53, 9);
            this.radDetail.Name = "radDetail";
            this.radDetail.Size = new System.Drawing.Size(52, 17);
            this.radDetail.TabIndex = 0;
            this.radDetail.TabStop = true;
            this.radDetail.Text = "Detail";
            this.radDetail.UseVisualStyleBackColor = true;
            // 
            // multipleSelectorBarBranch
            // 
            this.multipleSelectorBarBranch.ButtonLeft = 370;
            this.multipleSelectorBarBranch.dtSelected = null;
            this.multipleSelectorBarBranch.Location = new System.Drawing.Point(4, 117);
            this.multipleSelectorBarBranch.Name = "multipleSelectorBarBranch";
            this.multipleSelectorBarBranch.PrimaryKey = null;
            this.multipleSelectorBarBranch.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarBranch.TabIndex = 4;
            this.multipleSelectorBarBranch.TextBoxLeft = 164;
            this.multipleSelectorBarBranch.Title = "Branch";
            this.multipleSelectorBarBranch.UnselectedVarList = null;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 447);
            this.Controls.Add(this.multipleSelectorBarBranch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.multipleSelectorBarItems);
            this.Controls.Add(this.multipleSelectorBarCustomers);
            this.Controls.Add(this.reportToolbar1);
            this.Controls.Add(this.dateTimePickerDateTo);
            this.Controls.Add(this.dateTimePickerDateFrom);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private ReportToolbar reportToolbar1;
        private MultipleSelectorBarCustomers multipleSelectorBarCustomers;
        private MultipleSelectorBarItems multipleSelectorBarItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRepWise;
        private System.Windows.Forms.RadioButton radItemWise;
        private System.Windows.Forms.RadioButton radCustomerWise;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radSummary;
        private System.Windows.Forms.RadioButton radDetail;
        private MultipleSelectorBar multipleSelectorBarBranch;
    }
}