using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class Sony_TV : TV,TV_IF
    {
        private int MSRP;
        private String type;
        private int resolution;
        private double powerUsage;
        protected static String brand;

        public TV Replenish(String type, int budget)
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

        public String GetBrand()
        {
            return this.brand;
        }

        public String GetType()
        {
            return this.type;
        }

        public String GetInfo()

        {

        }

    }
}
