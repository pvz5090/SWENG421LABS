using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class TV
    {
        protected int MSRP;
        protected string type;
        
        public TV()
        {
            MSRP = 200; 
        }

        public TV replenish(string type, int budget)
        {
            TV kingTV = new TV(); 
            Middleman proxy = new Middleman(); 
            foreach(TV tv in proxy.tvTable)
            {
                if (tv.getPrice() <= budget && kingTV.getPrice() < tv.getPrice())
                {
                    if(type == null)
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
        public string getType() { return type; }
        public double getPrice() { return MSRP; }
        public string getInfo()
        {
            string str = "";
            str += getType() + "\n" + getPrice() + "\n";
            return str; 
        }

        protected class SmartTV : TV
        {
            public SmartTV()
            {
                MSRP = 300;
                type = "SmartTV"; 
            }
            public double getPowerUsage() { return 5.5; }
        }
        protected class UltraHDTV: TV
        {
            public UltraHDTV()
            {
                MSRP = 400;
                type = "UltraHDTV"; 
            }
            public int getResolution() { return 2; }
        }
    }
}
