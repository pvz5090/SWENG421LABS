using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class Customer
    {
        public TV_IF tv;  
        public Customer() { tv = new Middleman(); }
    }
}
