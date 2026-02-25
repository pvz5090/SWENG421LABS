using System;
using System.Collections.Generic;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace M6_lab
{
    internal class Edge : Drawing, ICloneable
    {
        private int edge_ID;
        private Vertex from_vertex;
        private Vertex to_vertex;

        public Edge(Edge otherEdge)
        {
            this.edge_ID = otherEdge.edge_ID + 1;
            this.from_vertex = otherEdge.from_vertex;
            this.to_vertex = otherEdge.to_vertex;
        }

        public object Clone()
        {
            return new Edge(this);
        }

        //Edge(int edge_ID,Vertex)
        //{
        //    this.edge_ID = edge_ID;
        //}

        public void drawing()
        { }

        public void setFromVertex(Vertex fromVertex)
        {
            this.from_vertex = fromVertex;
        }

        public Vertex getFromVertex()
        {
            return from_vertex;
        }

        public void setToVertex(Vertex toVertex)
        {
            this.to_vertex = toVertex;
        }

        public Vertex getToVertex()
        {
            return to_vertex;
        }

        public int getEdgeID()
        {
            return edge_ID;
        }

        public void setEdgeID(int id) { edge_ID = id; }

    }
}
