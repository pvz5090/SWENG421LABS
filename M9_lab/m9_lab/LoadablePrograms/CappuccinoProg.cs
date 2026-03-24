using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class CappuccinoProg:LoadableClasses
    {
        public override void run()
        {
            enviroment.setLEDnum(2);
            enviroment.setGrindingTime(6);
            enviroment.setTemperature(140);
            enviroment.setLEDnum(-1);
        }
    }
}
