using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLayer;

namespace InventorySalesDebtorsSytem.Forms.Transactions.Manufacturing
{
    public partial class SPS : TransactionForm
    {
        private InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<SPSHed> tmpHedData = new BindingList<SPSHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        bool alreadyFilling = false;

        public SPS()
        {
            InitializeComponent();
        }

        private void SPS_Load(object sender, EventArgs e)
        {

        }
    }
}
