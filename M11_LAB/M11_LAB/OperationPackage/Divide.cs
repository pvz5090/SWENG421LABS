using M11_LAB.StatePackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace M11_LAB.OperationPackage
{
    internal class Divide : BinaryOperatorIF
    {

        public void ExecuteOperation(CalculatorEnviroment env)
        {
            double num = env.GetFirstNumber() / env.GetSecondNumber(); 
            env.setResult(num);
            env.setFirstNumber(num);
            env.setDisplay(num);
        }
    }
}
