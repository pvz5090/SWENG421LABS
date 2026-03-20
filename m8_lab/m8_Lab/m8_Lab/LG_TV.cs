using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class LG_TV : TV, TV_IF
    {
        private int MSRP = 250;
        private string type = "TV";
        protected static string brand = "LG";

        public TV_IF Replenish(string type, int budget)
        {
            if (type == "UltraHD_TV")
            {
                if (budget >= 450)
                {
                    return new LG_UltraHD_TV();
                }
                else
                {
                    return null;
                }
            }
            else if (type == "Smart_TV")
            {
                if (budget >= 350)
                {
                    return new LG_Smart_TV();
                }
                else
                {
                    return null;
                }
            }
            else if (budget >= 250)
            {
                return new LG_TV();
            }
            else
            {
                return null;
            }
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
            return $"Price: {GetPrice()}\nType: {GetType()}\nBrand{GetBrand()}\n";
        }
    }
}
