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
    public partial class MultipleSelectorBarItems : UserControl
    {
        public InventorySalesDebtorsSystemEntities DataBaseEntity { get; set; }
        public DataTable dtSelectedType, dtSelectedGroup, dtSelectedBrand, dtSelectedCategory, dtSelectedSubCategory, dtSelectedItem;
        public List<Item> SelectedItems
        {
            get { return GetItemList(); }
        }

        public List<string> SelectedItemCodes
        {
            get { return GetItemCodeList(); }
        }

        public MultipleSelectorBarItems()
        {
            InitializeComponent();
        }

        private void MultipleSelectorBarItems_Load(object sender, EventArgs e)
        {
            if (DataBaseEntity != null)
            {
                multipleSelectorBarType.UnselectedVarList = from t in DataBaseEntity.ItemTypes select new { t.TypeCode, t.TypeName };
                multipleSelectorBarGroup.UnselectedVarList = from g in DataBaseEntity.ItemGroups select new { g.GroupCode, g.GroupName };
                multipleSelectorBarBrand.UnselectedVarList = from b in DataBaseEntity.Brands select new { b.BrandCode, b.BrandName };
                multipleSelectorBarCategory.UnselectedVarList = from c in DataBaseEntity.ItemCategories select new { c.CategoryCode, c.CategoryName };
                multipleSelectorBarSubCategory.UnselectedVarList = from s in DataBaseEntity.ItemSubCategories select new { s.SubCatCode, s.SubCatName, s.ItemCategory.CategoryName };
                multipleSelectorBarItem.UnselectedVarList = from i in DataBaseEntity.Items select new { i.ItemCode, i.ItemName, i.ItemGroup.GroupName, i.ItemType.TypeName, i.ItemSubCategory.ItemCategory.CategoryName, i.ItemSubCategory.SubCatName, i.Brand.BrandName, i.Status };
            }
        }

        public List<Item> GetItemList()
        {
            List<Item> SelectedItem = new List<Item>();

            dtSelectedType = multipleSelectorBarType.dtSelected;
            dtSelectedGroup = multipleSelectorBarGroup.dtSelected;
            dtSelectedItem = multipleSelectorBarItem.dtSelected;
            dtSelectedCategory = multipleSelectorBarCategory.dtSelected;
            dtSelectedBrand = multipleSelectorBarBrand.dtSelected;
            dtSelectedSubCategory = multipleSelectorBarSubCategory.dtSelected;

            if (DataBaseEntity != null && dtSelectedItem != null && dtSelectedGroup != null && dtSelectedType != null)
            {
                var items = DataBaseEntity.Items.ToList();
                foreach (var item in items)
                {
                    if ((dtSelectedType.Select("TypeCode = '" + item.TypeCode + "'").Count() > 0)
                        && (dtSelectedGroup.Select("GroupCode = '" + item.GroupCode + "'").Count() > 0)
                        && (dtSelectedCategory.Select("CategoryCode = '" + item.ItemSubCategory.CategoryCode + "'").Count() > 0)
                        && (dtSelectedSubCategory.Select("SubCatCode = '" + item.SubCatCode + "'").Count() > 0)
                        && (dtSelectedBrand.Select("BrandCode = '" + item.BrandCode + "'").Count() > 0)
                        && (dtSelectedItem.Select("ItemCode = '" + item.ItemCode + "'").Count() > 0))
                    {
                        if (chkActive.Checked && item.Status == "Active")
                            SelectedItem.Add(item);
                        else
                            if (chkInactive.Checked && item.Status == "Inactive")
                                SelectedItem.Add(item);
                    }
                }
            }

            return SelectedItem;
        }

        public List<string> GetItemCodeList()
        {
            List<string> SelectedItemCodes = new List<string>();

            dtSelectedType = multipleSelectorBarType.dtSelected;
            dtSelectedGroup = multipleSelectorBarGroup.dtSelected;
            dtSelectedItem = multipleSelectorBarItem.dtSelected;
            dtSelectedCategory = multipleSelectorBarCategory.dtSelected;
            dtSelectedBrand = multipleSelectorBarBrand.dtSelected;
            dtSelectedSubCategory = multipleSelectorBarSubCategory.dtSelected;

            if (DataBaseEntity != null && dtSelectedItem != null && dtSelectedGroup != null && dtSelectedType != null)
            {
                var items = DataBaseEntity.Items.ToList();
                foreach (var item in items)
                {
                    if ((dtSelectedType.Select("TypeCode = '" + item.TypeCode + "'").Count() > 0)
                        && (dtSelectedGroup.Select("GroupCode = '" + item.GroupCode + "'").Count() > 0)
                        && (dtSelectedCategory.Select("CategoryCode = '" + item.ItemSubCategory.CategoryCode + "'").Count() > 0)
                        && (dtSelectedSubCategory.Select("SubCatCode = '" + item.SubCatCode + "'").Count() > 0)
                        && (dtSelectedBrand.Select("BrandCode = '" + item.BrandCode + "'").Count() > 0)
                        && (dtSelectedItem.Select("ItemCode = '" + item.ItemCode + "'").Count() > 0))
                    {
                        if (chkActive.Checked && item.Status == "Active")
                            SelectedItemCodes.Add(item.ItemCode);
                        else
                            if (chkInactive.Checked && item.Status == "Inactive")
                                SelectedItemCodes.Add(item.ItemCode);
                    }
                }
            }

            return SelectedItemCodes;
        }

        public void PrintClick()
        {
            multipleSelectorBarType.PrintClick();
            multipleSelectorBarGroup.PrintClick();
            multipleSelectorBarCategory.PrintClick();
            multipleSelectorBarSubCategory.PrintClick();
            multipleSelectorBarBrand.PrintClick();
            multipleSelectorBarItem.PrintClick();
        }
    }
}
