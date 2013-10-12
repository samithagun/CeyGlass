using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySalesDebtorsSytem
{
    public class ReferenceItemGrid
    {
        public string RefferenceNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public ReferenceItemGrid() { }
        public ReferenceItemGrid(string refNo, string ItemCode, string ItemName, decimal Quantity)
        {
            this.RefferenceNo = refNo;
            this.ItemCode = ItemCode;
            this.ItemName = ItemName;
            this.Quantity = Quantity;
        }

    }
}
