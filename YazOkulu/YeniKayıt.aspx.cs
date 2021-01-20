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
    public partial class YeniKayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.ad = txtad.Text;
            ent.soyad = txtsoyad.Text;
            ent.numara = txtnumara.Text;
            ent.mail = txtmail.Text;
            ent.sifre = txtsifre.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}