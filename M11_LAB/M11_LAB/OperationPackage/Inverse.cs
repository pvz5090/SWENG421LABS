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
        public double ExecuteOperation(CalculatorEnviroment state)
        {
            return 1 / state.GetFirstNumber();
        }
    }
}
