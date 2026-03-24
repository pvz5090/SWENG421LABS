using System.Net.Mail;

namespace m9_lab
{
    internal static class ProgramMain
    {
        static void Main()
        {
            Console.WriteLine("Hello world");

            Cream cream = new Cream();
            Chocholate chocholate = new Chocholate();
            Vanilla vanilla = new Vanilla();

            CoffeeMakingMachineEnviroment cme = new CoffeeMakingMachineEnviroment();
            cme.setProgram("Mocha");
            cme.runProgram();
            Coffee order1Base = new Coffee();
            order1Base.addCondiment(cream);
            order1Base.addCondiment(vanilla);

            cme.setCoffee(order1Base);

            cme.computePrice();







            cme.setProgram("Espresso");
            cme.runProgram();
            Coffee order2Base = new Coffee();
            order2Base.addCondiment(cream);
            order2Base.addCondiment(vanilla);
            order2Base.addCondiment(chocholate);

            cme.setCoffee(order2Base);
            cme.computePrice();


        }
    }
}
