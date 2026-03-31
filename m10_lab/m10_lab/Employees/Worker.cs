using m10_lab.EmployeeIFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace m10_lab.Employees
{
    internal class Worker: Employee
    {
        private _superior LowerManagement;
        public Worker(List<WorkerIF> subordinates, UpperManagement? superior, string name): base
        {
            _subordinates = subordinates;
            _superior = superior;
            _name = name;
        }

    }
}
