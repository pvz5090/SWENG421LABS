using m10_lab.EmployeeIFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace m10_lab.Employees
{
    internal class ProjectLeader : Worker,LowerManagementIF
    {

        private UpperManagementIF superior;

        public ProjectLeader(List<WorkerIF> subordinates, UpperManagementIF sup, string name) : base(subordinates, sup, name)
        {
            superior = sup;
            this._subordinates = subordinates;
            this.SetName(name);
        }

        public string provideInfo()
        { 
            return "Infomation from "+this.GetName();
        }

        public void seeDanger()
        {   
            if (superior == null)
            {
                Console.WriteLine("No superior to report to.");
            }
            else
            {
                foreach (Worker s in this._subordinates)
                {
                    s.fixIt();//solve the problem
                }
                superior.seeDanger();//report to superiot the problem
            }
        }
    }
}
