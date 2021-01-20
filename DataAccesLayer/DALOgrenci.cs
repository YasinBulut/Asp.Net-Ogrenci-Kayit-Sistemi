using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Layer;

namespace DataAccesLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into tbl_Ogrenci (OGRAD,OGRSOYAD,OGRNUMARA,OGRMAIL,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1",parametre.ad);
            komut1.Parameters.AddWithValue("@p2",parametre.soyad);
            komut1.Parameters.AddWithValue("@p3",parametre.numara);
            komut1.Parameters.AddWithValue("@p4",parametre.mail);
            komut1.Parameters.AddWithValue("@p5",parametre.sifre);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from tbl_Ogrenci",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.ad = dr["OGRAD"].ToString();
                ent.soyad = dr["OGRSOYAD"].ToString();
                ent.numara = dr["OGRNUMARA"].ToString();
                ent.mail = dr["OGRMAIL"].ToString();
                ent.sifre = dr["OGRSIFRE"].ToString();
                ent.bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("delete from tbl_ogrenci where ogrıd=@p1",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1",parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("select * from tbl_Ogrenci where OGRID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1",id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ad = dr["OGRAD"].ToString();
                ent.soyad = dr["OGRSOYAD"].ToString();
                ent.numara = dr["OGRNUMARA"].ToString();
                ent.mail = dr["OGRMAIL"].ToString();
                ent.sifre = dr["OGRSIFRE"].ToString();
                ent.bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("update tbl_ogrenci set OGRAD=@p1,OGRSOYAD=@p2,OGRNUMARA=@p3,OGRMAIL=@p4,OGRSIFRE=@p5 " +
                "where OGRID=@p6",Baglanti.bgl);
            komut5.Parameters.AddWithValue("@p1",deger.ad);
            komut5.Parameters.AddWithValue("@p2",deger.soyad);
            komut5.Parameters.AddWithValue("@p3",deger.numara);
            komut5.Parameters.AddWithValue("@p4",deger.mail);
            komut5.Parameters.AddWithValue("@p5",deger.sifre);
            komut5.Parameters.AddWithValue("@p6",deger.id);
            return komut5.ExecuteNonQuery() > 0;
        }

    }
}
