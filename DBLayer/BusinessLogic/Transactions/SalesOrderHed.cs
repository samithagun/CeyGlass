using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLayer
{
    public partial class SalesOrderHed : ITransaction
    {
        public void SetUserID(string UserID)
        {
            this.UserID = UserID;
        }

        public void SetAddedDate(DateTime AddedDate)
        {
            this.AddedDate = AddedDate;
        }

        public void SetAddedMachineInfo(string AddedMachineInfo)
        {
            this.AddedMachineInfo = AddedMachineInfo;
        }

        public bool Add(InventorySalesDebtorsSystemEntities DB)
        {
            try
            {
                DB.SalesOrderHeds.AddObject(this);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(InventorySalesDebtorsSystemEntities DB)
        {
            try
            {

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(InventorySalesDebtorsSystemEntities DB)
        {
            try
            {
                DB.DeleteObject(this);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SaveRecord(InventorySalesDebtorsSystemEntities DB)
        {
            try
            {
                DB.SalesOrderHeds.AddObject(this);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<SalesOrderDet> GetDetails(InventorySalesDebtorsSystemEntities DB, string SalesOrderNo)
        {
            return DB.SalesOrderDets.Where(p => p.ReferenceNo == SalesOrderNo).ToList();
        }
    }
}
