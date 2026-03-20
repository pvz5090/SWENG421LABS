using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class TV
    {
        protected int MSRP = 200;
        protected string type = "TV";

        public TV Replenish(string type, int budget)
        {
            TV kingTV = new TV(); 
            Middleman proxy = new Middleman(); 
            foreach(TV tv in proxy.tvTable)
            {
                if (tv.GetPrice() <= budget && kingTV.GetPrice() < tv.GetPrice())
                {
                    if (type == null)
                    {
                        kingTV = tv;
                    }
                    else
                    {
                        if (type.Equals(tv.GetType()))
                        {
                            kingTV = tv;
                        }
                    }

                }
            }
            
            return kingTV; 
        }
        public string GetType() { return type; }
        public double GetPrice() { return MSRP; }
        public string GetInfo()
        {
            string str = "";
            str += "Type: "+ GetType() + "\n" + "Price:" +GetPrice() + "\n";
            return str; 
        }

        protected class SmartTV : TV
        {
            public SmartTV()
            {
                MSRP = 300;
                type = "SmartTV"; 
            }
            public double GetPowerUsage() { return 5.5; }
        }
        protected class UltraHDTV: TV
        {
            public UltraHDTV()
            {
                MSRP = 400;
                type = "UltraHDTV"; 
            }
            public int GetResolution() { return 2; }
        }
    }
}
