using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer
{
    public class EntityDers
    {
        private string DERSAD;
        public string dersad
        {
            get { return DERSAD; }
            set { DERSAD = value; }
        }

        private int MIN;
        public int min
        {
            get { return MIN; }
            set { MIN = value; }
        }

        private int MAX;
        public int max
        {
            get { return MAX; }
            set { MAX = value; }
        }

        private int ID;
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}
