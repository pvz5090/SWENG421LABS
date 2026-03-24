using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class Chocalate:CondimentIF
    {

        private double price = 1.0;

        //defualt constructor

        public double getPrice()
        {
            return this.price;
        }

        public String getName()
        {
            return "Chocalate";
        }
    }
}
