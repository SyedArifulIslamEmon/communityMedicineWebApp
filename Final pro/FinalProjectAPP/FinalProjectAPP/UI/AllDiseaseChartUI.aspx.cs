using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using FinalProjectAPP.BLL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.UI
{
    public partial class AllDiseaseChartUI : System.Web.UI.Page
    {
        DistrictThanaManager aDistrictThanaManager = new DistrictThanaManager();
        DiseaseManager aDiseaseManager = new DiseaseManager();
        CenterManager aCenterManager = new CenterManager();
        TreatementManager aTreatementManager = new TreatementManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                districtDropDownList.DataSource = aDistrictThanaManager.GetDistrictList();
                districtDropDownList.DataBind();
            }
        }


        private void LoadChartData(DataTable initialDataSource)
        {

            for (int i = 1; i < initialDataSource.Columns.Count; i++)
            {

                Series series = new Series();

                foreach (DataRow dr in initialDataSource.Rows)
                {

                    int y = (int)dr[i];

                    series.Points.AddXY(dr["Data"].ToString(), y);

                }

                Chart1.Series.Add(series);

            }

        }


        protected void Show_Click(object sender, EventArgs e)
        {
            string districtName = districtDropDownList.Text;
            int districtId = aDistrictThanaManager.GetDistrictId(districtName);
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

            DataTable dt = new DataTable();

            dt.Columns.Add("Data", Type.GetType("System.String"));
            dt.Columns.Add("Value1", Type.GetType("System.Int32"));

            DataTable didt = aDiseaseManager.GetAllDisease();
            
            foreach (DataRow dr in didt.Rows)
            {
                int diseaseId = Convert.ToInt32(dr["Serial No"].ToString());
                int total = 0;
                foreach (int i in centerList)
                {
                    total += aTreatementManager.GetTotalByCenterDisease(i, diseaseId,startTextBox.Text, endTextBox.Text);
                
                }
                DataRow dr1 = dt.NewRow();
                dr1["Data"] = dr["Name"];
                dr1["Value1"] = total;

                dt.Rows.Add(dr1);
            }
            LoadChartData(dt);
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }

        protected void districtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}