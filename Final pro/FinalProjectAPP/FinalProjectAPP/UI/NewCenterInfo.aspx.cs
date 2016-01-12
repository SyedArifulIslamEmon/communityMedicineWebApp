using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectAPP.UI
{
    public partial class NewCenterInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            nameLabel.Text = Session["name"].ToString();
            codeLabel.Text = Session["code"].ToString();
            passLabel.Text = Session["password"].ToString();
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}