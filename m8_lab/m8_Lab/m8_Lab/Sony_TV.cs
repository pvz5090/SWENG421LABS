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
        private string type;
        protected static string brand;

        public TV_IF Replenish(string type, int budget)
        {
            if (type == "UltraHD_TV" )
            {
                if (budget >= 480)
                { 
                    return new Sony_UltraHD_TV();
                }
                else 
                {
                    return null;
                }
            }
            else if (type == "Smart_TV" )
            {
                if (budget >= 380)
                {
                    return new Sony_Smart_TV();
                }
                else 
                {
                    return null;
                }
            }else if(budget >= 280)
            {
                return new Sony_TV();
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
