namespace InventorySalesDebtorsSytem
{
    partial class MultipleSelectorBarItems
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
            this.multipleSelectorBarBrand = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.multipleSelectorBarSubCategory = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.multipleSelectorBarCategory = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.multipleSelectorBarItem = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.multipleSelectorBarGroup = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.multipleSelectorBarType = new InventorySalesDebtorsSytem.MultipleSelectorBar();
            this.SuspendLayout();
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(119, 156);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Location = new System.Drawing.Point(217, 156);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(64, 17);
            this.chkInactive.TabIndex = 7;
            this.chkInactive.Text = "Inactive";
            this.chkInactive.UseVisualStyleBackColor = true;
            // 
            // multipleSelectorBarBrand
            // 
            this.multipleSelectorBarBrand.ButtonLeft = 370;
            this.multipleSelectorBarBrand.dtSelected = null;
            this.multipleSelectorBarBrand.Location = new System.Drawing.Point(0, 104);
            this.multipleSelectorBarBrand.Name = "multipleSelectorBarBrand";
            this.multipleSelectorBarBrand.PrimaryKey = "BrandCode";
            this.multipleSelectorBarBrand.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarBrand.TabIndex = 4;
            this.multipleSelectorBarBrand.TextBoxLeft = 164;
            this.multipleSelectorBarBrand.Title = "Item Brand";
            this.multipleSelectorBarBrand.UnselectedVarList = null;
            // 
            // multipleSelectorBarSubCategory
            // 
            this.multipleSelectorBarSubCategory.ButtonLeft = 370;
            this.multipleSelectorBarSubCategory.dtSelected = null;
            this.multipleSelectorBarSubCategory.Location = new System.Drawing.Point(0, 78);
            this.multipleSelectorBarSubCategory.Name = "multipleSelectorBarSubCategory";
            this.multipleSelectorBarSubCategory.PrimaryKey = "SubCatCode";
            this.multipleSelectorBarSubCategory.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarSubCategory.TabIndex = 3;
            this.multipleSelectorBarSubCategory.TextBoxLeft = 164;
            this.multipleSelectorBarSubCategory.Title = "Item Sub Category";
            this.multipleSelectorBarSubCategory.UnselectedVarList = null;
            // 
            // multipleSelectorBarCategory
            // 
            this.multipleSelectorBarCategory.ButtonLeft = 370;
            this.multipleSelectorBarCategory.dtSelected = null;
            this.multipleSelectorBarCategory.Location = new System.Drawing.Point(0, 52);
            this.multipleSelectorBarCategory.Name = "multipleSelectorBarCategory";
            this.multipleSelectorBarCategory.PrimaryKey = "CategoryCode";
            this.multipleSelectorBarCategory.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarCategory.TabIndex = 2;
            this.multipleSelectorBarCategory.TextBoxLeft = 164;
            this.multipleSelectorBarCategory.Title = "Item Category";
            this.multipleSelectorBarCategory.UnselectedVarList = null;
            // 
            // multipleSelectorBarItem
            // 
            this.multipleSelectorBarItem.ButtonLeft = 370;
            this.multipleSelectorBarItem.dtSelected = null;
            this.multipleSelectorBarItem.Location = new System.Drawing.Point(0, 130);
            this.multipleSelectorBarItem.Name = "multipleSelectorBarItem";
            this.multipleSelectorBarItem.PrimaryKey = "ItemCode";
            this.multipleSelectorBarItem.Size = new System.Drawing.Size(400, 20);
            this.multipleSelectorBarItem.TabIndex = 5;
            this.multipleSelectorBarItem.TextBoxLeft = 164;
            this.multipleSelectorBarItem.Title = "Item";
            this.multipleSelectorBarItem.UnselectedVarList = null;
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
            this.multipleSelectorBarGroup.Title = "Item Group";
            this.multipleSelectorBarGroup.UnselectedVarList = null;
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
            this.multipleSelectorBarType.Title = "Item Type";
            this.multipleSelectorBarType.UnselectedVarList = null;
            // 
            // MultipleSelectorBarItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multipleSelectorBarBrand);
            this.Controls.Add(this.multipleSelectorBarSubCategory);
            this.Controls.Add(this.multipleSelectorBarCategory);
            this.Controls.Add(this.multipleSelectorBarItem);
            this.Controls.Add(this.multipleSelectorBarGroup);
            this.Controls.Add(this.multipleSelectorBarType);
            this.Controls.Add(this.chkInactive);
            this.Controls.Add(this.chkActive);
            this.Name = "MultipleSelectorBarItems";
            this.Size = new System.Drawing.Size(400, 176);
            this.Load += new System.EventHandler(this.MultipleSelectorBarItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkInactive;
        private MultipleSelectorBar multipleSelectorBarType;
        private MultipleSelectorBar multipleSelectorBarGroup;
        private MultipleSelectorBar multipleSelectorBarItem;
        private MultipleSelectorBar multipleSelectorBarSubCategory;
        private MultipleSelectorBar multipleSelectorBarCategory;
        private MultipleSelectorBar multipleSelectorBarBrand;
    }
}
