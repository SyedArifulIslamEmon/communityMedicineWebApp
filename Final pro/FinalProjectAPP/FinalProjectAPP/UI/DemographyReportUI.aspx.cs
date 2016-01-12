using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using EGIS.Web.Controls;

namespace FinalProjectAPP.UI
{
    public partial class DemographyReportUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.MapPanControl1.SetMap(this.SFMap1);
        }
        private static double[] GetQuintiles(double[] samples)
        {
            Array.Sort(samples);
            double[] quintiles = new double[4];
            //quintiles[0] = samples[(int)(samples.Length * 0.2)];
            //quintiles[1] = samples[(int)(samples.Length * 0.4)];
            //quintiles[2] = samples[(int)(samples.Length * 0.6)];
            //quintiles[3] = samples[(int)(samples.Length * 0.8)];

            quintiles[0] = samples[10];
            quintiles[1] = samples[30];
            quintiles[2] = samples[50];
            quintiles[3] = samples[60];
            return quintiles;
        }

        private void SetupPopulation()
        {
            TooltipHeaderFieldNamePair[] tooltipPairs;
            tooltipPairs = new TooltipHeaderFieldNamePair[] { 
                new TooltipHeaderFieldNamePair("District: ", "NAME_3"),
                new TooltipHeaderFieldNamePair("Population: ", "popu_mis")};
            SetupCustomRenderSettings("popu_mis", 0, tooltipPairs);

            /*
            tooltipPairs = new TooltipHeaderFieldNamePair[] { 
                    new TooltipHeaderFieldNamePair("County: ", "popu_mis"),
                    new TooltipHeaderFieldNamePair("Median Rent: $", "popu_mis")};

            SetupCustomRenderSettings("popu_mis", 1, tooltipPairs);
             */
        }

        private void SetupCustomRenderSettings(string fieldName, int layerIndex, TooltipHeaderFieldNamePair[] tooltipFields)
        {
            //get the required layer
            EGIS.ShapeFileLib.RenderSettings renderSettings = SFMap1.GetLayer(layerIndex).RenderSettings;
            int numRecords = SFMap1.GetLayer(layerIndex).RecordCount;
            EGIS.ShapeFileLib.DbfReader dbfReader = renderSettings.DbfReader;
            int fieldIndex = dbfReader.IndexOfFieldName(fieldName);

            double[] samples = new double[numRecords];
            //find the range of population values and obtain the quintile quantiles
            for (int n = 0; n < numRecords; n++)
            {


                if (String.IsNullOrEmpty(dbfReader.GetField(n, fieldIndex)) == false)
                {
                    string tmp = dbfReader.GetField(n, fieldIndex);
                    int value;
                    if (int.TryParse(tmp, out value))
                    {
                        double d = double.Parse(dbfReader.GetField(n, fieldIndex), System.Globalization.CultureInfo.InvariantCulture);
                        samples[n] = d;
                    }
                }
            }
            double[] ranges = GetQuintiles(samples);

            //create the quintile colors - there will be 1 more color than the number of elements in quantiles
            Color[] cols = new Color[] { 
                Color.FromArgb(96,169, 5), 
                Color.FromArgb(201, 200, 123), 
                Color.FromArgb(157, 135, 151), 
                Color.FromArgb(112, 155, 235),
                Color.FromArgb(255,0,0)};

            //setup the list of tooltip fields
            System.Collections.Generic.List<TooltipHeaderFieldNamePair> tooltipPairList = null;
            if (tooltipFields != null)
            {
                tooltipPairList = new System.Collections.Generic.List<TooltipHeaderFieldNamePair>();
                tooltipPairList.AddRange(tooltipFields);
            }

            //create a new QuantileCustomRenderSettings and add it to the SFMap
            QuantileCustomRenderSettings rcrs = new QuantileCustomRenderSettings(renderSettings, cols, ranges, fieldName, tooltipPairList);
            SFMap1.SetCustomRenderSettings(layerIndex, rcrs);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 1)
            {
                SetupPopulation();
            }
        }
    }
}