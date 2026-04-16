using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class Sony_TV : TV,TV_IF
    {
        private int MSRP = 280;
        private string type = "TV";
        protected static string brand = "Sony";

        public TV_IF Replenish(string type, int budget)
        {
            TV kingTV = new Sony_TV();
            Middleman proxy = new Middleman();
            foreach (TV tv in proxy.tvTable)
            {
                if (tv.GetPrice() <= budget && kingTV.GetPrice() < tv.GetPrice())  
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
            return kingTV as TV_IF;
        }

        public string GetBrand()
        {
            return brand;
        }

        public new string GetType()
        {
            return type;
        }

        public new int GetPrice()
        {
            return MSRP;
        }

        public new string GetInfo()
        {
            return $"Price: {GetPrice()}\nType: {GetType()}\nBrand: {GetBrand()}\n";
        }

    }
}
