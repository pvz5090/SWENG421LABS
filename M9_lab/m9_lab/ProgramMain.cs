namespace m9_lab
{
    internal static class ProgramMain
    {
        static void Main()
        {
            Console.WriteLine("Hello world");

            CoffeeMakingMachineEnviroment cme = new CoffeeMakingMachineEnviroment();
            cme.setProgram(1);
            cme.setCoffee(new Coffee(new Milk()));

            Cream cream = new Cream();
            Chocholate chocholate = new Chocholate();
            Vanilla vanilla = new Vanilla();
            
            Coffee order1Base=new Coffee();
            order1Base.addCondiment(cream);
            order1Base.addCondiment(vanilla);



            Coffee order2Base = new Coffee();
            order2Base.addCondiment(cream);
            order2Base.addCondiment(vanilla);
            order2Base.addCondiment(chocholate);


            /*
             * 
             * Prepare and print prices for:

Mocha with:

Cream ×1
Vanilla ×1

Espresso with:

Cream ×1
Vanilla ×1
Chocolate ×2
             */
        }
    }
}
