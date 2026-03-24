using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class EspressoProg:LoadableClasses
    {
        public EspressoProg() {
            this.price = 5;
        }
        public override void run()
        {
            enviroment.setLEDnum(3);
            enviroment.setGrindingTime(5);
            enviroment.setTemperature(200);
            enviroment.setLEDnum(-1);
        }
    }
}
