using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProjectAPP.BLL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.UI
{
    public partial class SendMedicineUI1 : System.Web.UI.Page
    {
        CenterManager centerManager = new CenterManager();
        DistrictThanaManager aDistrictThanaManager = new DistrictThanaManager();
        MedicineManager aMedicineManager = new MedicineManager();
        CenterMedicineRelationManager aCenterMedicineRelationManager = new CenterMedicineRelationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                districtNameDropDownList.DataSource = aDistrictThanaManager.GetDistrictList();
                districtNameDropDownList.DataBind();
                quantityTextBox.Enabled = false;

                MedicineGridViewHeader();
            }
        }

        protected void districtNameDropDownList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string districtName = districtNameDropDownList.Text;
            int id = aDistrictThanaManager.GetDistrictId(districtName);

            thanaDropDownList.DataSource = aDistrictThanaManager.GetThanaList(id);
            thanaDropDownList.DataBind();

        }

        protected void thanaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thanaName = thanaDropDownList.Text;
            int id = aDistrictThanaManager.GetThanaId(thanaName);

            centerDropDownList.DataSource = centerManager.GetCenterList(id);
            centerDropDownList.DataBind();
        }

        protected void centerDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectMedicineDropDownList.DataSource = aMedicineManager.GetMedicineList();
            selectMedicineDropDownList.DataBind();
        }

        protected void selectMedicineDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityTextBox.Enabled = true;
        }

        protected void addButton_Click(object sender, EventArgs e)
        {

            Medicine aMedicine = new Medicine();
            aMedicine.Name = selectMedicineDropDownList.Text;
            aMedicine.Id = aMedicineManager.GetMedicineIdByName(aMedicine.Name);
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            AddMedicineInQueue(aMedicine.Name, quantity);

        }

        protected void medicineQueueGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["MedicineList"];
            foreach (DataRow row in dt.Rows)
            {
                CenterMedicineRelation aCenterMedicineRelation = new CenterMedicineRelation();
                aCenterMedicineRelation.CenterId = centerManager.GetCenterId(centerDropDownList.Text, 0);
                aCenterMedicineRelation.MedicineId = aMedicineManager.GetMedicineIdByName(row["name"].ToString());
                aCenterMedicineRelation.MedicineQuantity = Convert.ToInt32(row["quantity"].ToString());
                aCenterMedicineRelation.Date = DateTime.Now.ToString();

                if (aCenterMedicineRelationManager.IsExist(aCenterMedicineRelation) == false)
                {
                    
                    aCenterMedicineRelationManager.Insert(aCenterMedicineRelation);
                }
                else
                {
                    aCenterMedicineRelationManager.AddMedicine(aCenterMedicineRelation);
                }
            }
            
        }



        public void AddMedicineInQueue(string name, int quantity)
        {

            if (ViewState["MedicineList"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["MedicineList"];
                DataRow drCurrentRow = null;
                bool cheak = false;
                foreach (DataRow row in dtCurrentTable.Rows)
                {
                    if (row["Name"].ToString() == name)
                    {
                        row["quantity"] = Convert.ToInt32(row["quantity"])+quantity;
                        cheak = true;
                    }

                }
                if (dtCurrentTable.Rows.Count > 0)
                {
                    if (cheak == false)
                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {
                        drCurrentRow = dtCurrentTable.NewRow();
                        drCurrentRow["name"] = name;
                        drCurrentRow["quantity"] = quantity;
                    } 
                    if (dtCurrentTable.Rows[0][0].ToString() == "")
                    {
                        dtCurrentTable.Rows[0].Delete();
                        dtCurrentTable.AcceptChanges();
                    }
                    if (cheak == false)
                    dtCurrentTable.Rows.Add(drCurrentRow);

                    ViewState["MedicineList"] = dtCurrentTable;
                    medicineQueueGridView.DataSource = dtCurrentTable;
                    medicineQueueGridView.DataBind();
                }
            }

        }



        private void MedicineGridViewHeader()
        {

            DataTable dt = new DataTable();
            DataRow dr;
            dt.TableName = "MedicineList";
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(string)));

            dr = dt.NewRow();
            dt.Rows.Add(dr);
            //saving databale into viewstate   
            ViewState["MedicineList"] = dt;
            //bind Gridview  
            medicineQueueGridView.DataSource = dt;
            medicineQueueGridView.DataBind();
        }


    }
}