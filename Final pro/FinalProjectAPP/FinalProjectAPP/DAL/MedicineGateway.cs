using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.DAL
{
    public class MedicineGateway
    {
        private string conncetionStr = ConfigurationManager.ConnectionStrings["ConnDBStr"].ConnectionString;
        public int Insert(Medicine aMedicine)
        {
            string query = "insert into medicine_tbl values ('" + aMedicine.Name + "')";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query,aConnection);

            aConnection.Open();
            int rowAffect = aCommand.ExecuteNonQuery();
            aConnection.Close();

            return rowAffect;
        }





        public DataTable GetAllMedicine()
        {
            DataTable aTable = new DataTable();
            aTable.Columns.Add("Serial No");
            aTable.Columns.Add("Name");
            string query = "select * from medicine_tbl ";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aTable.Rows.Add(aReader["medicine_id"].ToString(), aReader["medicine_name"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return aTable;
        }


        public bool  Check(string name)
        {
            bool found = false; 
            
            string query = "select * from medicine_tbl where medicine_name = '"+name+"'";
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


        public List<string> GetMedicineList()
        {
            string query = "select * from Medicine_tbl";
            List<string> aList = new List<string>();
            aList.Add("Select a Medicine");
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aList.Add(aReader["medicine_name"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return aList;
        }

        public int GetMedicineIdByName(string name)
        {
            int id = 0;
            string query = "select * from medicine_tbl WHERE medicine_name = '"+name+"'  ";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                id = Convert.ToInt32(aReader["medicine_id"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return id;
        }

        public string GetMedicineNambeById(int id)
        {
            string name = "";
            string query = "select * from medicine_tbl WHERE medicine_id = '" + id + "'  ";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                name = aReader["medicine_name"].ToString();
            }
            aReader.Close();
            aConnection.Close();

            return name;
        }

    
    }

}