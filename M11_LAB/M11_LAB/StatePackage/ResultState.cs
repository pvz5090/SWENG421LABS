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
            env.setSecondNumber(    )
            return resultState;
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
