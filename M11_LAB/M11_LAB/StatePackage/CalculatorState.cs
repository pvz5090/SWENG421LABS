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
        protected static ResultState resultState = new ResultState();
        protected static OperatorState operatorState = new OperatorState();
        protected static UnaryState unaryState = new UnaryState();
        protected static OneNumberState oneNumberState = new OneNumberState();
        protected static TwoNumberState twoNumberState = new TwoNumberState();

        protected static CalculatorEnviroment env = new CalculatorEnviroment();
        public abstract CalculatorState GetNextState(string input);


        public abstract CalculatorState GetNextState(UnaryOperatorIF input);
        public abstract CalculatorState GetNextState(BinaryOperatorIF input);


        public abstract CalculatorState GetNextState(CE input);


        public abstract CalculatorState GetNextState(C input);

        public abstract CalculatorState GetNextState(Equal input);



    }

}
