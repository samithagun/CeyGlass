using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLayer;

namespace InventorySalesDebtorsSytem
{
    public partial class TransactionToolBar : UserControl
    {
        public BindingNavigator bindingNavigator { get; set; }
        public BindingSource hedObjectBindingSource { get; set; }
        public BindingSource detObjectBindingSource { get; set; }
        public DataGridView detDataGrid { get; set; }
        public Control primaryKeyControl { get; set; }
        public string primaryKeyField { get; set; }
        public Control firstFocusControl { get; set; }
        public Control branchCodeControl { get; set; }
        public string ReferenceID { get; set; }
        public InventorySalesDebtorsSystemEntities db { get; set; }
        private TransactionForm parentForm;
        public string mode { get; set; }
        public bool HideAddButton { get; set; }
        public bool HideEditButton { get; set; }
        public bool HideDeleteButton { get; set; }
        public bool HidePrintButton { get; set; }
        public bool HideViewButton { get; set; }

        public TransactionToolBar()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            try
            {
                parentForm = (TransactionForm)this.ParentForm;

                btnAdd.Visible = !HideAddButton;
                btnEdit.Visible = !HideEditButton;
                btnDelete.Visible = !HideDeleteButton;
                btnPrint.Visible = !HidePrintButton;
                btnView.Visible = !HideViewButton;

                var ua = db.UserAccesses.Where(u => u.UserID == Program.UserID && u.sOption.sEntry.EntryDescription == this.ParentForm.Text);
                if (btnAdd.Visible)
                {
                    btnAdd.Visible = false;
                    if (ua.Where(u => u.sOption.OptionDescription == "Add").Count() == 1)
                        if (ua.Single(u => u.sOption.OptionDescription == "Add").Authorize)
                            btnAdd.Visible = true;
                }

                if (btnEdit.Visible)
                {
                    btnEdit.Visible = false;
                    if (ua.Where(u => u.sOption.OptionDescription == "Edit").Count() == 1)
                        if (ua.Single(u => u.sOption.OptionDescription == "Edit").Authorize)
                            btnEdit.Visible = true;
                }

                if (btnDelete.Visible)
                {
                    btnDelete.Visible = false;
                    if (ua.Where(u => u.sOption.OptionDescription == "Delete").Count() == 1)
                        if (ua.Single(u => u.sOption.OptionDescription == "Delete").Authorize)
                            btnDelete.Visible = true;
                }

                if (btnPrint.Visible)
                {
                    btnPrint.Visible = false;
                    if (ua.Where(u => u.sOption.OptionDescription == "Print").Count() == 1)
                        if (ua.Single(u => u.sOption.OptionDescription == "Print").Authorize)
                            btnPrint.Visible = true;
                }

                if (btnView.Visible)
                {
                    btnView.Visible = false;
                    if (ua.Where(u => u.sOption.OptionDescription == "View").Count() == 1)
                        if (ua.Single(u => u.sOption.OptionDescription == "View").Authorize)
                            btnView.Visible = true;
                }

                bindingNavigator.Visible = btnView.Visible;

                if (!btnAdd.Visible && !btnEdit.Visible)
                {
                    btnSave.Visible = false;
                    if (!btnView.Visible)
                        btnUndo.Visible = false;
                }

                EnableButtons(true);
                EnableControls(false);
                this.Top = 2;
                this.Left = 2;
                this.Width = 388;
                this.Height = 52;
                bindingNavigator.Dock = DockStyle.None;
                bindingNavigator.Top = 16;
                bindingNavigator.Left = 400;
                List<Control> ctrls = Helpers.GetAllControls(this.ParentForm.Controls);
                var a = ctrls.Where(ctrl => ctrl.GetType().Name == "NumericUpDown");
                foreach (Control ctrl in a)
                    ctrl.Enter += new System.EventHandler(numericUpDown_Enter);
                primaryKeyControl.Enter += new System.EventHandler(this.primaryKeyControl_Enter);
                primaryKeyControl.Leave += new System.EventHandler(this.primaryKeyControl_Leave);
                primaryKeyControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.primaryKeyControl_KeyUp);
                primaryKeyControl.DoubleClick += new System.EventHandler(this.primaryKeyControl_DoubleClick);
                mode = "Init";
                List<Button> btnList = new List<Button>();
                btnList.Add(btnAdd);
                btnList.Add(btnEdit);
                btnList.Add(btnDelete);
                btnList.Add(btnUndo);
                btnList.Add(btnSave);
                btnList.Add(btnPrint);
                btnList.Add(btnView);

                btnList = btnList.Where(b => b.Visible).ToList();
                int Left = 0;
                foreach (Button button in btnList)
                {
                    button.Left = Left;
                    Left += button.Width + 5;
                }
                this.Width = Left;
                bindingNavigator.Left = this.Left + this.Width + 5;
                //primaryKeyControl.Leave += new System.EventHandler(this.primaryKeyControl_Leave);
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
            }
        }

        private void numericUpDown_Enter(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            num.Select(0, num.Value.ToString().Length);
        }

        private void primaryKeyControl_Enter(object sender, EventArgs e)
        {

        }

        private void primaryKeyControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)
            {
                if (mode == "Edit")
                    SearchAndEditData();
                if (mode == "Delete")
                    SearchAndDeleteData();
                if (mode == "Print")
                    SearchAndPrintData();
            }
        }

        private void primaryKeyControl_DoubleClick(object sender, EventArgs e)
        {
            if (mode == "Edit")
                SearchAndEditData();
            if (mode == "Delete")
                SearchAndDeleteData();
            if (mode == "Print")
                SearchAndPrintData();
        }

        private void primaryKeyControl_Leave(object sender, EventArgs e)
        {
            try
            {
                parentForm.LoadData();
            }
            catch (Exception)
            {
                UndoTransaction();
                return;
            }
            if (mode == "Edit")
                EditData();
            if (mode == "Delete")
                DeleteData();
            if (mode == "Print")
                PrintData();
        }

        private void TransactionToolBar_Load(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            List<Control> ctrls = Helpers.GetAllControls(this.ParentForm.Controls);
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.DataBindings.Count > 0)
                {
                    switch (ctrl.GetType().ToString())
                    {
                        case "System.Windows.Forms.TextBox":
                            ((TextBox)ctrl).Text = string.Empty;
                            break;
                        case "System.Windows.Forms.DateTimePicker":
                            ((DateTimePicker)ctrl).Value = DateTime.Today;
                            break;
                    }
                }
            }
        }

        private void EnableControls(bool enable)
        {
            List<Control> ctrls = Helpers.GetAllControls(this.ParentForm.Controls);
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.DataBindings.Count > 0)
                    ctrl.Enabled = enable;
            }
            primaryKeyControl.Enabled = false;

            parentForm.EnableControls(enable);
        }

        private void EnableButtons(bool enable)
        {
            btnAdd.Enabled = enable;
            btnDelete.Enabled = enable;
            btnEdit.Enabled = enable;
            btnSave.Enabled = !enable;
            btnUndo.Enabled = !enable;
            btnPrint.Enabled = enable;
            btnView.Enabled = enable;
            bindingNavigator.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            EnableButtons(false);
            hedObjectBindingSource.AddNew();
            EnableControls(true);
            RefreshData();
            parentForm.AddClick();
            firstFocusControl.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (mode == "View")
            {
                string refNo = primaryKeyControl.Text;
                UndoTransaction();
                primaryKeyControl.Text = refNo;
                mode = "Edit";
                EnableButtons(false);
                EditData();
            }
            else
            {
                mode = "Edit";
                EnableButtons(false);
                parentForm.EditClick();
                //SearchAndEditData();
                primaryKeyControl.Enabled = true;
                if (primaryKeyControl.GetType().Name == "TextBox")
                    ((TextBox)primaryKeyControl).ReadOnly = false;
                primaryKeyControl.Focus();
            }
        }

        private void SearchAndEditData()
        {
            DataRow dr = parentForm.SearchReferences(mode);
            if (dr != null)
            {
                primaryKeyControl.Text = dr[primaryKeyField].ToString();
                EditData();
            }
            else
                UndoTransaction();
        }

        private void EditData()
        {
            parentForm.LoadData();
            if (!parentForm.ValidateOnChange(mode))
            {
                UndoTransaction();
                return;
            }
            EnableControls(true);
            firstFocusControl.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mode == "View")
            {
                string refNo = primaryKeyControl.Text;
                UndoTransaction();
                primaryKeyControl.Text = refNo;
                mode = "Delete";
                EnableButtons(false);
                btnSave.Enabled = false;
                DeleteData();
                UndoTransaction();
            }
            else
            {
                mode = "Delete";
                EnableButtons(false);
                btnSave.Enabled = false;
                //SearchAndDeleteData();
                primaryKeyControl.Enabled = true;
                if (primaryKeyControl.GetType().Name == "TextBox")
                    ((TextBox)primaryKeyControl).ReadOnly = false;
                primaryKeyControl.Focus();
            }
        }

        private void SearchAndDeleteData()
        {
            DataRow dr = parentForm.SearchReferences(mode);
            if (dr != null)
            {
                primaryKeyControl.Text = dr[primaryKeyField].ToString();
                DeleteData();
            }
            UndoTransaction();
        }

        private void DeleteData()
        {
            parentForm.LoadData();
            if (!parentForm.ValidateOnChange(mode))
            {
                UndoTransaction();
                return;
            }
            if (MessageBox.Show("Are you sure you want to Delete this record?", this.ParentForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                db.Connection.Open();
                System.Data.Common.DbTransaction transaction = db.Connection.BeginTransaction();
                try
                {
                    if (!parentForm.BeforeDataDelete())
                        throw new Exception("Error @ BeforeDataDelete");
                    db.DeleteObject(hedObjectBindingSource.Current);
                    if (!parentForm.AfterDataDelete())
                        throw new Exception("Error @ AfterDataDelete");
                    int noOfRecordSaved = db.SaveChanges();
                    if (noOfRecordSaved <= 0)
                        throw new Exception("Error - No records to save");
                    transaction.Commit();
                    MessageBox.Show("Deleted Successfully", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Helpers.WriteException(ex);
                    transaction.Rollback();
                    MessageBox.Show("Delete Failed", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Connection.Close();
                bindingNavigator.Focus();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoTransaction();
        }

        private void UndoTransaction()
        {
            bindingNavigator.Enabled = false;
            if (detDataGrid != null)
                detDataGrid.AllowUserToDeleteRows = true;
            if ((mode == "Edit") && (hedObjectBindingSource.Current != null))
                db.Refresh(System.Data.Objects.RefreshMode.StoreWins, hedObjectBindingSource.Current);
            if (mode == "Add")
                hedObjectBindingSource.CancelEdit();
            if (detObjectBindingSource != null)
                detObjectBindingSource.Clear();
            hedObjectBindingSource.Clear();
            EnableButtons(true);
            EnableControls(false);
            primaryKeyControl.Text = "";
            parentForm.UndoClick();
            parentForm.ClearData();
            mode = "Init";
            primaryKeyControl.Enabled = false;
            if (primaryKeyControl.GetType().Name == "TextBox")
                ((TextBox)primaryKeyControl).ReadOnly = true;
            btnAdd.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Focus();
            if (!parentForm.ValidateOnSave(mode))
                return;

            List<Control> ctrls = Helpers.GetAllControls(this.ParentForm.Controls);
            foreach (Control ctrl in ctrls)
            {
                foreach (Binding binding in ctrl.DataBindings)
                    binding.WriteValue();
            }
            db.Connection.Open();
            System.Data.Common.DbTransaction transaction = db.Connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                string ReferenceNo = null;
                if (this.mode == "Add")
                {
                    ReferenceNo = Helpers.GenerateNewNo(db, ReferenceID, branchCodeControl.Text);
                    if (ReferenceNo == null)
                        throw new Exception("Error generating Reference No");
                    primaryKeyControl.Text = ReferenceNo;
                }
                if (!parentForm.BeforeDataSave())
                    throw new Exception("Error @ BeforeDataSave");

                //ITransaction Txn = (ITransaction)hedObjectBindingSource.Current;

                //Txn.SetAddedDate(DateTime.Now);
                //Txn.SetAddedMachineInfo(Program.MachineName);
                //Txn.SetUserID(Program.UserID);

                hedObjectBindingSource.EndEdit();
                if (!parentForm.AfterDataSave())
                    throw new Exception("Error @ AfterDataSave");
                int noOfRecordSaved = db.SaveChanges();
                if (noOfRecordSaved <= 0)
                    throw new Exception("Error - No records to save");
                transaction.Commit();
                MessageBox.Show("Saved Successfully", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
                UndoTransaction();
                EnableButtons(true);
                EnableControls(false);
                bindingNavigator.Focus();
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                transaction.Rollback();
                MessageBox.Show("Save Failed", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.Connection.Close();
            hedObjectBindingSource.ResetCurrentItem();
        }

        private void TransactionToolBar_VisibleChanged(object sender, EventArgs e)
        {
            if (bindingNavigator != null)
                Initialize();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //SearchAndPrintData();
            if (mode == "View")
            {
                string refNo = primaryKeyControl.Text;
                UndoTransaction();
                primaryKeyControl.Text = refNo;
                mode = "Print";
                EnableButtons(false);
                btnSave.Enabled = false;
                PrintData();
                UndoTransaction();
            }
            else
            {
                mode = "Print";
                EnableButtons(false);
                btnSave.Enabled = false;
                primaryKeyControl.Enabled = true;
                if (primaryKeyControl.GetType().Name == "TextBox")
                    ((TextBox)primaryKeyControl).ReadOnly = false;
                primaryKeyControl.Focus();
            }
        }

        private void SearchAndPrintData()
        {
            EnableButtons(false);
            btnSave.Enabled = false;
            DataRow dr = parentForm.SearchReferences(mode);
            if (dr != null)
            {
                primaryKeyControl.Text = dr[primaryKeyField].ToString();
                PrintData();
            }
            UndoTransaction();
        }

        private void PrintData()
        {
            parentForm.LoadData();
            parentForm.PrintData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            mode = "View";
            EnableButtons(false);
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnPrint.Enabled = true;
            parentForm.ViewClick();
            if (hedObjectBindingSource.Count > 0)
            {
                if (detDataGrid != null)
                    detDataGrid.AllowUserToDeleteRows = false;
                bindingNavigator.Enabled = true;
                btnSave.Enabled = false;
                hedObjectBindingSource.MoveLast();
                bindingNavigator.Focus();
            }
            else
                UndoTransaction();
        }
    }
}
