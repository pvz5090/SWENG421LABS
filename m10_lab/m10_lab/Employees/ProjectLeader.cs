using m10_lab.EmployeeIFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace m10_lab.Employees
{
    internal class ProjectLeader : Worker, LowerManagementIF, ProvidesInfoIF
    {

        private UpperManagementIF _superior;

        public ProjectLeader(UpperManagementIF sup, string name) : base(sup, name)
        {
            _superior = sup;
        }

        public string ProvideInfo()
        {
            return ("Information from " + this._name);
        }

        public void SeeDanger()
        {   
            if (_superior == null)
            {
                Console.WriteLine("No superior to report to.");
            }
            else
            {
                foreach (Worker s in this._subordinates)
                {
                    s.FixIt();//solve the problem
                }
                _superior.SeeDanger();//report to superior the problem
            }
        }
    }
}
