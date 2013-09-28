using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLayer
{
    public partial class Location : IMasterFile
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
                DB.Locations.AddObject(this);
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
                DB.Locations.DeleteObject(this);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool CheckValidity(InventorySalesDebtorsSystemEntities DB, string BranchCode, string LocationCode)
        {
            return (DB.Locations.Where(c => c.BranchCode == BranchCode && c.LocationCode == LocationCode).Count() == 1);
        }
    }
}
