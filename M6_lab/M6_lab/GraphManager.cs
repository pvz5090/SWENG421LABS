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
        private static GraphManager? graphManager = null; 
        public static List <Graph> listOfGraphs = new List <Graph> (); 
        private static int nextGraphID=1;
        private static int nextVertexID = 1;
        private static int nextEdgeID = 1;
       
        //Singleton pattern implementation of Constructor for GraphManager class
        private GraphManager()
        {
            if (graphManager==null)
            {
                graphManager = new GraphManager();
            }
            else 
            {
                Console.WriteLine("GraphManager instance already exists. Constructor will not Construct new Instance");
               
            }

        }
        public int create() 
        {
            lock (listOfGraphs) {
                
                listOfGraphs.Add(new Graph(nextGraphID)); //graph_id - 1 = where graph lies in listOfGraphs 
                nextGraphID= listOfGraphs.Count + 1;//incrementing nextGraphID for next graph creation
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

        public int copy(Graph g)
        {
            listOfGraphs.Add(g.Clone() as Graph);
            nextGraphID = listOfGraphs.Count + 1;

            return listOfGraphs.Count - 1;
        }

        public static GraphManager getManager()
        {
            return graphManager;
        }

        public static int getNextGraphID()
        {
            return nextGraphID;
        }

        public static int getNextVertexID()
        {
            return nextVertexID;
        }

        public static int getNextEdgeID()
        {
            return nextEdgeID;
        }

        public static void incrementNextGraphID()
        {
            nextGraphID++;
        }

        public static void incrementNextVertexID()
        {
            nextVertexID++;
        }

        public static void incrementNextEdgeID()
        {
            nextEdgeID++;
        }

            
    }
}
