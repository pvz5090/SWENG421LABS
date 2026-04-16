using M11_LAB.OperationPackage;
using M11_LAB.StatePackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.OperationPackage
{
    internal class Sign : UnaryOperatorIF
    {
        public void ExecuteOperation(CalculatorEnviroment env)
        {
            double result;
            if (env.getCurrentState() is OneNumberState or ResultState)
            {
                result = env.GetFirstNumber() * -1;
                env.setFirstNumber(result);
            }
            else
            {
                result = env.GetSecondNumber() * -1;
                env.setSecondNumber(result);
            }
            env.setDisplay(result);
        }
    }
}
