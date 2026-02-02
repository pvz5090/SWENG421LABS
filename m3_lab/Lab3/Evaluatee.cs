using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal abstract class Evaluatee : Employee
    {
        public Evaluatee(string name, int age, string title, int salary): base(name, age, title, salary)
        { }
    }
}
