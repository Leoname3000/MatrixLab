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

        public GraphicDrawer(Panel canvas, Pen pen) 
        {
            this.canvas = canvas;
            graphics = canvas.CreateGraphics();
            this.pen = pen;
            (curX, curY) = (30, 30);
            (multX, multY) = (10, 15);
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
            var label = new Label()
            {
                Text = d.ToString(format),
                Location = new Point(x, y),
                Size = new Size(multX * 4, multY),
            };
            canvas.Controls.Add(label);
        }

        public void DrawHorizontalLine(int length)
        {
            int x = (int)(curX * 1) + 1;
            int y = (int)(curY * 1.15) + 1;
            graphics.DrawLine(pen, x, y, x + length * multX, y);
        }

        public void DrawVerticalLine(int length)
        {
            int x = (int)(curX * 1.04) + 1;
            int y = (int)(curY * 1);
            graphics.DrawLine(pen, x, y, x, y + length * multY);
        }

        public void MoveOrigin(int deltaX, int deltaY)
        {
            curX += deltaX * multX;
            curY += deltaY * multY;
        }

        public void SetPosition(int x, int y)
        {
            curX = x * multX;
            curY = y * multY;
        }

        public void Undraw()
        {
            graphics.Clear(SystemColors.Control);
            canvas.Controls.Clear();
        }
    }
}
