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

            txtItemCode.varList = from i in db.Items join p in db.ProductionPlanFinishedGoodDets on i.ItemCode equals p.ItemCode where p.ReferenceNo == txtProPlan.Text select new { i.ItemCode, i.ItemName, p.Quantity };
            txtItemCode.codeFieldName = "ItemCode";
            txtItemCode.controlList.Add(txtItemName);
            txtItemCode.fieldList.Add("ItemName");
            txtItemCode.controlList.Add(txtTotalQty);
            txtItemCode.fieldList.Add("Quantity");
            //txtItemCode.controlList.Add(txtDamageQty);
            //txtItemCode.fieldList.Add("DamageQty");
            //txtItemCode.controlList.Add(txtUsableQty);
            //txtItemCode.fieldList.Add("UsableQty");
            //txtItemCode.controlList.Add(txtBOQQty);
            //txtItemCode.fieldList.Add("ToalQty");

            PNBindingSource.DataSource = db.ProductionNoteHeds;
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
            var itemData = db.ProductionPlanRawItems.Where(h => h.ReferenceNo == txtProPlan.Text && h.FinishedItemCode == txtItemCode.Text);

            foreach (var Item in itemData)
                tmpDetData.Add(new ItemGrid(Item.Item1, Item.Quantity, 0, Item.Quantity));
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
                    tmpDetData.Add(new ItemGrid(d.Item, d.TotalQty, d.UsedQty, d.WasteQty));
            }

            alreadyFilling = false;
        }

        public override bool BeforeDataSave()
        {

            ((ProductionNoteHed)PNBindingSource.Current).ReferenceNo = referenceNoTextBox.Text;

            ((ProductionNoteHed)PNBindingSource.Current).UserID = Program.UserID;

            ((ProductionNoteHed)PNBindingSource.Current).AddedDate = DateTime.Now;

            ((ProductionNoteHed)PNBindingSource.Current).AddedMachineInfo = Program.MachineName;

            ProductionNoteDet d;

            foreach (var x in tmpDetData)
            {
                d = new ProductionNoteDet();
                d.ReferenceNo = referenceNoTextBox.Text;
                d.ItemCode = x.ItemCode;
                d.UsedQty = x.UsedQty;
                d.WasteQty = x.WasteQty;
                d.TotalQty = x.TotalQty;
                ((ProductionNoteHed)PNBindingSource.Current).ProductionNoteDets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.ProductionNoteHeds.AddObject((ProductionNoteHed)PNBindingSource.Current);
            return true;
        }

        private void PNDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PNDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (PNDataGridView.Columns[e.ColumnIndex].Name == "WasteQty")
            {
                decimal totalqty = 0;

                totalqty = Convert.ToDecimal(PNDataGridView.Rows[e.RowIndex].Cells["WasteQty"].Value) + Convert.ToDecimal(PNDataGridView.Rows[e.RowIndex].Cells["UsedQty"].Value);
                PNDataGridView.Rows[e.RowIndex].Cells["TotalQty"].Value = totalqty;
            }
        }

        public override bool AfterDataSave()
        { 
            var companyData = db.Companies.FirstOrDefault();

            try
            {
                //update finish good qty
                if (!BusinessRules.UpdateQOH(db, txtBranchCode.Text, companyData.StoresLoc.ToString(), txtItemCode.Text, Convert.ToDecimal(txtTotalQty.Text), 0, false))
                throw new Exception("Error @ UpdateQOH");

                //update raw material qty
                ProductionNoteHed h = ((ProductionNoteHed)PNBindingSource.Current);

                foreach (ProductionNoteDet p in h.ProductionNoteDets)
                {
                    //db.InvoiceDets.Single(x => x.ReferenceNo == h.InvoiceNo && x.ItemCode == d.ItemCode).BalQty1 -= d.Quantity;
                    if (!BusinessRules.UpdateQOH(db, txtBranchCode.Text, companyData.ProductionLoc.ToString(), p.ItemCode, -1 * p.TotalQty, 0, false))
                        throw new Exception("Error @ UpdateQOH");
                }

                return true;
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                return false;
            }
        }
    }
}