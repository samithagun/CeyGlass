using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CeyGlass.DataTransfer.Responses
{
    /// <summary>
    /// Pending Purchase Order Dto
    /// </summary>
    [ServiceContract]
    public class PendingPurchaseOrderDto
    {
        /// <summary>
        /// Gets or sets the reference number.
        /// </summary>
        /// <value>
        /// The reference number.
        /// </value>
        [DataMember]
        public string ReferenceNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TXN date.
        /// </summary>
        /// <value>
        /// The TXN date.
        /// </value>
        [DataMember]
        public DateTime TxnDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the manual number.
        /// </summary>
        /// <value>
        /// The manual number.
        /// </value>
        [DataMember]
        public string ManualNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        /// <value>
        /// The name of the location.
        /// </value>
        [DataMember]
        public string LocationName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>
        /// The name of the item.
        /// </value>
        [DataMember]
        public string ItemName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        [DataMember]
        public decimal Quantity
        {
            get;
            set;
        }
    }
}
