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
            //
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
