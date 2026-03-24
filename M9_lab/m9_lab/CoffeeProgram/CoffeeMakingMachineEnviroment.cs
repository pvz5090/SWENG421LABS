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
            switch (num)
            {
                case 0:
                    pif = new RegularProg();
                    break;
                case 1:
                    pif = new MochaProg();
                    break;
                case 2:
                    pif = new CappicinoProg();
                    break;
                default:
                    Console.WriteLine("Invalid program number. Please enter 1, 2, or 3.");
                    return null;
            }
            return pif;
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


        public void setLEDnum(int num)
        {
            Console.WriteLine("LED number set to " + num);
        }



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
            return pif.GetPrice() + cif.GetPrice();   
        }




    }
}
