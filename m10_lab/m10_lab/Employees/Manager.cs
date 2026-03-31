using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m10_lab.Employees
{
    internal class Manager: Worker, UpperManagementIF
    {
        private CEO _superior;
        private Worker informedBy;
        public Manager(CEO superior, string name) : base(superior, name)
        {
            _superior = superior;
        }
        public void SeeDanger()
        {
            string str = ((ProvidesInfoIF)informedBy).ProvideInfo();
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
