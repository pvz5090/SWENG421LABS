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
        protected ResultState resultState = new ResultState();
       
        protected OperatorState operatorState = new OperatorState();
        protected UnaryState unaryState = new UnaryState();
        protected OneNumberState oneNumberState = new OneNumberState();
        protected TwoNumberState twoNumberState = new TwoNumberState();

        protected CalculatorEnviroment env = new CalculatorEnviroment();
        public abstract CalculatorState GetNextState(string input);


        public abstract CalculatorState GetNextState(UnaryOperatorIF input);
        public abstract CalculatorState GetNextState(BinaryOperatorIF input);


        public abstract CalculatorState GetNextState(CE input);


        public abstract CalculatorState GetNextState(C input);

        public abstract CalculatorState GetNextState(Equal input);



    }

}
