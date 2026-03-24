using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class MochaProg : LoadableClasses
    {
        public MochaProg()
        {
            this.price = 4;
        }
        public override void run()
        {
            enviroment.setLEDnum(1);
            enviroment.setGrindingTime(8);
            enviroment.setTemperature(150);
            enviroment.setLEDnum(-1);
        }
    }
}
