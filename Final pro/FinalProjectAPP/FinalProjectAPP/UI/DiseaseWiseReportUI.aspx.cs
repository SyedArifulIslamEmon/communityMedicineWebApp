using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProjectAPP.BLL;

namespace FinalProjectAPP.UI.CenterUI
{
    public partial class DiseaseWiseReportUI : System.Web.UI.Page
    {
        DiseaseManager aDiseaseManager = new DiseaseManager();
        DistrictThanaManager aDistrictThanaManager = new DistrictThanaManager();
        TreatementManager aTreatementManager = new TreatementManager();
        CenterManager aCenterManager = new CenterManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = aDiseaseManager.GetAllDisease();
                List<string> aList = new List<string>();
                aList.Add("Select A Disease");
                foreach (DataRow dr in dt.Rows)
                {
                    aList.Add(dr["Name"].ToString());
                }
                selectDropDownList.DataSource = aList;
                selectDropDownList.DataBind();
            }
        }

        protected void selectButton_Click(object sender, EventArgs e)
        {
            

            List<string> disList = aDistrictThanaManager.GetDistrictList();
            DataTable dt = new DataTable();
            dt.Columns.Add("District Name");
            dt.Columns.Add("Total Patient");
            dt.Columns.Add("% On Population");
            for(int j=1;j<disList.Count;j++)
            {
                string s = disList[j];
                int districtId = aDistrictThanaManager.GetDistrictId(s);
                List<int> thanalList = aDistrictThanaManager.GetThanaIDList(districtId);
                List<int> centerList = new List<int>();
                foreach (int i in thanalList)
                {
                    List<int> aList = aCenterManager.GetCenterListByThanaID(i);
                    foreach (int i1 in aList)
                    {
                        centerList.Add(i1);
                    }
                }
                int total = 0;
                int diseaseId = aDiseaseManager.GetDiseaseId(selectDropDownList.Text);
               
                foreach (int i in centerList)
                {
                    total += aTreatementManager.GetTotalByCenterDisease(i, diseaseId,startTextBox.Text,endTextBox.Text);
                }
                int totalpopulation = aDistrictThanaManager.GetPopulation(districtId);

                double per = ((double) total/totalpopulation)*100;

                dt.Rows.Add(s, total, per);
            }
            diseaseGridView.DataSource = dt;
            diseaseGridView.DataBind();


        }
    }
}