using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace m9_lab
{
    internal class Coffee:CoffeeIF
    {
        private CondimentIF condiment;
        private Coffee cof; 
        public Coffee()
        {
            condiment = null;
            cof = null; 
        }

        public Coffee(CondimentIF con)
        {
            condiment = con;
            cof = null; 
        }
        public void AddCondiment(CondimentIF con)
        {
            if(condiment == null)
                condiment = con;
            else if(this.cof == null)
                this.cof = new Coffee(con); 
            else
                this.cof.AddCondiment(con); 
        }

        public double GetPrice()
        {
            if(condiment == null)
            {
                return 0; 
            }
            else
            {
                if (cof == null)
                    return condiment.getPrice();
                else
                    return condiment.getPrice() + cof.GetPrice(); 
            }

             
        }

        public Coffee getCoffee()
        {
            return cof;
        }

        public CondimentIF getCondiment()
        {
            return condiment;
        }
    }
}
