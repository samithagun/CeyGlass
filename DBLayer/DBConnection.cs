using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DBLayer
{
    public class DBConnection
    {
        public static String ConStr;// = "Data Source=VARUNA\\SQLEXPRESS;Initial Catalog=AutoValuation;User Id=sa;Password=tintin";

        private static SqlConnection con;

        private static SqlCommand com;

        private static SqlTransaction txn;

        public static DataTable GetData(string sqlQuery)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, DBConnection.ConStr);
                DataTable dt = new DataTable("Employee");
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool ExecQuery(String query)
        {
            try
            {
                con = new SqlConnection(ConStr);
                con.Open();
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool ExecQueryParam(String query, SqlParameter[] Params)
        {
            try
            {
                con = new SqlConnection(ConStr);
                con.Open();
                com = new SqlCommand(query, con);
                foreach (SqlParameter Param in Params)
                {
                    com.Parameters.Add(Param);
                }
                com.ExecuteNonQuery();
                com = null;
                return true;
            }
            catch (Exception)
            {
                com = null;
                return false;
            }
        }

        public static bool BeginTxn()
        {
            try
            {
                con = new SqlConnection(ConStr);
                con.Open();
                //com = new SqlCommand();
                txn = con.BeginTransaction();
                //com.Transaction = txn;
                //com.Connection = con;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool ExecTxnQuery(String query)
        {
            try
            {
                com = new SqlCommand();
                com.Transaction = txn;
                com.Connection = con;
                com.CommandText = query;
                com.ExecuteNonQuery();
                com = null;
                return true;
            }
            catch (Exception)
            {
                com = null;
                return false;
            }
        }

        public static bool ExecTxnQueryParam(String query, SqlParameter[] Params)
        {
            try
            {
                com = new SqlCommand();
                com.Transaction = txn;
                com.Connection = con;
                com.CommandText = query;
                foreach (SqlParameter Param in Params)
                {
                    com.Parameters.Add(Param);
                }
                com.ExecuteNonQuery();
                com = null;
                return true;
            }
            catch (Exception)
            {
                com = null;
                return false;
            }
        }

        public static SqlDataReader GetTxnQuery(String query)
        {
            try
            {
                com = new SqlCommand();
                com.Transaction = txn;
                com.Connection = con;
                com.CommandText = query;
                SqlDataReader dr = com.ExecuteReader();
                com = null;
                return dr;
            }
            catch (Exception)
            {
                com = null;
                return null;
            }

        }

        public static bool CommitTxn()
        {
            try
            {
                txn.Commit();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool RollbackTxn()
        {
            try
            {
                txn.Rollback();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
