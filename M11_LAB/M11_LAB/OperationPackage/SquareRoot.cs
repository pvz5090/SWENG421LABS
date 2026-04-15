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
            if (env.getCurrentState() is OneNumberState)
                env.setFirstNumber(Math.Sqrt(env.GetFirstNumber()));
            else
                env.setSecondNumber(Math.Sqrt(env.GetSecondNumber()));
            env.setDisplay(Math.Sqrt(env.getDisplay())); 
        }
    }
}
