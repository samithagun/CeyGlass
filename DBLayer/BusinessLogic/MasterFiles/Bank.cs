﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLayer
{
    public partial class Bank : IMasterFile
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
                DB.Banks.AddObject(this);
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
                DB.Banks.DeleteObject(this);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
