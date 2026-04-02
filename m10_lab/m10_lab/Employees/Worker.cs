using m10_lab.EmployeeIFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace m10_lab
{
    internal class Worker: Employee
    {
        public Worker(LowerManagementIF? superior, string name): base (superior, name) 
        {
        }

        public void SeeDanger()
        {
            _superior.SeeDanger(); 
        }

        public void FixIt()
        {
            Console.WriteLine("The person " + this._name + " is fixing it"); 
        }
    }
}
