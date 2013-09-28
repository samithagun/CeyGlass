using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySalesDebtorsSytem
{
    public class BusinessRules
    {
        public static decimal GetQOH(DBLayer.InventorySalesDebtorsSystemEntities DataBaseEntity, string BranchCode, string LocationCode, string ItemCode)
        {
            try
            {
                return DataBaseEntity.ItemQOHs.Single(q => q.BranchCode == BranchCode && q.LocationCode == LocationCode && q.ItemCode == ItemCode).QOH;
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                return -1.00m;
            }
        }

        public static bool UpdateQOH(DBLayer.InventorySalesDebtorsSystemEntities DataBaseEntity, string BranchCode, string LocationCode, string ItemCode, decimal Qty, decimal UnitPrice, bool UpdateAverage)
        {
            if (Qty == 0.00m)
                return true;
            try
            {
                var item = DataBaseEntity.Items.Single(i => i.ItemCode == ItemCode); 
                item.ItemQOHs.Single(q => q.BranchCode == BranchCode && q.LocationCode == LocationCode).QOH += Qty;
                if (UpdateAverage)
                    item.CostPrice = ((item.CostPrice * item.ItemQOHs.Sum(q => q.QOH)) + (Qty * UnitPrice)) / (item.ItemQOHs.Sum(q => q.QOH) + Qty);
                return true;
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                return false;
            }
        }

        public static decimal CalculateTaxes(decimal GrossVal, decimal NBTPer, out decimal NBTVal, decimal VATPer, out decimal VATVal)
        {
            NBTVal = GrossVal * NBTPer / 100;
            VATVal = (GrossVal + NBTVal) * VATPer / 100;
            return GrossVal + NBTVal + VATVal;
        }
    }
}
