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
    public partial class CenterLoginUI1 : System.Web.UI.Page
    {
        CenterManager aCenterManager = new CenterManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Center aCenter = new Center();

            aCenter.Code = codeTextBox.Text;
            aCenter.Password = passwordTextBox.Text;
            if (aCenter.Password == "")
                massegeLabel.Text = "Error";
            massegeLabel.Text = aCenter.Password;

            if (aCenterManager.AuthenticateCenterLogin(aCenter.Code, aCenter.Password) == true)
            {
                //massegeLabel.Text = "";
                Session["center_code"] = aCenter.Code;
                Session["center_id"] = aCenterManager.GetCenterId(aCenter.Code, 1);
                Response.Redirect("CenterUI/DoctorEntryUI.aspx");
            }
            else
            {
                massegeLabel.Text = "Incorrect Center Code OR password";
            }
        }
    }
}