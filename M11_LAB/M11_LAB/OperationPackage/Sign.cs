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
            if (env.getCurrentState() is OneNumberState) 
                env.setFirstNumber(env.GetFirstNumber() * -1);
            else
                env.setSecondNumber(env.GetSecondNumber() * -1);

            env.setDisplay(env.getDisplay() * -1);
        }
    }
}
