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
    public partial class SPS : TransactionForm
    {
        private InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<SPSHed> tmpHedData = new BindingList<SPSHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        bool alreadyFilling = false;

        public SPS()
        {
            InitializeComponent();
        }

        private void SPS_Load(object sender, EventArgs e)
        {
            transactionToolBar1.bindingNavigator = SPSBindingNavigator;
            transactionToolBar1.hedObjectBindingSource = SPSBindingSource;
            transactionToolBar1.detObjectBindingSource = SPSDetBindingSource;
            transactionToolBar1.detDataGrid = SPSDataGridView;
            transactionToolBar1.primaryKeyControl = referenceNoTextBox;
            transactionToolBar1.primaryKeyField = "ReferenceNo";
            transactionToolBar1.firstFocusControl = txtItemCode;
            transactionToolBar1.db = db;
            transactionToolBar1.branchCodeControl = txtBranchCode;
            transactionToolBar1.ReferenceID = "M-SPS";

            txtItemCode.varList = from i in db.Items where i.IsRawMaterial == false select new { i.ItemCode, i.ItemName };
            txtItemCode.codeFieldName = "ItemCode";
            txtItemCode.controlList.Add(txtItemName);
            txtItemCode.fieldList.Add("ItemName");

            SPSBindingSource.DataSource = db.SPSHeds;
            SPSDetBindingSource.DataSource = tmpDetData;
            SPSDataGridView.DataSource = SPSDetBindingSource;

            SPSDataGridView.Columns["Date"].DataPropertyName = "Date";
            SPSDataGridView.Columns["Quantity"].DataPropertyName = "Quantity";

        }

        public override void EnableControls(bool enable)
        {
            txtItemCode.Enabled = enable;

            txtTotalQty.Enabled = enable;
            dateTimeFromPicker.Enabled = enable;
            dateTimeToPicker.Enabled = enable;
        }

        private void dateTimeToPicker_ValueChanged(object sender, EventArgs e)
        {
            if (transactionToolBar1.mode == "Add")
            {
                DateTime dateFrom = dateTimeFromPicker.Value.Date;
                DateTime dateTo = dateTimeToPicker.Value.Date;
                decimal Qty = 0;
                
                if (!String.IsNullOrEmpty(txtTotalQty.Text))
                {
                    Qty = Convert.ToDecimal(txtTotalQty.Text);
                }

                if (dateTo > dateFrom && Qty > 0)
                {

                    double Days = (dateTo - dateFrom).TotalDays;
                    decimal dayQty = Math.Round(Qty / Convert.ToDecimal(Days), 2);

                    tmpDetData.Clear();

                    for (int i = 0; i < Days; i++)
                    {
                        tmpDetData.Add(new ItemGrid(dateFrom.AddDays(i), dayQty));
                    }
                }
            }
        }

        public override bool BeforeDataSave()
        {
            ((SPSHed)SPSBindingSource.Current).ReferenceNo = referenceNoTextBox.Text;

            ((SPSHed)SPSBindingSource.Current).UserID = Program.UserID;

            ((SPSHed)SPSBindingSource.Current).AddedDate = DateTime.Now;

            ((SPSHed)SPSBindingSource.Current).AddedMachineInfo = Program.MachineName;

            ((SPSHed)SPSBindingSource.Current).SPSDets.Clear();

            SPSDet d;

            foreach (var x in tmpDetData)
            {
                d = new SPSDet();
                d.ReferenceNo = referenceNoTextBox.Text;
                d.Date = x.Date;
                d.Qty = x.Quantity;
                ((SPSHed)SPSBindingSource.Current).SPSDets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.SPSHeds.AddObject((SPSHed)SPSBindingSource.Current);
            return true;
        }

        public override void ViewClick()
        {
            SPSBindingSource.DataSource = db.SPSHeds.ToList();
            FillDetails((SPSHed)SPSBindingSource.Current);
        }

        private void FillDetails(SPSHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.SPSDets.ToList();

                foreach (SPSDet d in detData)
                    tmpDetData.Add(new ItemGrid(d.Date, d.Qty));
            }

            alreadyFilling = false;
        }

        public override void ClearData()
        {
            txtItemCode.Text = "";
            txtItemName.Text = "";
            dateTimeFromPicker.Value = DateTime.Today.Date;
            dateTimeToPicker.Value = DateTime.Today.Date;
            txtTotalQty.Text = "";
            referenceNoTextBox.Text = "";
        }
    }
}
