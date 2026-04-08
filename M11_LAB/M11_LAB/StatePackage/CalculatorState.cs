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

        private create()
        { 
        }

        protected enter()
        { 
        }

        protected static CalculatorState nextState(int eventID)
        {
        
        }

        public CalculatorState start()
        { 
        }

        public CalculatorState ProcessEvent(int eventID)
        {

        }
}
