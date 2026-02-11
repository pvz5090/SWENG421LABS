namespace m5_lab
{
    public partial class Form1 : Form
    {
        Factory factory = new Factory();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "modules.txt";

            try
            {
                string[] list = File.ReadAllLines(filePath);
                comboBox1.Items.AddRange(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: modules.txt");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Module mod = factory.createModule(comboBox1.Text);
            mod.compute(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Module.getValue().ToString();
            textBox2.Text = Module.getValue().ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Module mod = factory.createModule(comboBox1.Text);
            //showing of input box 
            if (mod is InputModule)
            {
                textBox1.Visible = true;
                textBox5.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox5.Visible = false;
                mod.compute();
                textBox2.Text = Module.getValue().ToString();
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
