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
        private String firstNumber = "0";
        private String? SecondNumber = null;
        private String? resultNumber = "0";
        private String display = "0";

        private OperatorIF previousOperator = null;
        CalculatorState currentState = new OneNumberState();

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
            this.firstNumber = num.HasValue ? num.ToString() : "0";
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
            this.SecondNumber = num.HasValue ? num.ToString() : null;
        }
        public double getResult()
        {
            return double.Parse(resultNumber);
        }
        public void setResult(double? num)
        {
            this.resultNumber = num.HasValue ? num.ToString() : "0";
        }

        public void PushToFirstNumber(string digit) {
            if (firstNumber == null)
                firstNumber = "";
            firstNumber += digit;
        }

        public void PushToSecondNumber(string digit) {
            if (SecondNumber == null)
                SecondNumber = "";
            SecondNumber += digit;
        }

        public void PopFromFirstNumber() {
            if (firstNumber?.Length > 0)
                firstNumber = firstNumber.Remove(firstNumber.Length - 1);
        }

        public void PopFromSecondNumber() {
            if (SecondNumber?.Length > 0)
                SecondNumber = SecondNumber.Remove(SecondNumber.Length - 1);
        }
        public string getDisplay()
        {
            return this.display;
        }
        public void setDisplay(double num)
        {
            this.display = num.ToString();
        }
        public void setDisplay(string s)
        {
            this.display = s;
        }

        public string getFirstNumberString()
        {
            return firstNumber ?? "0";
        }

        public string getSecondNumberString()
        {
            return SecondNumber ?? "0";
        }

    }//end class
}//end namespace
