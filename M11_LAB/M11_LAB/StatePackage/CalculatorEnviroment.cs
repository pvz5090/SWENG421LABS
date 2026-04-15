using M11_LAB.OperationPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.StatePackage
{
    internal class CalculatorEnviroment
    {
        private String firstNumber;
        private String SecondNumber;
        private String resultNumber;

        private OperatorIF previousOperator;

        CalculatorState currentState;

        public CalculatorState getCurrentState()
        {
            return currentState;
        }
        public void setCurrentState(CalculatorState state)
        {
            this.currentState = state; 
        }
        public double GetFirstNumber()
        {
            return double.Parse(this.firstNumber);

        }

        public void setFirstNumber(double? num)
        {
            this.firstNumber = num.ToString();
        }

        public OperatorIF GetPreviousOperator()
        {
            return previousOperator;
        }

        public void setPreviousOperator(OperatorIF op)
        {
            this.previousOperator = op;
        }

        public double GetSecondNumber()
        {
            return double.Parse(this.SecondNumber);
        }

        public void setSecondNumber(double? num)
        {
            this.SecondNumber = num.ToString();
        }

    }//end class
}//end namespace
