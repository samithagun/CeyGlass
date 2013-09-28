using System;
using DBLayer;

namespace InventorySalesDebtorsSytem
{
    public class ItemGrid
    {
        public ItemGrid() { }

        public ItemGrid(Item item, decimal Quantity, decimal QOH)
        {
            this.ItemCode = item.ItemCode;
            this.ItemName = item.ItemName;
            this.UOM = item.UOM;
            this.CostPrice = item.CostPrice;
            this.SelPrice = item.SelPrice;
            this.VatPer = item.VATPer;
            this.NbtPer = item.NBTPer;
            this.Quantity = Quantity;
            this.QOH = QOH;
        }

        public ItemGrid(Item item, decimal CostPrice, decimal SelPrice, decimal ItemDiscPer, decimal Quantity, decimal QOH)
        {
            this.ItemCode = item.ItemCode;
            this.ItemName = item.ItemName;
            this.UOM = item.UOM;
            this.CostPrice = CostPrice;
            this.SelPrice = SelPrice;
            this.ItemDiscPer = ItemDiscPer;
            this.VatPer = item.VATPer;
            this.NbtPer = item.NBTPer;
            this.Quantity = Quantity;
            this.QOH = QOH;
        }

        public ItemGrid(Item item, decimal CostPrice, decimal SelPrice, decimal ItemDiscPer, decimal NBTPer, decimal VATPer, decimal Quantity, decimal QOH)
        {
            this.ItemCode = item.ItemCode;
            this.ItemName = item.ItemName;
            this.UOM = item.UOM;
            this.CostPrice = CostPrice;
            this.SelPrice = SelPrice;
            this.ItemDiscPer = ItemDiscPer;
            this.VatPer = VATPer;
            this.NbtPer = NBTPer;
            this.Quantity = Quantity;
            this.QOH = QOH;
        }

        public ItemGrid(Item item, decimal Price, decimal ItemDiscPer, decimal Quantity, decimal QOH)
        {
            this.ItemCode = item.ItemCode;
            this.ItemName = item.ItemName;
            this.UOM = item.UOM;
            this.CostPrice = item.CostPrice;
            this.SelPrice = Price;
            this.ItemDiscPer = ItemDiscPer;
            this.VatPer = item.VATPer;
            this.NbtPer = item.NBTPer;
            this.Quantity = Quantity;
            this.QOH = QOH;
        }

        public ItemGrid(string ItemCode, string ItemName, decimal Quantity, decimal QOH)
        {
            this.ItemCode = ItemCode;
            this.ItemName = ItemName;
            this.Quantity = Quantity;
            this.QOH = QOH;
        }

        public void CalculatePurchases(decimal HedDiscPer)
        {
            decimal grossTotal = this.CostPrice * this.Quantity;

            this.ItemDiscVal = Math.Round(grossTotal * this.ItemDiscPer / 100, 2);
            this.HedDiscVal = Math.Round((grossTotal - this.ItemDiscVal) * HedDiscPer / 100, 2);
            this.NbtItemVal = Math.Round((grossTotal - this.ItemDiscVal - this.HedDiscVal) * this.NbtPer / 100, 2);
            this.VatItemVal = Math.Round((grossTotal - this.ItemDiscVal - this.HedDiscVal + this.NbtItemVal) * this.VatPer / 100, 2);
            this.TotalItemVal = Math.Round(grossTotal - this.ItemDiscVal - this.HedDiscVal + this.NbtItemVal + this.VatItemVal, 2);
        }

        public void CalculateSales(decimal HedDiscPer)
        {
            decimal grossTotal = this.SelPrice * this.Quantity;

            this.ItemDiscVal = Math.Round(grossTotal * this.ItemDiscPer / 100, 2);
            this.HedDiscVal = Math.Round((grossTotal - this.ItemDiscVal) * HedDiscPer / 100, 2);
            this.NbtItemVal = Math.Round((grossTotal - this.ItemDiscVal - this.HedDiscVal) * this.NbtPer / 100, 2);
            this.VatItemVal = Math.Round((grossTotal - this.ItemDiscVal - this.HedDiscVal + this.NbtItemVal) * this.VatPer / 100, 2);
            this.TotalItemVal = Math.Round(grossTotal - this.ItemDiscVal - this.HedDiscVal + this.NbtItemVal + this.VatItemVal, 2);
        }

        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string UOM { get; set; }
        public decimal Quantity { get; set; }
        public decimal QOH { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SelPrice { get; set; }
        public decimal ItemDiscPer { get; set; }
        public decimal ItemDiscVal { get; set; }
        public decimal HedDiscVal { get; set; }
        public decimal VatPer { get; set; }
        public decimal NbtPer { get; set; }
        public decimal VatItemVal { get; set; }
        public decimal NbtItemVal { get; set; }
        public decimal TotalItemVal { get; set; }
    }
}
