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
            env.setFirstNumber(0);
            env.setSecondNumber(0);
            env.setPreviousOperator(null);
            env.setResult(null);
            env.setDisplay(0);

        }
    }
}
