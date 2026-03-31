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
        public Manager(WorkerIF? superior, string name) : base(superior, name)
        {

        }
        public void SeeDanger()
        {
            string str = ((LowerManagementIF)informedBy).ProvideInfo();
            Console.WriteLine(str);
            ContactBoss();
        }

        private void ContactBoss()
        {
            _superior.SeeDanger(); 
        }
        public Decision SuggestedDecision()
        {
            return new Decision();
        }
        public void AddInformer(Worker informer) { informedBy = informer; }
    }
}
