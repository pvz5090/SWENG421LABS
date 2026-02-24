using System;
using System.Numerics;
using System.Collections.Generic;
using M6_lab;//for list


internal class Graph :ICloneable 
{
	int graph_ID;
	List<M6_lab.Vertex> listOfVertices;
    List<M6_lab.Edge> listOfEdges;



    public Graph(int id)
	{
			this.graph_ID = id;
			List<M6_lab.Vertex> listOfVertices = new List<M6_lab.Vertex>();
			List<M6_lab.Edge> listOfEdges = new List<M6_lab.Edge>();
    }

	public void addVertex(M6_lab.Vertex v)
	{
		v.setID(listOfVertices.Count + 1);
		listOfVertices.Add(v);
    }

	public void addEdge(M6_lab.Edge e)
	{ 
		e.setEdgeID(listOfEdges.Count + 1);
		listOfEdges.Add(e);
    }

	public void removeVertex(M6_lab.Vertex v)
	{ }





    public void display() { }

	public Object Clone()
	{
		return new Graph(GraphManager.listOfGraphs.Count+1);
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
