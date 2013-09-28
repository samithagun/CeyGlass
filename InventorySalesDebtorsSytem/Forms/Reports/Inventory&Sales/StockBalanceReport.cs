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
    public partial class StockBalanceReport : ReportForm
    {
        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        public StockBalanceReport()
        {
            InitializeComponent();
            multipleSelectorBarItems.DataBaseEntity = db;

            multipleSelectorBarBranch.UnselectedVarList = from b in db.Branches select new { b.BranchCode, b.BranchName };
            multipleSelectorBarBranch.PrimaryKey = "BranchCode";

            multipleSelectorBarLocation.UnselectedVarList = from l in db.Locations select new { l.LocationCode, l.LocationName, l.Branch.BranchName };
            multipleSelectorBarLocation.PrimaryKey = "LocationCode";
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            dateTimePickerDate.Value = DateTime.Today;
        }

        public override void PrintData()
        {
            multipleSelectorBarBranch.PrintClick();
            multipleSelectorBarLocation.PrintClick();
            multipleSelectorBarItems.PrintClick();

            List<string> SelectedBranchCodes = new List<string>();

            if (multipleSelectorBarBranch.CodeText == "")
                foreach (DataRow dr in multipleSelectorBarBranch.dtSelected.Rows)
                    SelectedBranchCodes.Add(dr["BranchCode"].ToString());
            else
                SelectedBranchCodes.Add(multipleSelectorBarBranch.CodeText);

            List<string> SelectedLocationCodes = new List<string>();

            if (multipleSelectorBarLocation.CodeText == "")
                foreach (DataRow dr in multipleSelectorBarLocation.dtSelected.Rows)
                    SelectedLocationCodes.Add(dr["LocationCode"].ToString());
            else
                SelectedLocationCodes.Add(multipleSelectorBarLocation.CodeText);

            List<string> SelectedItemCodes = multipleSelectorBarItems.SelectedItemCodes;

            var GRNs = (from g in db.GRNDets
                        where g.GRNHed.TxnDate <= dateTimePickerDate.Value
                        select new
                        {
                            g.GRNHed.ReferenceNo,
                            g.GRNHed.BranchCode,
                            g.GRNHed.Branch.BranchName,
                            g.GRNHed.LocationCode,
                            g.GRNHed.Location.LocationName,
                            g.GRNHed.ManualNo,
                            g.GRNHed.TxnDate,
                            g.CostPrice,
                            g.ItemCode,
                            g.Item.ItemName,
                            GroupCode = radCategoryWise.Checked ? g.Item.ItemSubCategory.CategoryCode + " - " + g.Item.SubCatCode : radGroupWise.Checked ? g.Item.GroupCode : radTypeWise.Checked ? g.Item.TypeCode : "",
                            GroupName = radCategoryWise.Checked ? g.Item.ItemSubCategory.ItemCategory.CategoryName + " - " + g.Item.ItemSubCategory.SubCatName : radGroupWise.Checked ? g.Item.ItemGroup.GroupName : radTypeWise.Checked ? g.Item.ItemType.TypeName : "",
                            g.Quantity,
                            Remarks = "Goods Received Note",
                            seq = 2
                        }).ToList();

            var GRRNs = (from g in db.GRRNDets
                         where g.GRRNHed.TxnDate <= dateTimePickerDate.Value
                         select new
                         {
                             g.GRRNHed.ReferenceNo,
                             g.GRRNHed.BranchCode,
                             g.GRRNHed.Branch.BranchName,
                             g.GRRNHed.LocationCode,
                             g.GRRNHed.Location.LocationName,
                             g.GRRNHed.ManualNo,
                             g.GRRNHed.TxnDate,
                             g.CostPrice,
                             g.ItemCode,
                             g.Item.ItemName,
                             GroupCode = radCategoryWise.Checked ? g.Item.ItemSubCategory.CategoryCode + " - " + g.Item.SubCatCode : radGroupWise.Checked ? g.Item.GroupCode : radTypeWise.Checked ? g.Item.TypeCode : "",
                             GroupName = radCategoryWise.Checked ? g.Item.ItemSubCategory.ItemCategory.CategoryName + " - " + g.Item.ItemSubCategory.SubCatName : radGroupWise.Checked ? g.Item.ItemGroup.GroupName : radTypeWise.Checked ? g.Item.ItemType.TypeName : "",
                             Quantity = -1 * g.Quantity,
                             Remarks = "Goods Received Return Note",
                             seq = 8
                         }).ToList();

            var GTNOuts = (from g in db.TransferDets
                           where g.TransferHed.TxnDate <= dateTimePickerDate.Value
                           select new
                           {
                               g.TransferHed.ReferenceNo,
                               BranchCode = g.TransferHed.BranchCodeF,
                               BranchName = g.TransferHed.BranchFrom.BranchName,
                               LocationCode = g.TransferHed.LocationCodeF,
                               LocationName = g.TransferHed.LocationFrom.LocationName,
                               g.TransferHed.ManualNo,
                               g.TransferHed.TxnDate,
                               g.CostPrice,
                               g.ItemCode,
                               g.Item.ItemName,
                               GroupCode = radCategoryWise.Checked ? g.Item.ItemSubCategory.CategoryCode + " - " + g.Item.SubCatCode : radGroupWise.Checked ? g.Item.GroupCode : radTypeWise.Checked ? g.Item.TypeCode : "",
                               GroupName = radCategoryWise.Checked ? g.Item.ItemSubCategory.ItemCategory.CategoryName + " - " + g.Item.ItemSubCategory.SubCatName : radGroupWise.Checked ? g.Item.ItemGroup.GroupName : radTypeWise.Checked ? g.Item.ItemType.TypeName : "",
                               Quantity = -1 * g.Quantity,
                               Remarks = "Stock Transfer Out Note" + (radDetail.Checked ? " To " + g.TransferHed.LocationCodeT.TrimEnd() + " - " + g.TransferHed.LocationTo.LocationName : ""),
                               seq = 7
                           }).ToList();

            var GTNIns = (from g in db.TransferDets
                          where g.TransferHed.TxnDate <= dateTimePickerDate.Value
                          select new
                          {
                              g.TransferHed.ReferenceNo,
                              BranchCode = g.TransferHed.BranchCodeT,
                              BranchName = g.TransferHed.BranchTo.BranchName,
                              LocationCode = g.TransferHed.LocationCodeT,
                              LocationName = g.TransferHed.LocationTo.LocationName,
                              g.TransferHed.ManualNo,
                              g.TransferHed.TxnDate,
                              g.CostPrice,
                              g.ItemCode,
                              g.Item.ItemName,
                              GroupCode = radCategoryWise.Checked ? g.Item.ItemSubCategory.CategoryCode + " - " + g.Item.SubCatCode : radGroupWise.Checked ? g.Item.GroupCode : radTypeWise.Checked ? g.Item.TypeCode : "",
                              GroupName = radCategoryWise.Checked ? g.Item.ItemSubCategory.ItemCategory.CategoryName + " - " + g.Item.ItemSubCategory.SubCatName : radGroupWise.Checked ? g.Item.ItemGroup.GroupName : radTypeWise.Checked ? g.Item.ItemType.TypeName : "",
                              g.Quantity,
                              Remarks = "Stock Transfer In Note" + (radDetail.Checked ? " From " + g.TransferHed.LocationCodeF.TrimEnd() + " - " + g.TransferHed.LocationFrom.LocationName : ""),
                              seq = 3
                          }).ToList();

            var Disps = (from g in db.DispatchDets
                         where g.DispatchHed.TxnDate <= dateTimePickerDate.Value
                         select new
                         {
                             g.DispatchHed.ReferenceNo,
                             g.DispatchHed.BranchCode,
                             g.DispatchHed.Branch.BranchName,
                             g.DispatchHed.LocationCode,
                             g.DispatchHed.Location.LocationName,
                             g.DispatchHed.ManualNo,
                             g.DispatchHed.TxnDate,
                             g.CostPrice,
                             g.ItemCode,
                             g.Item.ItemName,
                             GroupCode = radCategoryWise.Checked ? g.Item.ItemSubCategory.CategoryCode + " - " + g.Item.SubCatCode : radGroupWise.Checked ? g.Item.GroupCode : radTypeWise.Checked ? g.Item.TypeCode : "",
                             GroupName = radCategoryWise.Checked ? g.Item.ItemSubCategory.ItemCategory.CategoryName + " - " + g.Item.ItemSubCategory.SubCatName : radGroupWise.Checked ? g.Item.ItemGroup.GroupName : radTypeWise.Checked ? g.Item.ItemType.TypeName : "",
                             Quantity = -1 * g.Quantity,
                             Remarks = "Dispatch Note",
                             seq = 5
                         }).ToList();

            var InvRets = (from g in db.SalesReturnDets
                           where g.SalesReturnHed.TxnDate <= dateTimePickerDate.Value
                           select new
                           {
                               g.SalesReturnHed.ReferenceNo,
                               g.SalesReturnHed.BranchCode,
                               g.SalesReturnHed.Branch.BranchName,
                               g.SalesReturnHed.LocationCode,
                               g.SalesReturnHed.Location.LocationName,
                               g.SalesReturnHed.ManualNo,
                               g.SalesReturnHed.TxnDate,
                               g.CostPrice,
                               g.ItemCode,
                               g.Item.ItemName,
                               GroupCode = radCategoryWise.Checked ? g.Item.ItemSubCategory.CategoryCode + " - " + g.Item.SubCatCode : radGroupWise.Checked ? g.Item.GroupCode : radTypeWise.Checked ? g.Item.TypeCode : "",
                               GroupName = radCategoryWise.Checked ? g.Item.ItemSubCategory.ItemCategory.CategoryName + " - " + g.Item.ItemSubCategory.SubCatName : radGroupWise.Checked ? g.Item.ItemGroup.GroupName : radTypeWise.Checked ? g.Item.ItemType.TypeName : "",
                               g.Quantity,
                               Remarks = "Invoice Return",
                               seq = 6
                           }).ToList();

            var Adjs = (from g in db.AdjustmentDets
                        where g.AdjustmentHed.TxnDate <= dateTimePickerDate.Value
                        select new
                        {
                            g.AdjustmentHed.ReferenceNo,
                            g.AdjustmentHed.BranchCode,
                            g.AdjustmentHed.Branch.BranchName,
                            g.AdjustmentHed.LocationCode,
                            g.AdjustmentHed.Location.LocationName,
                            g.AdjustmentHed.ManualNo,
                            g.AdjustmentHed.TxnDate,
                            g.CostPrice,
                            g.ItemCode,
                            g.Item.ItemName,
                            GroupCode = radCategoryWise.Checked ? g.Item.ItemSubCategory.CategoryCode + " - " + g.Item.SubCatCode : radGroupWise.Checked ? g.Item.GroupCode : radTypeWise.Checked ? g.Item.TypeCode : "",
                            GroupName = radCategoryWise.Checked ? g.Item.ItemSubCategory.ItemCategory.CategoryName + " - " + g.Item.ItemSubCategory.SubCatName : radGroupWise.Checked ? g.Item.ItemGroup.GroupName : radTypeWise.Checked ? g.Item.ItemType.TypeName : "",
                            g.Quantity,
                            Remarks = "Adjustment " + (g.Quantity > 0.00m ? "Addition" : "Deduction"),
                            seq = g.Quantity > 0.00m ? 4 : 9
                        }).ToList();

            var StkTxns = GRNs.ToList();

            StkTxns.AddRange(GRRNs);

            StkTxns.AddRange(GTNOuts);

            StkTxns.AddRange(GTNIns);

            StkTxns.AddRange(Disps);

            StkTxns.AddRange(InvRets);

            StkTxns.AddRange(Adjs);

            StkTxns.RemoveAll(s => !SelectedBranchCodes.Contains(s.BranchCode) || !SelectedLocationCodes.Contains(s.LocationCode) || !SelectedItemCodes.Contains(s.ItemCode));

            var StkBal = (from s in StkTxns
                          group s by new
                          {
                              s.BranchCode,
                              s.BranchName,
                              s.LocationCode,
                              s.LocationName,
                              s.ItemCode,
                              s.ItemName,
                              s.GroupCode,
                              s.GroupName
                          } into g
                          select new
                          {
                              g.Key.BranchCode,
                              g.Key.BranchName,
                              g.Key.LocationCode,
                              g.Key.LocationName,
                              CostPrice = g.Sum(s => s.CostPrice * s.Quantity) / g.Sum(s => s.Quantity),
                              g.Key.ItemCode,
                              g.Key.ItemName,
                              g.Key.GroupCode,
                              g.Key.GroupName,
                              Quantity = g.Sum(s => s.Quantity),
                              Remarks = "Opening Balance",
                          }).ToList();

            var StockBalance = StkBal.OrderBy(s => s.BranchCode).
                OrderBy(s => s.LocationCode).
                OrderBy(s => s.ItemCode);

            DataTable dt = Helpers.LINQToDataTable(StockBalance);

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No Records Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dt.TableName = "StockBalance";

            ReportViewer r = new ReportViewer();

            string Date = dateTimePickerDate.Value.ToShortDateString();
            string grouping = radCategoryWise.Checked ? " - Item Category / Sub Category Wise" : radGroupWise.Checked ? " - Item Group Wise" : radTypeWise.Checked ? " - Item Type Wise" : "";

            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\StockBalance", dt, db, this.Text + grouping + " as at " + Date);

            //    if (radCustomerWise.Checked)
            //    {
            //        GroupName = "Customer";
            //        foreach (DataRow s in dt.Rows)
            //        {
            //            s["GroupingField"] = s["CustomerCode"];
            //            s["GroupingFieldDesc"] = s["CustomerName"];
            //            s["Field1C"] = s["ReferenceNo"];
            //            s["Field1N"] = ((DateTime)s["TxnDate"]).ToString("dd/MM/yyyy") + s["ManualNo"];
            //            s["Field2C"] = s["ItemCode"];
            //            s["Field2N"] = s["ItemName"];
            //            //s["Field3C"] = s["CustomerCode"];
            //            //s["Field3N"] = s["CustomerName"];
            //        }
            //    }

            //    if (radItemWise.Checked)
            //    {
            //        GroupName = "Item";
            //        foreach (DataRow s in dt.Rows)
            //        {
            //            s["GroupingField"] = s["ItemCode"];
            //            s["GroupingFieldDesc"] = s["ItemName"];
            //            s["Field1C"] = s["CustomerCode"];
            //            s["Field1N"] = s["CustomerName"];
            //            s["Field2C"] = s["ReferenceNo"];
            //            s["Field2N"] = ((DateTime)s["TxnDate"]).ToString("dd/MM/yyyy") + s["ManualNo"];
            //        }
            //    }

            //    if (radRepWise.Checked)
            //    {
            //        GroupName = "Sales Rep";
            //        foreach (DataRow s in dt.Rows)
            //        {
            //            s["GroupingField"] = s["RepCode"];
            //            s["GroupingFieldDesc"] = s["RepName"];
            //            s["Field1C"] = s["ItemCode"];
            //            s["Field1N"] = s["ItemName"];
            //            s["Field2C"] = s["CustomerCode"];
            //            s["Field2N"] = s["CustomerName"];
            //        }
            //    }

            //    dt.TableName = "NetSales";

            //    ReportViewer r = new ReportViewer();
            //    r.ParameterNames.Add("GroupName");
            //    r.ParameterValues.Add(GroupName);

            //    if (radDetail.Checked)
            //        r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\SalesReport", dt, db, this.Text + " - Detail");
            //    else
            //        r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\SalesReportS", dt, db, this.Text + " - Summary");
        }
    }
}
