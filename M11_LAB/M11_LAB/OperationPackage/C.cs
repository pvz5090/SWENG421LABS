using M11_LAB.StatePackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.OperationPackage
{
    internal class C : OperatorIF
    {
        public void ExecuteOperation(CalculatorEnviroment env)
        {
            if (env.GetSecondNumber() == null)
                env.setFirstNumber(0);
            else
                env.setSecondNumber(0);
        }
    }
}
