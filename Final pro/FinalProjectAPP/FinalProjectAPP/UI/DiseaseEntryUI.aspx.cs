using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProjectAPP.BLL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.UI
{

    public partial class DiseaseEntryUI1 : System.Web.UI.Page
    {
        DiseaseManager aDiseaseManager = new DiseaseManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dieseaseGridView.DataSource = aDiseaseManager.GetAllDisease();
                dieseaseGridView.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            Disease aDisease = new Disease();
            aDisease.Name = diseaseNameTextBox.Text;
            aDisease.Description = descriptionTextBox.Text;
            aDisease.Treatment = treatmentProcedureTextBox.Text;

            savelable.Text = aDiseaseManager.Insert(aDisease);

            dieseaseGridView.DataSource = aDiseaseManager.GetAllDisease();
            dieseaseGridView.DataBind();
        }
    }
}