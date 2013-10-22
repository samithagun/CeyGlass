using CeyGlass.DataTransfer.Requests;
using CeyGlass.DataTransfer.Responses;
using CeyGlass.Services;
using CeyGlass.Services.Wcf;
using CeyGlass.Web.Common;
using CeyGlass.Web.Views;
using CeyGlass.Web.Views.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeyGlass.Web.Presenters.Supplier
{
    /// <summary>
    /// Sign I nPresenter
    /// </summary>
    public class SignInPresenter : IPresenter
    {
        /// <summary>
        /// The view
        /// </summary>
        private IView view;

        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        /// <value>
        /// The view.
        /// </value>
        public IView View
        {
            get
            {
                return this.view as SignIn;
            }
            set
            {
                this.view = value;
            }
        }

        /// <summary>
        /// Loads the initial data.
        /// </summary>
        public void LoadInitialData()
        {

        }

        /// <summary>
        /// Signs the in.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// If the sign in was successful
        /// </returns>
        public bool SignIn(string username, string password)
        {
            bool response = false;

            SignInRequestDto request = new SignInRequestDto();

            request.UserName = username;
            request.Password = password;

            SupplierServiceReference.ISupplierService service = new SupplierServiceReference.SupplierServiceClient();

            SignInResponseDto signInResponse = service.SignIn(request);

            response = signInResponse.IsSuccessful;
            SessionHelper.SignInResponse = signInResponse;

            return response;
        }
    }
}