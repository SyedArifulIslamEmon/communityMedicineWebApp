using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProjectAPP.BLL;

namespace FinalProjectAPP.UI.CenterUI
{
    public partial class MedicineStockReportUI : System.Web.UI.Page
    {
        CenterMedicineRelationManager aCenterMedicineRelationManager = new CenterMedicineRelationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["center_id"]!="")
             {
                int id = Convert.ToInt32(Session["center_id"].ToString());
            
                medicineStockGridView.DataSource = aCenterMedicineRelationManager.GetStockMedicine(id);
                medicineStockGridView.DataBind();
            }
            else
            {
                Response.Redirect("MedicineStockReportUI.aspx");
            }
        }
    }
}