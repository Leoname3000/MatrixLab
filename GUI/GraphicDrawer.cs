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
        int originX, originY;
        int curX, curY;
        int multX, multY;
        double scaleX, scaleY;

        public GraphicDrawer(Panel canvas, Pen pen) 
        {
            this.canvas = canvas;
            graphics = canvas.CreateGraphics();
            this.pen = pen;
            (originX, originY) = (0, 0);
            (curX, curY) = (0, 0);
            (multX, multY) = (10, 15);
            //(scaleX, scaleY) = (1.5, 1.5);
            (scaleX, scaleY) = (1.0, 1.0);
        }

        public void SetPosition(int x, int y)
        {
            curX = (int)(x * multX * scaleX);
            curY = (int)(y * multY * scaleY);
        }

        public void MoveOrigin(int deltaX, int deltaY)
        {
            originX += (int)(deltaX * multX * scaleX);
            originY += (int)(deltaY * multY * scaleY);
        }

        public void DrawDouble(double d, int digits)
        {
            string format = "0.";
            for (int i = 0; i < digits; i++)
            {
                format += "0";
            }
            int width = (int)(multX * (digits + 2) * scaleX);
            int height = (int)(multY * scaleY);
            int x = originX + curX + (multX * (digits + 2) - width) / 2 + multX / 2;
            int y = originY + curY + (multY - height) / 2;
            var label = new Label()
            {
                Text = d.ToString(format),
                Location = new Point(x, y),
                Size = new Size(width, height),
            };
            canvas.Controls.Add(label);
        }

        public void DrawBox(int width, int height)
        {
            DrawHorizontalLine(width);
            DrawVerticalLine(height);
            SetPosition(width, 0);
            DrawVerticalLine(height);
            SetPosition(0, height);
            DrawHorizontalLine(width);
        }

        public void DrawHorizontalLine(int length)
        {
            int x = originX + curX;
            int y = originY + curY;
            length = (int)(length * multX * scaleX);
            graphics.DrawLine(pen, x, y, x + length, y);
        }

        public void DrawVerticalLine(int length)
        {
            int x = originX + curX;
            int y = originY + curY;
            length = (int)(length * multY * scaleY);
            graphics.DrawLine(pen, x, y, x, y + length);
        }

        public void Undraw()
        {
            graphics.Clear(SystemColors.Control);
            canvas.Controls.Clear();
        }
    }
}
