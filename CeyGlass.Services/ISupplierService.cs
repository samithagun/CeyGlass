using CeyGlass.DataTransfer.Requests;
using CeyGlass.DataTransfer.Responses;
using System.ServiceModel;

namespace CeyGlass.Services
{
    /// <summary>
    /// Supplier Service Interface
    /// </summary>
    [ServiceContract]
    public interface ISupplierService
    {
        /// <summary>
        /// Signs the in.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>
        /// Sign in response
        /// </returns>
        [OperationContract]
        SignInResponseDto SignIn(SignInRequestDto request);
    }
}
