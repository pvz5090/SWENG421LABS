using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.StatePackage
{
    internal class TwoNumberState:CalculatorState
    {

        public override CalculatorState GetNextState(string input)
        {
            if(input == "backspace"){
                env.PopFromSecondNumber();
            }
            else {
                env.PushToSecondNumber(input);
            }

            return twoNumberState;
        }

        public override CalculatorState GetNextState(BinaryOperatorIF input)
        {
            input.ExecuteOperation(env);

            return operatorState;
        }

        public override CalculatorState GetNextState(UnaryOperatorIF input)
        {
            input.ExecuteOperation(env);
            return unaryState;
        }

        public override CalculatorState GetNextState(CE input)
        {
            input.ExecuteOperation(env);
            return twoNumberState;
        }

        public override CalculatorState GetNextState(C input)
        {
            input.ExecuteOperation(env);
            return operatorState;
        }
        public override CalculatorState GetNextState(Equal input)
        {
            input.ExecuteOperation(env);
            return resultState;
        }
    }
}
