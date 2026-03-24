using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal interface ProgramIF
    {

        public void run();

        public void setEnviroment(CoffeeMakingMachineEnviromentIF env);
    }
}
