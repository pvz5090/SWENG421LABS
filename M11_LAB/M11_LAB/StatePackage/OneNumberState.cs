using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.StatePackage
{
    internal class OneNumberState : CalculatorState
    {
        public CalculatorState GetNextState(string input)
        {
            return oneNumberState;
        }

        public CalculatorState GetNextState(BinaryOperatorIF input)
        {
            return operatorState;
        }

        public CalculatorState GetNextState(UnaryOperatorIF input)
        {
            return resultState;
        }

        public CalculatorState GetNextState(CE input)
        {
            return oneNumberState;
        }

        public CalculatorState GetNextState(C input)
        {
            return oneNumberState;
        }

        public CalculatorState GetNextState(Equal input)
        {
            return resultState;
        }
    }
}
