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
            if (env.getCurrentState() is OneNumberState)
            {
                env.setFirstNumber(1 / env.GetFirstNumber());
                env.setDisplay(1 / env.GetFirstNumber());
            }
            else
            {
                env.setSecondNumber(1 / env.GetSecondNumber());
                env.setDisplay(1 / env.GetSecondNumber());
            }

        }
    }
}
