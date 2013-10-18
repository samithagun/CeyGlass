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
    public partial class CustomerQuotation : TransactionForm
    {
        string branchCode, locationCode;

        bool alreadyFilling = false;

        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<QuotationHed> tmpHedData = new BindingList<QuotationHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        public CustomerQuotation()
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
            transactionToolBar1.ReferenceID = "S-QUOT";

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

            HeaderBindingSource.DataSource = tmpHedData;

            itemGridBindingSource.DataSource = tmpDetData;
            cusDataGridView.DataSource = itemGridBindingSource;
            //pORequisitionDetsDataGridView.DataSource = tmpDetData;

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
            numItemDiscPer.Enabled = enable;
            numQty.Enabled = enable;
            numUnitPrice.Enabled = enable;
            btnAddItem.Enabled = enable;

            itemDiscTotValTextBox.Enabled = false;
            hedDiscTotValTextBox.Enabled = false;
            nBTValTextBox.Enabled = false;
            vATValTextBox.Enabled = false;
            totalValTextBox.Enabled = false;
        }

        public override void AddClick()
        {
            ((QuotationHed)HeaderBindingSource.Current).HedDiscPer = 0.00m;
            ((QuotationHed)HeaderBindingSource.Current).ManualNo = "";
            ((QuotationHed)HeaderBindingSource.Current).Remarks = "";
        }

        private void GenerateItemCodeVarList()
        {
            if (txtBranchCode.Text != "" && txtLocationCode.Text != "")
                txtItemCode.varList = (from i in db.Items join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" && i.IsRawMaterial==false select new { i.ItemCode, i.ItemName, s.QOH, SellingPrice = i.SelPrice }).ToList();
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
            var hedData = db.QuotationHeds.Single(h => h.ReferenceNo == referenceNoTextBox.Text);

            tmpHedData.Add(hedData);

            HeaderBindingSource.MoveLast();

            branchCode = txtBranchCode.Text;
            locationCode = txtLocationCode.Text;

            //FillDetails(hedData);

            GenerateLocationCodeVarList();
            txtItemCode.varList = (from i in db.Items join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, SellingPrice = i.SelPrice }).ToList();

            txtBranchCode.Validate();
            txtLocationCode.Validate();
            txtRepCode.Validate();
            txtCustomerCode.Validate();

            Calculate();

            //itemDiscTotValTextBox.Text = ((QuotationHed)HeaderBindingSource.Current).ItemDiscTotVal.ToString("C");
            //hedDiscTotValTextBox.Text = ((QuotationHed)HeaderBindingSource.Current).HedDiscTotVal.ToString("C");
            //nBTValTextBox.Text = ((QuotationHed)HeaderBindingSource.Current).NBTVal.ToString("C");
            //vATValTextBox.Text = ((QuotationHed)HeaderBindingSource.Current).VATVal.ToString("C");
            //totalValTextBox.Text = ((QuotationHed)HeaderBindingSource.Current).TotalVal.ToString("C");
        }

        private void FillDetails(QuotationHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.QuotationDets.ToList();

                foreach (QuotationDet d in detData)
                    tmpDetData.Add(new ItemGrid(d.Item, d.CostPrice, d.SelPrice, d.ItemDiscPer, d.NBTPer, d.VATPer, d.Quantity, db.ItemQOHs.Single(q => q.BranchCode == hedData.BranchCode && q.LocationCode == hedData.LocationCode && q.ItemCode == d.ItemCode).QOH));
            }

            alreadyFilling = false;
        }

        public override DataRow SearchReferences(string mode)
        {
            var searchList = db.QuotationHeds.Where(h => h.QuotationDets.Where(d => d.BalQty < d.Quantity).Count() == 0);
            if (mode == "Print")
                searchList = db.QuotationHeds;

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
                from d in db.QuotationDets
                where d.QuotationHed.ReferenceNo == referenceNoTextBox.Text
                select new
                {
                    d.QuotationHed.ReferenceNo,
                    d.QuotationHed.TxnDate,
                    d.QuotationHed.Remarks,
                    d.QuotationHed.ManualNo,
                    d.QuotationHed.LocationCode,
                    d.QuotationHed.Location.LocationName,
                    d.QuotationHed.BranchCode,
                    d.QuotationHed.Branch.BranchName,
                    d.QuotationHed.HedDiscPer,
                    d.QuotationHed.HedDiscTotVal,
                    d.QuotationHed.ItemDiscTotVal,
                    d.QuotationHed.NBTVal,
                    d.QuotationHed.TotalVal,
                    d.QuotationHed.VATVal,
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
            dt.TableName = "CustomerQuotation";

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\CustomerQuotation", dt, db, this.Text);
        }

        public override bool ValidateOnChange(string mode)
        {
            if (db.QuotationHeds.Single(x => x.ReferenceNo == referenceNoTextBox.Text).QuotationDets.Where(y => y.BalQty < y.Quantity).Count() > 0)
            {
                MessageBox.Show(string.Format("The {0} you selected has already been used in a Sales Order", this.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public override void ViewClick()
        {
            HeaderBindingSource.DataSource = db.QuotationHeds.ToList();
            FillDetails((QuotationHed)HeaderBindingSource.Current);
        }

        private void HeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!alreadyFilling)
                FillDetails((QuotationHed)HeaderBindingSource.Current);
        }

        public override bool BeforeDataSave()
        {
            ((QuotationHed)HeaderBindingSource.Current).ReferenceNo = referenceNoTextBox.Text;

            ((QuotationHed)HeaderBindingSource.Current).UserID = Program.UserID;

            ((QuotationHed)HeaderBindingSource.Current).AddedDate = DateTime.Now;

            ((QuotationHed)HeaderBindingSource.Current).AddedMachineInfo = Program.MachineName;

            ((QuotationHed)HeaderBindingSource.Current).QuotationDets.Clear();

            QuotationDet d;

            foreach (var x in tmpDetData)
            {
                d = new QuotationDet();
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
                ((QuotationHed)HeaderBindingSource.Current).QuotationDets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.QuotationHeds.AddObject((QuotationHed)HeaderBindingSource.Current);

            return true;
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

            ((QuotationHed)HeaderBindingSource.Current).ItemDiscTotVal = totItDis;
            ((QuotationHed)HeaderBindingSource.Current).HedDiscTotVal = totHedDis;
            ((QuotationHed)HeaderBindingSource.Current).NBTVal = totNbt;
            ((QuotationHed)HeaderBindingSource.Current).VATVal = totVat;
            ((QuotationHed)HeaderBindingSource.Current).TotalVal = totNet;

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

            return true;
        }

        public override void UndoClick()
        {
            HeaderBindingSource.DataSource = tmpHedData;
        }

    }
}
