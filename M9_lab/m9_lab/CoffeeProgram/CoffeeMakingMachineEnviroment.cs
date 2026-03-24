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

        public void setCoffee(CoffeeIF order)
        {
            this.cif = order;
        }

        public void runProgram()
        {
            pif.run(); 
        }

        public double computePrice()
        {
            return pif.getPrice() + cif.GetPrice();  
        }




    }
}
