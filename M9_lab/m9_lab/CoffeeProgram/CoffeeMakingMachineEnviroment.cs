using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class CoffeeMakingMachineEnviroment : CoffeeMakingMachineEnviromentIF
    {
        private CoffeeIF cif;
        private ProgramIF pif;

        public ProgramIF setProgram(int num);

        public ProgramIF setProgramIF(String programName);

    }
}
