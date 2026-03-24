using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class Cream:CondimentIF
    {
        private double price = 0.25;

        //defualt constructor

        public double getPrice()
        {
            return this.price;
        }
    }
}
