using InventorySalesDebtorsSytem.Forms.Transactions.Manufacturing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySalesDebtorsSytem
{
    public class ShowForm
    {
        public static System.Windows.Forms.Form Show(string FormName)
        {
            switch (FormName)
            {
                #region Inventory and Sales

                #region Master Files

                case "MFSItem":
                    return new ItemMasterFile();


                #endregion

                #region Transactions

                case "TRSPOR":
                    return new PurchaseOrderRequisition();
                case "TRSPO":
                    return new PurchaseOrder();
                case "TRSGRN":
                    return new GoodsReceivedNote();
                case "TRSQuot":
                    return new CustomerQuotation();
                case "TRSSOrd":
                    return new SalesOrder();
                case "TRSInv":
                    return new Invoice();
                case "TRSDis":
                    return new Dispatch();                  


                #endregion

                #region Reports

                case "RptStkMvt":
                    return new StockMovementReport();
                case "RptStkBal":
                    return new StockBalanceReport();
                case "RptSales":
                    return new SalesReport();
                case "RptMSales":
                    return new MonthlySalesReport();

                #endregion

                #endregion

                #region Debtor

                #region Master Files

               case "MFDCust":
                    return new CustomerMasterFile();

                #endregion


                #endregion

                #region Administrator

                #region Master Files

                case "MFAUserMgr":
                    return new UserManager();

                case "MFAUserLvl":
                    return new UserAccessManager();

                #endregion

                #endregion

                #region Manufacturing
                case "MFBOQ":
                    return new BOQ();

                case "TRMProductionPlan":
                    return new ProductionPlan();

                case "TRMSPS":
                    return new StandardProSchedule();

                case "TRMProductionNote":
                    return new ProductionNote();
                #endregion

            }

            return null;
        }
    }
}
