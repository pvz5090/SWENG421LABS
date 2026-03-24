using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class Coffee:CoffeeIF
    {
        private double price;
        private String ItemLog;
        public Coffee(double price)
        {
            this.price = price;
        }

        public Coffee(int cr, int v,int ch)
        { 
        }
        public double getPrice()
        {
            return price;
        }
    }
}
