using System.Collections.Generic;
using System.Drawing;

namespace M1_M2_Lab
{
    public partial class Form1 : Form
    {
        private int downX, downY;
        private int currentX, currentY;
        private Shape shape;
        private Color selectedColor = Color.Black;
        private Bitmap finalImage;
        private Bitmap previewBuffer;
        private bool mouseIsDown = false;

        public Form1()
        {
            InitializeComponent();

            if (panel1 != null)
            {
                panel1.GetType().GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.Instance
                    | System.Reflection.BindingFlags.NonPublic
                ).SetValue(panel1, true, null);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (finalImage != null)
                e.Graphics.DrawImageUnscaled(finalImage, 0, 0);

            if (mouseIsDown && previewBuffer != null)
                e.Graphics.DrawImageUnscaled(previewBuffer, 0, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            downX = e.X;
            downY = e.Y;
            mouseIsDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                currentX = e.X;
                currentY = e.Y;

                // Shape preview
                if (shape != null)
                {
                    Graphics g = Graphics.FromImage(previewBuffer);
                    g.Clear(Color.Transparent);
                    shape.drawColoredShape(g, selectedColor, downX, downY, currentX, currentY);
                }

                panel1.Invalidate();
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            currentX = e.X;
            currentY = e.Y;
            mouseIsDown = false;
            if (shape != null)
            {
                Graphics gFinal = Graphics.FromImage(finalImage);
                shape.drawColoredShape(gFinal, selectedColor, downX, downY, currentX, currentY);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                shape = new Line();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                shape = new Rectangle();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                shape = new Ellipse();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            // Copy old image contents, don't start fresh.
            if (finalImage != null)
            {
                Bitmap newFinal = new Bitmap(panel1.Width, panel1.Height);
                Graphics g = Graphics.FromImage(newFinal);
                g.DrawImageUnscaled(finalImage, 0, 0);

                finalImage = newFinal;
            }

            previewBuffer = new Bitmap(panel1.Width, panel1.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            finalImage = new Bitmap(panel1.Width, panel1.Height);
            previewBuffer = new Bitmap(panel1.Width, panel1.Height);
        }


    }
}
