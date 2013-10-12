using DBLayer;
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
        BindingList<ItemGrid> tmpSummaryDetData = new BindingList<ItemGrid>();

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

            //var standardOrdList = (from h in db.SPSHeds
            //                       join i in db.Items on h.ItemCode equals i.ItemCode
            //                       where i.TypeCode == txtTypeCode.Text && h.SPSDets.Date == delDate
                                
            //                       select new { });

            int x = 0;
            foreach (var item in salesorderList)
            {
                x += 1;
                tmpDetData.Add(new ReferenceItemGrid(item.ReferenceNo, item.ItemCode, item.ItemName, item.Quantity));
                tmpSummaryDetData.Add(new ItemGrid(item.ItemCode, item.ItemName,0, item.Quantity));
            }
                

            SOItemBindingSource.DataSource = tmpDetData;
            SoDataGridView.DataSource = SOItemBindingSource;
            SoDataGridView.Refresh();

            
            SoDataGridView.Columns["ItemCode"].DataPropertyName = "ItemCode";
            //SoDataGridView.Columns["SONo"].DataPropertyName = "ReferenceNo";
            //SoDataGridView.Columns["ItemName"].DataPropertyName = "ItemName";
            //SoDataGridView.Columns["Quantity"].DataPropertyName = "Quantity";
            int w = 0;

        }
        #endregion

        private void txtTypeCode_Leave(object sender, EventArgs e)
        {
            GetReleventSalesOrders();
        }
    }
}
