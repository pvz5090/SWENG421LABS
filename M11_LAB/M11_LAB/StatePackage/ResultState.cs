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

        public CalculatorState GetNextState(int input, CalculatorEnviroment)
        {
            //PreviousOPerator Does nopthing,stay same
            //SecondNumber does nothing, stay sane
            
            env.setFirstNumber(input);

            return oneNumberState;

        }

        public CalculatorState GetNextState(BinaryOperatorIF input, CalculatorEnviroment)
        {
            //PreviousOPerator Does nopthing,stay same
            //SecondNumber does nothing, stay sane
            env.setSecondNumber((double) null);

            env.setPreviousOperator(input);
            return operatorState;

        }

        public CalculatorState GetNextState(UnaryOperatorIF input, CalculatorEnviroment)
        {
            //uses result as first number and computes new result by using input operator 
            input.ExecuteOperation(env)
            //env.setPreviousOperator(input);
            //env.setFirstNumber(  );//this Right

            return resultState;
        }

        public CalculatorState GetNextState(CE input, CalculatorEnviroment)
        {
            //sets first number to 0, preserves previous operator and second number

            //env.setPreviousOperator(); no change
            //env.setSecondNumber();//no change
            env.setFirstNumber(0);

            return oneNumberState;
        }

        public CalculatorState GetNextState(C input, CalculatorEnviroment)
        {
            //sets first number to 0, second number to null and previous operator to null

                env.setPreviousOperator(null);
                env.setFirstNumber(0);
                env.setSecondNumber(null);//this right?

                return oneNumberState;

        }
        public CalculatorState GetNextState(Equal input, CalculatorEnviroment)
        {
            //takes result as first number and computes new result by using previous operator and second number

            //env.setPreviousOperator(); no change
            //env.setSecondNumber();//no change

            env.setFirstNumber(resultNumber);

            return resultState;
        }
    }
}
