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
        private static int create() 
        {
            lock (listOfGraphs) {
                listOfGraphs.Add(new Graph(listOfGraphs.Count + 1));
                return listOfGraphs.Count - 1;
            }
            
        }
        private static void modify(int graph_id)
        {

        }

        private static int copy(int graph_id)
        {
            listOfGraphs.Add(listOfGraphs[graph_id - 1].clone());
            return listOfGraphs.Count - 1;
        }

    }
}
