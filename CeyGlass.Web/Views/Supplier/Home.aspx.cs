using CeyGlass.DataTransfer.Responses;
using CeyGlass.Web.Common;
using CeyGlass.Web.Presenters;
using CeyGlass.Web.Presenters.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeyGlass.Web.Views.Supplier
{
    /// <summary>
    /// Sign In
    /// </summary>
    public partial class Home : System.Web.UI.Page, IView
    {
        /// <summary>
        /// The presenter
        /// </summary>
        private HomePresenter presenter;

        /// <summary>
        /// Gets the presenter.
        /// </summary>
        /// <value>
        /// The presenter.
        /// </value>
        public HomePresenter Presenter
        {
            get
            {
                if (this.presenter == null)
                {
                    this.presenter = new HomePresenter();
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
            if (!SessionHelper.SignInResponse.IsSuccessful)
            {
                Response.Redirect("SignIn.aspx");
                return;
            }

            this.GridViewPendingPO.AutoGenerateColumns = false;

            this.GridViewPendingPO.DataSource = SessionHelper.SignInResponse.PendingPurchaseOrders;

            ////this.GridViewPendingPO.Columns.Add();

            this.GridViewPendingPO.DataBind();
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