using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal class Middleman : TV, TV_IF
    {
        public List<TV> tvTable;
        private TV tv; 
        public string GetBrand()
        {
            throw new NotImplementedException();
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public TV Replenish(string type, int budget)
        {
            throw new NotImplementedException();
        }

        string TV_IF.GetType()
        {
            throw new NotImplementedException();
        }
    }
}
