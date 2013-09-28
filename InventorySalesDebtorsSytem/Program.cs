using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventorySalesDebtorsSytem
{
    static class Program
    {
        public static bool DebuggingMode = false;

        public static string UserID { get; set; }

        public static string MachineName
        {
            get { return System.Security.Principal.WindowsIdentity.GetCurrent().Name; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBLayer.DBConnection.ConStr = global::InventorySalesDebtorsSytem.Properties.Settings.Default.InventorySalesDebtorsSytemsConnectionString;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if DEBUG
            DebuggingMode = true;
#endif
            //if (System.Diagnostics.Debugger.IsAttached)
            //    DebuggingMode = true;

            Application.Run(new MainForm());
        }
    }
}
