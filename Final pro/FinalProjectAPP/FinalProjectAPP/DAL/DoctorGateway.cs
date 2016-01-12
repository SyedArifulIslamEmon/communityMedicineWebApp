using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.DAL
{
    public class DoctorGateway
    {
        private string conncetionStr = ConfigurationManager.ConnectionStrings["ConnDBStr"].ConnectionString;

        public int Insert(Doctor aDoctor)
        {
            string query = "insert into doctor_tbl values ('" + aDoctor.Name + "','" + aDoctor.Degree + "','" + aDoctor.Specialization + "','"+aDoctor.CenterID+"')";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffect = aCommand.ExecuteNonQuery();
            aConnection.Close();

            return rowAffect;
        }
        public List<string> GetDoctorList(int id)
        {

            string query = "select * from doctor_tbl where center_id='" + id + "'";
            List<string> aList = new List<string>();
            aList.Add("Select A Doctor Name");
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aList.Add(aReader["doctor_name"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return aList;
        }
    }
}