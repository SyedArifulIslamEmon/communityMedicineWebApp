using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProjectAPP.MODEL;
using Newtonsoft.Json;

namespace FinalProjectAPP.UI.CenterUI
{
    public partial class AllTreatmentHistoryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            FillTextBox();
            
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
                if (nationalIdTextBox.Text == voters.Id)
                {
                    nameTextBox.Text = voters.Name;
                    addressTextBox.Text = voters.Address;
                    

                }

            }

        }


    }
}