using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.StatePackage;

namespace M11_LAB.OperationPackage
{
    internal class Multiply : BinaryOperatorIF
    {
        public double ExecuteOperation(CalculatorEnviroment state)
        {
            return state.GetFirstNumber() * state.GetSecondNumber();
        }

    }
}
