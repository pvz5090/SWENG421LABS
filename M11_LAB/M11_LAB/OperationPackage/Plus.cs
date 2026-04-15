using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.StatePackage;

namespace M11_LAB.OperationPackage
{
    internal class Plus : BinaryOperatorIF
    {

        public void ExecuteOperation(CalculatorEnviroment env)
        {
            double num = env.GetFirstNumber() + env.GetSecondNumber();
            env.setResult(num);
            env.setFirstNumber(num);
            env.setDisplay(num);
        }
    }
}
