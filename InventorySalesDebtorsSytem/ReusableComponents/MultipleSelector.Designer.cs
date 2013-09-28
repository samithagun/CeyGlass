namespace InventorySalesDebtorsSytem
{
    partial class MultipleSelector
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
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.dataGridViewSelected = new System.Windows.Forms.DataGridView();
            this.dataGridViewUnselected = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnselected)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselectAll.Location = new System.Drawing.Point(372, 258);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(40, 40);
            this.btnUnselectAll.TabIndex = 11;
            this.btnUnselectAll.Text = "<<";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // btnUnselect
            // 
            this.btnUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselect.Location = new System.Drawing.Point(372, 210);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(40, 40);
            this.btnUnselect.TabIndex = 10;
            this.btnUnselect.Text = "<";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(372, 162);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(40, 40);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(372, 114);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(40, 40);
            this.btnSelectAll.TabIndex = 8;
            this.btnSelectAll.Text = ">>";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // dataGridViewSelected
            // 
            this.dataGridViewSelected.AllowUserToAddRows = false;
            this.dataGridViewSelected.AllowUserToDeleteRows = false;
            this.dataGridViewSelected.AllowUserToOrderColumns = true;
            this.dataGridViewSelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewSelected.Location = new System.Drawing.Point(431, 6);
            this.dataGridViewSelected.Name = "dataGridViewSelected";
            this.dataGridViewSelected.ReadOnly = true;
            this.dataGridViewSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelected.Size = new System.Drawing.Size(350, 400);
            this.dataGridViewSelected.TabIndex = 7;
            this.dataGridViewSelected.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelected_CellDoubleClick);
            // 
            // dataGridViewUnselected
            // 
            this.dataGridViewUnselected.AllowUserToAddRows = false;
            this.dataGridViewUnselected.AllowUserToDeleteRows = false;
            this.dataGridViewUnselected.AllowUserToOrderColumns = true;
            this.dataGridViewUnselected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUnselected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnselected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewUnselected.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewUnselected.Name = "dataGridViewUnselected";
            this.dataGridViewUnselected.ReadOnly = true;
            this.dataGridViewUnselected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnselected.Size = new System.Drawing.Size(350, 400);
            this.dataGridViewUnselected.TabIndex = 6;
            this.dataGridViewUnselected.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnselected_CellDoubleClick);
            // 
            // MultipleSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.btnUnselectAll);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.dataGridViewSelected);
            this.Controls.Add(this.dataGridViewUnselected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultipleSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnselected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.DataGridView dataGridViewSelected;
        private System.Windows.Forms.DataGridView dataGridViewUnselected;
    }
}