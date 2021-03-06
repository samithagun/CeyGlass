﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLayer
{
    public partial class Customer : IMasterFile
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
                DB.Customers.AddObject(this);
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
                DB.Customers.DeleteObject(this);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool CheckValidity(InventorySalesDebtorsSystemEntities DB, string CustomerCode)
        {
            return (DB.Customers.Where(c => c.CustomerCode == CustomerCode).Count() == 1);
        }

        public static decimal GetDiscountPercentage(InventorySalesDebtorsSystemEntities DB, string CustomerCode)
        {
            return (DB.Customers.Single(c => c.CustomerCode == CustomerCode).DiscountPer);
        }
    }
}
