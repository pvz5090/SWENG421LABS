using System;
using System.Numerics;
using System.Collections.Generic;//For List
using M6_lab;//for getter method of vertex and edge
using M6_lab.Vertex;
using M6_lab.Edges;



internal class Graph :ICloneable
{
	private int graph_ID;
	private List<M6_lab.Vertex> listOfVertices;
	private List<M6_lab.Edge> listOfEdges;



    public Graph(int id)
	{
			this.graph_ID = id;
			List<M6_lab.Vertex> listOfVertices = new List<M6_lab.Vertex>();
			List<M6_lab.Edge> listOfEdges = new List<M6_lab.Edge>();
    }

    //a Copy constructor that creates a new graph by Constructing  the vertices and edges from an existing graph
    public Graph(Graph g)
    {
        this.graph_ID = id;
        List<M6_lab.Vertex> listOfVertices = new List<M6_lab.Vertex>();
		for v in g.getVertices()
			{
				Vertex newVertex = new Vertex(v.getVertexID(), v.getX(), v.getY());
				this.listOfVertices.Add(newVertex);
        }
        List<M6_lab.Edge> listOfEdges = new List<M6_lab.Edge>();
    }

    public void addVertex(M6_lab.Vertex v)
	{
		listOfVertices.Add(v);
    }

	public void addEdge(M6_lab.Edge e)
	{ 
		this.listOfEdges.Add(e);
    }

	public void removeVertex(M6_lab.Vertex v)
	{ 
		for item in listOfVertices

        {
			if (item.getVertexID() == v.getVertexID())
			{
				this.listOfVertices.Remove(item);
            }
        }

		for item in this.listOfEdges
			{
            if (item.getFromVertex().getVertexID == v || item.getDestination() == v)
            {
                listOfEdges.Remove(item);
            }

        }
    }





    public display()

	public clone()

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
