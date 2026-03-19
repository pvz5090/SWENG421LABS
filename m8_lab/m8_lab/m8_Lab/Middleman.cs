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
            throw new NotImplementedException();
        }

        public string GetInfo()
        {
            return tv.getInfo() + "\n";
        }

        public TV_IF Replenish(string type, int budget)
        {
            TV_IF kingTV = new TV();
            foreach (TV tv in tvTable)
            {
                if (tv.getPrice() <= budget && kingTV.getPrice() < tv.getPrice())
                {
                    if (type == null)
                        kingTV = tv;
                    else
                    {
                        if (type.Equals(tv.GetType()))
                            kingTV = tv;
                    }

                }
            }
            return kingTV;
        }

        string TV_IF.GetType()
        {
            throw new NotImplementedException();
        }
    }
}
