using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class GraphicDrawer : IDrawer
    {
        Panel canvas;
        Graphics graphics;
        Pen pen;
        int curX, curY;
        int multX, multY;
        double scaleX, scaleY;

        public GraphicDrawer(Panel canvas, Pen pen) 
        {
            this.canvas = canvas;
            graphics = canvas.CreateGraphics();
            this.pen = pen;
            (curX, curY) = (0, 0);
            (multX, multY) = (10, 15);
            (scaleX, scaleY) = (1.5, 1.5);
        }

        public void DrawDouble(double d, int digits)
        {
            string format = "0.";
            for (int i = 0; i < digits; i++)
            {
                format += "0";
            }
            int x = curX + multX + 1;
            int y = (int)(curY * 1.25) + 8;
            int width = (int)(multX * 4 * scaleX);
            int height = (int)(multY * scaleY);
            var label = new Label()
            {
                Text = d.ToString(format),
                Location = new Point(x, y),
                Size = new Size(width, height),
            };
            canvas.Controls.Add(label);
        }

        public void DrawHorizontalLine(int length)
        {
            int x = (int)(curX * 1) + 1;
            int y = (int)(curY * 1.15) + 1;
            length = (int)(length * multX * scaleX);
            graphics.DrawLine(pen, x, y, x + length, y);
        }

        public void DrawVerticalLine(int length)
        {
            int x = (int)(curX * 1.04) + 1;
            int y = (int)(curY * 1);
            length = (int)(length * multY * scaleY);
            graphics.DrawLine(pen, x, y, x, y + length);
        }

        public void MoveOrigin(int deltaX, int deltaY)
        {
            curX += (int)(deltaX * multX * scaleX);
            curY += (int)(deltaY * multY * scaleY);
        }

        public void SetPosition(int x, int y)
        {
            curX = (int)(x * multX * scaleX);
            curY = (int)(y * multY * scaleY);
        }

        public void Undraw()
        {
            graphics.Clear(SystemColors.Control);
            canvas.Controls.Clear();
        }
    }
}
