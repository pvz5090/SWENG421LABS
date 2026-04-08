using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_LAB.StatePackage
{
    internal class CalculatorEnviroment
    {
        private double firstNumber;
        private double previousOperator;
        private double SecondNumber;



        public double getFirstNumber()
        {
            return this.firstNumber;

        }

        public void setFirstNumber(double num)
        {
            this.firstNumber = num;
        }

        public double getPreviousOperator()
        {
            return previousOperator;
        }

        public void setPreviousOperator(double num)
        {
            this.previousOperator = num;
        }

        public double getSecondNumber()
        {
            return this.SecondNumber;
        }

        public void setSecondNumber(double num)
        {
            this.SecondNumber = num;
        }

    }//end class
}//end namespace
