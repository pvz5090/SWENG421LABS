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

        public void drawing()
        { }

        public void setFromVertex(Edge fromVertex)
        {
            this.from_vertex = fromVertex;
        }

        public Edge getFromVertex()
        {
            return from_vertex;
        }

        public void setToVertex(Edge toVertex)
        {
            this.to_vertex = toVertex;
        }

        public Edge getToVertex()
        {
            return to_vertex;
        }

        public int getEdgeID()
        {
            return edge_ID;
        }

    }
}
