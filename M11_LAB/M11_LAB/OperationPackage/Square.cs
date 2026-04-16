using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.StatePackage;

namespace M11_LAB.OperationPackage
{
    internal class Square : UnaryOperatorIF
    {
        public void ExecuteOperation(CalculatorEnviroment env)
        {
            if (env.getCurrentState() is OneNumberState)
                env.setFirstNumber(env.GetFirstNumber() * env.GetFirstNumber());
            else
                env.setSecondNumber(env.GetSecondNumber() * env.GetSecondNumber());

            if (env.getCurrentState() is OneNumberState)
                env.setDisplay(env.GetFirstNumber());
            else
                env.setDisplay(env.GetSecondNumber());
        }
    }
}
