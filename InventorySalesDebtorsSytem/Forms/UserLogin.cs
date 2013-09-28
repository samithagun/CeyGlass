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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private bool valid = false;
        private InventorySalesDebtorsSystemEntities db;

        public bool ShowLogin(InventorySalesDebtorsSystemEntities db)
        {
            this.db = db;
            this.ShowDialog();
            return valid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); 

            if (txtUserID.Text == "")
            {
                errorProvider1.SetError(txtUserID, "Please Enter Your User ID");
                txtUserID.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Please Enter Your Password");
                txtPassword.Focus();
                return;
            }

            try
            {
                User user = db.Users.Single(u => u.UserID == txtUserID.Text);

                if (Helpers.Encrypt(txtPassword.Text) == user.PassWord)
                {
                    valid = true;
                    Program.UserID = txtUserID.Text;
                    this.Close();
                }
                else
                    throw new Exception("Invalid User ID or Password");
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                MessageBox.Show("Invalid User ID or Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Text = "";
                txtPassword.Text = "";
                txtUserID.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
