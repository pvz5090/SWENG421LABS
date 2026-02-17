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
		listOfVertices.Add(v);
    }

	public void addEdge(M6_lab.Edge e)
	{ 
		listOfEdges.Add(e);
    }

	public void removeVertex(M6_lab.Vertex v)
	{ }





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
