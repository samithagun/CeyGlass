using CeyGlass.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeyGlass.Web.Views.Supplier
{
    public partial class AuthenticatedSupplier : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SessionHelper.SignInResponse.IsSuccessful)
            {
                Response.Redirect("SignIn.aspx");
                return;
            }

            this.lblUserName.Text = SessionHelper.SignInResponse.UserName;
        }

        /// <summary>
        /// Handles the Click event of the linkButtonSignOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void linkButtonSignOut_Click(object sender, EventArgs e)
        {
            SessionHelper.SignInResponse = new DataTransfer.Responses.SignInResponseDto();

            Response.Redirect("SignIn.aspx");
        }
    }
}