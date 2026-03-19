using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace M6_lab
{
    internal class GraphManager
    {
        private static GraphManager graphManager = null; 
        public static List <Graph> listOfGraphs = new List <Graph> (); 
        private static int nextGraphID=1;
        private static int nextVertexID = 1;
        private static int nextEdgeID = 1;
        private GraphManager() {}

        public int create() 
        {
            lock (listOfGraphs) 
            {
                listOfGraphs.Add(new Graph(nextGraphID)); 
                nextGraphID= listOfGraphs.Count + 1;//incrementing nextGraphID for next graph creation
                return listOfGraphs.Count;
            }
        }
        /// <summary>
        /// 
        /// modifies the vertices and edges of an existing graph with the given graph_id,
        /// if a vertex in the input list of vertices already exists in the graph, it updates the X and Y coordinates of the existing vertex,
        /// otherwise it adds the new vertex to the graph. The method does not modify edges in this implementation.
        /// </summary>
        public void modify(Graph activeGraph, List<Vertex> modifiedVertices)
        {
            List<Vertex> graphVertices = activeGraph.getVertices();
            var vertexList = graphVertices.ToDictionary(v => v.getVertexID());
            if(modifiedVertices.Count == 2)
            {
                activeGraph.addEdge(new Edge(modifiedVertices[0], modifiedVertices[1]));
            }
            foreach (Vertex vertex in modifiedVertices) { 
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

        /// <summary>
        /// creates a new graph by copying an existing graph and adds the new graph to the list of graphs, returns the ID of the new graph
        /// </summary>
        /// <param name="g">the new x-coordinate.</param>
        ///  <returns>
        /// the identifier graph_ID of the newly created graph in the list of graphs, which serves as its unique identifier (ID).
        /// </returns>
        public Graph copy(Graph oldGraph)
        {
            Graph newGraph = oldGraph.Clone() as Graph; 
            listOfGraphs.Add(newGraph);

            return newGraph;
        }

        /// <summary>
        /// a static getter for the singleton instance of GraphManager, if it does not exist, creates a new instance, otherwise returns existing instance
        /// </summary>
        public static GraphManager getManager()
        {
            if (graphManager == null)
            {
                graphManager = new GraphManager();
            }
            else
            {
                Console.WriteLine("GraphManager instance already exists. Constructor will not Construct new Instance");

            }
            return graphManager;
        }

        /// <summary>
        ///a static getter for nextGraphID attribute, used for new graph creation
        /// </summary>
        /// <returns> returns interger attribute nextGraphID of GraphManager, it is primarily used to determine the ID of new Graphs in their constructors </returns>
        public static int getNextGraphID()
        {
            return nextGraphID;
        }

        /// <summary>
        ///a static getter for the attribute nextVertexID, used in new vertex creation
        /// </summary>
        /// <returns> returns interger attribute nextVertexID of GraphManager, it is primarily used to determine the ID of new Vertexs in their constructors </returns>
        public static int getNextVertexID()
        {
            return nextVertexID;
        }

        /// <summary>
        /// a static getter for nextEdgeID attribute, used when new edges are created
        /// </summary>
        /// <returns> returns interger attribute nextEdgeID of GraphManager, it is primarily used to determine the ID of new Edges in their constructors </returns>
        public static int getNextEdgeID()
        {
            return nextEdgeID;
        }

        /// <summary>
        /// Increments the identifier nextGraphID used for constructing new graphs
        /// </summary>
        public static void incrementNextGraphID()
        {
            nextGraphID++;
        }

        /// <summary>
        /// Increments the identifier nextVertexID used for new vertex creation 
        /// </summary>
        public static void incrementNextVertexID()
        {
            nextVertexID++;
        }

        /// <summary>
        /// Increments the identifier nextEdgeID used for creating new edges.
        /// </summary>
        public static void incrementNextEdgeID()
        {
            nextEdgeID++;
        }

            
    }
}
