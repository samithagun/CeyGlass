using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using DBLayer;
//using System.Xml;

namespace InventorySalesDebtorsSytem
{
    public partial class ReportViewer : Form
    {
        public List<string> ParameterNames = new List<string>();
        public List<object> ParameterValues = new List<object>();
        private bool printed = false;

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            List<Control> ctrls = Helpers.GetAllControls(crystalReportViewer.Controls);
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.GetType().Name == "ToolStrip")
                {
                    ToolStrip ts = (ToolStrip)ctrl;
                    foreach (ToolStripItem tsi in ts.Items)
                    {
                        if (tsi.ToolTipText == "Print Report")
                            tsi.Click += new EventHandler(PrintButton_Click);
                    }
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printed = true;
        }

        public bool PrintReport(string ReportPath, DataTable PrintData, InventorySalesDebtorsSystemEntities DataBaseEntity, string ReportName)
        {
            try
            {
                this.Text = ReportName;

                //XmlWriter Xml = XmlWriter.Create(ReportPath + ".xml");
                
                PrintData.WriteXml(ReportPath + ".xml", XmlWriteMode.WriteSchema);

                ParameterFields pfs = new ParameterFields();

                ParameterField pf;
                ParameterDiscreteValue pdv;

                var Company = DataBaseEntity.Companies.Single();

                //Company Name
                pf = new ParameterField();
                pdv = new ParameterDiscreteValue();
                pf.Name = "CompanyName";
                pdv.Value = Company.CompanyName;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);

                //Company Address
                pf = new ParameterField();
                pdv = new ParameterDiscreteValue();
                pf.Name = "CompanyAddress";
                pdv.Value = Company.CompanyAddress1 + Company.CompanyAddress2 + Company.CompanyAddress3;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);

                //Company Tel Fax Email
                pf = new ParameterField();
                pdv = new ParameterDiscreteValue();
                pf.Name = "CompanyTelFaxEmail";
                pdv.Value = "Tel: " + Company.CompanyTelephone1 + ", " + Company.CompanyTelephone2 + ", " + Company.CompanyTelephone3 + " Fax: " + Company.CompanyFax + " Email: " + Company.CompanyEmail + " Web: " + Company.CompanyWeb;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);

                //Copyright Statement
                pf = new ParameterField();
                pdv = new ParameterDiscreteValue();
                pf.Name = "CopyrightStatement";
                pdv.Value = Company.CopyrightStatement;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);

                //Current User
                pf = new ParameterField();
                pdv = new ParameterDiscreteValue();
                pf.Name = "UserID";
                pdv.Value = Program.UserID;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);

                //Report Name
                pf = new ParameterField();
                pdv = new ParameterDiscreteValue();
                pf.Name = "ReportName";
                pdv.Value = ReportName;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);

                //Custom Parameters
                int count = (ParameterNames.Count > ParameterValues.Count) ? ParameterValues.Count : ParameterNames.Count;

                for (int i = 0; i < count; i++)
                {
                    pf = new ParameterField();
                    pdv = new ParameterDiscreteValue();
                    pf.Name = ParameterNames[i];
                    pdv.Value = ParameterValues[i];
                    pf.CurrentValues.Add(pdv);
                    pfs.Add(pf);
                }

                ReportDocument rd = new ReportDocument();
                rd.Load(ReportPath + ".rpt"); //System.IO.Directory.GetCurrentDirectory()+@"\Reports\"+
                //rd.SetDatabaseLogon("sa", "test", @"DAYAN-PC\SQLEXPRESS", "DandD", false);
                rd.SetDataSource(PrintData);
                crystalReportViewer.ReportSource = rd;
                crystalReportViewer.ParameterFieldInfo = pfs;
                //crystalReportViewer1.EnableRefresh = false;
                crystalReportViewer.ShowParameterPanelButton = false;
                crystalReportViewer.ReuseParameterValuesOnRefresh = true;

                this.ShowDialog();

                return printed;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Report", ReportName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helpers.WriteException(ex);
                return false;
            }
        }
    }
}
