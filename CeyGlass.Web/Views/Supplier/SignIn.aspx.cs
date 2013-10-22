using CeyGlass.Web.Common;
using CeyGlass.Web.Presenters.Supplier;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace CeyGlass.Web.Views.Supplier
{
    /// <summary>
    /// Sign In
    /// </summary>
    public partial class SignIn : System.Web.UI.Page, IView
    {
        /// <summary>
        /// The presenter
        /// </summary>
        private SignInPresenter presenter;

        /// <summary>
        /// Gets the presenter.
        /// </summary>
        /// <value>
        /// The presenter.
        /// </value>
        public SignInPresenter Presenter
        {
            get
            {
                if (this.presenter == null)
                {
                    this.presenter = new SignInPresenter();
                    this.presenter.View = this as IView;
                }

                return this.presenter;
            }
        }

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SessionHelper.SignInResponse.IsSuccessful)
            {
                Response.Redirect("PendingPO.aspx");
                return;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSignIn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ImageClickEventArgs"/> instance containing the event data.</param>
        protected void btnSignIn_Click(object sender, ImageClickEventArgs e)
        {
            string userName = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            if (this.Presenter.SignIn(userName, password))
            {
                Response.Redirect("PendingPO.aspx");
            }
            else
            {

            }
        }

        /// <summary>
        /// Handles the Click event of the btnSignIn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string userName = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            if (this.Presenter.SignIn(userName, password))
            {
                Response.Redirect("PendingPO.aspx");
            }
            else
            {

            }
        }

        /// <summary>
        /// Sets the initial data.
        /// </summary>
        /// <param name="initialObjectList">The initial object list.</param>
        public void SetInitialData(List<object> initialObjectList)
        {

        }
    }
}