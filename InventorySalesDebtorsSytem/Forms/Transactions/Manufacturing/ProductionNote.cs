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
    public partial class ProductionNote : TransactionForm
    {
        private InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<ProductionNoteHed> tmpHedData = new BindingList<ProductionNoteHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        bool alreadyFilling = false;
        
        public ProductionNote()
        {
            InitializeComponent();
        }

        private void ProductionNote_Load(object sender, EventArgs e)
        {

        }
    }
}
