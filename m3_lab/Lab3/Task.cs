using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Task
    {
        public int Id;
        public string DueDate;
        public string Description;

        public Task(int id, string dueDate, string description)
        {
            this.Id = id;
            this.DueDate = dueDate;
            this.Description = description;
        }

    }
}
