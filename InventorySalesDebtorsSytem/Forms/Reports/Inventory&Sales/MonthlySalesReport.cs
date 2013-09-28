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
    public partial class MonthlySalesReport : ReportForm
    {
        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        public MonthlySalesReport()
        {
            InitializeComponent();
            multipleSelectorBarItems.DataBaseEntity = db;
            multipleSelectorBarCustomers.DataBaseEntity = db;

            multipleSelectorBarBranch.UnselectedVarList = from b in db.Branches select new { b.BranchCode, b.BranchName };
            multipleSelectorBarBranch.PrimaryKey = "BranchCode";
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            dateTimePickerDateFrom.Value = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);
            dateTimePickerDateTo.Value = dateTimePickerDateFrom.Value.AddYears(1).AddDays(-1);
        }

        public override void PrintData()
        {
            multipleSelectorBarBranch.PrintClick();
            multipleSelectorBarCustomers.PrintClick();
            multipleSelectorBarItems.PrintClick();

            List<string> SelectedBranchCodes = new List<string>();

            if (multipleSelectorBarBranch.CodeText == "")
                foreach (DataRow dr in multipleSelectorBarBranch.dtSelected.Rows)
                    SelectedBranchCodes.Add(dr["BranchCode"].ToString());
            else
                SelectedBranchCodes.Add(multipleSelectorBarBranch.CodeText);

            List<string> SelectedCustomerCodes = multipleSelectorBarCustomers.SelectedCustomerCodes;
            List<string> SelectedItemCodes = multipleSelectorBarItems.SelectedItemCodes;

            var Invoices = (from i in db.InvoiceDets
                            where i.InvoiceHed.TxnDate >= dateTimePickerDateFrom.Value && i.InvoiceHed.TxnDate <= dateTimePickerDateTo.Value
                            select new
                            {
                                i.InvoiceHed.ReferenceNo,
                                i.InvoiceHed.BranchCode,
                                i.InvoiceHed.Branch.BranchName,
                                i.InvoiceHed.CustomerCode,
                                i.InvoiceHed.Customer.CustomerName,
                                i.InvoiceHed.HedDiscPer,
                                i.InvoiceHed.HedDiscTotVal,
                                i.InvoiceHed.ItemDiscTotVal,
                                i.InvoiceHed.LocationCode,
                                i.InvoiceHed.Location.LocationName,
                                i.InvoiceHed.ManualNo,
                                i.InvoiceHed.NBTVal,
                                i.InvoiceHed.Remarks,
                                i.InvoiceHed.RepCode,
                                i.InvoiceHed.SalesRep.RepName,
                                ReferenceNo2 = i.InvoiceHed.SalesOrderNo,
                                i.InvoiceHed.TotalVal,
                                i.InvoiceHed.TxnDate,
                                i.InvoiceHed.VATVal,
                                i.CostPrice,
                                i.HedDiscVal,
                                i.ItemCode,
                                i.Item.ItemName,
                                i.ItemDiscPer,
                                i.ItemDiscVal,
                                i.NBTItemVal,
                                i.NBTPer,
                                i.Quantity,
                                i.SelPrice,
                                i.TotalItemVal,
                                i.VATItemVal,
                                i.VATPer,
                                TxnType = "IN",
                                GroupingField = "",
                                GroupingFieldDesc = "",
                                Field1C = "",
                                Field1N = "",
                                Field2C = "",
                                Field2N = "",
                                Field3C = "",
                                Field3N = ""
                            }).ToList();

            var SalesReturns = (from i in db.SalesReturnDets
                                where i.SalesReturnHed.TxnDate >= dateTimePickerDateFrom.Value && i.SalesReturnHed.TxnDate <= dateTimePickerDateTo.Value
                                select new
                                {
                                    i.SalesReturnHed.ReferenceNo,
                                    i.SalesReturnHed.BranchCode,
                                    i.SalesReturnHed.Branch.BranchName,
                                    i.SalesReturnHed.CustomerCode,
                                    i.SalesReturnHed.Customer.CustomerName,
                                    i.SalesReturnHed.HedDiscPer,
                                    HedDiscTotVal = -1 * i.SalesReturnHed.HedDiscTotVal,
                                    ItemDiscTotVal = -1 * i.SalesReturnHed.ItemDiscTotVal,
                                    i.SalesReturnHed.LocationCode,
                                    i.SalesReturnHed.Location.LocationName,
                                    i.SalesReturnHed.ManualNo,
                                    NBTVal = -1 * i.SalesReturnHed.NBTVal,
                                    i.SalesReturnHed.Remarks,
                                    i.SalesReturnHed.RepCode,
                                    i.SalesReturnHed.SalesRep.RepName,
                                    ReferenceNo2 = i.SalesReturnHed.InvoiceNo,
                                    TotalVal = -1 * i.SalesReturnHed.TotalVal,
                                    i.SalesReturnHed.TxnDate,
                                    VATVal = -1 * i.SalesReturnHed.VATVal,
                                    i.CostPrice,
                                    HedDiscVal = -1 * i.HedDiscVal,
                                    i.ItemCode,
                                    i.Item.ItemName,
                                    i.ItemDiscPer,
                                    ItemDiscVal = -1 * i.ItemDiscVal,
                                    NBTItemVal = -1 * i.NBTItemVal,
                                    i.NBTPer,
                                    Quantity = -1 * i.Quantity,
                                    i.SelPrice,
                                    TotalItemVal = -1 * i.TotalItemVal,
                                    VATItemVal = -1 * i.VATItemVal,
                                    i.VATPer,
                                    TxnType = "SR",
                                    GroupingField = "",
                                    GroupingFieldDesc = "",
                                    Field1C = "",
                                    Field1N = "",
                                    Field2C = "",
                                    Field2N = "",
                                    Field3C = "",
                                    Field3N = ""
                                }).ToList();

            var NetSales = Invoices.Union(SalesReturns).Where(i => SelectedBranchCodes.Contains(i.BranchCode) && SelectedCustomerCodes.Contains(i.CustomerCode) && SelectedItemCodes.Contains(i.ItemCode)).ToList();

            var MonthlySales = from n in NetSales //.Where(x => ((x.TxnDate >= dateTimePickerDateFrom.Value) && (x.TxnDate < dateTimePickerDateFrom.Value.AddMonths(1))))
                               group n by new { n.BranchCode, n.BranchName, n.RepCode, n.RepName, n.CustomerCode, n.CustomerName, n.ItemCode, n.ItemName } into g
                               select new
                               {
                                   g.Key.BranchCode,
                                   g.Key.BranchName,
                                   g.Key.RepCode,
                                   g.Key.RepName,
                                   g.Key.CustomerCode,
                                   g.Key.CustomerName,
                                   g.Key.ItemCode,
                                   g.Key.ItemName,
                                   Qty1 = g.Sum(n => ((n.TxnDate >= dateTimePickerDateFrom.Value) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(1))) ? n.Quantity : 0.00m),
                                   TotalVal1 = g.Sum(n => ((n.TxnDate >= dateTimePickerDateFrom.Value) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(1))) ? n.TotalItemVal : 0.00m),
                                   Qty2 = g.Sum(n => ((n.TxnDate >= dateTimePickerDateFrom.Value.AddMonths(1)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(2))) ? n.Quantity : 0.00m),
                                   TotalVal2 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(1)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(2))) ? n.TotalItemVal : 0.00m),
                                   Qty3 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(2)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(3))) ? n.Quantity : 0.00m),
                                   TotalVal3 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(2)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(3))) ? n.TotalItemVal : 0.00m),
                                   Qty4 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(3)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(4))) ? n.Quantity : 0.00m),
                                   TotalVal4 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(3)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(4))) ? n.TotalItemVal : 0.00m),
                                   Qty5 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(4)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(5))) ? n.Quantity : 0.00m),
                                   TotalVal5 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(4)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(5))) ? n.TotalItemVal : 0.00m),
                                   Qty6 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(5)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(6))) ? n.Quantity : 0.00m),
                                   TotalVal6 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(5)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(6))) ? n.TotalItemVal : 0.00m),
                                   Qty7 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(6)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(7))) ? n.Quantity : 0.00m),
                                   TotalVal7 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(6)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(7))) ? n.TotalItemVal : 0.00m),
                                   Qty8 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(7)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(8))) ? n.Quantity : 0.00m),
                                   TotalVal8 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(7)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(8))) ? n.TotalItemVal : 0.00m),
                                   Qty9 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(8)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(9))) ? n.Quantity : 0.00m),
                                   TotalVal9 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(8)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(9))) ? n.TotalItemVal : 0.00m),
                                   Qty10 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(9)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(10))) ? n.Quantity : 0.00m),
                                   TotalVal10 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(9)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(10))) ? n.TotalItemVal : 0.00m),
                                   Qty11 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(10)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(11))) ? n.Quantity : 0.00m),
                                   TotalVal11 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(10)) && (n.TxnDate < dateTimePickerDateFrom.Value.AddMonths(11))) ? n.TotalItemVal : 0.00m),
                                   Qty12 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(11)) && (n.TxnDate < dateTimePickerDateTo.Value)) ? n.Quantity : 0.00m),
                                   TotalVal12 = g.Sum(n => ((n.TxnDate > dateTimePickerDateFrom.Value.AddMonths(11)) && (n.TxnDate < dateTimePickerDateTo.Value)) ? n.TotalItemVal : 0.00m)
                               };

            DataTable dt = Helpers.LINQToDataTable(MonthlySales);

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No Records Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dt.TableName = "MonthlySales";

            ReportViewer r = new ReportViewer();

            for (int monthCount = 0; monthCount < 12; monthCount++)
            {
                r.ParameterNames.Add("Month" + (monthCount + 1).ToString().PadLeft(2, '0'));
                r.ParameterValues.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTimePickerDateFrom.Value.AddMonths(monthCount).Month) + ", " + dateTimePickerDateFrom.Value.AddMonths(monthCount).Year.ToString());
            }

            string DateRange = dateTimePickerDateFrom.Value.ToShortDateString() + " - " + dateTimePickerDateTo.Value.ToShortDateString();

            if (radCustomerWise.Checked)
            {
                if (radDetail.Checked)
                    r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\MonthlySalesReportCD", dt, db, this.Text + " - Customer Wise / Detail" + " - " + DateRange);
                else
                    r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\MonthlySalesReportCS", dt, db, this.Text + " - Customer Wise / Summary" + " - " + DateRange);
            }

            if (radItemWise.Checked)
            {
                if (radDetail.Checked)
                    r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\MonthlySalesReportID", dt, db, this.Text + " - Item Wise - Detail" + " - " + DateRange);
                else
                    r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\MonthlySalesReportIS", dt, db, this.Text + " - Item Wise - Summary" + " - " + DateRange);
            }

            if (radRepWise.Checked)
            {
                if (radDetail.Checked)
                    r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\MonthlySalesReportRD", dt, db, this.Text + " - Rep Wise - Detail" + " - " + DateRange);
                else
                    r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\MonthlySalesReportRS", dt, db, this.Text + " - Rep Wise - Summary" + " - " + DateRange);
            }

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

        private void dateTimePickerDateFrom_Leave(object sender, EventArgs e)
        {
            dateTimePickerDateTo.Value = dateTimePickerDateFrom.Value.AddYears(1).AddDays(-1);
        }

        private void dateTimePickerDateTo_Leave(object sender, EventArgs e)
        {
            dateTimePickerDateFrom.Value = dateTimePickerDateTo.Value.AddYears(-1).AddDays(1);
        }
    }
}
