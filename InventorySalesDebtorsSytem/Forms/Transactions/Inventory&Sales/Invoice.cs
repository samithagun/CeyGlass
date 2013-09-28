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
    public partial class Invoice : TransactionForm
    {
        string branchCode, locationCode, salOrdNo;

        bool alreadyFilling = false;

        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<InvoiceHed> tmpHedData = new BindingList<InvoiceHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        public Invoice()
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
            transactionToolBar1.ReferenceID = "S-INV";

            txtSalOrdNo.codeFieldName = "ReferenceNo";
            txtSalOrdNo.sortOrder = "ReferenceNo Desc";
            txtSalOrdNo.controlList.Add(txtBranchCode);
            txtSalOrdNo.fieldList.Add("BranchCode");
            txtSalOrdNo.controlList.Add(txtLocationCode);
            txtSalOrdNo.fieldList.Add("LocationCode");
            txtSalOrdNo.controlList.Add(txtRepCode);
            txtSalOrdNo.fieldList.Add("RepCode");
            txtSalOrdNo.controlList.Add(txtCustomerCode);
            txtSalOrdNo.fieldList.Add("CustomerCode");
            txtSalOrdNo.controlList.Add(numHedDiscPer);
            txtSalOrdNo.fieldList.Add("HedDiscPer");

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
            numQty.Enabled = enable;
            btnAddItem.Enabled = enable;

            itemDiscTotValTextBox.Enabled = false;
            hedDiscTotValTextBox.Enabled = false;
            nBTValTextBox.Enabled = false;
            vATValTextBox.Enabled = false;
            totalValTextBox.Enabled = false;

            txtBranchCode.Enabled = enable;
            txtLocationCode.Enabled = enable;
            txtRepCode.Enabled = enable;
            txtCustomerCode.Enabled = enable;
            numHedDiscPer.Enabled = enable;

            numItemDiscPer.Enabled = enable;
            numUnitPrice.Enabled = enable;
        }

        public override void AddClick()
        {
            ((InvoiceHed)HeaderBindingSource.Current).HedDiscPer = 0.00m;
            ((InvoiceHed)HeaderBindingSource.Current).ManualNo = "";
            ((InvoiceHed)HeaderBindingSource.Current).Remarks = "";
        }

        private void GenerateItemCodeVarList()
        {
            if ((branchCode != txtBranchCode.Text) || (locationCode != txtLocationCode.Text) || (salOrdNo != txtSalOrdNo.Text))
            {
                if (txtBranchCode.Text != "" && txtLocationCode.Text != "")
                    if (txtSalOrdNo.Text != "")
                        txtItemCode.varList = from q in db.SalesOrderDets.Where(d => d.ReferenceNo == txtSalOrdNo.Text && d.BalQty > 0) join i in db.Items on q.ItemCode equals i.ItemCode join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, SellingPrice = q.SelPrice, BalanceQuantity = q.BalQty, q.ItemDiscPer };
                    else
                        txtItemCode.varList = (from i in db.Items join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, SellingPrice = i.SelPrice, BalanceQuantity = 0.00m, ItemDiscPer = 0.00m }).ToList();
                else
                    txtItemCode.varList = null;
                branchCode = txtBranchCode.Text;
                locationCode = txtLocationCode.Text;
                salOrdNo = txtSalOrdNo.Text;
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
            var hedData = db.InvoiceHeds.Single(h => h.ReferenceNo == referenceNoTextBox.Text);

            tmpHedData.Add(hedData);

            HeaderBindingSource.MoveLast();

            branchCode = txtBranchCode.Text;
            locationCode = txtLocationCode.Text;

            //FillDetails(hedData);

            branchCode = txtBranchCode.Text;
            locationCode = txtLocationCode.Text;
            salOrdNo = txtSalOrdNo.Text;

            GenerateLocationCodeVarList();
            if (txtSalOrdNo.Text.Trim() != "")
                txtItemCode.varList = from q in db.SalesOrderDets.Where(d => d.ReferenceNo == txtSalOrdNo.Text && d.BalQty > 0) join i in db.Items on q.ItemCode equals i.ItemCode join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, SellingPrice = q.SelPrice, BalanceQuantity = q.BalQty, q.ItemDiscPer };
            else
                txtItemCode.varList = (from i in db.Items join s in db.ItemQOHs.Where(q => q.BranchCode == txtBranchCode.Text && q.LocationCode == txtLocationCode.Text) on i.ItemCode equals s.ItemCode where i.Status == "Active" select new { i.ItemCode, i.ItemName, s.QOH, SellingPrice = i.SelPrice, BalanceQuantity = 0.00m, ItemDiscPer = 0.00m }).ToList();

            txtBranchCode.Validate();
            txtLocationCode.Validate();
            txtRepCode.Validate();
            txtCustomerCode.Validate();

            Calculate();

            //itemDiscTotValTextBox.Text = ((InvoiceHed)HeaderBindingSource.Current).ItemDiscTotVal.ToString("C");
            //hedDiscTotValTextBox.Text = ((InvoiceHed)HeaderBindingSource.Current).HedDiscTotVal.ToString("C");
            //nBTValTextBox.Text = ((InvoiceHed)HeaderBindingSource.Current).NBTVal.ToString("C");
            //vATValTextBox.Text = ((InvoiceHed)HeaderBindingSource.Current).VATVal.ToString("C");
            //totalValTextBox.Text = ((InvoiceHed)HeaderBindingSource.Current).TotalVal.ToString("C");
        }

        private void FillDetails(InvoiceHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.InvoiceDets.ToList();

                foreach (InvoiceDet d in detData)
                    tmpDetData.Add(new ItemGrid(d.Item, d.CostPrice, d.SelPrice, d.ItemDiscPer, d.NBTPer, d.VATPer, d.Quantity, db.ItemQOHs.Single(q => q.BranchCode == hedData.BranchCode && q.LocationCode == hedData.LocationCode && q.ItemCode == d.ItemCode).QOH));
            }

            alreadyFilling = false;
        }

        public override DataRow SearchReferences(string mode)
        {
            var searchList = db.InvoiceHeds.Where(h => h.InvoiceDets.Where(d => d.BalQty1 < d.Quantity || d.BalQty2 < d.Quantity).Count() == 0);
            if (mode == "Print")
                searchList = db.InvoiceHeds;

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
                from d in db.InvoiceDets
                where d.InvoiceHed.ReferenceNo == referenceNoTextBox.Text
                select new
                {
                    d.InvoiceHed.ReferenceNo,
                    d.InvoiceHed.TxnDate,
                    d.InvoiceHed.Remarks,
                    d.InvoiceHed.ManualNo,
                    d.InvoiceHed.SalesOrderNo,
                    d.InvoiceHed.LocationCode,
                    d.InvoiceHed.Location.LocationName,
                    d.InvoiceHed.BranchCode,
                    d.InvoiceHed.Branch.BranchName,
                    d.InvoiceHed.HedDiscPer,
                    d.InvoiceHed.HedDiscTotVal,
                    d.InvoiceHed.ItemDiscTotVal,
                    d.InvoiceHed.NBTVal,
                    d.InvoiceHed.TotalVal,
                    d.InvoiceHed.VATVal,
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
            dt.TableName = "Invoice";

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\Invoice", dt, db, this.Text);
        }

        public override bool ValidateOnChange(string mode)
        {
            if (db.InvoiceHeds.Single(x => x.ReferenceNo == referenceNoTextBox.Text).InvoiceDets.Where(y => y.BalQty1 < y.Quantity).Count() > 0)
            {
                MessageBox.Show(string.Format("The {0} you selected has already been used in a Dispatch", this.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (db.InvoiceHeds.Single(x => x.ReferenceNo == referenceNoTextBox.Text).InvoiceDets.Where(y => y.BalQty2 < y.Quantity).Count() > 0)
            {
                MessageBox.Show(string.Format("The {0} you selected has already been used in a Sales Return", this.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (db.CusDebitNotes.Where(x => x.ReferenceNo == referenceNoTextBox.Text && x.TotalBalVal < x.TotalVal).Count() > 0)
            {
                MessageBox.Show(string.Format("The {0} you selected has already been Settled", this.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public override void ViewClick()
        {
            HeaderBindingSource.DataSource = db.InvoiceHeds.ToList();
            FillDetails((InvoiceHed)HeaderBindingSource.Current);
        }

        private void HeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!alreadyFilling)
                FillDetails((InvoiceHed)HeaderBindingSource.Current);
        }

        public override bool BeforeDataSave()
        {
            ((InvoiceHed)HeaderBindingSource.Current).ReferenceNo = referenceNoTextBox.Text;

            ((InvoiceHed)HeaderBindingSource.Current).UserID = Program.UserID;

            ((InvoiceHed)HeaderBindingSource.Current).AddedDate = DateTime.Now;

            ((InvoiceHed)HeaderBindingSource.Current).AddedMachineInfo = Program.MachineName;

            ((InvoiceHed)HeaderBindingSource.Current).InvoiceDets.Clear();

            InvoiceDet d;

            foreach (var x in tmpDetData)
            {
                d = new InvoiceDet();
                d.ItemCode = x.ItemCode;
                d.CostPrice = x.CostPrice;
                d.SelPrice = x.SelPrice;
                d.ItemDiscPer = x.ItemDiscPer;
                d.ItemDiscVal = x.ItemDiscVal;
                d.HedDiscVal = x.HedDiscVal;
                d.Quantity = x.Quantity;
                d.BalQty1 = x.Quantity;
                d.BalQty2 = x.Quantity;
                d.NBTPer = x.NbtPer;
                d.NBTItemVal = x.NbtItemVal;
                d.VATPer = x.VatPer;
                d.VATItemVal = x.VatItemVal;
                d.TotalItemVal = x.TotalItemVal;
                d.ReferenceNo = referenceNoTextBox.Text;
                ((InvoiceHed)HeaderBindingSource.Current).InvoiceDets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.InvoiceHeds.AddObject((InvoiceHed)HeaderBindingSource.Current);

            return true;
        }

        public override bool AfterDataSave()
        {
            try
            {
                InvoiceHed h = ((InvoiceHed)HeaderBindingSource.Current);

                if (txtSalOrdNo.Text != "")
                {
                    foreach (InvoiceDet d in h.InvoiceDets)
                    {
                        db.SalesOrderDets.Single(x => x.ReferenceNo == h.SalesOrderNo && x.ItemCode == d.ItemCode).BalQty -= d.Quantity;
                        //if (!BusinessRules.UpdateQOH(db, h.BranchCode, h.LocationCode, d.ItemCode, d.Quantity, (d.TotalItemVal - d.VATItemVal - d.NBTItemVal) / d.Quantity, true))
                        //    throw new Exception("Error @ UpdateQOH");
                    }
                }

                CusDebitNote cd = new CusDebitNote();

                if (transactionToolBar1.mode == "Edit")
                    db.DeleteObject(db.CusDebitNotes.Single(d => d.ReferenceNo == h.ReferenceNo));

                cd.ReferenceNo = h.ReferenceNo;
                cd.AddedDate = h.AddedDate;
                cd.AddedMachineInfo = h.AddedMachineInfo;
                cd.BranchCode = h.BranchCode;
                cd.CustomerCode = h.CustomerCode;
                cd.ManualNo = h.ManualNo;
                cd.NBTPer = 0.00m;
                cd.NBTVal = h.NBTVal;
                cd.Remarks = h.Remarks;
                cd.RepCode = h.RepCode;
                cd.TotalVal = h.TotalVal;
                cd.TotalBalVal = h.TotalVal;
                cd.TxnDate = h.TxnDate;
                cd.TxnType = "IN";
                cd.UserID = h.UserID;
                cd.VATPer = 0.00m;
                cd.VATVal = h.VATVal;

                db.CusDebitNotes.AddObject(cd);

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
                if (txtSalOrdNo.Text != "")
                {
                    foreach (var i in tmpDetData)
                    {
                        db.SalesOrderDets.Single(d => d.ReferenceNo == txtSalOrdNo.Text && d.ItemCode == i.ItemCode).BalQty += i.Quantity;
                        //if (!BusinessRules.UpdateQOH(db, txtBranchCode.Text, txtLocationCode.Text, i.ItemCode, i.Quantity, (i.TotalItemVal - i.VatItemVal - i.NbtItemVal) / i.Quantity, true))
                        //    throw new Exception("Error @ UpdateQOH");
                    }
                }

                db.DeleteObject(db.CusDebitNotes.Single(cd => cd.ReferenceNo == referenceNoTextBox.Text && cd.TxnType == "IN"));

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

            ((InvoiceHed)HeaderBindingSource.Current).ItemDiscTotVal = totItDis;
            ((InvoiceHed)HeaderBindingSource.Current).HedDiscTotVal = totHedDis;
            ((InvoiceHed)HeaderBindingSource.Current).NBTVal = totNbt;
            ((InvoiceHed)HeaderBindingSource.Current).VATVal = totVat;
            ((InvoiceHed)HeaderBindingSource.Current).TotalVal = totNet;

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

            if (txtSalOrdNo.Text != "")
            {
                decimal QuoQty = db.SalesOrderDets.Single(p => p.ReferenceNo == txtSalOrdNo.Text && p.ItemCode == txtItemCode.Text).BalQty;

                if (numQty.Value + detQty > QuoQty)
                {
                    errorProvider1.SetError(numQty, "Sales Order Balance Quantity cannot be exceeded");//MessageBox.Show("PO Balance Quantity cannot be exceeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numQty.Value = QuoQty - detQty;
                    numQty.Focus();
                    return false;
                }
            }

            return true;
        }

        public override void UndoClick()
        {
            HeaderBindingSource.DataSource = tmpHedData;
        }

        private void txtSalOrdNo_Enter(object sender, EventArgs e)
        {
            txtSalOrdNo.varList = from q in db.SalesOrderHeds
                                  where q.SalesOrderDets.Where(d => d.BalQty > 0).Count() > 0
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

        private void txtSalOrdNo_Leave(object sender, EventArgs e)
        {
            bool enable = (txtSalOrdNo.Text == "");

            txtBranchCode.Enabled = enable;
            txtLocationCode.Enabled = enable;
            txtRepCode.Enabled = enable;
            txtCustomerCode.Enabled = enable;
            numHedDiscPer.Enabled = enable;

            numItemDiscPer.Enabled = enable;
            numUnitPrice.Enabled = enable;
        }

        private void txtSalOrdNo_TextChanged(object sender, EventArgs e)
        {
            txtSalOrdNo.Text = txtSalOrdNo.Text.TrimEnd();
        }

    }
}
