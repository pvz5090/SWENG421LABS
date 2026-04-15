using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using M11_LAB.OperationPackage;


namespace M11_LAB.StatePackage
{
    internal abstract class CalculatorState
    {
        protected ResultState resultState;
       
        protected OperatorState operatorState;
        protected UnaryState unaryState;
        protected OneNumberState oneNumberState;
        protected TwoNumberState twoNumberState;

        protected CalculatorEnviroment env;
        public abstract CalculatorState GetNextState(string input);
      \


        public abstract CalculatorState GetNextState(UnaryOperatorIF input);


        public abstract CalculatorState GetNextState(CE input);


        public abstract CalculatorState GetNextState(C input);

        public abstract CalculatorState GetNextState(Equal input);



    }

}
