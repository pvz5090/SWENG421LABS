using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Roles;

namespace Lab3
{
    internal class Manager : Employee, Evaluator, Admin
    {
        private Evaluator EvaluateDelegate;

        public Manager(string name, int age, string title, int salary) : base(name, age, title, salary)
        { }

        public void AssignDelegate(Evaluator evaluator) { EvaluateDelegate = evaluator; }

        public void PublicSend(List<Employee> employees, string message)
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine(this.GetName() + " is sending a message to " + e.GetName() + ": " + message);
            }
        }

        public void PublicEvaluate(Evaluatee evaluatee, int score)
        {
            if (EvaluateDelegate == null)
            {
                this.Evaluate(evaluatee, score);
            }
            else
            {
                EvaluateDelegate.PublicEvaluate(evaluatee, score);
            }
        }

        private void Evaluate(Evaluatee evaluatee, int score)
        {
            Console.WriteLine(this.GetName() + " is evaluating " + evaluatee.GetName() + " with score " +  score);
        }

    }
}
