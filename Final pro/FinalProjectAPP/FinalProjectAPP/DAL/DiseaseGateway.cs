using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.DAL
{
    public class DiseaseGateway
    {
        private string conncetionStr = ConfigurationManager.ConnectionStrings["ConnDBStr"].ConnectionString;
        public int Insert(Disease aDisease)
        {
            string query = "insert into Disease_tbl values ('" + aDisease.Name + "','" + aDisease.Description + "','" + aDisease.Treatment + "')";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffect = aCommand.ExecuteNonQuery();
            aConnection.Close();

            return rowAffect;
        }
        public DataTable GetAllDisease()
        {
            DataTable aTable = new DataTable();
            aTable.Columns.Add("Serial No");
            aTable.Columns.Add("Name");
            aTable.Columns.Add("Description");
            aTable.Columns.Add("Treatment");
            string query = "select * from disease_tbl ";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aTable.Rows.Add(aReader["disease_id"].ToString(), aReader["disease_name"].ToString(), aReader["disease_description"].ToString(), aReader["treatement_procedure"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return aTable;
        }

        public bool Cheak(string name)
        {
            bool found = false;

            string query = "select * from disease_tbl where disease_name = '" + name + "'";
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

        public int GetDiseaseId(string name)
        {
            int id = 0;
            string query = "select disease_id from disease_tbl where disease_name='" + name + "'";


            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                id = Convert.ToInt32(aReader["disease_id"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return id;
        }
    }
}