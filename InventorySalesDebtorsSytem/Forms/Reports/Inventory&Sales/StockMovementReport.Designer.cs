namespace InventorySalesDebtorsSytem
{
    partial class StockMovementReport
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
            this.multipleSelectorBarItems = new InventorySalesDebtorsSytem.MultipleSelectorBarItems();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTypeWise = new System.Windows.Forms.RadioButton();
            this.radGroupWise = new System.Windows.Forms.RadioButton();
            this.radCategoryWise = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radSummary = new System.Windows.Forms.RadioButton();
            this.radDetail = new System.Windows.Forms.RadioButton();
            this.multipleSelectorBarBranch = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.multipleSelectorBarLocation = new InventorySalesDebtorsSytem.MultipleSelectorBar();
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
            // multipleSelectorBarItems
            // 
            this.multipleSelectorBarItems.DataBaseEntity = null;
            this.multipleSelectorBarItems.Location = new System.Drawing.Point(4, 169);
            this.multipleSelectorBarItems.Name = "multipleSelectorBarItems";
            this.multipleSelectorBarItems.Size = new System.Drawing.Size(400, 176);
            this.multipleSelectorBarItems.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTypeWise);
            this.groupBox1.Controls.Add(this.radGroupWise);
            this.groupBox1.Controls.Add(this.radCategoryWise);
            this.groupBox1.Location = new System.Drawing.Point(114, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 30);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radTypeWise
            // 
            this.radTypeWise.AutoSize = true;
            this.radTypeWise.Location = new System.Drawing.Point(213, 9);
            this.radTypeWise.Name = "radTypeWise";
            this.radTypeWise.Size = new System.Drawing.Size(76, 17);
            this.radTypeWise.TabIndex = 2;
            this.radTypeWise.Text = "Type Wise";
            this.radTypeWise.UseVisualStyleBackColor = true;
            // 
            // radGroupWise
            // 
            this.radGroupWise.AutoSize = true;
            this.radGroupWise.Location = new System.Drawing.Point(115, 9);
            this.radGroupWise.Name = "radGroupWise";
            this.radGroupWise.Size = new System.Drawing.Size(81, 17);
            this.radGroupWise.TabIndex = 1;
            this.radGroupWise.Text = "Group Wise";
            this.radGroupWise.UseVisualStyleBackColor = true;
            // 
            // radCategoryWise
            // 
            this.radCategoryWise.AutoSize = true;
            this.radCategoryWise.Checked = true;
            this.radCategoryWise.Location = new System.Drawing.Point(4, 9);
            this.radCategoryWise.Name = "radCategoryWise";
            this.radCategoryWise.Size = new System.Drawing.Size(94, 17);
            this.radCategoryWise.TabIndex = 0;
            this.radCategoryWise.TabStop = true;
            this.radCategoryWise.Text = "Category Wise";
            this.radCategoryWise.UseVisualStyleBackColor = true;
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
            // multipleSelectorBarLocation
            // 
            this.multipleSelectorBarLocation.ButtonLeft = 370;
            this.multipleSelectorBarLocation.dtSelected = null;
            this.multipleSelectorBarLocation.Location = new System.Drawing.Point(4, 143);
            this.multipleSelectorBarLocation.Name = "multipleSelectorBarLocation";
            this.multipleSelectorBarLocation.PrimaryKey = null;
            this.multipleSelectorBarLocation.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarLocation.TabIndex = 8;
            this.multipleSelectorBarLocation.TextBoxLeft = 164;
            this.multipleSelectorBarLocation.Title = "Location";
            this.multipleSelectorBarLocation.UnselectedVarList = null;
            // 
            // StockMovementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 344);
            this.Controls.Add(this.multipleSelectorBarLocation);
            this.Controls.Add(this.multipleSelectorBarBranch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.multipleSelectorBarItems);
            this.Controls.Add(this.reportToolbar1);
            this.Controls.Add(this.dateTimePickerDateTo);
            this.Controls.Add(this.dateTimePickerDateFrom);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockMovementReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Movement Report";
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
        private MultipleSelectorBarItems multipleSelectorBarItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTypeWise;
        private System.Windows.Forms.RadioButton radGroupWise;
        private System.Windows.Forms.RadioButton radCategoryWise;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radSummary;
        private System.Windows.Forms.RadioButton radDetail;
        private MultipleSelectorBar multipleSelectorBarBranch;
        private MultipleSelectorBar multipleSelectorBarLocation;
    }
}