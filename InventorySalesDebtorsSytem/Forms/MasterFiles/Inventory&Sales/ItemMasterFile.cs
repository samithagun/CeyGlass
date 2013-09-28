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
    public partial class ItemMasterFile : MasterFileForm
    {
        private InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        public ItemMasterFile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = db.Items;

            txtBrandCode.varList = from b in db.Brands select new { b.BrandCode, b.BrandName };
            txtBrandCode.codeFieldName = "BrandCode";
            txtBrandCode.controlList.Add(txtBrandName);
            txtBrandCode.fieldList.Add("BrandName");

            txtGroupCode.varList = from g in db.ItemGroups select new { g.GroupCode, g.GroupName };
            txtGroupCode.codeFieldName = "GroupCode";
            txtGroupCode.controlList.Add(txtGroupName);
            txtGroupCode.fieldList.Add("GroupName");

            txtSubCatCode.varList = from s in db.ItemSubCategories select new { SubCategoryCode = s.SubCatCode, SubCategoryName = s.SubCatName, s.ItemCategory.CategoryName };
            txtSubCatCode.codeFieldName = "SubCategoryCode";
            txtSubCatCode.controlList.Add(txtSubCatName);
            txtSubCatCode.fieldList.Add("SubCategoryName");

            txtTypeCode.varList = from t in db.ItemTypes select new { t.TypeCode, t.TypeName };
            txtTypeCode.codeFieldName = "TypeCode";
            txtTypeCode.controlList.Add(txtTypeName);
            txtTypeCode.fieldList.Add("TypeName");

            RefreshData();
        }

        private void statusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            bool stat;
            stat = txtBrandCode.valid;
            stat = txtGroupCode.valid;
            stat = txtSubCatCode.valid;
            stat = txtTypeCode.valid;
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void masterFileToolBar1_Load(object sender, EventArgs e)
        {
            masterFileToolBar1.bindingNavigator = itemBindingNavigator;
            masterFileToolBar1.objectBindingSource = itemBindingSource;
            masterFileToolBar1.primaryKeyControl = itemCodeTextBox;
            masterFileToolBar1.firstFocusControl = itemNameTextBox;
            masterFileToolBar1.db = db;
        }

        public override void PrintData()
        {
            DataTable dt = Helpers.LINQToDataTable(from i in db.Items select new { i.ItemCode, i.ItemName, i.TypeCode, i.ItemType.TypeName, i.SubCatCode, i.ItemSubCategory.SubCatName, i.ItemSubCategory.ItemCategory.CategoryCode, i.ItemSubCategory.ItemCategory.CategoryName, i.BrandCode, i.Brand.BrandName, i.GroupCode, i.ItemGroup.GroupName, i.SelPrice, i.CostPrice, i.UOM, i.ReOrderLevel, i.ReOrderQty, i.Status, i.DiscountPer, i.VATPer, i.NBTPer });
            dt.TableName = "Item";
            //dt.WriteXml(System.IO.Directory.GetCurrentDirectory() + @"\Reports\ItemMasterFile.xml");

            ReportViewer r = new ReportViewer();
            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\ItemMasterFile", dt, db, this.Text);
        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void nBTPerLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
