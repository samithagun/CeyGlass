using CeyGlass.Web.Views;

namespace CeyGlass.Web.Presenters
{
    /// <summary>
    /// Presenter interface
    /// </summary>
    public interface IPresenter
    {
        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        /// <value>
        /// The view.
        /// </value>
        IView View
        {
            get;
            set;
        }

        /// <summary>
        /// Loads the initial data.
        /// </summary>
        void LoadInitialData();
    }
}