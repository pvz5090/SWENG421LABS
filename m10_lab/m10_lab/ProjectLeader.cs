using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace m10_lab
{
    internal class ProjectLeader : Employee
    {

        private UpperManagementIF superior;

        public ProjectLeader(List<Worker> subordinates, LowerManagement sup, string name) : base(subordinates, sup, name)
        {
            superior = sup;
        }

        public String provideInfo()
        { 
        
        }

        public void seeDanger()
        { 
        }
    }
}
