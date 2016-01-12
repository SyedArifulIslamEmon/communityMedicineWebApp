using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.DAL
{
    public class TreatementGateway
    {
        private string conncetionStr = ConfigurationManager.ConnectionStrings["ConnDBStr"].ConnectionString;

        public int Insert(Treatment aTreatment)
        {
            string query = "insert into treatment_tbl values ('"+aTreatment.DiseaseId+"','"+aTreatment.PatientId+"','"+aTreatment.MedicineId+"','"+aTreatment.Dose+"','"+aTreatment.BeforeAfter+"','"+aTreatment.MedicineQty+"','"+aTreatment.Note+"','"+aTreatment.Date+"','"+aTreatment.Count+"','"+aTreatment.CenterId+"')";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffect = aCommand.ExecuteNonQuery();
            aConnection.Close();

            return rowAffect;
        }

        public int GetTreatementCount(string patientId)
        {
            int total = 0;
            string query = "select * from treatment_tbl where patient_Id='" + patientId + "'";

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                total=Convert.ToInt32(aReader["treatment_count"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return total;
        }

        public int GetTotalByCenterDisease(int centerId, int diseaseId, string d1, string d2)
        {
            int total = 0;
            string query = "select * from treatment_tbl where center_id ='" + centerId + "' and disease_id = '" + diseaseId + "' and ( treatment_date between '"+d1+"' and '"+d2+"')";

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<string> voterIdList = new List<string>();
            List<int> countList = new List<int>();
            while (aReader.Read())
            {
                total = 1;
                voterIdList.Add(aReader["patient_id"].ToString());
                countList.Add(Convert.ToInt32(aReader["treatment_count"].ToString()));
            }
            aReader.Close();
            aConnection.Close();

            for (int i = 1; i < voterIdList.Count; i++)
            {
                if (voterIdList[i] == voterIdList[i - 1] && countList[i] == countList[i - 1])
                {

                }
                else
                {
                    total++;
                }
            }
            return total;
        }
        public List<int> GetCenterList( int diseaseId, string d1, string d2)
        {
            List<int> aList = new List<int>();
            string query = "select * from treatment_tbl where  disease_id = '" + diseaseId + "' and ( treatment_date between '" + d1 + "' and '" + d2 + "')";

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<string> voterIdList = new List<string>();
            List<int> countList = new List<int>();
            while (aReader.Read())
            {
                aList.Add(Convert.ToInt32(aReader["center_id"].ToString()));
                voterIdList.Add(aReader["center_id"].ToString());
                countList.Add(Convert.ToInt32(aReader["treatment_count"].ToString()));
            }
            aReader.Close();
            aConnection.Close();

            for (int i = 1; i < voterIdList.Count; i++)
            {
                if (voterIdList[i] == voterIdList[i - 1] && countList[i] == countList[i - 1])
                {

                }
                else
                {
                    aList.Add(Convert.ToInt32(aReader["center_id"].ToString()));
                }
            }
            return aList;
        }

    }
}