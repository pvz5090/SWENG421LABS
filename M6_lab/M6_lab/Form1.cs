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

            graphsRefresh();
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
            activeGraph = manager.copy(activeGraph);
            GraphPanel.Invalidate();
            VerticesRefresh();
            graphsRefresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void graphsRefresh()
        {
            graphsComboBox.Items.Clear();
            foreach (Graph g in graphs)
                graphsComboBox.Items.Add(g);
            graphsComboBox.Invalidate();
        }
        private void VerticesRefresh()
        {
            VerticesComboBox.Items.Clear();
            foreach (Vertex v in activeGraph.getVertices())
                VerticesComboBox.Items.Add(v);
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
            Vertex selectedVertex = (Vertex)VerticesComboBox.SelectedItem;
            userX.Text = selectedVertex.getX().ToString();
            userY.Text = selectedVertex.getY().ToString();
        }

        private void userX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Vertex selectedVertex = (Vertex)VerticesComboBox.SelectedItem;
                selectedVertex.setX(int.Parse(userX.Text));
                GraphPanel.Invalidate();
            }
        }

        private void userY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Vertex selectedVertex = (Vertex)VerticesComboBox.SelectedItem;
                selectedVertex.setY(int.Parse(userY.Text));
                GraphPanel.Invalidate();
            }
        }

        private void graphsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeGraph = (Graph)graphsComboBox.SelectedItem;
            GraphPanel.Invalidate();
            VerticesRefresh(); 
        }
    }
}
