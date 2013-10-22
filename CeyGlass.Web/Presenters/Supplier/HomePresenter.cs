using CeyGlass.DataTransfer.Requests;
using CeyGlass.DataTransfer.Responses;
using CeyGlass.Services;
using CeyGlass.Services.Wcf;
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
    public class HomePresenter : IPresenter
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
                return this.view as Home;
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
    }
}