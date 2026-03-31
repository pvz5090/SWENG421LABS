using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m10_lab.Employees
{
    internal class Manager: Worker, UpperManagement 
    {
        private Worker informedBy;
        public Manager(List<WorkerIF> subordinates, WorkerIF? superior, string name) : base(subordinates, null, name)
        {

        }
        public void SeeDanger()
        {

        }

        private void ContactBoss()
        {

        }
        public Decision suggestedDecision()
        {
            return new Decision();
        }
        public void addInformer(WorkerIF informer) { informedBy = informer; }
    }
}
