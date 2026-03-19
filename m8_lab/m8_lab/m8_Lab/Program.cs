// See https://aka.ms/new-console-template for more information

namespace m8_Lab
{
    class Program
    {
        static void PrintTVInfo(TV_IF tv)
        {
            if (tv == null)
            {
                Console.WriteLine("TV is null (not within budget)");
            }
            else
            {
                Console.WriteLine(tv.GetInfo());
            }

        }
        static void Main(string[] args)
        {
            Buyer b = new Buyer();
            Customer c = new Customer();

            TV tv3 = b.tv.Replenish("Sony", 500); 
            PrintTVInfo(tv3.GetInfo());

            TV_IF tv4 = b.tv.Replenish("LG", 250);
            PrintTVInfo(tv4);

            TV_IF tv1 = c.tv.Replenish("Sony", 500);
            PrintTVInfo(tv1);

            TV_IF tv2 = c.tv.Replenish("LG", 250);
            PrintTVInfo(tv2);
        }
    }

}
