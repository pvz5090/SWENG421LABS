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
            string filePath = "C:\\Users\\patrick\\SWENG421LABS\\m5_lab\\m5_lab\\m5_lab\\modules.txt";

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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            e.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(); 
            Module mod = factory.createModule(e.ToString(), textBox1); 
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
            }
        }
    }
}
