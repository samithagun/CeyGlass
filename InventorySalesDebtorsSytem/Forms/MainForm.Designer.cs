namespace InventorySalesDebtorsSytem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.vNavPaneMain = new VIBlend.WinForms.Controls.vNavPane();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vNavPaneMain
            // 
            this.vNavPaneMain.AllowAnimations = true;
            this.vNavPaneMain.AllowPressedItemState = true;
            this.vNavPaneMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.vNavPaneMain.EnableToolTips = true;
            this.vNavPaneMain.IsExpandCollapseAnimationEnabled = true;
            this.vNavPaneMain.Location = new System.Drawing.Point(0, 0);
            this.vNavPaneMain.Name = "vNavPaneMain";
            this.vNavPaneMain.Size = new System.Drawing.Size(214, 468);
            this.vNavPaneMain.TabIndex = 23;
            this.vNavPaneMain.ToolTipDuration = 5000;
            this.vNavPaneMain.ToolTipShowDelay = 1500;
            this.vNavPaneMain.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            this.vNavPaneMain.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(903, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vNavPaneMain);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory, Sales and Debtors Control System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VIBlend.WinForms.Controls.vNavPane vNavPaneMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;







    }
}