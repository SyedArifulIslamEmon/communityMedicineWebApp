using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProjectAPP.BLL;
using FinalProjectAPP.MODEL;
using Newtonsoft.Json;

namespace FinalProjectAPP.UI.CenterUI
{
    public partial class TreatmentUI : System.Web.UI.Page
    {
        DiseaseManager aDiseaseManager = new DiseaseManager();
        DoctorManager aDoctorManager = new DoctorManager();
        MedicineManager aMedicineManager = new MedicineManager();
        TreatementManager aTreatementManager = new TreatementManager();
        CenterMedicineRelationManager aCenterMedicineRelationManager = new CenterMedicineRelationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TreatmentGridViewHeader();
                doctorDropDownList.DataSource =
                aDoctorManager.GetDoctorList(Convert.ToInt32(Session["center_id"].ToString()));
                doctorDropDownList.DataBind();
            }
        }

        protected void docterDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = aDiseaseManager.GetAllDisease();
            List<string> aList = new List<string>();
            aList.Add("Select A Disease");
            foreach (DataRow dr in dt.Rows)
            {
                aList.Add(dr["Name"].ToString());
            }
            diseaseDropDownList.DataSource = aList;
            diseaseDropDownList.DataBind();
        }

        protected void diseaseDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> aList = new List<int>();
            aList =  aCenterMedicineRelationManager.GetMedicinListByCenterID(Convert.ToInt32(Session["center_id"].ToString()));
            List<string> aNameList = new List<string>();

            aNameList.Add("Select A Medicine");
            foreach (int i in aList)
            {
                aNameList.Add(aMedicineManager.GetMedicineNambeById(i));
            }

            medicineDropDownList.DataSource = aNameList;
            medicineDropDownList.DataBind();
        }

        protected void medicineDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void doseDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void showDetailsButton_Click(object sender, EventArgs e)
        {
            FillTextBox();
            string patientID = voterIdTextBox.Text;
            serviceNumberTextBox.Text = Convert.ToString(aTreatementManager.GetTreatementCount(patientID));
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<Treatment> aList = new List<Treatment>();
            aList = (List<Treatment>)ViewState["Treatment"];
            foreach (Treatment treatment in aList)
            {
                aTreatementManager.Insert(treatment);
                CenterMedicineRelation aCenterMedicineRelation = new CenterMedicineRelation();
                aCenterMedicineRelation.CenterId = Convert.ToInt32(Session["center_id"].ToString());
                aCenterMedicineRelation.MedicineId = treatment.MedicineId;
                aCenterMedicineRelation.MedicineQuantity = treatment.MedicineQty;
                aCenterMedicineRelationManager.UpdateMedicine(aCenterMedicineRelation);
            }
            massegeLabel.Text = "Saved";
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            Treatment aTreatment = new Treatment();
            aTreatment.DiseaseId = aDiseaseManager.GetDiseaseId(diseaseDropDownList.Text);
            aTreatment.PatientId = voterIdTextBox.Text;
            aTreatment.MedicineId = aMedicineManager.GetMedicineIdByName(medicineDropDownList.Text);
            aTreatment.Dose = doseDropDownList.Text;
            if (RadioButton1.Checked == true)
            {
                aTreatment.BeforeAfter = "Before Meal";
            }
            else
            {
                aTreatment.BeforeAfter = "After Meal";
            }
            aTreatment.MedicineQty = Convert.ToInt32(quantityTextBox.Text);
            aTreatment.Note = noteTextBox.Text;
            aTreatment.Date = dateTextBox.Text;
            aTreatment.Count = Convert.ToInt32(serviceNumberTextBox.Text)+1;
            aTreatment.CenterId = Convert.ToInt32(Session["center_id"].ToString());
            //
            if (aCenterMedicineRelationManager.GetMedicineQty(Convert.ToInt32(Session["center_id"].ToString()),
                aTreatment.MedicineId) < Convert.ToInt32(quantityTextBox.Text))
            {
                Label16.Text = "Out Of stock ";
            }
            else
            {
                AddTreatementInQueue(aTreatment);
                AddTreatmentInViewState(aTreatment);
            }

        }

        public void AddTreatmentInViewState(Treatment aTreatment)
        {
            if (ViewState["Treatment"] == null)
            {
                List <Treatment> aList = new List<Treatment>();
                aList.Add(aTreatment);

                ViewState["Treatment"] = aList;
            }
            else
            {
                List <Treatment> aList = new List<Treatment>();
                aList = (List<Treatment>) ViewState["Treatment"];
                aList.Add(aTreatment);
                ViewState["Treatment"] = aList;
            }
        }

 
        public void FillTextBox()
        {
            WebRequest request = WebRequest.Create("http://nerdcastlebd.com/web_service/voterdb/index.php/voters/all/format/json");
            WebResponse response = request.GetResponse();
            string json;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                json = sr.ReadToEnd();
            }
            var serializer = new JavaScriptSerializer();
            VoterObj aPerson = JsonConvert.DeserializeObject<VoterObj>(json);


            foreach (Voter voters in aPerson.voters)
            {
                if (voterIdTextBox.Text == voters.Id)
                {
                    nameTextBox.Text = voters.Name;
                    addressTextBox.Text = voters.Address;
                    ageTextBox.Text = voters.Date_of_birth;

                }

            }

        }


        private void TreatmentGridViewHeader()
        {

            DataTable dt = new DataTable();
            DataRow dr;
            dt.TableName = "TreatmentList";
            dt.Columns.Add(new DataColumn("Disease", typeof(string)));
            dt.Columns.Add(new DataColumn("Medicine", typeof(string)));
            dt.Columns.Add(new DataColumn("Dose", typeof(string)));
            dt.Columns.Add(new DataColumn("Before/After", typeof(string)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
            dt.Columns.Add(new DataColumn("Note", typeof(string)));

            dr = dt.NewRow();
            dt.Rows.Add(dr);
            //saving databale into viewstate   
            ViewState["TreatmentList"] = dt;
            //bind Gridview  
            treatmentGridView.DataSource = dt;
            treatmentGridView.DataBind();

        }


        public void AddTreatementInQueue(Treatment aTreatment)
        {

            if (ViewState["TreatmentList"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["TreatmentList"];
                DataRow drCurrentRow = null;

                if (dtCurrentTable.Rows.Count > 0)
                {

                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {
                        drCurrentRow = dtCurrentTable.NewRow();
                        drCurrentRow["disease"] = diseaseDropDownList.Text;
                        drCurrentRow["medicine"] = medicineDropDownList.Text;
                        drCurrentRow["dose"] = doseDropDownList.Text;
                        drCurrentRow["Before/After"] = aTreatment.BeforeAfter;
                        drCurrentRow["quantity"] = quantityTextBox.Text;
                        drCurrentRow["note"] = noteTextBox.Text;
                    }
                    if (dtCurrentTable.Rows[0][0].ToString() == "")
                    {
                        dtCurrentTable.Rows[0].Delete();
                        dtCurrentTable.AcceptChanges();
                    }

                    dtCurrentTable.Rows.Add(drCurrentRow);

                    ViewState["TreatmentList"] = dtCurrentTable;
                    treatmentGridView.DataSource = dtCurrentTable;
                    treatmentGridView.DataBind();

                }
            }
        }





    }
}