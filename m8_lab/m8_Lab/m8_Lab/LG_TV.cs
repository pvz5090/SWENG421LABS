using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class LG_TV : TV, TV_IF
    {
        private int MSRP;
        private String type;
        private int resolution;
        private double powerUsage;
        protected static String brand;

        public TV Replenish(String type, int budget)
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
