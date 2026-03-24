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

        public ProgramIF setProgram(int num)
        {
             return base(num);
        }

        public ProgramIF setProgramIF(String programName)
        {

            return base(programName);
        }
        public void setGrindingTime(int seconds)
        {
            base();
        }
        public void setTemperature(int degree)
        {
            base()
        }
        
        public void setLEDnum(int num)
        {
            base();
        }

        public void setCoffee(CoffeeIF order)
        {
            this.cif = order;
        }

        public void runProgram();

        public double computePrice();




    }
}
