using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m10_lab.Employees
{
    internal class Manager: Worker, UpperManagementIF 
    {
        private Worker informedBy;
        public Manager(List<Manager> subordinates, WorkerIF? superior, string name) : base(subordinates, null, name)
        {

        }
        public void SeeDanger()
        {
            LowerManagementIF reporter = informedBy;
            reporter.ProvideInfo();
            ContactBoss();
        }

        private void ContactBoss()
        {
            _superior.SeeDanger(); 
        }
        public Decision suggestedDecision()
        {
            return new Decision();
        }
        public void addInformer(WorkerIF informer) { informedBy = informer; }
    }
}
