using System;
using System.Collections;
using System.Net.Mail;

namespace m9_lab
{
    internal static class ProgramMain
    {
        static void Main()
        {
            Cream cream = new Cream();
            Chocalate chocolate = new Chocalate();
            Vanilla vanilla = new Vanilla();

            CoffeeMakingMachineEnviroment cme = new CoffeeMakingMachineEnviroment();
            ProgramIF c = cme.setProgram(1);
            c.setEnviroment(cme); 
            cme.runProgram();
            Console.WriteLine();
          

            Coffee order1Base = new Coffee();
            order1Base.AddCondiment(cream);
            order1Base.AddCondiment(vanilla);

            cme.setCoffee(order1Base);

            Console.WriteLine("Mocha with:");
            PrintCondiments(order1Base);

            Console.WriteLine("Price: " + cme.computePrice());

            Coffee order2Base = new Coffee();
            order2Base.AddCondiment(cream);
            order2Base.AddCondiment(vanilla);
            order2Base.AddCondiment(chocolate);
            order2Base.AddCondiment(chocolate);

            cme.setCoffee(order2Base);

            Console.WriteLine();
            c = cme.setProgram(3);
            c.setEnviroment(cme);
            cme.runProgram();

            Console.WriteLine();
            Console.WriteLine("Espresso with:");
            PrintCondiments(order2Base);

            Console.WriteLine("Price: " + cme.computePrice());
        }

        static void PrintCondiments(Coffee coffee)
        {
            Coffee contents = coffee;

            int ch = 0;
            int cr = 0;
            int va = 0;

            while (contents != null && contents.getCondiment() != null)
            {
                switch (contents.getCondiment().getName())
                {
                    case "Chocalate":
                        ch++;
                        break;
                    case "Cream":
                        cr++;
                        break;
                    case "Vanilla":
                        va++;
                        break;
                }

                contents = contents.getCoffee();
            }

            if (cr > 0)
                Console.WriteLine($"Cream ×{cr}");

            if (va > 0)
                Console.WriteLine($"Vanilla ×{va}");

            if (ch > 0)
                Console.WriteLine($"Chocolate ×{ch}");
        }
    }
}