using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLayer;
using VIBlend.WinForms.Controls;

namespace InventorySalesDebtorsSytem
{
    public partial class MainForm : Form
    {
        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        List<VIBlend.Utilities.VIBLEND_THEME> themeList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs ea)
        {
            //ShowNavPane(false);
            vNavPaneMain.Visible = false;

            if ((!Program.DebuggingMode) && (!new UserLogin().ShowLogin(db)))
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                if (Program.DebuggingMode)
                    Program.UserID = "Admin";

                SetTheme();
                //List<vNavPaneItem> navPaneItems = new List<vNavPaneItem>();
                var modules = db.sModules.OrderBy(m => m.Sequence).ToList();
                foreach (sModule m in modules)
                {
                    vNavPaneItem navPaneItem = new vNavPaneItem();
                    navPaneItem.Text = m.ModuleDescription.ToString();
                    navPaneItem.HeaderText = m.ModuleDescription.ToString();
                    navPaneItem.TooltipText = m.ModuleDescription.ToString();
                    navPaneItem.Name = m.ModuleDescription.Replace(' ', '_');
                    TreeView t = new TreeView();
                    t.HotTracking = true;
                    t.LabelEdit = false;
                    t.ShowLines = false;
                    t.ShowNodeToolTips = true;
                    var sections = m.sSections.OrderBy(s => s.Sequence).ToList();
                    foreach (sSection s in sections)
                    {
                        TreeNode tn = new TreeNode(s.SectionDescription.ToString());
                        tn.Tag = m.ModuleDescription.ToString().Replace(' ', '_') + "-" + s.SectionDescription.ToString().Replace(' ', '_');
                        var entries = s.sEntries.Where(e => e.sOptions.Where(o => o.UserAccesses.Where(u => u.UserID == Program.UserID && u.Authorize).Count() > 0).Count() > 0).OrderBy(e => e.Sequence).ToList();
                        foreach (sEntry e in entries)
                        {
                            TreeNode stn = new TreeNode(e.EntryDescription.ToString());
                            stn.Tag = e.FormName;
                            //stn.BackColor = Color.LightBlue;
                            tn.Nodes.Add(stn);
                        }
                        //tn.BackColor = Color.SkyBlue;
                        t.Nodes.Add(tn);
                    }

                    navPaneItem.ItemPanel.Controls.Add(t);
                    t.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menuTree_AfterSelect);
                    t.Dock = DockStyle.Fill;
                    t.ExpandAll();
                    this.SetStyle(ControlStyles.UserPaint, true);
                    t.BackColor = Color.AliceBlue;
                    //t.BackgroundImage = global::InventorySalesDebtorsSytem.Properties.Resources.BlueToWhiteGradient;
                    //navPaneItem.BackgroundImage = global::InventorySalesDebtorsSytem.Properties.Resources.BlueToWhiteGradient;
                    navPaneItem.BackColor = Color.Azure;
                    vNavPaneMain.Items.Add(navPaneItem);
                }
                themeList = Enum.GetValues(typeof(VIBlend.Utilities.VIBLEND_THEME)).Cast<VIBlend.Utilities.VIBLEND_THEME>().ToList();

                vNavPaneItem navPaneTheme = new vNavPaneItem();
                navPaneTheme.Text = "Themes";
                navPaneTheme.HeaderText = "Themes";
                navPaneTheme.TooltipText = "Change Themes";
                navPaneTheme.Name = "Themes";
                TreeView themeTree = new TreeView();
                foreach (VIBlend.Utilities.VIBLEND_THEME theme in themeList)
                {
                    TreeNode themeNode = new TreeNode(theme.ToString());
                    themeNode.Tag = theme;
                    //themeNode.Value = theme;
                    themeTree.Nodes.Add(themeNode);
                }

                navPaneTheme.ItemPanel.Controls.Add(themeTree);
                themeTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.themeTree_AfterSelect);
                themeTree.Dock = DockStyle.Fill;
                vNavPaneMain.Items.Add(navPaneTheme);

                SetTheme();

                vNavPaneMain.Visible = true;
                //ShowNavPane(true);
            }
        }

        private Form f;

        private void menuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView treeView = (TreeView)sender;
            if (treeView.SelectedNode != null)
            {
                f = ShowForm.Show(treeView.SelectedNode.Tag.ToString());
                //Form f = ShowForm.Show(treeView.SelectedNode.Tag.ToString());
                if (f != null)
                {
                    ShowNavPane(false);
                    f.ShowInTaskbar = false;
                    f.ShowDialog();
                    ShowNavPane(true);

                    //f.MdiParent = this;
                    //f.Show();
                }
                treeView.SelectedNode = null;
            }
        }

        private void themeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme = (VIBlend.Utilities.VIBLEND_THEME)((TreeView)sender).SelectedNode.Tag;
            }
            catch (Exception) { }
            SetTheme();
        }

        private void SetTheme()
        {
            //this.VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
            try
            {
                vNavPaneMain.VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                List<Control> ctrls = Helpers.GetAllControls(this.Controls);
                foreach (Control ctrl in ctrls)
                {
                    try
                    {
                        switch (ctrl.GetType().Name)
                        {
                            case "vFormButton":
                                ((vFormButton)ctrl).VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                                break;
                            case "vNavPane":
                                ((vNavPane)ctrl).VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                                break;
                            //case "vNavPaneItem":
                            //    ((vNavPaneItem)ctrl).VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                            //    break;
                            case "vNavPaneHeader":
                                ((vNavPaneHeader)ctrl).VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                                break;
                            case "vTreeView":
                                ((vTreeView)ctrl).VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                                break;
                            case "vHScrollBar":
                                ((vHScrollBar)ctrl).VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                                break;
                            case "vVScrollBar":
                                ((vVScrollBar)ctrl).VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                                break;
                            case "vTextBox":
                                ((vTextBox)ctrl).VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                                break;
                        }
                        //var control = (vTreeView)ctrl;
                        //control.VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
                    }
                    catch (Exception) { }
                }
            }
            catch (Exception) { }
        }

        private void ShowNavPane(bool show)
        {
            if (show)
            {
                for (int i = 0; i < 250; i += 10)
                    vNavPaneMain.Width = i;
                vNavPaneMain.Width = 250;
            }
            else
            {
                for (int i = 250; i > 0; i -= 10)
                    vNavPaneMain.Width = i;
                vNavPaneMain.Width = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            Test t = new Test();
            //t.MdiParent = this;
            t.Show();
        }

    }
}
