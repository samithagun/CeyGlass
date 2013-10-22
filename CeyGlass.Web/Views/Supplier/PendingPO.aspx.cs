using CeyGlass.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeyGlass.Web.Views.Supplier
{
    public partial class PendingPO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridViewPendingPO.AutoGenerateColumns = false;

            this.GridViewPendingPO.DataSource = SessionHelper.SignInResponse.PendingPurchaseOrders;

            this.GridViewPendingPO.DataBind();
        }
    }
}