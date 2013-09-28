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
    public partial class GoodsReceivedNote : TransactionForm
    {
        string branchCode, locationCode;

        bool alreadyFilling = false;

        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<GRNHed> tmpHedData = new BindingList<GRNHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        public GoodsReceivedNote()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            transactionToolBar1.bindingNavigator = gRNHedBindingNavigator;
            transactionToolBar1.hedObjectBindingSource = gRNHedBindingSource;
            transactionToolBar1.detObjectBindingSource = itemGridBindingSource;
            transactionToolBar1.detDataGrid = poDetDataGridView;
            transactionToolBar1.primaryKeyControl = referenceNoTextBox;
            transactionToolBar1.primaryKeyField = "ReferenceNo";
            transactionToolBar1.firstFocusControl = txnDateDateTimePicker;
            transactionToolBar1.db = db;
            transactionToolBar1.branchCodeControl = txtBranchCode;
            transactionToolBar1.ReferenceID = "S-GRN";

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

            txtPONo.codeFieldName = "ReferenceNo";
            txtPONo.controlList.Add(txtBranchCode);
            txtPONo.fieldList.Add("BranchCode");
            txtPONo.controlList.Add(txtLocationCode);
            txtPONo.fieldList.Add("LocationCode");
            txtPONo.controlList.Add(txtSupplierCode);
            txtPONo.fieldList.Add("SupplierCode");
            txtPONo.controlList.Add(numHedDiscPer);
            txtPONo.fieldList.Add("HedDiscPer");

            txtItemCode.codeFieldName = "ItemCode";
            txtItemCode.controlList.Add(numQty);
            txtItemCode.fieldList.Add("BalanceQty");

            gRNHedBindingSource.DataSource = tmpHedData;

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
            txtSupplierCode.Enabled = false;
            numHedDiscPer.Enabled = false;
        }

        public override void AddClick()
        {
            ((GRNHed)gRNHedBindingSource.Current).HedDiscPer = 0.00m;
            ((GRNHed)gRNHedBindingSource.Current).ManualNo = "";
            ((GRNHed)gRNHedBindingSource.Current).Remarks = "";
        }

        private void GenerateItemCodeVarList()
        {
            if ((branchCode != txtBranchCode.Text) && (locationCode != txtLocationCode.Text))
            {
                if (txtBranchCode.Text != "" && txtLocationCode.Text != "" && txtPONo.Text != "")
                    txtItemCode.varList = from p in db.PODets.Where(r => r.ReferenceNo == txtPONo.Text) join i in db.Items on p.ItemCode equals i.ItemCode join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, BalanceQty = p.BalQty };
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
            var hedData = db.GRNHeds.Single(h => h.ReferenceNo == referenceNoTextBox.Text);

            tmpHedData.Add(hedData);

            branchCode = txtBranchCode.Text;
            locationCode = txtLocationCode.Text;

            //FillDetails(hedData);

            GeneratePONoVarList();
            GenerateLocationCodeVarList();
            txtItemCode.varList = from p in db.PODets.Where(r => r.ReferenceNo == txtPONo.Text) join i in db.Items on p.ItemCode equals i.ItemCode join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, BalanceQty = p.BalQty };

            txtBranchCode.Validate();
            txtLocationCode.Validate();
            txtSupplierCode.Validate();

            Calculate();

            //itemDiscTotValTextBox.Text = ((GRNHed)gRNHedBindingSource.Current).ItemDiscTotVal.ToString("C");
            //hedDiscTotValTextBox.Text = ((GRNHed)gRNHedBindingSource.Current).HedDiscTotVal.ToString("C");
            //nBTValTextBox.Text = ((GRNHed)gRNHedBindingSource.Current).NBTVal.ToString("C");
            //vATValTextBox.Text = ((GRNHed)gRNHedBindingSource.Current).VATVal.ToString("C");
            //totalValTextBox.Text = ((GRNHed)gRNHedBindingSource.Current).TotalVal.ToString("C");
        }

        private void FillDetails(GRNHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.GRNDets.ToList();

                foreach (GRNDet d in detData)
                    tmpDetData.Add(new ItemGrid(d.Item, d.CostPrice, d.SelPrice, d.ItemDiscPer, d.NBTPer, d.VATItemVal, d.Quantity, db.ItemQOHs.Single(q => q.BranchCode == hedData.BranchCode && q.LocationCode == hedData.LocationCode && q.ItemCode == d.ItemCode).QOH));
            }

            alreadyFilling = false;
        }

        public override DataRow SearchReferences(string mode)
        {
            var searchList = db.GRNHeds.Where(h => h.GRNDets.Where(d => d.BalQty < d.Quantity).Count() == 0);
            if (mode == "Print")
                searchList = db.GRNHeds;

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
                from d in db.GRNDets
                where d.GRNHed.ReferenceNo == referenceNoTextBox.Text
                select new
                {
                    d.GRNHed.ReferenceNo,
                    d.GRNHed.TxnDate,
                    d.GRNHed.Remarks,
                    d.GRNHed.ManualNo,
                    d.GRNHed.LocationCode,
                    d.GRNHed.Location.LocationName,
                    d.GRNHed.BranchCode,
                    d.GRNHed.Branch.BranchName,
                    d.GRNHed.HedDiscPer,
                    d.GRNHed.HedDiscTotVal,
                    d.GRNHed.ItemDiscTotVal,
                    d.GRNHed.NBTVal,
                    d.GRNHed.PONo,
                    d.GRNHed.TotalVal,
                    d.GRNHed.VATVal,
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
            dt.TableName = "GoodsReceivedNote";

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\GoodsReceivedNote", dt, db, this.Text);
        }

        public override bool ValidateOnChange(string mode)
        {
            if (db.GRNHeds.Single(x => x.ReferenceNo == referenceNoTextBox.Text).GRNDets.Where(y => y.BalQty < y.Quantity).Count() > 0)
            {
                MessageBox.Show(string.Format("The {0} you selected has already been used in a Goods Return Note", this.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public override void ViewClick()
        {
            gRNHedBindingSource.DataSource = db.GRNHeds.ToList();
            //FillDetails((GRNHed)gRNHedBindingSource.Current);
        }

        private void pOHedBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!alreadyFilling)
                FillDetails((GRNHed)gRNHedBindingSource.Current);
        }

        public override bool BeforeDataSave()
        {
            ((GRNHed)gRNHedBindingSource.Current).ReferenceNo = referenceNoTextBox.Text;

            ((GRNHed)gRNHedBindingSource.Current).UserID = Program.UserID;

            ((GRNHed)gRNHedBindingSource.Current).AddedDate = DateTime.Now;

            ((GRNHed)gRNHedBindingSource.Current).AddedMachineInfo = Program.MachineName;

            ((GRNHed)gRNHedBindingSource.Current).GRNDets.Clear();

            GRNDet d;

            foreach (var x in tmpDetData)
            {
                d = new GRNDet();
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
                ((GRNHed)gRNHedBindingSource.Current).GRNDets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.GRNHeds.AddObject((GRNHed)gRNHedBindingSource.Current);

            return true;
        }

        public override bool AfterDataSave()
        {
            try
            {
                GRNHed h = ((GRNHed)gRNHedBindingSource.Current);

                foreach (GRNDet d in h.GRNDets)
                {
                    db.PODets.Single(x => x.ReferenceNo == h.PONo && x.ItemCode == d.ItemCode).BalQty -= d.Quantity;
                    if (!BusinessRules.UpdateQOH(db, h.BranchCode, h.LocationCode, d.ItemCode, d.Quantity, (d.TotalItemVal - d.VATItemVal - d.NBTItemVal) / d.Quantity, true))
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

            ((GRNHed)gRNHedBindingSource.Current).ItemDiscTotVal = totItDis;
            ((GRNHed)gRNHedBindingSource.Current).HedDiscTotVal = totHedDis;
            ((GRNHed)gRNHedBindingSource.Current).NBTVal = totNbt;
            ((GRNHed)gRNHedBindingSource.Current).VATVal = totVat;
            ((GRNHed)gRNHedBindingSource.Current).TotalVal = totNet;

            itemDiscTotValTextBox.Text = totItDis.ToString("C");
            hedDiscTotValTextBox.Text = totHedDis.ToString("C");
            nBTValTextBox.Text = totNbt.ToString("C");
            vATValTextBox.Text = totVat.ToString("C");
            totalValTextBox.Text = totNet.ToString("C");
        }

        private void txtPOReqNo_Enter(object sender, EventArgs e)
        {
            GeneratePONoVarList();

            GenerateLocationCodeVarList();
        }

        private void GeneratePONoVarList()
        {
            txtPONo.varList = from p in db.POHeds where p.PODets.Where(d => d.BalQty > 0).Count() > 0 select new { p.ReferenceNo, p.TxnDate, p.BranchCode, p.Branch.BranchName, p.LocationCode, p.Location.LocationName, p.SupplierCode, p.Supplier.SupplierName, p.ManualNo, p.Remarks, p.HedDiscPer };
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

            if (txtPONo.Text == "" || txtItemCode.Text == "")
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

            decimal PORQty = db.PODets.Single(p => p.ReferenceNo == txtPONo.Text && p.ItemCode == txtItemCode.Text).BalQty;

            if (numQty.Value + detQty > PORQty)
            {
                errorProvider1.SetError(numQty, "PO Balance Quantity cannot be exceeded");//MessageBox.Show("PO Balance Quantity cannot be exceeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                {
                    db.PODets.Single(d => d.ReferenceNo == txtPONo.Text && d.ItemCode == i.ItemCode).BalQty += i.Quantity;
                    if (!BusinessRules.UpdateQOH(db, txtBranchCode.Text, txtLocationCode.Text, i.ItemCode, -1*i.Quantity, (i.TotalItemVal - i.VatItemVal - i.NbtItemVal) / i.Quantity, true))
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

        public override void UndoClick()
        {
            gRNHedBindingSource.DataSource = tmpHedData;
        }

        private void txtPONo_Leave(object sender, EventArgs e)
        {
            GenerateItemCodeVarList();
        }

    }
}
