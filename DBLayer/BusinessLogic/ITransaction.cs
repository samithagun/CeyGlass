using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLayer
{
    public interface ITransaction
    {
        void SetUserID(string UserID);
        void SetAddedDate(DateTime AddedDate);
        void SetAddedMachineInfo(string AddedMachineInfo);
        bool Add(InventorySalesDebtorsSystemEntities DB);
        bool Update(InventorySalesDebtorsSystemEntities DB);
        bool Delete(InventorySalesDebtorsSystemEntities DB);
        bool SaveRecord(InventorySalesDebtorsSystemEntities DB);
    }
}
