using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class TV
    {
        public int MSRP;
        public string type;

        public TV replenish(string type, int budget)
        {
            TV kingTV = null; 
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
            return new TV(); 
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
            public double
        }
        protected class UltraTV: TV
        {

        }
    }
}
