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
    public Graph(Graph oldGraph)
    {
        this.graph_ID = GraphManager.getNextGraphID();
        GraphManager.incrementNextGraphID(); 
        List<M6_lab.Vertex> listOfVertices = new List<M6_lab.Vertex>();
		foreach (Vertex v in oldGraph.getVertices())
			{
				Vertex newVertex = new Vertex(v.getX(), v.getY());
				this.listOfVertices.Add(newVertex);
        }
        List<M6_lab.Edge> listOfEdges = new List<M6_lab.Edge>();
		foreach (Edge e in oldGraph.getEdges())
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

    public void display(Graphics g)
	{
        Color color = Color.Black;
        int vertexRadius = 10;
        int lineThickness = 1;
        foreach (Edge e in this.listOfEdges)
        {
            e.drawing(g, color, lineThickness);
            e.getFromVertex().drawing(g, color, vertexRadius);
            e.getToVertex().drawing(g, color, vertexRadius);
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

    public override string ToString()
    {
        return graph_ID.ToString();
    }
}
