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
    public partial class MasterFileToolBar : UserControl
    {
        public BindingNavigator bindingNavigator;
        public BindingSource objectBindingSource;
        public Control primaryKeyControl;
        public Control firstFocusControl;
        public InventorySalesDebtorsSystemEntities db;
        private MasterFileForm parentForm;

        public MasterFileToolBar()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            try
            {
                parentForm = (MasterFileForm)this.ParentForm;

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

                if (!btnAdd.Visible && !btnEdit.Visible && !btnDelete.Visible && !btnPrint.Visible)
                {
                    bindingNavigator.Visible = false;
                    if (ua.Where(u => u.sOption.OptionDescription == "View").Count() == 1)
                        if (ua.Single(u => u.sOption.OptionDescription == "View").Authorize)
                            bindingNavigator.Visible = true;
                }

                EnableButtons(true);
                EnableControls(false);
                this.Top = 2;
                this.Left = 2;
                this.Height = 52;
                this.Width = 330;
                bindingNavigator.Dock = DockStyle.None;
                bindingNavigator.Top = 16;
                bindingNavigator.Left = 338;
            }
            catch (Exception) { }
        }

        private void MasterFileToolBar_Load(object sender, EventArgs e)
        {

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
            if (objectBindingSource.Count > 1)
            {
                btnDelete.Enabled = enable;
                btnEdit.Enabled = enable;
            }
            else
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            btnSave.Enabled = !enable;
            btnUndo.Enabled = !enable;
            bindingNavigator.Enabled = enable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            objectBindingSource.AddNew();
            EnableControls(true);
            primaryKeyControl.Enabled = true;
            primaryKeyControl.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            EnableControls(true);
            firstFocusControl.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete this record?", this.ParentForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                primaryKeyControl.Focus();
                db.Connection.Open();
                System.Data.Common.DbTransaction transaction = db.Connection.BeginTransaction();
                try
                {
                    if (!parentForm.BeforeDataDelete())
                        throw new Exception("Error @ BeforeDataDelete");
                    objectBindingSource.RemoveCurrent();
                    int noOfRecordSaved = db.SaveChanges();
                    if (noOfRecordSaved <= 0)
                        throw new Exception("No Records to Save");
                    if (!parentForm.AfterDataDelete())
                        throw new Exception("Error @ AfterDataDelete");
                    transaction.Commit();
                    MessageBox.Show("Deleted Successfully", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Helpers.WriteException(ex);
                    MessageBox.Show("Delete Failed", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Connection.Close();
                bindingNavigator.Focus();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            objectBindingSource.CancelEdit();

            if (objectBindingSource.Current != null)
                db.Refresh(System.Data.Objects.RefreshMode.StoreWins, objectBindingSource.Current);

            EnableButtons(true);
            EnableControls(false);
            bindingNavigator.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Focus();

            List<Control> ctrls = Helpers.GetAllControls(this.ParentForm.Controls);
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.DataBindings.Count > 0)
                    ctrl.DataBindings[0].WriteValue();
            }

            db.Connection.Open();
            System.Data.Common.DbTransaction transaction = db.Connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                if (!parentForm.BeforeDataSave())
                    throw new Exception("Error @ BeforeDataSave");

                IMasterFile MF = (IMasterFile)objectBindingSource.Current;

                MF.SetAddedDate(DateTime.Now);
                MF.SetAddedMachineInfo(Program.MachineName);
                MF.SetUserID(Program.UserID);

                objectBindingSource.EndEdit();

                if (!parentForm.AfterDataSave())
                    throw new Exception("Error @ AfterDataSave");

                int noOfRecordSaved = db.SaveChanges();
                if (noOfRecordSaved <= 0)
                    throw new Exception("No Records to Save");

                transaction.Commit();

                MessageBox.Show("Saved Successfully", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnableButtons(true);
                EnableControls(false);
                bindingNavigator.Focus();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Helpers.WriteException(ex);
                MessageBox.Show("Save Failed", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.Connection.Close();
            objectBindingSource.ResetCurrentItem();
        }

        private void MasterFileToolBar_VisibleChanged(object sender, EventArgs e)
        {
            if (bindingNavigator != null)
                Initialize();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            parentForm.PrintData();
        }

    }
}
