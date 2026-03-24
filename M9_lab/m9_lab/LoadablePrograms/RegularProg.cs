using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class RegularProg:LoadableClasses
    {
        public RegularProg()
        {
            this.price = 2; 
        }
        public override void run()
        {
            enviroment.setLEDnum(0);
            enviroment.setGrindingTime(10);
            enviroment.setTemperature(180);
            enviroment.setLEDnum(-1);
        }
    }
}
