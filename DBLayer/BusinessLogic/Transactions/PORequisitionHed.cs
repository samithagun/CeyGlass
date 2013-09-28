using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLayer
{
    public partial class PORequisitionHed : ITransaction
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
                DB.PORequisitionHeds.AddObject(this);
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
                DB.PORequisitionHeds.AddObject(this);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<PORequisitionDet> GetDetails(InventorySalesDebtorsSystemEntities DB, string PORequisitionNo)
        {
            return DB.PORequisitionDets.Where(p => p.ReferenceNo == PORequisitionNo).ToList();
        }
    }
}
