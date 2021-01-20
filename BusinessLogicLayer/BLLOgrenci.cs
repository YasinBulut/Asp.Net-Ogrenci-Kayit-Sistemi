using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer;
using DataAccesLayer;

namespace BusinessLogicLayer
{
     public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.ad != null && p.soyad !=null && p.numara != null && p.sifre != null && p.mail != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p != null)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.ad != null && p.soyad != null && p.numara != null && p.sifre != null && p.mail != null && p.id>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }

    }
}
