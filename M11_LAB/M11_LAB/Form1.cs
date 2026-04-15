using M11_LAB.StatePackage;
using M11_LAB.OperationPackage;
using System.Security.Cryptography.Xml;

namespace M11_Lab
{
    public partial class Display : Form
    {
        private CalculatorEnviroment env = new CalculatorEnviroment();
        CalculatorState state;
        public Display()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new SquareRoot());
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void period_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(".");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("0");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Plus());
            env.setCurrentState(state);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Equal());
            env.setCurrentState(state);
        }

        private void one_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("1");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void two_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("2");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void three_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("3");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Minus());
            env.setCurrentState(state);
        }

        private void inverse_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Inverse());
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Multiply());
            env.setCurrentState(state);
        }

        private void six_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("6");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void five_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("5");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void four_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("4");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("7");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("8");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("9");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Divide());
            env.setCurrentState(state);
        }

        private void sign_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Sign()); 
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void C_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new C());
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void CC_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new CE());
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState("backspace");
            env.setCurrentState(state);
            displayBox.Text = env.getDisplay().ToString();
        }
    }
}
