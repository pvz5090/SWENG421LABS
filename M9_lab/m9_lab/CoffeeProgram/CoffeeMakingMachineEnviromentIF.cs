using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal interface CoffeeMakingMachineEnviromentIF
    {
        public ProgramIF setProgram(int num)
        {

            if (num == 0)
            {
                return new RegularProg();
            }
            else if (num == 1)
            {
                return new MochaProg();

            }
            else if (num == 2)
            {
                return new CappuccinoProg();
            }
            else
            {
                Console.WriteLine("Invalid program number. Please enter 0, 1, or 2. For a Coffee,Mocha,and Cappuccino plese enter 0, 1, or 2 respectively");
                return null;

            }
        }

        public ProgramIF SetProgramIF(String programName)
        {
            Type type = Type.GetType(programName);
            if (type == null)
            {
                Console.WriteLine("Invalid program name. Please enter Coffee, Mocha, or Cappicino.");
                return null; 
            }

            else
                return (ProgramIF)Activator.CreateInstance(type);
        }

        public void setGrindingTime(int seconds)
        {
            Console.WriteLine("Grinding Time set to " + seconds + "seconds."); ;
        }


        public void setTemperature(int degree)
        {
            Console.WriteLine("Temperature set to " + degree + " degrees.");
        }

        public void setCoffee(CoffeeIF order);

        public void setLEDnum(int num)
        { 
            Console.WriteLine("LED number set to " + num);
        }

        public void runProgram();

        public double computePrice();


    }
}
