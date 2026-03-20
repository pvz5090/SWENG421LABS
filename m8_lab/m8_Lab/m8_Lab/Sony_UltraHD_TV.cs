using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class Sony_UltraHD_TV : Sony_TV, UltraHD_TV_IF
    {
        private int MSRP = 480;
        public new int GetPrice()
        {
            return MSRP; 
        }
        public int GetResolution()
        {
            return 4;
        }
        public new TV_IF Replenish(string type, int budget)
        {
            return base.Replenish(type, budget);
        }
        public new string GetInfo()
        {
            return $"{base.GetInfo()}Resolution: {GetResolution()}\n";
        }
    }
}
