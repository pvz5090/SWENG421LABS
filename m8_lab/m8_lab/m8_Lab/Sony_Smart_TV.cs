using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class Sony_Smart_TV: Sony_TV, Smart_TV_IF
    {
        private int MSRP = 380;
        private string type = "SmartTV";
        public new int GetPrice()
        {
            return MSRP; 
        }
        public new string GetType()
        {
            return type;
        }
		public double GetPowerUsage()
        {
            return 6.35;
        }
        public new TV_IF Replenish(string type, int budget)
        {
            return base.Replenish(type, budget);
        }
        public new string GetInfo()
        {
            return $"{base.GetInfo()}Power Usage: {GetPowerUsage()}";
        }
    }
}
