using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;


namespace FinalProjectAPP.UI
{
    public partial class demoMapNewUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                BindChart();

            }

        }





        StringBuilder str = new StringBuilder();

    //Get connection string from web.config

   // SqlConnection conn = new SqlConnection("Data source = AKASH\SQLEXPRESS; Initial catalog=CommunutyMedicineDB; Integrated Security=True");

        
        



    private DataTable GetData()

    {
        string connectionStr = ConfigurationManager.ConnectionStrings["ConnDBStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionStr);

        DataTable dt = new DataTable();

        string cmd = "select * from disease_tbl";

        SqlDataAdapter adp = new SqlDataAdapter(cmd, conn);

        adp.Fill(dt);

        return dt;

    }

 

    private void BindChart()

    {

        DataTable dt = new DataTable();

        try

        {

            dt = GetData(); 

            str.Append(@" <script type='text/javascript'>

                         google.load('visualization', '1', {'packages': ['geochart']});

                         google.setOnLoadCallback(drawRegionsMap);

 

                          function drawRegionsMap() {

                            var data = google.visualization.arrayToDataTable([

                              ['Country', 'Popularity'],");

 

            int count = dt.Rows.Count - 1; 

            for (int i = 0; i <= count; i++)

            {

                str.Append("['" + dt.Rows[i]["Country"].ToString() + "',  " + dt.Rows[i]["Popularity"].ToString() + "],");

                if (i == count)

                {

                    str.Append("['" + dt.Rows[i]["Country"].ToString() + "',  " + dt.Rows[i]["Popularity"].ToString() + "]]);");

                }

            } 

            str.Append(" var options = {}; var chart = new google.visualization.GeoChart(document.getElementById('chart_div'));");

            str.Append("chart.draw(data, options); };");          

            str.Append("</script>");

            lt.Text = str.ToString();

        }

        catch

        {

        }

    }



    }
}