using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class Middleman : TV, TV_IF
    {
        public List<TV> tvTable;
        private TV tv; 

        public Middleman()
        {
            tvTable = new List<TV>();
            tvTable.Add(new TV());
            tvTable.Add(new SmartTV());
            tvTable.Add(new UltraHDTV());
            tvTable.Add(new Sony_TV());
            tvTable.Add(new Sony_Smart_TV());
            tvTable.Add(new Sony_UltraHD_TV());
            tvTable.Add(new LG_TV()); 
            tvTable.Add(new LG_Smart_TV());
            tvTable.Add(new LG_UltraHD_TV());
            tv = new TV(); 
        }
        public string GetBrand()
        {
            return "No Brand"; 
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public TV Replenish(string type, int budget)
        {
            throw new NotImplementedException();
        }

        string TV_IF.GetType()
        {
            throw new NotImplementedException();
        }
    }
}
