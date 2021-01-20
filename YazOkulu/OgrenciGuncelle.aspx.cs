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
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            txtıd.Text = x.ToString();
            txtıd.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
                txtad.Text = OgrList[0].ad.ToString();
                txtsoyad.Text = OgrList[0].soyad.ToString();
                txtnumara.Text = OgrList[0].numara.ToString();
                txtmail.Text = OgrList[0].mail.ToString();
                txtsifre.Text = OgrList[0].sifre.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.ad = txtad.Text;
            ent.soyad = txtsoyad.Text;
            ent.numara = txtnumara.Text;
            ent.mail = txtmail.Text;
            ent.sifre = txtsifre.Text;
            ent.id = Convert.ToInt32(txtıd.Text);
            BLLOgrenci.OgrenciGuncelleBll(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}