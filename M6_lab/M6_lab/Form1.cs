using System.Windows.Forms.VisualStyles;

namespace M6_lab
{
    public partial class Form1 : Form
    {
        GraphManager manager = GraphManager.getManager();
        List<Graph> graphs = GraphManager.listOfGraphs;
        Graph activeGraph;

        Vertex fromVertex, toVertex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Graph g in graphs)
                graphsComboBox.Items.Add("Graph " + g.getID);
            graphsComboBox.Invalidate();
        }

        private void CreateGraphClicked(object sender, EventArgs e)
        {
            int graph = manager.create();
            activeGraph = graphs[graph - 1];
            GraphPanel.Invalidate();

            VerticesRefresh();
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (activeGraph != null)
                activeGraph.display(g);
        }

        private void CopyGraphButton_Click(object sender, EventArgs e)
        {
            int newGraphID = manager.copy(activeGraph);
            activeGraph = graphs[newGraphID];
            GraphPanel.Invalidate();
            VerticesRefresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerticesRefresh()
        {
            VerticesComboBox.Items.Clear();
            foreach (Vertex v in activeGraph.getVertices())
                VerticesComboBox.Items.Add(v.getVertexID());
            VerticesComboBox.Visible = true;
        }

        private void GraphPanel_MouseDown(object sender, MouseEventArgs e)
        {
            fromVertex = new Vertex(e.X, e.Y);
        }

        private void GraphPanel_MouseUp(object sender, MouseEventArgs e)
        {
            toVertex = new Vertex(e.X, e.Y);
            activeGraph.addVertex(fromVertex);
            activeGraph.addVertex(toVertex);
            activeGraph.addEdge(new Edge(fromVertex, toVertex));

            GraphPanel.Invalidate();
            VerticesRefresh();

        }

        private void VerticesComboBox_SelectedIndexChanged(object sender, EventArgs e) //this should update the X,Y coordinate textboxes
        {
            int vertexID = VerticesComboBox.SelectedIndex;  
        }
    }
}
