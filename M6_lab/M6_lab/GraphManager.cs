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
        private static int create() 
        {
            lock (listOfGraphs) {
                listOfGraphs.Add(new Graph(listOfGraphs.Count + 1)); //graph_id = where graph lies in listOfGraphs 
                return listOfGraphs.Count - 1;
            }
        }
        private static void modify(int graph_id, List<Vertex> vertices, List<Edge> edges)
        {
            foreach (Vertex v in vertices) { 
                if (listOfGraphs[graph_id].         //if vertex doesn't exist in graph.listOfVertexes -> create one and add to list, else modify existing 


            }
            foreach (Edge e in edges) {             
                if (listOfGraphs[graph_id].         //if edge doesn't exists in graph.listOfEdges -> create and add to list, else modify existing 
            }
        }

        private static int copy(int graph_id)
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
