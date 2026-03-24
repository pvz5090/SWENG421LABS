using System.Net.Mail;

namespace m9_lab
{
    internal static class ProgramMain
    {
        static void Main()
        {
            Console.WriteLine("Hello world");

            Cream cream = new Cream();
            Chocalate chocholate = new Chocalate();
            Vanilla vanilla = new Vanilla();

            CoffeeMakingMachineEnviroment cme = new CoffeeMakingMachineEnviroment();
            cme.setProgram(1);
            cme.runProgram();
            Coffee order1Base = new Coffee();
            order1Base.AddCondiment(cream);
            order1Base.AddCondiment(vanilla);

            Console.WriteLine("Mocha with:\n" );

            Coffee contents = order1Base;
            while (contents.getCoffee !=null && )
            { 
                Console.WriteLine

            }
/*
Mocha with:

Cream ×1
Vanilla ×1

Espresso with:

Cream ×1
Vanilla ×1
Chocolate ×2
*/
            cme.setCoffee(order1Base);



            cme.computePrice();







            cme.setProgram(3);
            cme.runProgram();
            Coffee order2Base = new Coffee();
            order2Base.AddCondiment(cream);
            order2Base.AddCondiment(vanilla);
            order2Base.AddCondiment(chocholate);

            cme.setCoffee(order2Base);
            Console.WriteLine(cme.computePrice());




        }
    }
}
