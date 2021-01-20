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
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut6 = new SqlCommand("select * from tbl_Ders", Baglanti.bgl);
            if (komut6.Connection.State != ConnectionState.Open)
            {
                komut6.Connection.Open();
            }
            SqlDataReader dr2 = komut6.ExecuteReader();
            while (dr2.Read())
            {
                EntityDers ent = new EntityDers();
                ent.id = Convert.ToInt32(dr2["DERSID"].ToString());
                ent.dersad = dr2["DERSAD"].ToString();
                ent.min = int.Parse(dr2["DERSMINKONTEJAN"].ToString());
                ent.max = int.Parse(dr2["DERSMAXKONTEJAN"].ToString());
                degerler.Add(ent);
            }
            dr2.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuru p)
        {
            SqlCommand komut8 = new SqlCommand("insert into Tbl_Basvuru (OGRID,DERSID) VALUES (@p1,@p2)", Baglanti.bgl);
            komut8.Parameters.AddWithValue("@p1", p.BASOGRID1);
            komut8.Parameters.AddWithValue("@p2", p.BASDERSID1);
            if (komut8.Connection.State != ConnectionState.Open)
            {
                komut8.Connection.Open();
            }
            return komut8.ExecuteNonQuery();
        }
    }
}
