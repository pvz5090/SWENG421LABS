using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class RegularProg:LoadableClasses
    {
        public override void run()
        {
            enviroment.setLEDnum(1);
            enviroment.setGrindingTime(5);
            enviroment.setTemperature(200);
            enviroment.setLEDnum(0);
        }
    }
}
