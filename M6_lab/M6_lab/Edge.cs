using System;
using System.Collections.Generic;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace M6_lab
{
    internal class Edge : Drawing
    {
        private int edge_ID;
        private Edge from_vertex;
        private Edge to_vertex;

        Edge(int edge_ID,Vextex)
        {
            this.edge_ID = edge_ID;
        }

        public void drawing()
        { }

        public void setFromVertex(Edge fromVertex)
        {
            this.from_vertex = fromVertex;
        }

        public M6_lab.Vertex getFromVertex()
        {
            return from_vertex;
        }

        public void setToVertex(Edge toVertex)
        {
            this.to_vertex = toVertex;
        }

        public M6_lab.Vertex getToVertex()
        {
            return to_vertex;
        }

        public int getEdgeID()
        {
            return edge_ID;
        }

    }
}
