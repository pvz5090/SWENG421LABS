using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Person
    {
        private string name;
        private int age;
        private string title;
        public Person(string name, int age, string title)
        {
            this.name = name;
            this.age = age;
            this.title = title;
        }

        public string GetName()
        {
            return name;
        }
    }
}
