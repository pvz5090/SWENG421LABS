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
            env.setPreviousOperator(input);
            env.setFirstNumber();//this Right

            return resultState;
        }

        public CalculatorState GetNextState(CE input, CalculatorEnviroment)
        {
            //env.setPreviousOperator(); no change
            //env.setSecondNumber();//no change
            env.setFirstNumber(0);

            return oneNumberState;
        }

        public CalculatorState GetNextState(C input, CalculatorEnviroment)
        {

                env.setPreviousOperator(input);
                env.setFirstNumber(0);
    
                env.setSecondNumber(0);//this right?
                return oneNumberState;

        }
        public CalculatorState GetNextState(Equal input, CalculatorEnviroment)
        {


        }
    }
}
