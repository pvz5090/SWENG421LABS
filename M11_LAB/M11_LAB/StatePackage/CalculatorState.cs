using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.StatePackage
{
    internal class CalculatorState
    {
        protected ResultState result;
        protected OperatorState oper;
        protected CalculatorEnviroment env;
        public int minusEvent = 1;
        public int plusEvent = 2;
        public CalculatorState GetNextState(int eventID, CalculatorEnviroment)
        {


        }
    }
}
