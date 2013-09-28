namespace InventorySalesDebtorsSytems
{
    partial class helpSearchDataLinq
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
            this.dataGridSearch = new System.Windows.Forms.DataGridView();
            this.txtSearchStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSearch
            // 
            this.dataGridSearch.AllowUserToAddRows = false;
            this.dataGridSearch.AllowUserToDeleteRows = false;
            this.dataGridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridSearch.Location = new System.Drawing.Point(12, 38);
            this.dataGridSearch.MultiSelect = false;
            this.dataGridSearch.Name = "dataGridSearch";
            this.dataGridSearch.ReadOnly = true;
            this.dataGridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSearch.Size = new System.Drawing.Size(776, 319);
            this.dataGridSearch.TabIndex = 1;
            this.dataGridSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSearch_CellDoubleClick);
            // 
            // txtSearchStr
            // 
            this.txtSearchStr.Location = new System.Drawing.Point(59, 12);
            this.txtSearchStr.Name = "txtSearchStr";
            this.txtSearchStr.Size = new System.Drawing.Size(729, 20);
            this.txtSearchStr.TabIndex = 0;
            this.txtSearchStr.TextChanged += new System.EventHandler(this.txtSearchStr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // helpSearchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchStr);
            this.Controls.Add(this.dataGridSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "helpSearchData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearch;
        private System.Windows.Forms.TextBox txtSearchStr;
        private System.Windows.Forms.Label label1;
    }
}