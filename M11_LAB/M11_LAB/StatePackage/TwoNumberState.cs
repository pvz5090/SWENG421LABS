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
                env.PopFromFirstNumber();
            }
            else {
                env.PushToFirstNumber(input);
            }

            return twoNumberState;
        }

        public CalculatorState GetNextState(BinaryOperatorIF input)
        {
            input.ExecuteOperation(env);

            return operatorState;
        }

        public CalculatorState GetNextState(UnaryOperatorIF input)
        {
            input.ExecuteOperation(env);
            return unaryState;
        }

        public CalculatorState GetNextState(CE input)
        {
            input.ExecuteOperation(env);
            return twoNumberState;
        }

        public CalculatorState GetNextState(C input)
        {
            input.ExecuteOperation(env);
            return operatorState;
        }
        public CalculatorState GetNextState(Equal input)
        {
            input.ExecuteOperation(env);
            return resultState;
        }
    }
}
