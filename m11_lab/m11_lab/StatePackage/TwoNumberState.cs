using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.StatePackage
{
    internal class TwoNumberState:CalculatorState
    {

        public CalculatorState GetNextState(string input)
        {
            if(input == "backspace"){
                env.PopFromFirstNumber(input);
            }
            else {
                env.PushToFirstNumber(input);
            }

            return twoNumberState;
        }

        public CalculatorState GetNextState(BinaryOperatorIF input)
        {
            return operatorState;
        }

        public CalculatorState GetNextState(UnaryOperatorIF input)
        {
            return unaryState;
        }

        public CalculatorState GetNextState(CE input)
        {
            return twoNumberState;
        }

        public CalculatorState GetNextState(C input)
        {
            return operatorState;
        }
        public CalculatorState GetNextState(Equal input)
        {
            return resultState;
        }
    }
}
