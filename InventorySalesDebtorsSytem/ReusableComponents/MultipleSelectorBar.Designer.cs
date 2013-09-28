namespace InventorySalesDebtorsSytem
{
    partial class MultipleSelectorBar
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtCode = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Code:";
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::InventorySalesDebtorsSytem.Properties.Resources.checklist;
            this.btnSelect.Location = new System.Drawing.Point(370, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(30, 20);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtCode
            // 
            this.txtCode.codeFieldName = null;
            this.txtCode.filterCondition = null;
            this.txtCode.Location = new System.Drawing.Point(164, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 20);
            this.txtCode.sortOrder = null;
            this.txtCode.TabIndex = 1;
            this.txtCode.valid = false;
            this.txtCode.varList = null;
            // 
            // MultipleSelectorBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblTitle);
            this.Name = "MultipleSelectorBar";
            this.Size = new System.Drawing.Size(400, 20);
            this.Load += new System.EventHandler(this.MultipleSelectorBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasterDataTextBox txtCode;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblTitle;
    }
}
