using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal abstract class LoadableClasses : ProgramIF
    {
        protected CoffeeMakingMachineEnviromentIF enviroment;
        protected double price;

        public void setEnviroment(CoffeeMakingMachineEnviromentIF enviroment)
        {
            this.enviroment = enviroment;
        }

        public abstract void run();
        public double GetPrice()
        {
            return this.price;
        }
    }
}
