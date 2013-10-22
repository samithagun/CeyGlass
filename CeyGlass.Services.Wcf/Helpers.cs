using DBLayer;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CeyGlass.Services.Wcf
{
    public class Helpers
    {
        public static string GenerateNewNo(InventorySalesDebtorsSystemEntities DataBaseEntity, string ReferenceID, string BranchCode)
        {
            string ReferenceNo;

            try
            {
                sReferencePrefix referencePrefix = DataBaseEntity.sReferencePrefixes.Single(p => p.ReferenceID == ReferenceID && p.BranchCode == BranchCode);
                int ReferenceValue = (referencePrefix.ReferenceValue)++;

                ReferenceNo = referencePrefix.ReferencePrefix + referencePrefix.BranchPrefix;
                ReferenceNo += ReferenceValue.ToString().PadLeft(15 - ReferenceNo.Length, '0');
                return ReferenceNo;
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                return null;
            }
        }

        public static void WriteException(Exception ex)
        {
            if (ex.Message == "Table doesn't have a primary key.")
                return;

            Console.WriteLine("Exception @" + DateTime.Now + "/n" + ex.Message);
            //if (Program.DebuggingMode)
            //    System.Windows.Forms.MessageBox.Show("Exception: " + ex.Message + "\nInner Exception: " + ex.InnerException);
        }

        public static string GetMachineInfo()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        /// <summary>

        /// Key for the crypto provider

        /// </summary>

        private static readonly byte[] _key = { 0xA1, 0xF1, 0xA6, 0xBB, 0xA2, 0x5A, 0x37, 0x6F, 0x81, 0x2E, 0x17, 0x41, 0x72, 0x2C, 0x43, 0x27 };

        /// <summary>

        /// Initialization vector for the crypto provider

        /// </summary>

        private static readonly byte[] _initVector = { 0xE1, 0xF1, 0xA6, 0xBB, 0xA9, 0x5B, 0x31, 0x2F, 0x81, 0x2E, 0x17, 0x4C, 0xA2, 0x81, 0x53, 0x61 };

        public static string Decrypt(string Value)
        {

            SymmetricAlgorithm mCSP;
            ICryptoTransform ct = null;
            MemoryStream ms = null;
            CryptoStream cs = null;
            byte[] byt;
            byte[] _result;
            mCSP = new RijndaelManaged();
            try
            {
                mCSP.Key = _key;
                mCSP.IV = _initVector;
                ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);
                byt = Convert.FromBase64String(Value);
                ms = new MemoryStream();
                cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
                cs.Write(byt, 0, byt.Length);
                cs.FlushFinalBlock();
                cs.Close();
                _result = ms.ToArray();
            }
            catch
            {
                _result = null;
            }
            finally
            {
                if (ct != null)
                    ct.Dispose();
                if (ms != null)
                    ms.Dispose();
                if (cs != null)
                    cs.Dispose();
            }
            return ASCIIEncoding.UTF8.GetString(_result);

        }

        public static string Encrypt(string Password)
        {
            if (string.IsNullOrEmpty(Password))
                return string.Empty;

            byte[] Value = Encoding.UTF8.GetBytes(Password);
            SymmetricAlgorithm mCSP = new RijndaelManaged();
            mCSP.Key = _key;
            mCSP.IV = _initVector;
            using (ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                    {
                        cs.Write(Value, 0, Value.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

    }
}
