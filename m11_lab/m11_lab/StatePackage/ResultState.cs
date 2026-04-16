using M11_LAB.OperationPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.StatePackage;


namespace M11_LAB.StatePackage
{
    internal class ResultState: CalculatorState
    {

        public override CalculatorState GetNextState(String input)
        {
            if (input == "backspace")
                return resultState;
            // Start fresh with the typed digit
            env.setFirstNumber(null);
            env.PushToFirstNumber(input);
            env.setDisplay(env.getFirstNumberString());
            return oneNumberState;
        }

        public override CalculatorState GetNextState(BinaryOperatorIF input)
        {
            //PreviousOPerator Does nopthing,stay same
            //SecondNumber does nothing, stay sane
            env.setSecondNumber(null);

            env.setPreviousOperator(input);
            return operatorState;

        }

        public override CalculatorState GetNextState(UnaryOperatorIF input)
        {
            //uses result as first number and computes new result by using input operator 
            input.ExecuteOperation(env);
            //env.setPreviousOperator(input);
            //env.setFirstNumber(  );//this Right

            return resultState;
        }

        public override CalculatorState GetNextState(CE input)
        {
            //sets first number to 0, preserves previous operator and second number

            //env.setPreviousOperator(); no change
            //env.setSecondNumber();//no change
            env.setFirstNumber(0);

            return oneNumberState;
        }

        public override CalculatorState GetNextState(C input)
        {
            //sets first number to 0, second number to null and previous operator to null

            env.setPreviousOperator(null);
            env.setFirstNumber(0);
            env.setSecondNumber(null);//this right?

            return oneNumberState;

        }
        public override CalculatorState GetNextState(Equal input)
        {
            //takes result as first number and computes new result by using previous operator and second number

            //env.setPreviousOperator(); no change
            //env.setSecondNumber();//no change
            input.ExecuteOperation(env);
            return resultState;
        }
    }
}
