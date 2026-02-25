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

        public void drawing(Graphics g, Color c, int s)
        {
            Pen pen = new Pen(c, s);
            Brush brush = new SolidBrush(c);

            double cosine(Point p1, Point p2) {
                double d0 = p1.X * p2.X + p1.Y * p2.Y;
                double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);
                return d0 / d1;
            }

            Point compute(Point p1, double angle) {
                double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);
                double x = -20 * p1.X / d1;
                double y = -20 * p1.Y / d1;
                double nx = x * Math.Cos(angle) - y * Math.Sin(angle);
                double ny = x * Math.Sin(angle) + y * Math.Cos(angle);
                return new Point((int) nx, (int) ny);
            }

            Vertex fromVertex = this.getFromVertex();
            Vertex toVertex = this.getToVertex();

            int fromX = fromVertex.getX() - s;
            int fromY = fromVertex.getY() - s;
            int toX = toVertex.getX() - s;
            int toY = toVertex.getY() - s;

            int v = fromY > toY? -1: 1;
            double d = cosine(new Point(toX - fromX, toY - fromY), new Point(v, 0));
            double x = fromX + s + v * s * d;
            double y = fromY + s + v * s * Math.Sqrt(1 - d * d);
            double x2 = toX + s - v * s * d;
            double y2 = toY + s - v * s * Math.Sqrt(1 - d * d);

            // Draw the line between nodes
            g.DrawLine(pen, new Point((int) x, (int) y), new Point((int) x2, (int) y2));
            g.FillEllipse(brush, new Rectangle((int) (x - 5), (int) (y - 5), 10, 10));

            // Draw two lines at the end of the connecting line to make an arrow
            Point p = compute(new Point(toX - fromX, toY - fromY), Math.PI / 6);
            g.DrawLine(pen, new Point((int) x2, (int) y2), new Point((int) x2 + p.X, (int) y2 + p.Y));
            p = compute(new Point(toX - fromX, toY - fromY), -Math.PI / 6);
            g.DrawLine(pen, new Point((int) x2, (int) y2), new Point((int) x2 + p.X, (int) y2 + p.Y));
        }


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
