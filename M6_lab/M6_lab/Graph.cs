using System;
using System.Numerics;
using System.Collections.Generic;//For List
using M6_lab;//for getter method of vertex and edge


internal class Graph :ICloneable
{
	private int graph_ID;
	private List<Vertex> listOfVertices = new List<Vertex>();
	private List<Edge> listOfEdges = new List<Edge>();



    public Graph(int id)
	{
        this.graph_ID = id;
        List<Vertex> listOfVertices = new List<Vertex>();
        List<Edge> listOfEdges = new List<Edge>();
    }


    //a Copy constructor that creates a new graph by Constructing  the vertices and edges from an existing graph
    public Graph(Graph g)
    {
        this.graph_ID = g.graph_ID;
        List<M6_lab.Vertex> listOfVertices = new List<M6_lab.Vertex>();
		foreach (Vertex v in g.getVertices())
			{
				Vertex newVertex = new Vertex(v.getX(), v.getY());
				this.listOfVertices.Add(newVertex);
        }
        List<M6_lab.Edge> listOfEdges = new List<M6_lab.Edge>();
		foreach (Edge e in g.getEdges())
        {
            this.listOfEdges.Add(e.Clone() as Edge);
        }
    }


    public object Clone()
    {
        return new Graph(this);
    }

    public void addVertex(M6_lab.Vertex v)
	{
		
		listOfVertices.Add(v);
    }

	public void addEdge(M6_lab.Edge e)
	{ 
		listOfEdges.Add(e);
    }

	public void removeVertex(M6_lab.Vertex v)
	{ 
		foreach(Vertex currentVert in listOfVertices)
        {
			if (currentVert.getVertexID() == v.getVertexID())
			{
				this.listOfVertices.Remove(currentVert);
            }
        }

		foreach(Edge currentEdge in listOfEdges)
        {
			if (currentEdge.getFromVertex().getVertexID() == v.getVertexID() || currentEdge.getToVertex().getVertexID() == v.getVertexID())
			{
                this.listOfEdges.Remove(currentEdge);
            }
        }
    }

    private double cosine(Point p1, Point p2) {
        double d0 = p1.X * p2.X + p1.Y * p2.Y;
        double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);
        return d0 / d1;
    }

    private Point compute(Point p1, double angle) {
        double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);
        double x = -20 * p1.X / d1;
        double y = -20 * p1.Y / d1;
        double nx = x * Math.Cos(angle) - y * Math.Sin(angle);
        double ny = x * Math.Sin(angle) + y * Math.Cos(angle);
        return new Point((int) nx, (int) ny);
    }

    private void displayEdge(Graphics g, Edge e)
    {
        // Radius of each node
        int s = 1;

        Color color = Color.Black;
		Pen pen = new Pen(color);
        Brush brush = new SolidBrush(color);
        Rectangle r1 = new Rectangle(e.getFromVertex().getX() -s, e.getFromVertex().getY() -s, 2 * s, 2 * s);
        Rectangle r2 = new Rectangle(e.getToVertex().getX() -s, e.getToVertex().getY() -s, 2 * s, 2 * s);
        g.DrawEllipse(pen, r1);
        g.DrawEllipse(pen, r2);
        
        int v = r1.Y > r2.Y? -1: 1;
        double d = cosine(new Point(r2.X - r1.X, r2.Y - r1.Y), new Point(v, 0));
        double x = r1.X + s + v * s * d;
        double y = r1.Y + s + v * s * Math.Sqrt(1 - d * d);
        double x2 = r2.X + s - v * s * d;
        double y2 = r2.Y + s - v * s * Math.Sqrt(1 - d * d);
        g.DrawLine(pen, new Point((int) x, (int) y), new Point((int) x2, (int) y2));
        g.FillEllipse(brush, new Rectangle((int) (x - 5), (int) (y - 5), 10, 10));

        Point p = compute(new Point(r2.X - r1.X, r2.Y - r1.Y), Math.PI / 6);
        g.DrawLine(pen, new Point((int) x2, (int) y2), new Point((int) x2 + p.X, (int) y2 + p.Y));
        p = compute(new Point(r2.X - r1.X, r2.Y - r1.Y), -Math.PI / 6);
        g.DrawLine(pen, new Point((int) x2, (int) y2), new Point((int) x2 + p.X, (int) y2 + p.Y));
    }

    public void display(Graphics g)
	{
        foreach (Edge e in this.listOfEdges)
        {
            displayEdge(g, e);
        }
    }

	public int getID()
	{
		return graph_ID;
    }

	public List<M6_lab.Vertex> getVertices()
	{
		return listOfVertices;
    }

	public List<M6_lab.Edge> getEdges()
	{
		return listOfEdges;
    }


	public Vertex getVertexById(int id)
	{
		foreach (Vertex v in listOfVertices)
		{
			if (v.getVertexID() == id)
			{
				return v;
			}
		}
		return null; // Return null if vertex with the specified ID is not found
    }
}
