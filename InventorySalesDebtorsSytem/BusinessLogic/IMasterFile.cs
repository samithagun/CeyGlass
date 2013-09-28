using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBLayer;

namespace InventorySalesDebtorsSytem
{
    interface IMasterFile
    {
        void SetUserID(string UserID);
        void SetAddedDate(DateTime AddedDate);
        void setAddedMachineInfo(string AddedMachineInfo);
        //bool Add(InventorySalesDebtorsSystemEntities DB);
        //bool Update(InventorySalesDebtorsSystemEntities DB);
        //bool Delete(InventorySalesDebtorsSystemEntities DB);
    }
}
