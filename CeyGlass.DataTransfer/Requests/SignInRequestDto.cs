using System.Runtime.Serialization;
using System.ServiceModel;

namespace CeyGlass.DataTransfer.Requests
{
    /// <summary>
    /// Sign In Request Dto
    /// </summary>
    [ServiceContract]
    public class SignInRequestDto
    {
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
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [DataMember]
        public string Password
        {
            get;
            set;
        }
    }
}
