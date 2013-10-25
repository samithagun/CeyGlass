using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySalesDebtorsSytem.Forms.Reports.Inventory_Sales
{
    public partial class DailyItemOrderReport : ReportForm
    {
        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        public DailyItemOrderReport()
        {
            InitializeComponent();
        }

        private void DailyItemOrderReport_Load(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            dateTimePickerDate.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            DateTime reportDate = dateTimePickerDate.Value;

            // Sales orders
            var salesOrderOnDate = (from s in db.SalesOrderDets
                             where s.SalesOrderHed.DelieveryDate == reportDate
                             select new { 
                                s.ItemCode,
                                s.Item.ItemName,
                                s.Quantity,
                                s.SalesOrderHed.DelieveryDate
                             }).ToList();

            var salesOrders = (from s in db.SalesOrderDets
                               where ((s.SalesOrderHed.DelieveryDate < reportDate) &&  (currentDate <= s.SalesOrderHed.DelieveryDate))
                              select new
                              {
                                  s.ItemCode,
                                  s.Item.ItemName,
                                  s.Quantity,
                                  s.SalesOrderHed.DelieveryDate
                              }).ToList();


            // Standard Orders
            var standardOrdOnDate = (from s in db.SPSDets
                                     where s.Date == reportDate
                                     select new
                                     {
                                         s.SPSHed.ItemCode,
                                         s.SPSHed.Item.ItemName,
                                         Quantity=s.Qty,
                                         DelieveryDate=s.Date
                                     }).ToList();

            var standardOrds = (from s in db.SPSDets
                                     where s.Date < reportDate && s.Date>=currentDate
                                     select new
                                     {
                                         s.SPSHed.ItemCode,
                                         s.SPSHed.Item.ItemName,
                                         Quantity=s.Qty,
                                         DelieveryDate=s.Date
                                     }).ToList();

            var OnDateOrders = salesOrderOnDate.ToList();
            OnDateOrders.AddRange(standardOrdOnDate);

            var orders = salesOrders.ToList();
            orders.AddRange(standardOrds);

            var finalOnDateVal = from s in OnDateOrders
                           group s by new { s.ItemCode, s.ItemName }
                               into g
                                     select new { ItemCode = g.Key.ItemCode, ItemName=g.Key.ItemName, Item_Type = "Finish Goods", QOH = 0, Quantity = g.Sum(s => s.Quantity) };

            //var finalVal = from s in orders
            //               group s by new { s.ItemCode, s.ItemName }
            //                   into g
            //                   select new { g.Key.ItemCode, g.Key.ItemName, Quantity = g.Sum(s => s.Quantity) };

           
            var stores=db.Companies.FirstOrDefault().StoresLoc;
            var branch=db.Companies.FirstOrDefault().CurrentBranchCode;

            var cursor=string .Empty;
            foreach (var item in finalOnDateVal)
            {
      
                
                //var boqs = (from d in db.BoqDets join i in db.ItemQOHs 
                //                                on d.ItemCode equals i.ItemCode
                //           where d.BoqHed.BoqCode == item.ItemCode && i.LocationCode==stores && i.BranchCode==branch
                //           select new { d.ItemCode, d.Item.ItemName, Item_Type = "Raw ", QOH = i.QOH, Quantity = ((d.Quantity / d.BoqHed.UsableQty) * item.Quantity) }).ToList();

                var boqs = (from d in db.BoqDets
                            join i in db.ItemQOHs
                                  on d.ItemCode equals i.ItemCode
                            where d.BoqHed.BoqCode == item.ItemCode && i.LocationCode == stores && i.BranchCode == branch
                            select new {finishItem=item.ItemCode, d.ItemCode, d.Item.ItemName, QOH = i.QOH, Quantity = ((d.Quantity / d.BoqHed.UsableQty) * item.Quantity) }).ToList();

                //cursor += boqs.ToList();
              //  cursor.AddRange(boqs);
            }

            DataTable dt = Helpers.LINQToDataTable(cursor);

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No Records Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dt.TableName = "FinisheGoods";
            ReportViewer r = new ReportViewer();

            string Date = dateTimePickerDate.Value.ToShortDateString();


            r.PrintReport(System.IO.Directory.GetCurrentDirectory() + @"\Reports\FinisheGoods", dt, db, this.Text + "" + " as at " + Date);


        }
    }
}
