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
    public partial class MedicineEntryUI1 : System.Web.UI.Page
    {
        MedicineManager aMedicineManager = new MedicineManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                medicineGridView.DataSource = aMedicineManager.GetAllMedicine();
                medicineGridView.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            Medicine aMedicine = new Medicine();
            aMedicine.Name = medicineNameTextBox.Text;

            saveLabel.Text = aMedicineManager.Insert(aMedicine);

            medicineGridView.DataSource = aMedicineManager.GetAllMedicine();
            medicineGridView.DataBind();
        }

        protected void medicineGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            medicineGridView.PageIndex = e.NewPageIndex;
            medicineGridView.DataSource = aMedicineManager.GetAllMedicine();
            medicineGridView.DataBind();
        }
    }
}