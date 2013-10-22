using CeyGlass.DataTransfer.Requests;
using CeyGlass.DataTransfer.Responses;
using CeyGlass.Services.Wcf.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CeyGlass.Services.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SupplierService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SupplierService.svc or SupplierService.svc.cs at the Solution Explorer and start debugging.
    /// <summary>
    /// Supplier Service
    /// </summary>
    public class SupplierService : ISupplierService
    {
        /// <summary>
        /// Signs the in.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>
        /// Sign in response
        /// </returns>
        public SignInResponseDto SignIn(SignInRequestDto request)
        {
            SignInResponseDto response = null;

            SupplierSignInUnitOfWork work = new SupplierSignInUnitOfWork();

            work.Request = request;

            work.DoWork();

            response = work.Response;

            return response;
        }
    }
}
