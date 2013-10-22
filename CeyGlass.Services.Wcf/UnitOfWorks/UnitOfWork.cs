using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeyGlass.Services.Wcf.UnitOfWorks
{
    /// <summary>
    /// Unit Of Work
    /// </summary>
    public abstract class UnitOfWork
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance has execution error occurred.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has execution error occurred; otherwise, <c>false</c>.
        /// </value>
        protected bool HasExecutionErrorOccurred
        {
            get;
            set;
        }

        /// <summary>
        /// Does the work.
        /// </summary>
        public void DoWork()
        {
            this.PreExecute();

            try
            {
                this.Execute();

                this.HasExecutionErrorOccurred = false;
            }
            catch (Exception ex)
            {
                this.HasExecutionErrorOccurred = true;

                Helpers.WriteException(ex);

                throw ex;
            }
            finally
            {
                this.PostExecute();
            }
        }

        /// <summary>
        /// Pres the execute.
        /// </summary>
        public abstract void PreExecute();

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// Posts the execute.
        /// </summary>
        public abstract void PostExecute();
    }
}