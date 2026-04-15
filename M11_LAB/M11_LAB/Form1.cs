using M11_LAB.StatePackage;
using M11_LAB.OperationPackage;
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

        }

        private void period_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState('.', env);
            env.setCurrentState(state);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(0, env);
            env.setCurrentState(state);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Plus(), env);
            env.setCurrentState(state);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(new Equal(), env);
            env.setCurrentState(state);
        }

        private void one_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(1, env);
            env.setCurrentState(state);
        }

        private void two_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(2, env);
            env.setCurrentState(state);
        }

        private void three_Click(object sender, EventArgs e)
        {
            state = env.getCurrentState().GetNextState(3, env);
            env.setCurrentState(state);
        }
    }
}
