namespace InventorySalesDebtorsSytems
{
    partial class helpTextBox
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
            this.txtMasterData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMasterData
            // 
            this.txtMasterData.Location = new System.Drawing.Point(0, 0);
            this.txtMasterData.Name = "txtMasterData";
            this.txtMasterData.Size = new System.Drawing.Size(100, 20);
            this.txtMasterData.TabIndex = 0;
            this.txtMasterData.DoubleClick += new System.EventHandler(this.txtMasterData_DoubleClick);
            this.txtMasterData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMasterData_KeyUp);
            this.txtMasterData.Leave += new System.EventHandler(this.txtMasterData_Leave);
            // 
            // helpTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMasterData);
            this.Name = "helpTextBox";
            this.Size = new System.Drawing.Size(100, 20);
            this.DoubleClick += new System.EventHandler(this.MasterFileSearch_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMasterData;
    }
}
