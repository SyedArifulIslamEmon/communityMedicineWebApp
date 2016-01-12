using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.DAL
{
    public class CenterGateway
    {
        private string conncetionStr = ConfigurationManager.ConnectionStrings["ConnDBStr"].ConnectionString;

        public int Insert(Center aCenter)
        {
            string query = "insert into center_tbl values ('" + aCenter.Name + "','" + aCenter.Code + "','" + Encrypt(aCenter.Password) + "','" + aCenter.ThanaId + "')";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffect = aCommand.ExecuteNonQuery();
            aConnection.Close();

            return rowAffect;
        }
       
      

        public List<string> GetCenterList(int id)

        {

            string query = "select * from center_tbl where thana_id='" + id + "'";
            List<string> aList = new List<string>();
            aList.Add("Select a Center");
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aList.Add(aReader["center_name"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return aList;
        }
       

        public int GetTotalCenter(int thanaId)
        {
            int total= 0;
            string query = "select * from center_tbl where thana_id='" + thanaId + "'";

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                total++;
            }
            aReader.Close();
            aConnection.Close();

            return total;
        }
        public int GetCenterId(string name, int mode)
        {
            int id = 0;
            string query;
            if(mode==0)
            query = "select Center_id from Center_tbl where Center_name='" + name + "'";
            else
            {
                query = "select Center_id from Center_tbl where Center_code='" + name + "'";
            }

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                id = Convert.ToInt32(aReader["Center_id"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return id;
        }
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public List<int> GetCenterListByThanaID(int thanaId)
        {
            List<int> aList= new List<int>();
            string query = "select * from center_tbl where thana_id='" + thanaId + "'";

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aList.Add(Convert.ToInt32(aReader["center_id"].ToString()));
            }
            aReader.Close();
            aConnection.Close();

            return aList;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        public bool Cheak(string name,int thanaId)
        {
            bool found = false;

            string query = "select * from center_tbl where center_name = '" + name + "' and thana_id = '"+thanaId+"'";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                found = true;
            }
            aReader.Close();
            aConnection.Close();

            return found;
        }
        public string AuthenticateCenterLogin(string code)
        {
            string query = "select * from Center_tbl where Center_code = '" + code + "'  ";
            string res = "not found";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                res = Decrypt(aReader["center_password"].ToString());
            }
            aConnection.Close();

            return res;

        }
    }
}