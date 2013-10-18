using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLayer;

namespace InventorySalesDebtorsSytem
{
    public partial class PurchaseOrderRequisition : TransactionForm
    {
        string branchCode, locationCode;

        bool alreadyFilling = false;

        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<PORequisitionHed> tmpHedData = new BindingList<PORequisitionHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        public PurchaseOrderRequisition()
        {
            InitializeComponent();
        }

        private void PurchaseOrderRequisition_Load(object sender, EventArgs e)
        {
            transactionToolBar1.bindingNavigator = pORequisitionHedBindingNavigator;
            transactionToolBar1.hedObjectBindingSource = pORequisitionHedBindingSource;
            transactionToolBar1.detObjectBindingSource = poRequisitionDetBindingSource;
            transactionToolBar1.detDataGrid = pORequisitionDetsDataGridView;
            transactionToolBar1.primaryKeyControl = referenceNoTextBox;
            transactionToolBar1.primaryKeyField = "ReferenceNo";
            transactionToolBar1.firstFocusControl = txnDateDateTimePicker;
            transactionToolBar1.db = db;
            transactionToolBar1.branchCodeControl = txtBranchCode;
            transactionToolBar1.ReferenceID = "S-POREQ";

            txtBranchCode.varList = from b in db.Branches select new { b.BranchCode, b.BranchName };
            txtBranchCode.codeFieldName = "BranchCode";
            txtBranchCode.controlList.Add(txtBranchName);
            txtBranchCode.fieldList.Add("BranchName");

            txtLocationCode.codeFieldName = "LocationCode";
            txtLocationCode.controlList.Add(txtLocationName);
            txtLocationCode.fieldList.Add("LocationName");

            txtItemCode.codeFieldName = "ItemCode";

            pORequisitionHedBindingSource.DataSource = tmpHedData;

            poRequisitionDetBindingSource.DataSource = tmpDetData;
            pORequisitionDetsDataGridView.DataSource = poRequisitionDetBindingSource;
            //pORequisitionDetsDataGridView.DataSource = tmpDetData;

            pORequisitionDetsDataGridView.Columns["ItemCode"].DataPropertyName = "ItemCode";
            pORequisitionDetsDataGridView.Columns["ItemName"].DataPropertyName = "ItemName";
            pORequisitionDetsDataGridView.Columns["QOH"].DataPropertyName = "QOH";
            pORequisitionDetsDataGridView.Columns["Quantity"].DataPropertyName = "Quantity";
        }

        private void GenerateItemCodeVarList()
        {
            if (txtBranchCode.Text != "" && txtLocationCode.Text != "")
                txtItemCode.varList = (from i in db.Items join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" && i.IsRawMaterial==true select new { i.ItemCode, i.ItemName, s.QOH }).ToList();
            else
                txtItemCode.varList = null;
            tmpDetData.Clear();
        }

        private void txtBranchCode_Leave(object sender, EventArgs e)
        {
            if (txtBranchCode.Text != branchCode)
            {
                GenerateItemCodeVarList();
                branchCode = txtBranchCode.Text;
            }
        }

        private void txtLocationCode_Leave(object sender, EventArgs e)
        {
            if (txtLocationCode.Text != locationCode)
            {
                GenerateItemCodeVarList();
                locationCode = txtLocationCode.Text;
            }
        }

        public override void AddClick()
        {
            txtItemCode.Enabled = true;
            txtQuantity.Enabled = true;
            btnAddItem.Enabled = true;

            ((PORequisitionHed)pORequisitionHedBindingSource.Current).ManualNo = "";
            ((PORequisitionHed)pORequisitionHedBindingSource.Current).Remarks = "";
        }

        public override void EditClick()
        {
            txtItemCode.Enabled = true;
            txtQuantity.Enabled = true;
            btnAddItem.Enabled = true;
        }

        public override void ClearData()
        {
            txtItemCode.Enabled = false;
            txtQuantity.Enabled = false;
            btnAddItem.Enabled = false;

            txtBranchCode.Validate();
            txtLocationCode.Validate();

            txtItemCode.Text = "";
        }

        public override void LoadData()
        {
            var hedData = db.PORequisitionHeds.Single(h => h.ReferenceNo == referenceNoTextBox.Text);

            tmpHedData.Add(hedData);

            branchCode = txtBranchCode.Text;
            locationCode = txtLocationCode.Text;
            txtItemCode.varList = (from i in db.Items join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH }).ToList();

            FillDetails(hedData);

            txtBranchCode.Validate();
            txtLocationCode.Validate();
        }

        private void FillDetails(PORequisitionHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.PORequisitionDets.ToList();

                foreach (PORequisitionDet d in detData)
                    tmpDetData.Add(new ItemGrid(d.Item, d.Quantity, db.ItemQOHs.Single(q => q.BranchCode == hedData.BranchCode && q.LocationCode == hedData.LocationCode && q.ItemCode == d.ItemCode).QOH));
            }

            alreadyFilling = false;
        }

        public override DataRow SearchReferences(string mode)
        {
            var searchList = db.PORequisitionHeds.Where(h => h.PORequisitionDets.Where(d => d.BalQty < d.Quantity).Count() == 0);
            if (mode == "Print")
                searchList = db.PORequisitionHeds;

            DataRow drResult = new helpSearchData().SearchAndReturnRow(searchList, "ReferenceNo Desc");

            return drResult;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtItemCode.Text == "")
            {
                errorProvider1.SetError(txtItemCode, "Invalid Item Code");
                return;
            }
            decimal Qty;
            if (decimal.TryParse(txtQuantity.Text, out Qty))
            {
                var Item = db.Items.Single(i => i.ItemCode == txtItemCode.Text);
                if (Qty.CompareTo(0.00m) == 0)
                    return;
                if (tmpDetData.Where(d => d.ItemCode == txtItemCode.Text).Count() == 0)
                {
                    decimal QOH = Item.ItemQOHs.Single(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text).QOH;
                    tmpDetData.Add(new ItemGrid(Item, Qty, QOH));
                }
                else
                {
                    var detItem = tmpDetData.Single(d => d.ItemCode == txtItemCode.Text);
                    tmpDetData.Remove(detItem);
                    tmpDetData.Add(new ItemGrid(Item, detItem.Quantity + Qty, detItem.QOH));
                }
                var ZeroItems = tmpDetData.Where(d => d.Quantity.CompareTo(0.00m) <= 0).ToList();
                foreach (ItemGrid i in ZeroItems)
                    tmpDetData.Remove(i);

                txtItemCode.Text = "";
                txtQuantity.Text = "";
                txtItemCode.Focus();
            }
            else
            {
                errorProvider1.SetError(txtQuantity, "Invalid Quantity");
            }
        }

        public override void PrintData()
        {
            DataTable dt = Helpers.LINQToDataTable(from d in db.PORequisitionDets where d.PORequisitionHed.ReferenceNo == referenceNoTextBox.Text select new { d.PORequisitionHed.ReferenceNo, d.PORequisitionHed.TxnDate, d.PORequisitionHed.Remarks, d.PORequisitionHed.ManualNo, d.PORequisitionHed.LocationCode, d.PORequisitionHed.Location.LocationName, d.PORequisitionHed.BranchCode, d.PORequisitionHed.Branch.BranchName, d.ItemCode, d.Item.ItemName, d.Quantity });
            dt.TableName = "PurchaseOrderRequisition";

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\PurchaseOrderRequisition", dt, db, this.Text);
        }

        public override bool ValidateOnChange(string mode)
        {
            if (db.PORequisitionHeds.Single(x => x.ReferenceNo == referenceNoTextBox.Text).PORequisitionDets.Where(y => y.BalQty < y.Quantity).Count() > 0)
            {
                MessageBox.Show(string.Format("The {0} you selected has already been used in a Purchase Order", this.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public override void ViewClick()
        {
            pORequisitionHedBindingSource.DataSource = db.PORequisitionHeds.ToList();
            FillDetails((PORequisitionHed)pORequisitionHedBindingSource.Current);
        }

        private void pORequisitionHedBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!alreadyFilling)
                FillDetails((PORequisitionHed)pORequisitionHedBindingSource.Current);
        }

        public override bool BeforeDataSave()
        {
            ((PORequisitionHed)pORequisitionHedBindingSource.Current).ReferenceNo = referenceNoTextBox.Text;

            ((PORequisitionHed)pORequisitionHedBindingSource.Current).UserID = Program.UserID;

            ((PORequisitionHed)pORequisitionHedBindingSource.Current).AddedDate = DateTime.Now;

            ((PORequisitionHed)pORequisitionHedBindingSource.Current).AddedMachineInfo = Program.MachineName;

            ((PORequisitionHed)pORequisitionHedBindingSource.Current).PORequisitionDets.Clear();

            PORequisitionDet d;

            foreach (var x in tmpDetData)
            {
                d = new PORequisitionDet();
                d.ItemCode = x.ItemCode;
                d.Quantity = x.Quantity;
                d.BalQty = x.Quantity;
                d.ReferenceNo = referenceNoTextBox.Text;
                ((PORequisitionHed)pORequisitionHedBindingSource.Current).PORequisitionDets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.PORequisitionHeds.AddObject((PORequisitionHed)pORequisitionHedBindingSource.Current);
            return true;
        }

        private void pORequisitionDetsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Helpers.FillGridRecordNo(pORequisitionDetsDataGridView, "RecordNo");
        }

        private void pORequisitionDetsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Helpers.FillGridRecordNo(pORequisitionDetsDataGridView, "RecordNo");
        }

        private void txtLocationCode_Enter(object sender, EventArgs e)
        {
            txtLocationCode.varList = from l in db.Locations where l.BranchCode == txtBranchCode.Text select new { l.LocationCode, l.LocationName };
        }

        public override void UndoClick()
        {
            pORequisitionHedBindingSource.DataSource = tmpHedData;
        }

    }

}
