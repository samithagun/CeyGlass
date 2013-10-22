using CeyGlass.DataTransfer.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeyGlass.Web.Common
{
    /// <summary>
    /// Session Helper
    /// </summary>
    public class SessionHelper
    {
        /// <summary>
        /// The sign in response name
        /// </summary>
        private const string signInResponseName = "SignInResponse";

        /// <summary>
        /// Gets or sets the sign in response.
        /// </summary>
        /// <value>
        /// The sign in response.
        /// </value>
        public static SignInResponseDto SignInResponse
        {
            get
            {
                SignInResponseDto response = null;

                response = HttpContext.Current.Session[signInResponseName] as SignInResponseDto;

                if (response == null)
                {
                    response = new SignInResponseDto();
                }

                return response;
            }

            set
            {
                HttpContext.Current.Session[signInResponseName] = value;
            }
        }
    }
}