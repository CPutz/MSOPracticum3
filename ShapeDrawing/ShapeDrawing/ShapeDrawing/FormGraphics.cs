using System;
using System.Collections.Generic;
using System.Drawing;

class FormGraphics : IGraphics
{
    private Graphics canvas;

    public FormGraphics(Graphics canvas)
    {
        this.canvas = canvas;
    }


    public void Begin()
    {
        //do nothing
    }

    public void End()
    {
        //do nothing
    }


    public void DrawPolyLine(Point[] points)
    {
        Pen pen = new Pen(Color.Black);

        //assertion to ensure there are two points or more in the points array???

        for (int i = 0; i < points.Length - 1; ++i)
        {
            this.canvas.DrawLine(pen, points[i], points[i + 1]);
        }
    }

    public void DrawCircle(int x, int y, int size)
    {
        Pen pen = new Pen(Color.Black);
        this.canvas.DrawEllipse(pen, x, y, size, size);
    }
}
