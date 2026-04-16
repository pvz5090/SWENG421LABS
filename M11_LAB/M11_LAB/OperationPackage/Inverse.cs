using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.StatePackage;

namespace M11_LAB.OperationPackage
{
    internal class Inverse : UnaryOperatorIF
    {
        public void ExecuteOperation(CalculatorEnviroment env)
        {
            double result;
            if (env.getCurrentState() is OneNumberState)
            {
                result = 1 / env.GetFirstNumber();
                env.setFirstNumber(result);
            }
            else
            {
                result = 1 / env.GetSecondNumber();
                env.setSecondNumber(result);
            }
            env.setDisplay(result);
        }
    }
}
