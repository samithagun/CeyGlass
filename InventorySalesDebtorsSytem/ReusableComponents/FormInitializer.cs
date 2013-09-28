using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySalesDebtorsSytem.ReusableComponents
{
    public partial class FormInitializer : UserControl
    {
        public FormInitializer()
        {
            InitializeComponent();
        }

        private void FormInitializer_Load(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.Visible = false;
                this.ParentForm.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.ParentForm.MaximizeBox = false;
                this.ParentForm.MinimizeBox = false;
                this.ParentForm.ShowIcon = false;
                this.ParentForm.ShowInTaskbar = false;
                this.ParentForm.SizeGripStyle = SizeGripStyle.Hide;
                this.ParentForm.StartPosition = FormStartPosition.CenterScreen;
            }
        }
    }
}
