namespace InventorySalesDebtorsSytem
{
    partial class UserAccessManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.treeViewUserLevels = new System.Windows.Forms.TreeView();
            this.txtUserID = new InventorySalesDebtorsSytem.MasterDataTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User:";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(56, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(323, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // treeViewUserLevels
            // 
            this.treeViewUserLevels.CheckBoxes = true;
            this.treeViewUserLevels.Location = new System.Drawing.Point(21, 75);
            this.treeViewUserLevels.Name = "treeViewUserLevels";
            this.treeViewUserLevels.Size = new System.Drawing.Size(441, 369);
            this.treeViewUserLevels.TabIndex = 3;
            // 
            // txtUserID
            // 
            this.txtUserID.codeFieldName = null;
            this.txtUserID.filterCondition = null;
            this.txtUserID.Location = new System.Drawing.Point(56, 12);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.sortOrder = null;
            this.txtUserID.TabIndex = 0;
            this.txtUserID.valid = false;
            this.txtUserID.varList = null;
            this.txtUserID.Leave += new System.EventHandler(this.txtUserID_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::InventorySalesDebtorsSytem.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(412, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserAccessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 456);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.treeViewUserLevels);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccessManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Access Manager";
            this.Load += new System.EventHandler(this.UserAccessManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasterDataTextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TreeView treeViewUserLevels;
        private System.Windows.Forms.Button btnSave;
    }
}