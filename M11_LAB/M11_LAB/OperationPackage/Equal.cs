using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.StatePackage;

namespace M11_LAB.OperationPackage
{
    internal class Equal : BinaryOperatorIF
    {
        public void ExecuteOperation(CalculatorEnviroment env)
        {
            env.GetPreviousOperator().ExecuteOperation(env);
        }
    }
}
