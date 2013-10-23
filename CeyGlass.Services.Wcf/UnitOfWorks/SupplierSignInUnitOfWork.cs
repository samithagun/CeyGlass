using CeyGlass.DataTransfer.Requests;
using CeyGlass.DataTransfer.Responses;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CeyGlass.Services.Wcf.UnitOfWorks
{
    /// <summary>
    /// Sign In Unit Of Work
    /// </summary>
    public class SupplierSignInUnitOfWork : UnitOfWork
    {
        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        public SignInRequestDto Request
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>
        /// The response.
        /// </value>
        public SignInResponseDto Response
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the database.
        /// </summary>
        /// <value>
        /// The database.
        /// </value>
        private InventorySalesDebtorsSystemEntities Database
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the supplier.
        /// </summary>
        /// <value>
        /// The supplier.
        /// </value>
        private Supplier Supplier
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pending purchase orders.
        /// </summary>
        /// <value>
        /// The pending purchase orders.
        /// </value>
        private List<PendingPurchaseOrderDto> PendingPurchaseOrders
        {
            get;
            set;
        }

        /// <summary>
        /// Pres the execute.
        /// </summary>
        public override void PreExecute()
        {
            this.Database = new InventorySalesDebtorsSystemEntities();
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public override void Execute()
        {
            Supplier supplier = this.Database.Suppliers.FirstOrDefault(s => s.UserName == this.Request.UserName);

            if (supplier != null && Helpers.Encrypt(this.Request.Password) == supplier.Password)
            {
                this.Supplier = supplier;

                var results = (from h in this.Database.POHeds
                               join d in this.Database.PODets
                               on h.ReferenceNo equals d.ReferenceNo
                               where h.SupplierCode == supplier.SupplierCode && d.BalQty > 0
                               select new
                               {
                                   h.ReferenceNo,
                                   h.TxnDate,
                                   h.ManualNo,
                                   h.Location.LocationName,
                                   d.Item.ItemName,
                                   Quantity = d.BalQty
                               }).ToList();

                this.PendingPurchaseOrders = new List<PendingPurchaseOrderDto>();

                foreach (var item in results)
                {
                    PendingPurchaseOrderDto pendingPo = new PendingPurchaseOrderDto();

                    pendingPo.ReferenceNumber = item.ReferenceNo;
                    pendingPo.TxnDate = item.TxnDate;
                    pendingPo.ManualNumber = item.ManualNo;
                    pendingPo.LocationName = item.LocationName;
                    pendingPo.ItemName = item.ItemName;
                    pendingPo.Quantity = item.Quantity;

                    this.PendingPurchaseOrders.Add(pendingPo);
                }
            }
            else
            {
                throw new Exception("Invalid User ID or Password");
            }
        }

        /// <summary>
        /// Posts the execute.
        /// </summary>
        public override void PostExecute()
        {
            this.Response = new SignInResponseDto();

            this.Response.IsSuccessful = !this.HasExecutionErrorOccurred;

            if (this.Response.IsSuccessful)
            {
                this.Response.SupplierCode = this.Supplier.SupplierCode;
                this.Response.SupplierName = this.Supplier.SupplierName;
                this.Response.UserName = this.Supplier.UserName;

                this.Response.PendingPurchaseOrders = this.PendingPurchaseOrders;
            }
        }
    }
}