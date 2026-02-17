using System;
using System.Numerics;
using System.Collections.Generic;//for list

  
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

	public getID()

}
