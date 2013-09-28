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
    public partial class UserManager : Form
    {

        private InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        public UserManager()
        {
            InitializeComponent();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = db.Users.Where(u => u.UserID != "");

            EnableButtons();
            EnableControls(false);
        }

        public void PrintData()
        {
            DataTable dt = Helpers.LINQToDataTable(from g in db.Banks where g.BankCode != "" select new { g.BankCode, g.BankName, g.Branch, g.BankAddress1, g.BankAddress2, CompanyBank = g.CompanyBank ? "Company Bank" : "Customer Bank" });
            dt.TableName = "Users";
            //dt.WriteXml(System.IO.Directory.GetCurrentDirectory() + @"\Reports\ItemMasterFile.xml");

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\UserMasterFile", dt, db, this.Text);
        }

        private void userBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPasswordConfirm.Text = "";
            txtPasswordOld.Text = "";
            //if (Mode == "Init" && userBindingSource.Current != null)
            //{
            //    if (((User)userBindingSource.Current).PassWord != "")
            //        txtPassword.Text = Helpers.Decrypt(((User)userBindingSource.Current).PassWord);
            //}
        }

        private string Mode = "Init";

        private void EnableButtons()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnPrint.Enabled = false;
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            txtPasswordOld.Enabled = false;
            txtPasswordOld.Visible = false;
            lblPasswordOld.Visible = false;
            txtPasswordConfirm.Enabled = false;
            txtPasswordConfirm.Visible = false;
            lblPasswordConfirm.Visible = false;
            userBindingNavigator.Enabled = false;

            switch (Mode)
            {
                case "Add":
                    btnSave.Enabled = true;
                    btnUndo.Enabled = true;
                    txtPasswordConfirm.Enabled = true;
                    txtPasswordConfirm.Visible = true;
                    lblPasswordConfirm.Visible = true;
                    break;
                case "Edit":
                    btnSave.Enabled = true;
                    btnUndo.Enabled = true;
                    txtPasswordOld.Enabled = true;
                    txtPasswordOld.Visible = true;
                    lblPasswordOld.Visible = true;
                    txtPasswordConfirm.Enabled = true;
                    txtPasswordConfirm.Visible = true;
                    lblPasswordConfirm.Visible = true;
                    break;
                case "Print":
                    btnUndo.Enabled = true;
                    break;
                case "Init":
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnPrint.Enabled = true;
                    userBindingNavigator.Enabled = true;
                    break;
            }
        }

        private void EnableControls(bool enable)
        {
            txtUserID.Enabled = false;
            txtUserName.Enabled = enable;
            txtPassword.Enabled = enable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mode = "Add";
            userBindingSource.AddNew();
            EnableButtons();
            EnableControls(true);
            txtUserID.Enabled = true;
            txtUserID.Focus();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoClick();
        }

        private void UndoClick()
        {
            userBindingSource.CancelEdit();

            if (Mode == "Edit")
                db.Refresh(System.Data.Objects.RefreshMode.StoreWins, userBindingSource.Current);

            Mode = "Init";
            EnableButtons();
            EnableControls(false);
            btnAdd.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Please Enter a User ID", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserID.Focus();
                return;
            }

            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter a User Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return;
            }

            try
            {
                if (Mode == "Edit")
                {
                    if (txtPasswordOld.Text != "" || txtPassword.Text != "")
                    {
                        if (txtPassword.Text == "")
                        {
                            MessageBox.Show("Please Enter a Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassword.Focus();
                            return;
                        }

                        if (txtPassword.Text != txtPasswordConfirm.Text)
                        {
                            MessageBox.Show("Password and the Password Confirmation Does Not Match", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassword.Text = "";
                            txtPasswordConfirm.Text = "";
                            txtPassword.Focus();
                            return;
                        }

                        if (Helpers.Encrypt(txtPasswordOld.Text) != db.Users.Single(u => u.UserID == txtUserID.Text).PassWord)
                        {
                            MessageBox.Show("Old Password is Incorrect", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPasswordOld.Text = "";
                            txtPassword.Text = "";
                            txtPasswordConfirm.Text = "";
                            txtPasswordOld.Focus();
                            return;
                        }

                        ((User)userBindingSource.Current).PassWord = Helpers.Encrypt(txtPassword.Text);
                    }

                    userBindingSource.EndEdit();

                    if (db.SaveChanges() < 1)
                        throw new Exception("No Records to Save");

                    MessageBox.Show("User Updated Successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (Mode == "Add")
                {
                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Please Enter a Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Focus();
                        return;
                    }

                    if (txtPassword.Text != txtPasswordConfirm.Text)
                    {
                        MessageBox.Show("Password and the Password Confirmation Does Not Match", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Text = "";
                        txtPasswordConfirm.Text = "";
                        txtPassword.Focus();
                        return;
                    }

                    ((User)userBindingSource.Current).PassWord = Helpers.Encrypt(txtPassword.Text);

                    userBindingSource.EndEdit();

                    if (db.SaveChanges() < 1)
                        throw new Exception("No Records to Save");

                    MessageBox.Show("User Added Successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                UndoClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Save Failed", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Mode = "Edit";
            EnableButtons();
            EnableControls(true);
            txtUserName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    userBindingSource.RemoveCurrent();
                    int noOfRecordSaved = db.SaveChanges();
                    if (noOfRecordSaved <= 0)
                        throw new Exception("No Records to Save");
                    MessageBox.Show("Record Deleted Successfully", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Delete Failed", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                userBindingNavigator.Focus();
            }
        }
    }
}
