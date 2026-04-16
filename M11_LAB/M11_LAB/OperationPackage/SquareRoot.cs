using M11_LAB.StatePackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.OperationPackage
{
    internal class SquareRoot : UnaryOperatorIF
    {
        public void ExecuteOperation(CalculatorEnviroment env)
        {
            double result;
            if (env.getCurrentState() is OneNumberState or ResultState)
            {
                result = Math.Sqrt(env.GetFirstNumber());
                env.setFirstNumber(result);
            }
            else
            {
                result = Math.Sqrt(env.GetSecondNumber());
                env.setSecondNumber(result);
            }
            env.setDisplay(result);
        }
    }
}
