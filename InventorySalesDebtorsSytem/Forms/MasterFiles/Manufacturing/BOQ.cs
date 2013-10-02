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
    public partial class BOQ : TransactionForm
    {
        private InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        BindingList<BoqHed> tmpHedData = new BindingList<BoqHed>();
        BindingList<ItemGrid> tmpDetData = new BindingList<ItemGrid>();

        bool alreadyFilling = false;

        public BOQ()
        {
            InitializeComponent();
        }

        private void BOQ_Load(object sender, EventArgs e)
        {
            BOQBindingSource.DataSource = db.BoqHeds;

            transactionToolBar1.bindingNavigator = BOQBindingNavigator;
            transactionToolBar1.hedObjectBindingSource = BOQBindingSource;
            transactionToolBar1.detObjectBindingSource = BOQDetBindingSource;
            transactionToolBar1.detDataGrid = BOQDataGridView;
            transactionToolBar1.primaryKeyControl = txtItemCode;
            transactionToolBar1.primaryKeyField = "BoqCode";
            transactionToolBar1.firstFocusControl = txtItemCode;
            transactionToolBar1.db = db;
            //transactionToolBar1.branchCodeControl = txtBranchCode;
            //transactionToolBar1.ReferenceID = "S-INV";

            txtItemCode.varList = from i in db.Items select new { i.ItemCode, i.ItemName };
            txtItemCode.codeFieldName = "ItemCode";
            txtItemCode.controlList.Add(txtItemName);
            txtItemCode.fieldList.Add("ItemName");

            txtRawItemCode.varList = from i in db.Items select new { i.ItemCode, i.ItemName };
            txtRawItemCode.codeFieldName = "ItemCode";

            BOQDetBindingSource.DataSource = tmpDetData;
            BOQDataGridView.DataSource = BOQDetBindingSource;

            BOQDataGridView.Columns["ItemCode"].DataPropertyName = "ItemCode";
            BOQDataGridView.Columns["ItemName"].DataPropertyName = "ItemName";
            BOQDataGridView.Columns["Quantity"].DataPropertyName = "Quantity";
        }

        public override void EnableControls(bool enable)
        {
            txtItemCode.Enabled = enable;

            txtUsableQty.Enabled = enable;
            txtUOM.Enabled = enable;
            txtDamageQty.Enabled = enable;
            txtDuration.Enabled = enable;
            txtStdCost.Enabled = enable;
            txtTotalQty.Enabled = enable;

            txtRawItemCode.Enabled = enable;
            numQty.Enabled = enable;
            btnAddItem.Enabled = enable;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtRawItemCode.Text == "")
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

            var Item = db.Items.Single(i => i.ItemCode == txtRawItemCode.Text);
            if (tmpDetData.Where(d => d.ItemCode == txtRawItemCode.Text).Count() == 0)
            {
                tmpDetData.Add(new ItemGrid(Item, numQty.Value, numQty.Value));
            }
            else
            {
                var detItem = tmpDetData.Single(d => d.ItemCode == txtRawItemCode.Text);
                tmpDetData.Remove(detItem);
                tmpDetData.Add(new ItemGrid(Item, numQty.Value, numQty.Value));
            }

            var ZeroItems = tmpDetData.Where(d => d.Quantity.CompareTo(0.00m) <= 0).ToList();
            foreach (ItemGrid i in ZeroItems)
                tmpDetData.Remove(i);

            txtRawItemCode.Text = "";
            numQty.Value = 0.00m;
            txtRawItemCode.Focus();

        }

        public override void ClearData()
        {
            txtItemCode.Enabled = false;
            btnAddItem.Enabled = false;

            txtItemCode.Text = "";
            txtRawItemCode.Text = "";
            txtItemName.Text = "";
        }

        public override bool BeforeDataSave()
        {
            
            ((BoqHed)BOQBindingSource.Current).BoqCode = txtItemCode.Text;

            ((BoqHed)BOQBindingSource.Current).UserID = Program.UserID;

            ((BoqHed)BOQBindingSource.Current).AddedDate = DateTime.Now;

            ((BoqHed)BOQBindingSource.Current).AddedMachineInfo = Program.MachineName;

            BoqDet d;

            foreach (var x in tmpDetData)
            {
                d = new BoqDet();
                d.BoqCode = txtItemCode.Text;
                d.ItemCode = x.ItemCode;
                d.Quantity = x.Quantity;
                ((BoqHed)BOQBindingSource.Current).BoqDets.Add(d);
            }

            if (transactionToolBar1.mode == "Add")
                db.BoqHeds.AddObject((BoqHed)BOQBindingSource.Current);
            return true;
        }

        public override void ViewClick()
        {
            BOQBindingSource.DataSource = db.BoqHeds.ToList();
            FillDetails((BoqHed)BOQBindingSource.Current);
        }

        private void FillDetails(BoqHed hedData)
        {
            alreadyFilling = true;

            if (hedData != null)
            {
                tmpDetData.Clear();

                var detData = hedData.BoqDets.ToList();

                foreach (BoqDet d in detData)
                    tmpDetData.Add(new ItemGrid(d.Item, d.Quantity, d.Quantity));
            }

            alreadyFilling = false;
        }
       
        public override bool ValidateOnSave(string mode)
        {
            transactionToolBar1.mode = "Save";
            return true;
        }
    }
}
