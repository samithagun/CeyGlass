﻿using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySalesDebtorsSytem.Forms.Transactions.Manufacturing
{
    public partial class ProductionPlan : TransactionForm
    {

        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<ProductionPlanHed> tmpHedData = new BindingList<ProductionPlanHed>();
        BindingList<ReferenceItemGrid> tmpDetData = new BindingList<ReferenceItemGrid>();
        BindingList<ReferenceItemGrid> tmpStdordDetData = new BindingList<ReferenceItemGrid>();
        BindingList<ItemGrid> tmpSummaryDetData = new BindingList<ItemGrid>();
        BindingList<ItemGrid> tmpSummaryFinishGData = new BindingList<ItemGrid>();
        BindingList<ProductionPlanRawItem> tmpRawMaterialData = new BindingList<ProductionPlanRawItem>();
        BindingList<ItemGrid> tmpSummaryRawMatData = new BindingList<ItemGrid>();

        public ProductionPlan()
        {
            InitializeComponent();
        }

        private void ProductionPlan_Load(object sender, EventArgs e)
        {
            transactionToolBar1.bindingNavigator = HeaderBindingNavigator;
            transactionToolBar1.hedObjectBindingSource = productionPlanHedBindingSource;
            transactionToolBar1.detObjectBindingSource = FinishGoodItemBindingSource;
            transactionToolBar1.detDataGrid = FinishedGoodDataGridView;
            transactionToolBar1.primaryKeyControl = referenceNoTextBox;
            transactionToolBar1.primaryKeyField = "ReferenceNo";
            transactionToolBar1.firstFocusControl = txnDateDateTimePicker;
            transactionToolBar1.db = db;
            transactionToolBar1.branchCodeControl = txtBranchCode;
            transactionToolBar1.ReferenceID = "M-PPLAN";

            txtBranchCode.varList = from b in db.Branches select new { b.BranchCode, b.BranchName };
            txtBranchCode.codeFieldName = "BranchCode";
            txtBranchCode.controlList.Add(txtBranchName);
            txtBranchCode.fieldList.Add("BranchName");

            txtTypeCode.varList = from c in db.ItemTypes select new { c.TypeCode, c.TypeName };
            txtTypeCode.codeFieldName = "TypeCode";
            txtTypeCode.controlList.Add(txtTypeName);
            txtTypeCode.fieldList.Add("TypeName");

            productionPlanHedBindingSource.DataSource = tmpHedData;


            SOItemBindingSource.DataSource = tmpDetData;
            SoDataGridView.DataSource = SOItemBindingSource;

            SoDataGridView.Columns["RefferenceNo"].DataPropertyName = "RefferenceNo";
            SoDataGridView.Columns["ItemCode"].DataPropertyName = "ItemCode";
            SoDataGridView.Columns["ItemName"].DataPropertyName = "ItemName";
            SoDataGridView.Columns["Quantity"].DataPropertyName = "Quantity";

            StdOrderItemBindingSource.DataSource = tmpStdordDetData;
            StdOrderDataGridView.DataSource = StdOrderItemBindingSource;

            StdOrderDataGridView.Columns["StdRefferenceNo"].DataPropertyName = "RefferenceNo";
            StdOrderDataGridView.Columns["StdItemCode"].DataPropertyName = "ItemCode";
            StdOrderDataGridView.Columns["StdItemName"].DataPropertyName = "ItemName";
            StdOrderDataGridView.Columns["StdQuantity"].DataPropertyName = "Quantity";

            FinishGoodItemBindingSource.DataSource = tmpSummaryFinishGData;
            FinishedGoodDataGridView.DataSource = FinishGoodItemBindingSource;

            FinishedGoodDataGridView.Columns["FGItemCode"].DataPropertyName = "ItemCode";
            FinishedGoodDataGridView.Columns["FGItemName"].DataPropertyName = "ItemName";
            // FinishedGoodDataGridView.Columns["FgQOH"].DataPropertyName = "QOH";
            FinishedGoodDataGridView.Columns["FgQuantity"].DataPropertyName = "Quantity";

            RawItemBindingSource.DataSource = tmpSummaryRawMatData;
            RawMaterialDataGridView.DataSource = RawItemBindingSource;

            RawMaterialDataGridView.Columns["RItemCode"].DataPropertyName = "ItemCode";
            RawMaterialDataGridView.Columns["RItemName"].DataPropertyName = "ItemName";            
            RawMaterialDataGridView.Columns["RQuantity"].DataPropertyName = "Quantity";
            RawMaterialDataGridView.Columns["RQOH"].DataPropertyName = "QOH";
        }



        #region Methods
        private void GetReleventSalesOrders()
        {
            DateTime delDate = txnDateDateTimePicker.Value.Date;
            var salesorderList = (from d in db.SalesOrderDets
                                  join i in db.Items on d.ItemCode equals i.ItemCode
                                  where d.SalesOrderHed.DelieveryDate == delDate
                                      && d.Item.TypeCode == txtTypeCode.Text && d.SalesOrderHed.BranchCode == txtBranchCode.Text
                                  select new { d.ReferenceNo, d.ItemCode, i.ItemName, d.Quantity }).ToList();

            var standardOrdList = (from h in db.SPSHeds
                                   join i in db.Items on h.ItemCode equals i.ItemCode
                                   join d in db.SPSDets
                                   on h.ReferenceNo equals d.ReferenceNo
                                   where i.TypeCode == txtTypeCode.Text && d.Date == delDate
                                   select new { d.ReferenceNo, h.ItemCode, i.ItemName, d.Qty }).ToList();

            tmpDetData.Clear();
            foreach (var item in salesorderList)
            {
                tmpDetData.Add(new ReferenceItemGrid(item.ReferenceNo, item.ItemCode, item.ItemName, item.Quantity));
                tmpSummaryDetData.Add(new ItemGrid(item.ItemCode, item.ItemName, item.Quantity, 0));
            }

            tmpStdordDetData.Clear();
            foreach (var stdItem in standardOrdList)
            {
                tmpStdordDetData.Add(new ReferenceItemGrid(stdItem.ReferenceNo, stdItem.ItemCode, stdItem.ItemName, stdItem.Qty));
                tmpSummaryDetData.Add(new ItemGrid(stdItem.ItemCode, stdItem.ItemName, stdItem.Qty, 0));
            }

            tmpSummaryFinishGData.Clear();
            var finalVal = from s in tmpSummaryDetData
                           group s by new { s.ItemCode, s.ItemName }
                               into g
                               select new { g.Key.ItemCode, g.Key.ItemName, Quantity = g.Sum(s => s.Quantity) };


            foreach (var sumItem in finalVal)
            {
                tmpSummaryFinishGData.Add(new ItemGrid(sumItem.ItemCode, sumItem.ItemName, sumItem.Quantity, 0));
               
            }

            tmpRawMaterialData.Clear();
            tmpSummaryRawMatData.Clear();
            foreach (ItemGrid i in tmpSummaryFinishGData)
            {
                var boqData = from d in db.BoqDets
                              join h in db.BoqHeds on
                              d.BoqCode equals h.BoqCode
                              where h.BoqCode == i.ItemCode
                              select new { h.BoqCode, h.UsableQty, h.ToalQty, d.ItemCode, d.Quantity, d.Item.CostPrice };
                foreach (var raw in boqData)
                {
                    ProductionPlanRawItem rItem = new ProductionPlanRawItem();
                    rItem.FinishedItemCode = i.ItemCode;
                    rItem.RawItemCode = raw.ItemCode;
                    decimal reqQty;
                    if (raw.UsableQty > 0)
                        reqQty = (raw.Quantity / raw.UsableQty) * i.Quantity;
                    else
                        reqQty = (raw.Quantity / 1) * i.Quantity;

                    rItem.Quantity = reqQty;
                    rItem.CostPrice = raw.CostPrice;
                    tmpRawMaterialData.Add(rItem);
                }
            }

            var rawmatSum = from rdet in tmpRawMaterialData
                            group rdet by new {rdet.RawItemCode} into g
                            select new {g.Key.RawItemCode, Quantity = g.Sum(s => s.Quantity)};


            foreach (var rawS in rawmatSum)
            {
                decimal QOH = db.ItemQOHs.Single(q => q.BranchCode == "100" && q.LocationCode == "LOC01     " && q.ItemCode == rawS.RawItemCode).QOH;
                string itemName = db.Items.Single(i => i.ItemCode == rawS.RawItemCode).ItemName;
                tmpSummaryRawMatData.Add(new ItemGrid(rawS.RawItemCode, itemName, rawS.Quantity, QOH));
            }
        }

        public override void EnableControls(bool enable)
        {
            txtBranchCode.Enabled = enable;
            txtTypeCode.Enabled = enable;
            txnDateDateTimePicker.Enabled = enable;

        }
        #endregion

        private void txtTypeCode_Leave(object sender, EventArgs e)
        {
            GetReleventSalesOrders();
        }

        private void SoDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Helpers.FillGridRecordNo(SoDataGridView, "RecordNo");
        }

        private void StdOrderDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Helpers.FillGridRecordNo(StdOrderDataGridView, "RECNO");
        }

        private void FinishedGoodDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Helpers.FillGridRecordNo(FinishedGoodDataGridView, "FinishGRecNo");
        }
    }
}
