using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Roles;


namespace Lab3
{
    internal class Owner : Person, Admin, Evaluator
    {
        public Owner(string name, int age, string title): base(name, age, title)
        { }

        private Admin SendDelegate;
        private Evaluator EvaluateDelegate;

        public void AssignSendDelegate(Admin sendDelegate) { this.SendDelegate = sendDelegate; }
        public void AssignEvaluateDelegate(Evaluator evaluateDelegate) { this.EvaluateDelegate = evaluateDelegate; }
        public void PublicSend(List<Employee> employees, string message)
        {
            if (SendDelegate == null)
            {
                this.Send(employees, message);
            } else
            {
                SendDelegate.PublicSend(employees, message);
            }
        }

        private void Send(List<Employee> employees, string message)
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
