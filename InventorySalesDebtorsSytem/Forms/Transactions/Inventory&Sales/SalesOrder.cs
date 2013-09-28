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
    public partial class SalesOrder : TransactionForm
    {
        string branchCode, locationCode, quotNo;

        bool alreadyFilling = false;

        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<SalesOrderHed> tmpHedData = new BindingList<SalesOrderHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        public SalesOrder()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            transactionToolBar1.bindingNavigator = HeaderBindingNavigator;
            transactionToolBar1.hedObjectBindingSource = HeaderBindingSource;
            transactionToolBar1.detObjectBindingSource = itemGridBindingSource;
            transactionToolBar1.detDataGrid = cusDataGridView;
            transactionToolBar1.primaryKeyControl = referenceNoTextBox;
            transactionToolBar1.primaryKeyField = "ReferenceNo";
            transactionToolBar1.firstFocusControl = txnDateDateTimePicker;
            transactionToolBar1.db = db;
            transactionToolBar1.branchCodeControl = txtBranchCode;
            transactionToolBar1.ReferenceID = "S-SORDER";

            txtQuotNo.codeFieldName = "ReferenceNo";
            txtQuotNo.sortOrder = "ReferenceNo Desc";
            txtQuotNo.controlList.Add(txtBranchCode);
            txtQuotNo.fieldList.Add("BranchCode");
            txtQuotNo.controlList.Add(txtLocationCode);
            txtQuotNo.fieldList.Add("LocationCode");
            txtQuotNo.controlList.Add(txtRepCode);
            txtQuotNo.fieldList.Add("RepCode");
            txtQuotNo.controlList.Add(txtCustomerCode);
            txtQuotNo.fieldList.Add("CustomerCode");
            txtQuotNo.controlList.Add(numHedDiscPer);
            txtQuotNo.fieldList.Add("HedDiscPer");

            txtBranchCode.varList = from b in db.Branches select new { b.BranchCode, b.BranchName };
            txtBranchCode.codeFieldName = "BranchCode";
            txtBranchCode.controlList.Add(txtBranchName);
            txtBranchCode.fieldList.Add("BranchName");

            txtLocationCode.codeFieldName = "LocationCode";
            txtLocationCode.controlList.Add(txtLocationName);
            txtLocationCode.fieldList.Add("LocationName");

            txtCustomerCode.varList = from c in db.Customers where c.Status == "Active" select new { c.CustomerCode, c.CustomerName };
            txtCustomerCode.codeFieldName = "CustomerCode";
            txtCustomerCode.controlList.Add(txtCustomerName);
            txtCustomerCode.fieldList.Add("CustomerName");

            txtRepCode.varList = from r in db.SalesReps where r.Status == "Active" select new { r.RepCode, r.RepName };
            txtRepCode.codeFieldName = "RepCode";
            txtRepCode.controlList.Add(txtRepName);
            txtRepCode.fieldList.Add("RepName");

            txtItemCode.codeFieldName = "ItemCode";
            txtItemCode.controlList.Add(numUnitPrice);
            txtItemCode.fieldList.Add("SellingPrice");
            txtItemCode.controlList.Add(numQty);
            txtItemCode.fieldList.Add("BalanceQuantity");
            txtItemCode.controlList.Add(numItemDiscPer);
            txtItemCode.fieldList.Add("ItemDiscPer");

            HeaderBindingSource.DataSource = tmpHedData;

            itemGridBindingSource.DataSource = tmpDetData;
            cusDataGridView.DataSource = itemGridBindingSource;

            cusDataGridView.Columns["ItemCode"].DataPropertyName = "ItemCode";
            cusDataGridView.Columns["ItemName"].DataPropertyName = "ItemName";
            cusDataGridView.Columns["QOH"].DataPropertyName = "QOH";
            cusDataGridView.Columns["Quantity"].DataPropertyName = "Quantity";
            cusDataGridView.Columns["UnitPrice"].DataPropertyName = "SelPrice";
            cusDataGridView.Columns["DiscPer"].DataPropertyName = "ItemDiscPer";
            cusDataGridView.Columns["DiscVal"].DataPropertyName = "ItemDiscVal";
            cusDataGridView.Columns["NBTVal"].DataPropertyName = "NBTItemVal";
            cusDataGridView.Columns["VATVal"].DataPropertyName = "VATItemVal";
            cusDataGridView.Columns["TotalVal"].DataPropertyName = "TotalItemVal";
        }

        public override void EnableControls(bool enable)
        {
            txtItemCode.Enabled = enable;
            numItemDiscPer.Enabled = false;
            numQty.Enabled = enable;
            numUnitPrice.Enabled = false;
            btnAddItem.Enabled = enable;

            itemDiscTotValTextBox.Enabled = false;
            hedDiscTotValTextBox.Enabled = false;
            nBTValTextBox.Enabled = false;
            vATValTextBox.Enabled = false;
            totalValTextBox.Enabled = false;

            txtBranchCode.Enabled = false;
            txtLocationCode.Enabled = false;
            txtRepCode.Enabled = false;
            txtCustomerCode.Enabled = false;
            numHedDiscPer.Enabled = false;
        }

        public override void AddClick()
        {
            ((SalesOrderHed)HeaderBindingSource.Current).HedDiscPer = 0.00m;
            ((SalesOrderHed)HeaderBindingSource.Current).ManualNo = "";
            ((SalesOrderHed)HeaderBindingSource.Current).Remarks = "";
        }

        private void GenerateItemCodeVarList()
        {
            if ((branchCode != txtBranchCode.Text) || (locationCode != txtLocationCode.Text) || (quotNo != txtQuotNo.Text))
            {
                if (txtBranchCode.Text != "" && txtLocationCode.Text != "" && txtQuotNo.Text != "")
                    txtItemCode.varList = from q in db.QuotationDets.Where(d => d.ReferenceNo == txtQuotNo.Text && d.BalQty > 0) join i in db.Items on q.ItemCode equals i.ItemCode join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, SellingPrice = q.SelPrice, BalanceQuantity = q.BalQty, q.ItemDiscPer };
                else
                    txtItemCode.varList = null;
                branchCode = txtBranchCode.Text;
                locationCode = txtLocationCode.Text;
                quotNo = txtQuotNo.Text;
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
            txtRepCode.Validate();
            txtCustomerCode.Validate();

            txtItemCode.Text = "";
        }

        public override void LoadData()
        {
            var hedData = db.SalesOrderHeds.Single(h => h.ReferenceNo == referenceNoTextBox.Text);

            tmpHedData.Add(hedData);

            HeaderBindingSource.MoveLast();

            branchCode = txtBranchCode.Text;
            locationCode = txtLocationCode.Text;

            //FillDetails(hedData);

            branchCode = txtBranchCode.Text;
            locationCode = txtLocationCode.Text;
            quotNo = txtQuotNo.Text;

            GenerateLocationCodeVarList();
            txtItemCode.varList = from q in db.QuotationDets.Where(d => d.ReferenceNo == txtQuotNo.Text && d.BalQty > 0) join i in db.Items on q.ItemCode equals i.ItemCode join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, SellingPrice = q.SelPrice, BalanceQuantity = q.BalQty, q.ItemDiscPer };

            txtBranchCode.Validate();
            txtLocationCode.Validate();
            txtRepCode.Validate();
            txtCustomerCode.Validate();

            Calculate();

            //itemDiscTotValTextBox.Text = ((SalesOrderHed)HeaderBindingSource.Current).ItemDiscTotVal.ToString("C");
            //hedDiscTotValTextBox.Text = ((SalesOrderHed)HeaderBindingSource.Current).HedDiscTotVal.ToString("C");
            //nBTValTextBox.Text = ((SalesOrderHed)HeaderBindingSource.Current).NBTVal.ToString("C");
            //vATValTextBox.Text = ((SalesOrderHed)HeaderBindingSource.Current).VATVal.ToString("C");
            //totalValTextBox.Text = ((SalesOrderHed)HeaderBindingSource.Current).TotalVal.ToString("C");
        }

        private void FillDetails(SalesOrderHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.SalesOrderDets.ToList();

                foreach (SalesOrderDet d in detData)
                    tmpDetData.Add(new ItemGrid(d.Item, d.CostPrice, d.SelPrice, d.ItemDiscPer, d.NBTPer, d.VATPer, d.Quantity, db.ItemQOHs.Single(q => q.BranchCode == hedData.BranchCode && q.LocationCode == hedData.LocationCode && q.ItemCode == d.ItemCode).QOH));
            }

            alreadyFilling = false;
        }

        public override DataRow SearchReferences(string mode)
        {
            var searchList = db.SalesOrderHeds.Where(h => h.SalesOrderDets.Where(d => d.BalQty < d.Quantity).Count() == 0);
            if (mode == "Print")
                searchList = db.SalesOrderHeds;

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
                tmpDetData.Add(new ItemGrid(Item, numUnitPrice.Value, numItemDiscPer.Value, numQty.Value, QOH));
            }
            else
            {
                var detItem = tmpDetData.Single(d => d.ItemCode == txtItemCode.Text);
                tmpDetData.Remove(detItem);
                tmpDetData.Add(new ItemGrid(Item, numUnitPrice.Value, numItemDiscPer.Value, detItem.Quantity + numQty.Value, detItem.QOH));
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
                from d in db.SalesOrderDets
                where d.SalesOrderHed.ReferenceNo == referenceNoTextBox.Text
                select new
                {
                    d.SalesOrderHed.ReferenceNo,
                    d.SalesOrderHed.TxnDate,
                    d.SalesOrderHed.Remarks,
                    d.SalesOrderHed.ManualNo,
                    d.SalesOrderHed.QuotationNo,
                    d.SalesOrderHed.LocationCode,
                    d.SalesOrderHed.Location.LocationName,
                    d.SalesOrderHed.BranchCode,
                    d.SalesOrderHed.Branch.BranchName,
                    d.SalesOrderHed.HedDiscPer,
                    d.SalesOrderHed.HedDiscTotVal,
                    d.SalesOrderHed.ItemDiscTotVal,
                    d.SalesOrderHed.NBTVal,
                    d.SalesOrderHed.TotalVal,
                    d.SalesOrderHed.VATVal,
                    d.ItemCode,
                    d.Item.ItemName,
                    d.Quantity,
                    d.CostPrice,
                    d.SelPrice,
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
            dt.TableName = "SalesOrder";

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\SalesOrder", dt, db, this.Text);
        }

        public override bool ValidateOnChange(string mode)
        {
            if (db.SalesOrderHeds.Single(x => x.ReferenceNo == referenceNoTextBox.Text).SalesOrderDets.Where(y => y.BalQty < y.Quantity).Count() > 0)
            {
                MessageBox.Show(string.Format("The {0} you selected has already been used in an Invoice", this.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public override void ViewClick()
        {
            HeaderBindingSource.DataSource = db.SalesOrderHeds.ToList();
            FillDetails((SalesOrderHed)HeaderBindingSource.Current);
        }

        private void HeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!alreadyFilling)
                FillDetails((SalesOrderHed)HeaderBindingSource.Current);
        }

        public override bool BeforeDataSave()
        {
            ((SalesOrderHed)HeaderBindingSource.Current).ReferenceNo = referenceNoTextBox.Text;

            ((SalesOrderHed)HeaderBindingSource.Current).UserID = Program.UserID;

            ((SalesOrderHed)HeaderBindingSource.Current).AddedDate = DateTime.Now;

            ((SalesOrderHed)HeaderBindingSource.Current).AddedMachineInfo = Program.MachineName;

            ((SalesOrderHed)HeaderBindingSource.Current).SalesOrderDets.Clear();

            SalesOrderDet d;

            foreach (var x in tmpDetData)
            {
                d = new SalesOrderDet();
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
                ((SalesOrderHed)HeaderBindingSource.Current).SalesOrderDets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.SalesOrderHeds.AddObject((SalesOrderHed)HeaderBindingSource.Current);

            return true;
        }

        public override bool AfterDataSave()
        {
            try
            {
                SalesOrderHed h = ((SalesOrderHed)HeaderBindingSource.Current);

                foreach (SalesOrderDet d in h.SalesOrderDets)
                {
                    db.QuotationDets.Single(x => x.ReferenceNo == h.QuotationNo && x.ItemCode == d.ItemCode).BalQty -= d.Quantity;
                    //if (!BusinessRules.UpdateQOH(db, h.BranchCode, h.LocationCode, d.ItemCode, d.Quantity, (d.TotalItemVal - d.VATItemVal - d.NBTItemVal) / d.Quantity, true))
                    //    throw new Exception("Error @ UpdateQOH");
                }

                return true;
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                return false;
            }
        }

        public override bool AfterDataDelete()
        {
            try
            {
                foreach (var i in tmpDetData)
                {
                    db.QuotationDets.Single(d => d.ReferenceNo == txtQuotNo.Text && d.ItemCode == i.ItemCode).BalQty += i.Quantity;
                    //if (!BusinessRules.UpdateQOH(db, txtBranchCode.Text, txtLocationCode.Text, i.ItemCode, i.Quantity, (i.TotalItemVal - i.VatItemVal - i.NbtItemVal) / i.Quantity, true))
                    //    throw new Exception("Error @ UpdateQOH");
                }
                return true;
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                return false;
            }
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calculate();
        }

        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Calculate();
        }

        public void Calculate()
        {
            Helpers.FillGridRecordNo(cusDataGridView, "RecordNo");

            foreach (ItemGrid x in tmpDetData)
                x.CalculateSales(numHedDiscPer.Value);

            decimal totItDis = 0.00m, totHedDis = 0.00m, totVat = 0.00m, totNbt = 0.00m, totNet = 0.00m;

            foreach (ItemGrid x in tmpDetData)
            {
                totItDis += x.ItemDiscVal;
                totHedDis += x.HedDiscVal;
                totVat += x.VatItemVal;
                totNbt += x.NbtItemVal;
                totNet += x.TotalItemVal;
            }

            ((SalesOrderHed)HeaderBindingSource.Current).ItemDiscTotVal = totItDis;
            ((SalesOrderHed)HeaderBindingSource.Current).HedDiscTotVal = totHedDis;
            ((SalesOrderHed)HeaderBindingSource.Current).NBTVal = totNbt;
            ((SalesOrderHed)HeaderBindingSource.Current).VATVal = totVat;
            ((SalesOrderHed)HeaderBindingSource.Current).TotalVal = totNet;

            itemDiscTotValTextBox.Text = totItDis.ToString("C");
            hedDiscTotValTextBox.Text = totHedDis.ToString("C");
            nBTValTextBox.Text = totNbt.ToString("C");
            vATValTextBox.Text = totVat.ToString("C");
            totalValTextBox.Text = totNet.ToString("C");
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

            if (txtItemCode.Text == "")
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

            decimal QuoQty = db.QuotationDets.Single(p => p.ReferenceNo == txtQuotNo.Text && p.ItemCode == txtItemCode.Text).BalQty;

            if (numQty.Value + detQty > QuoQty)
            {
                errorProvider1.SetError(numQty, "Quotation Balance Quantity cannot be exceeded");//MessageBox.Show("PO Balance Quantity cannot be exceeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                numQty.Value = QuoQty - detQty;
                numQty.Focus();
                return false;
            }

            return true;
        }

        public override void UndoClick()
        {
            HeaderBindingSource.DataSource = tmpHedData;
        }

        private void txtQuotNo_Enter(object sender, EventArgs e)
        {
            txtQuotNo.varList = from q in db.QuotationHeds
                                where q.QuotationDets.Where(d => d.BalQty > 0).Count() > 0
                                select new
                                {
                                    q.ReferenceNo,
                                    q.TxnDate,
                                    q.CustomerCode,
                                    q.Customer.CustomerName,
                                    q.RepCode,
                                    q.SalesRep.RepName,
                                    q.BranchCode,
                                    q.Branch.BranchName,
                                    q.LocationCode,
                                    q.Location.LocationName,
                                    q.HedDiscPer
                                };
        }

        private void txtItemCode_Enter(object sender, EventArgs e)
        {
            GenerateItemCodeVarList();
        }

    }
}
