using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CeyGlass.DataTransfer.Responses
{
    /// <summary>
    /// Sign In Response Dto
    /// </summary>
    [ServiceContract]
    public class SignInResponseDto
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is successful.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is successful; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsSuccessful
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the supplier code.
        /// </summary>
        /// <value>
        /// The supplier code.
        /// </value>
        [DataMember]
        public string SupplierCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the supplier.
        /// </summary>
        /// <value>
        /// The name of the supplier.
        /// </value>
        [DataMember]
        public string SupplierName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [DataMember]
        public string UserName
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
        [DataMember]
        public List<PendingPurchaseOrderDto> PendingPurchaseOrders
        {
            get;
            set;
        }
    }
}
