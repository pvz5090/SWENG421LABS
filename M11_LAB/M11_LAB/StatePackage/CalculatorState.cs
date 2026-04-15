using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.OperationPackage;


namespace M11_LAB.StatePackage
{
    internal class CalculatorState
    {
        protected ResultState resultState;
       
        protected OperatorState operatorState;
        protected UnaryState unaryState;
        protected OneNumberState oneNumberState;
        protected TwoNumberState twoNumberState;

        protected CalculatorEnviroment env;
        public int minusEvent = 1;
        public int plusEvent = 2;
        public CalculatorState GetNextState(int input, CalculatorEnviroment)
        {


        }

        public CalculatorState GetNextState(BinaryOperatorIF input, CalculatorEnviroment)
        {


        }

        public CalculatorState GetNextState(UnaryOperatorIF input, CalculatorEnviroment)
        {


        }

        public CalculatorState GetNextState(CE input, CalculatorEnviroment)
        {


        }

        public CalculatorState GetNextState(C input, CalculatorEnviroment)
        {


        }
        public CalculatorState GetNextState(Equal input, CalculatorEnviroment)
        {


        }


    }

}
