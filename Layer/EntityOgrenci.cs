using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer
{
    public class EntityOgrenci
    {
        private string AD; 
        public string ad
        {
            get { return AD; }
            set { AD = value; }
        }

        private string SOYAD;
        public string soyad
        {
            get { return SOYAD; }
            set { SOYAD = value; }
        }

        private int ID;
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        private string NUMARA;
        public string numara
        {
            get { return NUMARA; }
            set { NUMARA = value; }
        }

        private string MAIL;
        public string mail
        {
            get { return MAIL; }
            set { MAIL = value; }
        }

        private string SIFRE;
        public string sifre
        {
            get { return SIFRE; }
            set { SIFRE = value; }
        }

        private double BAKIYE;
        public double bakiye
        {
            get { return BAKIYE; }
            set { BAKIYE = value; }
        }

    }
}
