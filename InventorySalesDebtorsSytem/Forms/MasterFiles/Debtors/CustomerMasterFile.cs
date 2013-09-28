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
    public partial class CustomerMasterFile : MasterFileForm
    {
        private InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        public CustomerMasterFile()
        {
            InitializeComponent();
        }

        private void LocationMasterFile_Load(object sender, EventArgs e)
        {
            tableBindingSource.DataSource = db.Customers;
            txtGroupCode.varList = from g in db.CustomerGroups select new { g.GroupCode, g.GroupName };
            txtGroupCode.codeFieldName = "GroupCode";
            txtGroupCode.fieldList.Add("GroupName");
            txtGroupCode.controlList.Add(txtGroupName);
            txtTypeCode.varList = from t in db.CustomerTypes select new { t.TypeCode, t.TypeName };
            txtTypeCode.codeFieldName = "TypeCode";
            txtTypeCode.fieldList.Add("TypeName");
            txtTypeCode.controlList.Add(txtTypeName);
        }

        private void masterFileToolBar1_Load(object sender, EventArgs e)
        {
            masterFileToolBar1.bindingNavigator = tableBindingNavigator;
            masterFileToolBar1.objectBindingSource = tableBindingSource;
            masterFileToolBar1.primaryKeyControl = groupCodeTextBox;
            masterFileToolBar1.firstFocusControl = groupNameTextBox;
            masterFileToolBar1.db = db;
        }

        private void RefreshData()
        {
            txtGroupCode.Validate();
            txtTypeCode.Validate();
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        public override void PrintData()
        {
            DataTable dt = Helpers.LINQToDataTable(from g in db.Customers select new { g.CustomerCode, g.CustomerName, g.CustomerAddress1, g.CustomerAddress2, g.CustomerAddress3, g.DiscountPer, g.EmailAddress, g.FaxNo, g.GroupCode, g.CustomerGroup.GroupName, g.Status, g.TelephoneNo, g.TypeCode, g.CustomerType.TypeName });
            dt.TableName = "Customer";
            //dt.WriteXml(System.IO.Directory.GetCurrentDirectory() + @"\Reports\ItemMasterFile.xml");

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\CustomerMasterFile", dt, db, this.Text);
        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
