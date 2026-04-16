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
        private TV_IF tv2; 

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
            tv2 = new Sony_TV(); 
        }
        public string GetBrand()
        {
            throw new NotImplementedException();
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public TV_IF Replenish(string type, int budget)
        {
            return (TV_IF) tv2.Replenish(type, budget);
        }

        string TV_IF.GetType()
        {
            return tv.GetType();
        }
    }
}
