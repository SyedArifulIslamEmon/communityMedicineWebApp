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
    public partial class CenterEntryUI1 : System.Web.UI.Page
    {
        CenterManager aCenterManager = new CenterManager();
        DistrictThanaManager aDistrictThanaManager = new DistrictThanaManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                districtDropDownList.DataSource = aDistrictThanaManager.GetDistrictList();
                districtDropDownList.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
             Center aCenter = new Center();
            aCenter.Name = centerNameTextBox.Text;
            aCenter.ThanaId = aDistrictThanaManager.GetThanaId(thanaDropDownList.Text);
            aCenter.Password = GenaretPassword();
            aCenter.Code = GenerateId(districtDropDownList.Text.ToUpper(), thanaDropDownList.Text.ToUpper(),aCenter.ThanaId);


            

            Label4.Text = aCenterManager.Insert(aCenter);

            if (Label4.Text == "Saved")
            {
                Session["name"] = aCenter.Name;
                Session["code"] = aCenter.Code;
                Session["password"] = aCenter.Password;
                Response.Redirect("NewCenterInfo.aspx");
            }
        }

        protected void districtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string districtName = districtDropDownList.Text;
            int districtId = aDistrictThanaManager.GetDistrictId(districtName);

            thanaDropDownList.DataSource = aDistrictThanaManager.GetThanaList(districtId);
            thanaDropDownList.DataBind();
        }

        protected void thanaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        public String GenaretPassword()
        {
            string password = "";
            for (int i = 0; i < 6; i++)
            {
                Random aRandom = new Random();
                int n = (int)(aRandom.NextDouble() * 100 * (i + 1));
                n = (n % 26);
                if (i % 2 == 0)
                    n += 'a';
                else
                    n += 'A';
                password += Convert.ToChar(n);
            }
            return password;
        }

        public string GenerateId(string district, string thana, int thanaId)
        {
            int numberOfcenter = aCenterManager.GetTotalThana(thanaId);
            string code = "";
            for (int i = 0; i < 3; i++)
            {
                code += district[i];
            }
            for (int i = 0; i < 3; i++)
            {
                code += thana[i];
            }
            code += ".";
            if (numberOfcenter < 9)
            {
                code += "00" + (numberOfcenter + 1).ToString();
            }
            else if (numberOfcenter < 99)
            {
                code += "0" + (numberOfcenter + 1).ToString();
            }
            else
            {
                code += (numberOfcenter + 1).ToString();
            }

            return code;
        }






    }
}