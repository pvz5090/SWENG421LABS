using m10_lab.EmployeeIFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace m10_lab
{
    internal class ProjectLeader : LowerManagementIF
    {

        private UpperManagementIF superior;

        public ProjectLeader(List<Worker> subordinates, UpperManagementIF sup, string name) 
        {
            superior = sup;
        }

        public String provideInfo()
        { 
        
        }

        public void seeDanger()
        {
            if (superior == null)
            {
                Console.WriteLine("No superior to report to.");
            }
            else
            {
                superior.seeDanger();
            }
        }
    }
}
