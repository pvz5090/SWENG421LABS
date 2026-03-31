using m10_lab.EmployeeIFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m10_lab.Employees
{
    internal class CEO: Employee, BossIF
    {
        private Decision decision; 
        public CEO(List<WorkerIF> subordinates, WorkerIF? superior, string name) : base(List < WorkerIF > subordinates, WorkerIF ? superior, string name)
        {    
        }
        public void seeDanger()
        {

        }
        private Decision grant(List<Decision> decs)
        {
            return decs[0]; 
        }
    }
}
