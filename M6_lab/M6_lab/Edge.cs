using System;
using System.Collections.Generic;
using System.Data.Common;
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

        //A constructor that initializes the edge with the source and destination vertices as copyied soft references and assign a given ID to the edge
        public Edge( Vertex source, Vertex Destination)
        {
            this.edge_ID = GraphManager.getNextEdgeID();
            GraphManager.incrementNextEdgeID();
            this.from_vertex = source;
            this.to_vertex = Destination;
        }


        public Edge(Edge otherEdge)
        {
            this.edge_ID = GraphManager.getNextEdgeID();
            GraphManager.incrementNextEdgeID();
            this.from_vertex = new Vertex(otherEdge.from_vertex);
            this.to_vertex = new Vertex(otherEdge.to_vertex);
        }

        public object Clone()
        {
            Edge e= new Edge( this);
            
            return e;
        }

        Edge(int edge_ID,Vextex)
        {
            this.edge_ID = edge_ID;
        }

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
