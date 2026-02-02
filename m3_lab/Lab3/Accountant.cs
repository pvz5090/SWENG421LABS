using Lab3.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Accountant : Evaluatee, SalaryUpdater
    {
        private Accountant Delegate;

        public Accountant(string name, int age, string title, int salary) : base(name, age, title, salary)
        { }

        public void AssignDelegate(Accountant Delegate)
        {
            this.Delegate = Delegate;
        }

        public void PublicUpdate(Employee employee, int newSalary)
        {
            if (Delegate == null)
            {
                update(employee, newSalary);
            }
            else
            {
                Delegate.PublicUpdate(employee, newSalary);
            }
        }

        private void update(Employee employee, int newSalary)
        {
        }
    }
}
