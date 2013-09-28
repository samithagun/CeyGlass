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
    public partial class PurchaseOrder : TransactionForm
    {
        string branchCode, locationCode;

        bool alreadyFilling = false;

        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<POHed> tmpHedData = new BindingList<POHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            transactionToolBar1.bindingNavigator = pOHedBindingNavigator;
            transactionToolBar1.hedObjectBindingSource = pOHedBindingSource;
            transactionToolBar1.detObjectBindingSource = itemGridBindingSource;
            transactionToolBar1.detDataGrid = poDetDataGridView;
            transactionToolBar1.primaryKeyControl = referenceNoTextBox;
            transactionToolBar1.primaryKeyField = "ReferenceNo";
            transactionToolBar1.firstFocusControl = txnDateDateTimePicker;
            transactionToolBar1.db = db;
            transactionToolBar1.branchCodeControl = txtBranchCode;
            transactionToolBar1.ReferenceID = "S-PO";

            txtBranchCode.varList = from b in db.Branches select new { b.BranchCode, b.BranchName };
            txtBranchCode.codeFieldName = "BranchCode";
            txtBranchCode.controlList.Add(txtBranchName);
            txtBranchCode.fieldList.Add("BranchName");

            txtLocationCode.codeFieldName = "LocationCode";
            txtLocationCode.controlList.Add(txtLocationName);
            txtLocationCode.fieldList.Add("LocationName");

            txtSupplierCode.varList = from s in db.Suppliers where s.Status == "Active" select new { s.SupplierCode, s.SupplierName };
            txtSupplierCode.codeFieldName = "SupplierCode";
            txtSupplierCode.controlList.Add(txtSupplierName);
            txtSupplierCode.fieldList.Add("SupplierName");

            txtPOReqNo.codeFieldName = "ReferenceNo";
            txtPOReqNo.controlList.Add(txtBranchCode);
            txtPOReqNo.fieldList.Add("BranchCode");
            txtPOReqNo.controlList.Add(txtLocationCode);
            txtPOReqNo.fieldList.Add("LocationCode");

            txtItemCode.codeFieldName = "ItemCode";
            txtItemCode.controlList.Add(numQty);
            txtItemCode.fieldList.Add("BalanceQty");

            pOHedBindingSource.DataSource = tmpHedData;

            itemGridBindingSource.DataSource = tmpDetData;
            poDetDataGridView.DataSource = itemGridBindingSource;
            //pORequisitionDetsDataGridView.DataSource = tmpDetData;

            poDetDataGridView.Columns["ItemCode"].DataPropertyName = "ItemCode";
            poDetDataGridView.Columns["ItemName"].DataPropertyName = "ItemName";
            poDetDataGridView.Columns["QOH"].DataPropertyName = "QOH";
            poDetDataGridView.Columns["Quantity"].DataPropertyName = "Quantity";
            poDetDataGridView.Columns["UnitPrice"].DataPropertyName = "CostPrice";
            poDetDataGridView.Columns["DiscPer"].DataPropertyName = "ItemDiscPer";
            poDetDataGridView.Columns["DiscVal"].DataPropertyName = "ItemDiscVal";
            poDetDataGridView.Columns["NBTVal"].DataPropertyName = "NBTItemVal";
            poDetDataGridView.Columns["VATVal"].DataPropertyName = "VATItemVal";
            poDetDataGridView.Columns["TotalVal"].DataPropertyName = "TotalItemVal";
        }

        public override void EnableControls(bool enable)
        {
            txtItemCode.Enabled = enable;
            numItemDiscPer.Enabled = enable;
            numQty.Enabled = enable;
            numUnitPrice.Enabled = enable;
            btnAddItem.Enabled = enable;

            itemDiscTotValTextBox.Enabled = false;
            hedDiscTotValTextBox.Enabled = false;
            nBTValTextBox.Enabled = false;
            vATValTextBox.Enabled = false;
            totalValTextBox.Enabled = false;

            txtBranchCode.Enabled = false;
            txtLocationCode.Enabled = false;
        }

        public override void AddClick()
        {
            ((POHed)pOHedBindingSource.Current).HedDiscPer = 0.00m;
            ((POHed)pOHedBindingSource.Current).ManualNo = "";
            ((POHed)pOHedBindingSource.Current).Remarks = "";
        }

        private void GenerateItemCodeVarList()
        {
            if ((branchCode != txtBranchCode.Text) && (locationCode != txtLocationCode.Text))
            {
                if (txtBranchCode.Text != "" && txtLocationCode.Text != "" && txtPOReqNo.Text != "")
                    txtItemCode.varList = from p in db.PORequisitionDets.Where(r => r.ReferenceNo == txtPOReqNo.Text) join i in db.Items on p.ItemCode equals i.ItemCode join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, BalanceQty = p.BalQty };
                else
                    txtItemCode.varList = null;
                tmpDetData.Clear();
            }
        }

        private void txtBranchCode_Leave(object sender, EventArgs e)
        {
            if (txtBranchCode.Text != branchCode)
            {
                GenerateItemCodeVarList();
                branchCode = txtBranchCode.Text;
                txtLocationCode.filterCondition = "BranchCode = '" + txtBranchCode.Text + "'";
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

        public override void ClearData()
        {
            txtItemCode.Enabled = false;
            numQty.Enabled = false;
            numItemDiscPer.Enabled = false;
            numUnitPrice.Enabled = false;
            btnAddItem.Enabled = false;

            txtBranchCode.Validate();
            txtLocationCode.Validate();
            txtSupplierCode.Validate();

            txtItemCode.Text = "";
        }

        public override void LoadData()
        {
            var hedData = db.POHeds.Single(h => h.ReferenceNo == referenceNoTextBox.Text);

            tmpHedData.Add(hedData);

            branchCode = txtBranchCode.Text;
            locationCode = txtLocationCode.Text;

            //FillDetails(hedData);

            GeneratePOReqNoVarList();
            GenerateLocationCodeVarList();
            txtItemCode.varList = from p in db.PORequisitionDets.Where(r => r.ReferenceNo == txtPOReqNo.Text) join i in db.Items on p.ItemCode equals i.ItemCode join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, BalanceQty = p.BalQty };

            txtBranchCode.Validate();
            txtLocationCode.Validate();
            txtSupplierCode.Validate();

            Calculate();

            //itemDiscTotValTextBox.Text = ((POHed)pOHedBindingSource.Current).ItemDiscTotVal.ToString("C");
            //hedDiscTotValTextBox.Text = ((POHed)pOHedBindingSource.Current).HedDiscTotVal.ToString("C");
            //nBTValTextBox.Text = ((POHed)pOHedBindingSource.Current).NBTVal.ToString("C");
            //vATValTextBox.Text = ((POHed)pOHedBindingSource.Current).VATVal.ToString("C");
            //totalValTextBox.Text = ((POHed)pOHedBindingSource.Current).TotalVal.ToString("C");
        }

        private void FillDetails(POHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.PODets.ToList();

                foreach (PODet d in detData)
                    tmpDetData.Add(new ItemGrid(d.Item, d.CostPrice, d.SelPrice, d.ItemDiscPer, d.NBTPer, d.VATPer, d.Quantity, db.ItemQOHs.Single(q => q.BranchCode == hedData.BranchCode && q.LocationCode == hedData.LocationCode && q.ItemCode == d.ItemCode).QOH));
            }

            alreadyFilling = false;
        }

        public override DataRow SearchReferences(string mode)
        {
            var searchList = db.POHeds.Where(h => h.PODets.Where(d => d.BalQty < d.Quantity).Count() == 0);
            if (mode == "Print")
                searchList = db.POHeds;

            DataRow drResult = new helpSearchData().SearchAndReturnRow(searchList, "ReferenceNo Desc");

            return drResult;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtItemCode.Text == "")
            {
                errorProvider1.SetError(txtItemCode, "Invalid Item Code");
                txtItemCode.Focus();
                return;
            }

            if (numQty.Value == 0.00m)
            {
                errorProvider1.SetError(numQty, "Invalid Quantity");
                numQty.Focus();
                return;
            }

            if (numUnitPrice.Value <= 0.00m)
            {
                errorProvider1.SetError(numUnitPrice, "Invalid Unit Price");
                numUnitPrice.Focus();
                return;
            }

            if ((numItemDiscPer.Value < 0.00m) || (numItemDiscPer.Value > 100.00m))
            {
                errorProvider1.SetError(numItemDiscPer, "Invalid Item Discount Percentage");
                numItemDiscPer.Focus();
                return;
            }

            if (!ValidateQty())
                return;

            var Item = db.Items.Single(i => i.ItemCode == txtItemCode.Text);
            if (tmpDetData.Where(d => d.ItemCode == txtItemCode.Text).Count() == 0)
            {
                decimal QOH = Item.ItemQOHs.Single(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text).QOH;
                tmpDetData.Add(new ItemGrid(Item, numUnitPrice.Value, Item.SelPrice, numItemDiscPer.Value, numQty.Value, QOH));
            }
            else
            {
                var detItem = tmpDetData.Single(d => d.ItemCode == txtItemCode.Text);
                tmpDetData.Remove(detItem);
                tmpDetData.Add(new ItemGrid(Item, numUnitPrice.Value, Item.SelPrice, numItemDiscPer.Value, detItem.Quantity + numQty.Value, detItem.QOH));
            }

            var ZeroItems = tmpDetData.Where(d => d.Quantity.CompareTo(0.00m) <= 0).ToList();
            foreach (ItemGrid i in ZeroItems)
                tmpDetData.Remove(i);

            txtItemCode.Text = "";
            numItemDiscPer.Value = 0.00m;
            numQty.Value = 0.00m;
            numUnitPrice.Value = 0.00m;
            txtItemCode.Focus();
        }

        public override void PrintData()
        {
            DataTable dt = Helpers.LINQToDataTable(
                from d in db.PODets
                where d.POHed.ReferenceNo == referenceNoTextBox.Text
                select new
                {
                    d.POHed.ReferenceNo,
                    d.POHed.TxnDate,
                    d.POHed.Remarks,
                    d.POHed.ManualNo,
                    d.POHed.LocationCode,
                    d.POHed.Location.LocationName,
                    d.POHed.BranchCode,
                    d.POHed.Branch.BranchName,
                    d.POHed.HedDiscPer,
                    d.POHed.HedDiscTotVal,
                    d.POHed.ItemDiscTotVal,
                    d.POHed.NBTVal,
                    d.POHed.POReqNo,
                    d.POHed.TotalVal,
                    d.POHed.VATVal,
                    d.ItemCode,
                    d.Item.ItemName,
                    d.Quantity,
                    d.CostPrice,
                    d.HedDiscVal,
                    d.ItemDiscPer,
                    d.ItemDiscVal,
                    d.NBTItemVal,
                    d.NBTPer,
                    d.TotalItemVal,
                    d.VATItemVal,
                    d.VATPer,
                    ItemGrossVal = d.TotalItemVal - d.NBTItemVal - d.VATItemVal + d.HedDiscVal
                });
            dt.TableName = "PurchaseOrder";

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\PurchaseOrder", dt, db, this.Text);
        }

        public override bool ValidateOnChange(string mode)
        {
            if (db.POHeds.Single(x => x.ReferenceNo == referenceNoTextBox.Text).PODets.Where(y => y.BalQty < y.Quantity).Count() > 0)
            {
                MessageBox.Show(string.Format("The {0} you selected has already been used in a GRN", this.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public override void ViewClick()
        {
            pOHedBindingSource.DataSource = db.POHeds.ToList();
            FillDetails((POHed)pOHedBindingSource.Current);
        }

        private void pOHedBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!alreadyFilling)
                FillDetails((POHed)pOHedBindingSource.Current);
        }

        public override bool BeforeDataSave()
        {
            ((POHed)pOHedBindingSource.Current).ReferenceNo = referenceNoTextBox.Text;

            ((POHed)pOHedBindingSource.Current).UserID = Program.UserID;

            ((POHed)pOHedBindingSource.Current).AddedDate = DateTime.Now;

            ((POHed)pOHedBindingSource.Current).AddedMachineInfo = Program.MachineName;

            ((POHed)pOHedBindingSource.Current).PODets.Clear();

            PODet d;

            foreach (var x in tmpDetData)
            {
                d = new PODet();
                d.ItemCode = x.ItemCode;
                d.CostPrice = x.CostPrice;
                d.SelPrice = x.SelPrice;
                d.ItemDiscPer = x.ItemDiscPer;
                d.ItemDiscVal = x.ItemDiscVal;
                d.HedDiscVal = x.HedDiscVal;
                d.Quantity = x.Quantity;
                d.BalQty = x.Quantity;
                d.NBTPer = x.NbtPer;
                d.NBTItemVal = x.NbtItemVal;
                d.VATPer = x.VatPer;
                d.VATItemVal = x.VatItemVal;
                d.TotalItemVal = x.TotalItemVal;
                d.ReferenceNo = referenceNoTextBox.Text;
                ((POHed)pOHedBindingSource.Current).PODets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.POHeds.AddObject((POHed)pOHedBindingSource.Current);

            return true;
        }

        public override bool AfterDataSave()
        {
            try
            {
                POHed h = ((POHed)pOHedBindingSource.Current);

                foreach (PODet d in h.PODets)
                    db.PORequisitionDets.Single(x => x.ReferenceNo == h.POReqNo && x.ItemCode == d.ItemCode).BalQty -= d.Quantity;

                return true;
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                return false;
            }
        }

        private void poDetDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calculate();
        }

        private void poDetDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Calculate();
        }

        public void Calculate()
        {
            Helpers.FillGridRecordNo(poDetDataGridView, "RecordNo");

            foreach (ItemGrid x in tmpDetData)
                x.CalculatePurchases(numHedDiscPer.Value);

            decimal totItDis = 0.00m, totHedDis = 0.00m, totVat = 0.00m, totNbt = 0.00m, totNet = 0.00m;

            foreach (ItemGrid x in tmpDetData)
            {
                totItDis += x.ItemDiscVal;
                totHedDis += x.HedDiscVal;
                totVat += x.VatItemVal;
                totNbt += x.NbtItemVal;
                totNet += x.TotalItemVal;
            }

            ((POHed)pOHedBindingSource.Current).ItemDiscTotVal = totItDis;
            ((POHed)pOHedBindingSource.Current).HedDiscTotVal = totHedDis;
            ((POHed)pOHedBindingSource.Current).NBTVal = totNbt;
            ((POHed)pOHedBindingSource.Current).VATVal = totVat;
            ((POHed)pOHedBindingSource.Current).TotalVal = totNet;

            itemDiscTotValTextBox.Text = totItDis.ToString("C");
            hedDiscTotValTextBox.Text = totHedDis.ToString("C");
            nBTValTextBox.Text = totNbt.ToString("C");
            vATValTextBox.Text = totVat.ToString("C");
            totalValTextBox.Text = totNet.ToString("C");
        }

        private void txtPOReqNo_Enter(object sender, EventArgs e)
        {
            GeneratePOReqNoVarList();

            GenerateLocationCodeVarList();
        }

        private void GeneratePOReqNoVarList()
        {
            txtPOReqNo.varList = from p in db.PORequisitionHeds where p.PORequisitionDets.Where(d => d.BalQty > 0).Count() > 0 select new { p.ReferenceNo, p.TxnDate, p.BranchCode, p.Branch.BranchName, p.LocationCode, p.Location.LocationName, p.ManualNo, p.Remarks };
        }

        private void txtLocationCode_Enter(object sender, EventArgs e)
        {
            GenerateLocationCodeVarList();
        }

        private void GenerateLocationCodeVarList()
        {
            txtLocationCode.varList = from l in db.Locations where l.BranchCode == txtBranchCode.Text select new { l.LocationCode, l.LocationName };
        }

        private void numQty_Leave(object sender, EventArgs e)
        {
            ValidateQty();
        }

        private bool ValidateQty()
        {
            errorProvider1.Clear();

            if (txtPOReqNo.Text == "" || txtItemCode.Text == "")
                return false;

            decimal detQty = 0.00m;
            if (tmpDetData.Where(d => d.ItemCode == txtItemCode.Text).Count() == 1)
                detQty = tmpDetData.Single(d => d.ItemCode == txtItemCode.Text).Quantity;

            if (numQty.Value + detQty < 0.00m)
            {
                errorProvider1.SetError(numQty, "Quantity cannot be a negative value");//MessageBox.Show("Quantity cannot be a negative value", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                numQty.Value = 0.00m;
                numQty.Focus();
                return false;
            }

            decimal PORQty = db.PORequisitionDets.Single(p => p.ReferenceNo == txtPOReqNo.Text && p.ItemCode == txtItemCode.Text).BalQty;

            if (numQty.Value + detQty > PORQty)
            {
                errorProvider1.SetError(numQty, "PO Requisition Balance Quantity cannot be exceeded");//MessageBox.Show("PO Requisition Balance Quantity cannot be exceeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                numQty.Value = PORQty - detQty;
                numQty.Focus();
                return false;
            }

            return true;
        }

        public override bool AfterDataDelete()
        {
            try
            {
                foreach (var i in tmpDetData)
                    db.PORequisitionDets.Single(d => d.ReferenceNo == txtPOReqNo.Text && d.ItemCode == i.ItemCode).BalQty += i.Quantity;
                return true;
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                return false;
            }
        }

        public override void UndoClick()
        {
            pOHedBindingSource.DataSource = tmpHedData;
        }

        private void txtPOReqNo_Leave(object sender, EventArgs e)
        {
            GenerateItemCodeVarList();
        }

    }
}
