using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.StatePackage
{
    internal class CalculatorEnviroment
    {
        private string firstNumber;
        private OperaterIF previousOperator;
        private string SecondNumber;
        CalculatorState currentState;

        public void compute()
        {
            currentState = currentState.GetNextState(Console.ReadLine(), this);
        }
        public double GetFirstNumber()
        {
            return this.firstNumber;

        }

        public void setFirstNumber(double num)
        {
            this.firstNumber = num;
        }

        public double GetPreviousOperator()
        {
            return previousOperator;
        }

        public void setPreviousOperator(double num)
        {
            this.previousOperator = num;
        }

        public double GetSecondNumber()
        {
            return this.SecondNumber;
        }

        public void setSecondNumber(double num)
        {
            this.SecondNumber = num;
        }

    }//end class
}//end namespace
