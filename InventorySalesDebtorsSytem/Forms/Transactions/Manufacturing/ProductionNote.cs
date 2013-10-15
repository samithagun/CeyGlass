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
            transactionToolBar1.bindingNavigator = PNBindingNavigator;
            transactionToolBar1.hedObjectBindingSource = PNBindingSource;
            transactionToolBar1.detObjectBindingSource = PNDetBindingSource;
            transactionToolBar1.detDataGrid = PNDataGridView;
            transactionToolBar1.primaryKeyControl = referenceNoTextBox;
            transactionToolBar1.primaryKeyField = "ReferenceNo";
            transactionToolBar1.firstFocusControl = txtProPlan;
            transactionToolBar1.db = db;
            transactionToolBar1.branchCodeControl = txtBranchCode;
            transactionToolBar1.ReferenceID = "M-PN";

            txtProPlan.varList = from p in db.ProductionPlanHeds select new { p.ReferenceNo, p.ManualNo, p.TxnDate };
            txtProPlan.codeFieldName = "ReferenceNo";
            txtProPlan.controlList.Add(txtProPlan);

            txtItemCode.varList = from i in db.Items join p in db.ProductionPlanFinishedGoodDets on i.ItemCode equals p.ItemCode join b in db.BoqHeds on i.ItemCode equals b.BoqCode where p.ReferenceNo == txtProPlan.Text select new { i.ItemCode, i.ItemName, p.Quantity, b.ToalQty, b.UsableQty, b.DamageQty };
            txtItemCode.codeFieldName = "ItemCode";
            txtItemCode.controlList.Add(txtItemName);
            txtItemCode.fieldList.Add("ItemName");
            txtItemCode.controlList.Add(txtTotalQty);
            txtItemCode.fieldList.Add("Quantity");
            txtItemCode.controlList.Add(txtDamageQty);
            txtItemCode.fieldList.Add("DamageQty");
            txtItemCode.controlList.Add(txtUsableQty);
            txtItemCode.fieldList.Add("UsableQty");
            txtItemCode.controlList.Add(txtBOQQty);
            txtItemCode.fieldList.Add("ToalQty");

            PNBindingSource.DataSource = db.SPSHeds;
            PNDetBindingSource.DataSource = tmpDetData;
            PNDataGridView.DataSource = PNDetBindingSource;

            PNDataGridView.Columns["ItemCode"].DataPropertyName = "ItemCode";
            PNDataGridView.Columns["ItemName"].DataPropertyName = "ItemName";
            PNDataGridView.Columns["TotalQty"].DataPropertyName = "TotalQty";
            PNDataGridView.Columns["WasteQty"].DataPropertyName = "WasteQty";
            PNDataGridView.Columns["UsedQty"].DataPropertyName = "UsedQty";
        }

        public override void EnableControls(bool enable)
        {
            txtItemCode.Enabled = enable;
            txtTotalQty.Enabled = enable;
            txtProPlan.Enabled = enable;
            txtManualNo.Enabled = enable;
            txnDateTimePicker.Enabled = enable;
        }

        public override void ClearData()
        {
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtTotalQty.Text = "";
            txtUsableQty.Text = "";
            txtDamageQty.Text = "";
            txtProPlan.Text = "";
            txtManualNo.Text = "";
            referenceNoTextBox.Text = "";
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            var itemData = db.ProductionPlanRawItems.Single(h => h.ReferenceNo == txtProPlan.Text);

            //foreach (var Item in itemData)
            tmpDetData.Add(new ItemGrid(itemData.Item1, itemData.Quantity, itemData.Quantity, itemData.Quantity));
        }

        public override void ViewClick()
        {
            PNBindingSource.DataSource = db.ProductionNoteHeds.ToList();
            FillDetails((ProductionNoteHed)PNBindingSource.Current);
        }

        private void FillDetails(ProductionNoteHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.ProductionNoteDets.ToList();

                foreach (ProductionNoteDet d in detData)
                tmpDetData.Add(new ItemGrid(d.Item,d.TotalQty,d.UsedQty,d.WasteQty));
            }

            alreadyFilling = false;
        }
    }
}
