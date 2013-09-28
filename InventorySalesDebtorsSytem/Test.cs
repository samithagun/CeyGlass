using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLayer;

namespace InventorySalesDebtorsSytem
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        InventorySalesDebtorsSystemEntities db = new InventorySalesDebtorsSystemEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(0, 100);
            for (int i = 0; i < 1000; i++)
            {
                db.Connection.Open();
                System.Data.Common.DbTransaction transaction = db.Connection.BeginTransaction(IsolationLevel.ReadCommitted);
                try
                {
                    string ReferenceNo = Helpers.GenerateNewNo(db, "TEST", "ST");

                    if (ReferenceNo == null || ReferenceNo == "")
                    {
                        throw new Exception("Reference No generation failed");
                    }

                    CustomerTxn x = new CustomerTxn();

                    x.ReferenceNo = ReferenceNo;
                    x.UserID = a.ToString();
                    x.AddedDate = DateTime.Now;
                    x.AddedMachineInfo = Program.MachineName;

                    db.CustomerTxns.AddObject(x);

                    int noOfRecordSaved = db.SaveChanges();
                    if (noOfRecordSaved <= 0)
                        throw new Exception("Error - No records to save");

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    //if (ex.GetType().Name != "UpdateException")
                    //{
                    //    if (ex.InnerException != null)
                    //        MessageBox.Show(ex.Message + " - " + ex.InnerException.Message);
                    //    else
                    //        MessageBox.Show(ex.Message);
                    //}
                    transaction.Rollback();
                }
                db.Connection.Close();
            }

            MessageBox.Show("Completed");
        }


    }
}
