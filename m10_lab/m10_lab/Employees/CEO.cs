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
        public CEO(WorkerIF? superior, string name) : base(null, name)
        {    
        }
        public new void SeeDanger()
        {
            List<Decision> decs = new List<Decision>();
            foreach(Manager m in _subordinates)
            {
                decs.Add(m.SuggestedDecision());
            }
            decision = grant(decs);
            decision.doIt();
            this.Evacuate(); 
        }
        private Decision grant(List<Decision> decs)
        {
            return decs[0]; 
        }
    }
}
