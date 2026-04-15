using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.OperationPackage;

namespace M11_LAB.StatePackage
{
    internal class UnaryState:CalculatorState
    {
        public override CalculatorState GetNextState(string input)
        {
            //keeps second number and previous operator unchanged. Sets first number to input
            env.setSecondNumber(double.Parse(input));
            return oneNumberState;
        }

        public override CalculatorState GetNextState(BinaryOperatorIF input)
        {
            input.ExecuteOperation(env);
            return resultState;
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
            return oneNumberState;
        }

        public override CalculatorState GetNextState(Equal input)
        {
            input.ExecuteOperation(env);
            return resultState;
        }
    }
}
