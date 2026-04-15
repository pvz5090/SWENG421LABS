using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.OperationPackage;

namespace M11_LAB.StatePackage
{
    internal class OneNumberState : CalculatorState
    {
        public override CalculatorState GetNextState(string input)
        {
            if(input == "backspace"){
                env.PopFromFirstNumber();
            }
            else {
                env.PushToFirstNumber(input);
            }

            return oneNumberState;
        }

        public override CalculatorState GetNextState(BinaryOperatorIF input)
        {
            env.setPreviousOperator(input);

            return operatorState;
        }

        public override CalculatorState GetNextState(UnaryOperatorIF input)
        {
            input.ExecuteOperation(env);
            return resultState;
        }

        public override CalculatorState GetNextState(CE input)
        {
            input.ExecuteOperation(env);
            return oneNumberState;
        }

        public override CalculatorState GetNextState(C input)
        {
            input.ExecuteOperation(env);
            return oneNumberState;
        }

        public override CalculatorState GetNextState(Equal input)
        {
            input.ExecuteOperation(env);
            return resultState;
        }
    }
}
