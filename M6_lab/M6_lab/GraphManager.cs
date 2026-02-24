using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6_lab
{
    internal class GraphManager
    {
        private static GraphManager graphManager; 
        public static List <Graph> listOfGraphs = new List <Graph> (); 

        private GraphManager(){}
        public int create() 
        {
            lock (listOfGraphs) {
                listOfGraphs.Add(new Graph(listOfGraphs.Count + 1)); //graph_id - 1 = where graph lies in listOfGraphs 
                return listOfGraphs.Count;
            }
        }
        public void modify(int graph_id, List<Vertex> vertices, List<Edge> edges)
        {
            Graph graph = listOfGraphs[graph_id]; 
            List<Vertex> graphVertices = listOfGraphs[graph_id].getVertices();
            var vertexList = graphVertices.ToDictionary(v => v.getVertexID());

            foreach (var vertex in vertices) { 
                int id = vertex.getVertexID();
                if(vertexList.TryGetValue(id, out Vertex existingVertex)) //if vertex exists in graph -> modify existing X,Y 
                {
                    existingVertex.setX(vertex.getX());
                    existingVertex.setY(vertex.getY());
                }
                else
                {
                    graphVertices.Add(vertex);
                }
            }
          
        }

        public int copy(int graph_id)
        {
            listOfGraphs.Add(listOfGraphs[graph_id - 1].clone());
            return listOfGraphs.Count - 1;
        }

        public static GraphManager getManager()
        {
            return graphManager;
        }
    }
}
