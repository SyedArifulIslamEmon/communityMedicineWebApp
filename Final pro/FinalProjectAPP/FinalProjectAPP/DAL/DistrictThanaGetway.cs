using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinalProjectAPP.DAL
{
    public class DistrictThanaGetway
    {
        private string conncetionStr = ConfigurationManager.ConnectionStrings["ConnDBStr"].ConnectionString;
        public int GetDistrictId(string name)
        {
            int id = 0;
            string query = "select district_id from district_tbl where district_name='" + name + "'";

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                id = Convert.ToInt32(aReader["district_id"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return id;
        }

        public List<int> GetThanaIDList(int id)
        {
            string query = "select * from thana_tbl where district_id = '" + id + "'";
            List<int> aList = new List<int>();
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aList.Add(Convert.ToInt32(aReader["thana_id"].ToString()));
            }
            aReader.Close();
            aConnection.Close();

            return aList;
        }
        public List<string> GetDistrictList()
        {
            string query = "select * from district_tbl";
            List<string> aList = new List<string>();
            aList.Add("Select a District");
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aList.Add(aReader["district_name"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return aList;
        }
        public int GetThanaId(string name)
        {
            int id = 0;
            string query = "select thana_id from thana_tbl where thana_name='" + name + "'";
           
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                id = Convert.ToInt32(aReader["thana_id"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return id;
        }

        public List<string> GetThanaList(int id)
        {
            string query = "select * from thana_tbl where district_id = '" + id + "'";
            List<string> aList = new List<string>();
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aList.Add(aReader["thana_name"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return aList;
        }

        public int GetPopulation(int id)
        {
            int popu = 0;
            string query = "select * from district_tbl where district_id='" + id + "'";

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                popu = Convert.ToInt32(aReader["district_population"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return popu;
        }

    }
}