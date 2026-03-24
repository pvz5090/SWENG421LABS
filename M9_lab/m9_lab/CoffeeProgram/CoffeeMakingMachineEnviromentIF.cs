using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal interface CoffeeMakingMachineEnviromentIF
    {
        public ProgramIF setProgram(int num);

        public ProgramIF SetProgramIF(String programName);


        public void setGrindingTime(int seconds);


        public void setTemperature(int degree);

        public void setCoffee(CoffeeIF order);

        public void setLEDnum(int num);

        public void runProgram();

        public double computePrice();


    }
}
