using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.DAL
{
    public class CenterMedicineRelationGetway
    {
        private string conncetionStr = ConfigurationManager.ConnectionStrings["ConnDBStr"].ConnectionString;
        public void Insert(CenterMedicineRelation aCenterMedicineRelation)
        {
            string query = "insert into Center_Medicine_Relation_tbl values ('" + aCenterMedicineRelation.CenterId + "','" + aCenterMedicineRelation.MedicineId + "','" + aCenterMedicineRelation.MedicineQuantity + "','" + aCenterMedicineRelation.Date + "')";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffect = aCommand.ExecuteNonQuery();
            aConnection.Close();
        }

        public void UpdateMedicine(CenterMedicineRelation aCenterMedicineRelation)
        {
            string query = "update Center_Medicine_Relation_tbl set medicine_quantity = medicine_quantity - '"+aCenterMedicineRelation.MedicineQuantity+"'where center_Id= ' "+aCenterMedicineRelation.CenterId+"'and medicine_id = '"+aCenterMedicineRelation.MedicineId+"' ";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffect = aCommand.ExecuteNonQuery();
            aConnection.Close();
        }

        public void AddMedicine(CenterMedicineRelation aCenterMedicineRelation)
        {
            string query = "update Center_Medicine_Relation_tbl set medicine_quantity = medicine_quantity + '" + aCenterMedicineRelation.MedicineQuantity + "'where center_Id= ' " + aCenterMedicineRelation.CenterId + "'and medicine_id = '" + aCenterMedicineRelation.MedicineId + "' ";
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffect = aCommand.ExecuteNonQuery();
            aConnection.Close();
        }
        public bool IsExist(CenterMedicineRelation aCenterMedicineRelation)
        {
            bool found = false;
            string query = "select * from Center_Medicine_Relation_tbl where center_id = '"+aCenterMedicineRelation.CenterId+"' and medicine_id = '"+aCenterMedicineRelation.MedicineId+"'";
            
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

        public List<int> GetMedicinListByCenterID(int id)
        {
            string query = "select * from Center_Medicine_Relation_tbl where center_id = '"+id+"' ";
            List<int> aList = new List<int>();
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aList.Add(Convert.ToInt32(aReader["medicine_id"].ToString()));
            }
            aReader.Close();
            aConnection.Close();

            return aList;
        }

        public int GetMedicineQty(int centerId, int medicineId)
        {
            int total = 0;
            string query = "select * from Center_Medicine_Relation_tbl where center_id = '" + centerId + "' and medicine_id = '" +medicineId + "'";

            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {

                total += Convert.ToInt32(aReader["medicine_quantity"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return total;
        }
        MedicineGateway aMedicineGateway = new MedicineGateway();
        public DataTable GetStockMedicine(int id)
        {   
            string query = "select * from Center_Medicine_Relation_tbl where center_id = '" + id + "' ";
            DataTable aDataTable = new DataTable();
            aDataTable.Columns.Add("Medicine Name");
            aDataTable.Columns.Add("Quantity");
            SqlConnection aConnection = new SqlConnection(conncetionStr);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                int medicineId = Convert.ToInt32(aReader["medicine_id"].ToString());
                aDataTable.Rows.Add(aMedicineGateway.GetMedicineNambeById(medicineId), aReader["medicine_quantity"].ToString());
            }
            aReader.Close();
            aConnection.Close();

            return aDataTable;
        }
    }
}