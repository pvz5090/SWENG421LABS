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
            if(input == "backspace"){
                env.PopFromFirstNumber();
            }
            else {
                env.PushToFirstNumber(input);
            }

            return oneNumberState;
        }

        public CalculatorState GetNextState(BinaryOperatorIF input)
        {
            env.setPreviousOperator(input);

            return operatorState;
        }

        public CalculatorState GetNextState(UnaryOperatorIF input)
        {
            input.ExecuteOperation(env);
            return resultState;
        }

        public CalculatorState GetNextState(CE input)
        {
            input.ExecuteOperation(env);
            return oneNumberState;
        }

        public CalculatorState GetNextState(C input)
        {
            input.ExecuteOperation(env);
            return oneNumberState;
        }

        public CalculatorState GetNextState(Equal input)
        {
            input.ExecuteOperation(env);
            return resultState;
        }
    }
}
