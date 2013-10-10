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
    public partial class ProductionPlan : Form
    {
        string branchCode, locationCode;
        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

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


        }
    }
}
