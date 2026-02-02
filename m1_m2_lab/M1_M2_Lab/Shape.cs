using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_M2_Lab
{
    internal abstract class Shape
    {
        public abstract void drawColoredShape(Graphics g, Color penColor, int x1, int y1, int x2, int y2);
    }

    internal class Line : Shape
    {
        public override void drawColoredShape(Graphics g, Color penColor, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(new Pen(penColor), x1, y1, x2, y2);
        }
    }

    internal class Rectangle : Shape
    {
        public override void drawColoredShape(Graphics g, Color penColor, int x1, int y1, int x2, int y2)
        {
            g.DrawRectangle(new Pen(penColor), Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1-x2), Math.Abs(y1-y2));
        }
    }

    internal class Ellipse : Shape
    {
        public override void drawColoredShape(Graphics g, Color penColor, int x1, int y1, int x2, int y2)
        {
            g.DrawEllipse(new Pen(penColor), Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
    }
}
