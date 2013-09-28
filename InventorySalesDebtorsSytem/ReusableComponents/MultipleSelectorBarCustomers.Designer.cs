namespace InventorySalesDebtorsSytem
{
    partial class MultipleSelectorBarCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.chkBlacklist = new System.Windows.Forms.CheckBox();
            this.multipleSelectorBarType = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.multipleSelectorBarGroup = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.multipleSelectorBarCustomer = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.SuspendLayout();
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(60, 78);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 3;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Location = new System.Drawing.Point(158, 78);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(64, 17);
            this.chkInactive.TabIndex = 4;
            this.chkInactive.Text = "Inactive";
            this.chkInactive.UseVisualStyleBackColor = true;
            // 
            // chkBlacklist
            // 
            this.chkBlacklist.AutoSize = true;
            this.chkBlacklist.Location = new System.Drawing.Point(264, 78);
            this.chkBlacklist.Name = "chkBlacklist";
            this.chkBlacklist.Size = new System.Drawing.Size(77, 17);
            this.chkBlacklist.TabIndex = 5;
            this.chkBlacklist.Text = "Blacklisted";
            this.chkBlacklist.UseVisualStyleBackColor = true;
            // 
            // multipleSelectorBarType
            // 
            this.multipleSelectorBarType.ButtonLeft = 370;
            this.multipleSelectorBarType.dtSelected = null;
            this.multipleSelectorBarType.Location = new System.Drawing.Point(0, 0);
            this.multipleSelectorBarType.Name = "multipleSelectorBarType";
            this.multipleSelectorBarType.PrimaryKey = "TypeCode";
            this.multipleSelectorBarType.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarType.TabIndex = 0;
            this.multipleSelectorBarType.TextBoxLeft = 164;
            this.multipleSelectorBarType.Title = "Customer Type";
            this.multipleSelectorBarType.UnselectedVarList = null;
            // 
            // multipleSelectorBarGroup
            // 
            this.multipleSelectorBarGroup.ButtonLeft = 370;
            this.multipleSelectorBarGroup.dtSelected = null;
            this.multipleSelectorBarGroup.Location = new System.Drawing.Point(0, 26);
            this.multipleSelectorBarGroup.Name = "multipleSelectorBarGroup";
            this.multipleSelectorBarGroup.PrimaryKey = "GroupCode";
            this.multipleSelectorBarGroup.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarGroup.TabIndex = 1;
            this.multipleSelectorBarGroup.TextBoxLeft = 164;
            this.multipleSelectorBarGroup.Title = "Customer Group";
            this.multipleSelectorBarGroup.UnselectedVarList = null;
            // 
            // multipleSelectorBarCustomer
            // 
            this.multipleSelectorBarCustomer.ButtonLeft = 370;
            this.multipleSelectorBarCustomer.dtSelected = null;
            this.multipleSelectorBarCustomer.Location = new System.Drawing.Point(0, 52);
            this.multipleSelectorBarCustomer.Name = "multipleSelectorBarCustomer";
            this.multipleSelectorBarCustomer.PrimaryKey = "CustomerCode";
            this.multipleSelectorBarCustomer.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarCustomer.TabIndex = 2;
            this.multipleSelectorBarCustomer.TextBoxLeft = 164;
            this.multipleSelectorBarCustomer.Title = "Customer";
            this.multipleSelectorBarCustomer.UnselectedVarList = null;
            // 
            // MultipleSelectorBarCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multipleSelectorBarCustomer);
            this.Controls.Add(this.multipleSelectorBarGroup);
            this.Controls.Add(this.multipleSelectorBarType);
            this.Controls.Add(this.chkBlacklist);
            this.Controls.Add(this.chkInactive);
            this.Controls.Add(this.chkActive);
            this.Name = "MultipleSelectorBarCustomers";
            this.Size = new System.Drawing.Size(400, 98);
            this.Load += new System.EventHandler(this.MultipleSelectorBarCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.CheckBox chkBlacklist;
        private MultipleSelectorBar multipleSelectorBarType;
        private MultipleSelectorBar multipleSelectorBarGroup;
        private MultipleSelectorBar multipleSelectorBarCustomer;
    }
}
