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
            DateTime currentDate = DateTime.Now;

        }
    }
}
