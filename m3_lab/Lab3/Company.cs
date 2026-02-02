using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Company
    {
        public List<Person> People;

        public Company(List<Person> people) { 
            this.People = people;
        }
    }
}
