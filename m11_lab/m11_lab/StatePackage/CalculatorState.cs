using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.OperationPackage;


namespace M11_LAB.StatePackage
{
    internal class CalculatorState
    {
        protected ResultState resultState;
       
        protected OperatorState operatorState;
        protected UnaryState unaryState;
        protected OneNumberState oneNumberState;
        protected TwoNumberState twoNumberState;

        protected CalculatorEnviroment env;
        public CalculatorState GetNextState(int input);


        public CalculatorState GetNextState(BinaryOperatorIF input);


        public CalculatorState GetNextState(UnaryOperatorIF input);


        public CalculatorState GetNextState(CE input);


        public CalculatorState GetNextState(C input);

        public CalculatorState GetNextState(Equal input);



    }

}
