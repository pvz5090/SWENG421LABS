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

        public ProjectLeader(List<Worker> subordinates, UpperManagementIF sup, string name) : base(subordinates, sup, name)
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
