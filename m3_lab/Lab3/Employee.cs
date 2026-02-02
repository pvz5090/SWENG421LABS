using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

using Lab3.Roles;

namespace Lab3
{

    internal abstract class Employee : Person, Performer
    {
        protected int Salary;

        public Employee(string name, int age, string title, int salary): base(name, age, title)
        {
            this.Salary = salary;
        }

        public void PublicPerform(Task task)
        {
            Console.WriteLine(this.GetName() + " is performing task " + task.Description);
        }

        public int GetSalary()
        {
            return Salary;
        }
    }
}
