using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProjectAPP.BLL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.UI.CenterUI
{
    public partial class DoctorEntryUI : System.Web.UI.Page
    {
        DoctorManager aDoctorManager = new DoctorManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Session["center_id"]=="")
            //    Response.Redirect("CenterLoginUI.aspx");
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Doctor aDoctor = new Doctor();
            aDoctor.Name = nameTextBox.Text;
            aDoctor.Degree = degreeTextBox.Text;
            aDoctor.Specialization = specializationTextBox.Text;
            aDoctor.CenterID = Convert.ToInt32(Session["center_id"].ToString());
            massegeLabel.Text = aDoctorManager.Insert(aDoctor);
        }
    }
}