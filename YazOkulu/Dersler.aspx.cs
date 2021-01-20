using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer;
using DataAccesLayer;
using BusinessLogicLayer;

namespace YazOkulu
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                List<EntityDers> EntDers = BLLDers.BllListele();
                DropDownList1.DataSource = BLLDers.BllListele();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();
            }
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuru ent = new EntityBasvuru();
            ent.BASOGRID1 = int.Parse(TextBox1.Text);
            ent.BASDERSID1 = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLDers.TaleoEkleBll(ent);
        }
    }
}