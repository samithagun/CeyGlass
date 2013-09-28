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
    public partial class UserAccessManager : Form
    {
        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        public UserAccessManager()
        {
            InitializeComponent();
        }

        private void UserAccessManager_Load(object sender, EventArgs e)
        {
            txtUserID.varList = from u in db.Users select new { u.UserID, u.UserName };
            txtUserID.codeFieldName = "UserID";
            txtUserID.fieldList.Add("UserName");
            txtUserID.controlList.Add(txtUserName);
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            treeViewUserLevels.Nodes.Clear();

            var UserLevels = (from x in db.sOptions
                              orderby x.sEntry.sSection.sModule.Sequence, x.sEntry.sSection.sModule.ModuleID,
                              x.sEntry.sSection.Sequence, x.sEntry.sSection.SectionID,
                              x.sEntry.Sequence, x.sEntry.EntryID,
                              x.Sequence, x.OptionID
                              select new
                              {
                                  x.OptionID,
                                  x.OptionDescription,
                                  x.sEntry.EntryID,
                                  x.sEntry.EntryDescription,
                                  x.sEntry.sSection.SectionID,
                                  x.sEntry.sSection.SectionDescription,
                                  x.sEntry.sSection.sModule.ModuleID,
                                  x.sEntry.sSection.sModule.ModuleDescription
                              }).ToList();

            int ModuleID = -1, SectionID = -1, EntryID = -1;

            TreeNode TreeNodeModule = new TreeNode(), TreeNodeSection = new TreeNode(), TreeNodeEntry = new TreeNode(), TreeNodeOption;

            foreach (var UserLevel in UserLevels)
            {
                if (ModuleID != UserLevel.ModuleID)
                {
                    TreeNodeModule = new TreeNode(UserLevel.ModuleDescription);
                    TreeNodeModule.Tag = UserLevel.ModuleID;
                    treeViewUserLevels.Nodes.Add(TreeNodeModule);
                    ModuleID = UserLevel.ModuleID;
                }

                if (SectionID != UserLevel.SectionID)
                {
                    TreeNodeSection = new TreeNode(UserLevel.SectionDescription);
                    TreeNodeSection.Tag = UserLevel.SectionID;
                    TreeNodeModule.Nodes.Add(TreeNodeSection);
                    SectionID = UserLevel.SectionID;
                }

                if (EntryID != UserLevel.EntryID)
                {
                    TreeNodeEntry = new TreeNode(UserLevel.EntryDescription);
                    TreeNodeEntry.Tag = UserLevel.EntryID;
                    TreeNodeSection.Nodes.Add(TreeNodeEntry);
                    EntryID = UserLevel.EntryID;
                }

                TreeNodeOption = new TreeNode(UserLevel.OptionDescription);
                TreeNodeOption.Tag = UserLevel.OptionID;
                if (db.UserAccesses.Where(u => u.OptionID == UserLevel.OptionID).Count() == 1)
                    TreeNodeOption.Checked = db.UserAccesses.Single(u => u.OptionID == UserLevel.OptionID).Authorize;
                TreeNodeEntry.Nodes.Add(TreeNodeOption);
            }

            //var Modules = (from m in db.sModules orderby m.Sequence, m.ModuleID select new { m.ModuleID, m.ModuleDescription }).Distinct();

            //foreach (var Module in Modules)
            //{

            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var UserLevels = (from x in db.sOptions
            //                  orderby x.sEntry.sSection.sModule.Sequence, x.sEntry.sSection.sModule.ModuleID,
            //                  x.sEntry.sSection.Sequence, x.sEntry.sSection.SectionID,
            //                  x.sEntry.Sequence, x.sEntry.EntryID,
            //                  x.Sequence, x.OptionID
            //                  select new
            //                  {
            //                      x.OptionID,
            //                      x.OptionDescription,
            //                      x.sEntry.EntryID,
            //                      x.sEntry.EntryDescription,
            //                      x.sEntry.sSection.SectionID,
            //                      x.sEntry.sSection.SectionDescription,
            //                      x.sEntry.sSection.sModule.ModuleID,
            //                      x.sEntry.sSection.sModule.ModuleDescription,
            //                      Authorize = false
            //                  }).ToList();

            db.Connection.Open();
            System.Data.Common.DbTransaction transaction = db.Connection.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                var ua = db.UserAccesses.Where(u => u.UserID == txtUserID.Text).ToList();

                foreach (var u in ua)
                    db.UserAccesses.DeleteObject(u);

                foreach (TreeNode TreeNodeModule in treeViewUserLevels.Nodes)
                    foreach (TreeNode TreeNodeSection in TreeNodeModule.Nodes)
                        foreach (TreeNode TreeNodeEntry in TreeNodeSection.Nodes)
                            foreach (TreeNode TreeNodeOption in TreeNodeEntry.Nodes)
                                if (TreeNodeOption.Checked)
                                    db.UserAccesses.AddObject(UserAccess.CreateUserAccess(txtUserID.Text, (int)TreeNodeOption.Tag, TreeNodeOption.Checked));

                if (db.SaveChanges() <= 0)
                    throw new Exception("Error - No records to save");

                transaction.Commit();
                MessageBox.Show("Saved Successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                transaction.Rollback();
                MessageBox.Show("Save Failed", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUserID.Focus();
        }
    }
}
