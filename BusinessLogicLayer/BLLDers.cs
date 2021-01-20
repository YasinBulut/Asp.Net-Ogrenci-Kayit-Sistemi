using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public  class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }

        public static int TaleoEkleBll(EntityBasvuru p)
        {
            if (p.BASOGRID1 != null && p.BASDERSID1 !=null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
