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
        private _superior LowerManagementIF;
        public Worker(List<WorkerIF> subordinates, LowerManagementIF? superior, string name)
        {
            _subordinates = subordinates;
            _superior = superior;
            _name = name;
        }

        public void SeeDanger()
        {

        }

        public void FixIt()
        {

        }
    }
}
