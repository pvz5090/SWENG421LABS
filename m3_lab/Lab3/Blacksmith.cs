using Lab3.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Blacksmith : Evaluatee
    {
        private Employee PerformDelegate;


        public Blacksmith(string name, int age, string title, int salary) : base(name, age, title, salary)
        { }

        private void Perform(Task task)
        {
            Console.WriteLine(this.GetName() + " is performing task " + task.Description);
        }

        public void PublicPerform(Task task)
        {
            if (PerformDelegate == null)
            {
                this.Perform(task);
            } else
            {
                PerformDelegate.PublicPerform(task);
            }
        }

        public void AssignDelegate(Employee employee)
        {
            this.PerformDelegate = employee;
        }

    }
}
