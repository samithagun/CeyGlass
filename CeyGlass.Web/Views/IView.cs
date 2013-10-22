using CeyGlass.Web.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeyGlass.Web.Views
{
    /// <summary>
    /// View interface
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Sets the initial data.
        /// </summary>
        /// <param name="initialObjectList">The initial object list.</param>
        void SetInitialData(List<object> initialObjectList);
    }
}