namespace M6_lab
{
    public partial class Form1 : Form
    {
        GraphManager manager = GraphManager.getManager();
        List<Graph> graphs = GraphManager.listOfGraphs;
        Graph activeGraph;
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
            activeGraph = graphs[graph-1];
            GraphPanel.Invalidate();
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (activeGraph != null)
                activeGraph.display(g);
        }

        private void CopyGraphButton_Click(object sender, EventArgs e)
        {
            int newGraphID = manager.copy(activeGraph.getID());
            activeGraph = graphs[newGraphID]; 
            GraphPanel.Invalidate();
        }
    }
}
