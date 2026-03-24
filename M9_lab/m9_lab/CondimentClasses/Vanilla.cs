using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class Vanilla: CondimentIF
    {
        private double price = 0.5;

        //defualt constructor

        public double getPrice()
        {
            return this.price;
        }

        public String getName()
        {
            return "Vanilla";
        }

    }
}
