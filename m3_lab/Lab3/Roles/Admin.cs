using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Roles
{
    internal interface Admin
    {
        public void PublicSend(List<Employee> employees, string message);
    }
}
