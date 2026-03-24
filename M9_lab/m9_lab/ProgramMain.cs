using System.Collections;
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

            Console.WriteLine("Mocha with:\n" );

            Coffee contents = order1Base;

            int ch = 0;
            int cr = 0;
            int va = 0;
            while (contents.getCoffee() !=null && contents.getCondiment()!=null)
            {
                //Console.WriteLine(contents.getCondiment().getName());
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

                if (contents.getCoffee != null)
                {
                    contents= contents.getCoffee();
                }


            }

            if (va > 0)
            { 
                Console.WriteLine("Vanilla x"+va);
            }
            if (cr > 0) 
            {
                Console.WriteLine("Cream x"+cr);
            }
            if (ch > 0) 
            {
                Console.WriteLine("Chocolate x"+ch);
            }

            Console.WriteLine("Total: " + cme.computePrice() ) ;


/*
Mocha with:

Cream ×1
Vanilla ×1

Espresso with:

Cream ×1
Vanilla ×1
Chocolate ×2
*/




            cme.computePrice();







            cme.setProgram(3);
            cme.runProgram();
            Coffee order2Base = new Coffee();
            order2Base.AddCondiment(cream);
            order2Base.AddCondiment(vanilla);
            order2Base.AddCondiment(chocholate);

            cme.setCoffee(order2Base);
            Console.WriteLine(cme.computePrice();)


        }
    }
}
