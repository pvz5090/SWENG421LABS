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
            =cme.setProgram(1);
            cme.runProgram();
            Coffee order1Base = new Coffee();
            order1Base.addCondiment(cream);
            order1Base.addCondiment(vanilla);

            cme.setCoffee(order1Base);

            cme.computePrice();







            cme.setProgram(3);
            cme.runProgram();
            Coffee order2Base = new Coffee();
            order2Base.addCondiment(cream);
            order2Base.addCondiment(vanilla);
            order2Base.addCondiment(chocholate);

            cme.setCoffee(order2Base);
            Console.WriteLine(cme.computePrice();)


        }
    }
}
