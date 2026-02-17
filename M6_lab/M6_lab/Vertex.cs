using System;
using System.Collections.Generic;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6_lab
{
    internal class Vertex
    {
        private int vertex_ID;
        private int x_coordinate;
        private int y_coordinate;

        public void drawing()
        { }

        public int getX()
        {
            return x_coordinate;
        }

        public void setX(int x)
        {
            this.x_coordinate = x;
        }

        public int getY()
        {
            return y_coordinate;
        }

        public void setY(int y)
        {
            this.y_coordinate = y;
        }

        public int getVertexID()
        {
            return vertex_ID;
        }

    }
}
