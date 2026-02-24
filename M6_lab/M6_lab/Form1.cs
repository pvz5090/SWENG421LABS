namespace M6_lab
{
    public partial class Form1 : Form
    {
        GraphManager manager = GraphManager.getManager();
        List<Graph> graphs = GraphManager.listOfGraphs; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Graph g in graphs)
                graphsComboBox.Items.Add("Graph " + g.getID);
        }

        private void CreateGraphClicked(object sender, EventArgs e)
        {
            int graph = manager.create();
            graphs[graph].display(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;


        }
    }
}
