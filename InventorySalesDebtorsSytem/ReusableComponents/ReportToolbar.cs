using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLayer;

namespace InventorySalesDebtorsSytem
{
    public partial class ReportToolbar : UserControl
    {
        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        public ReportToolbar()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ((ReportForm)this.ParentForm).PrintData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void ReportToolbar_Load(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.Left = 2;
                this.Top = 2;

                var ua = db.UserAccesses.Where(u => u.UserID == Program.UserID && u.sOption.sEntry.EntryDescription == this.ParentForm.Text);

                if (btnPrint.Visible)
                {
                    btnPrint.Visible = false;
                    if (ua.Where(u => u.sOption.OptionDescription == "Print").Count() == 1)
                        if (ua.Single(u => u.sOption.OptionDescription == "Print").Authorize)
                            btnPrint.Visible = true;
                }
            }
            
        }
    }
}
