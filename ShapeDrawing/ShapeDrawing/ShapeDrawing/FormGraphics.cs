using System;
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


    public void DrawPolyLine(Point[] points, Color color)
    {
        //polylines with fewer than 2 points are invalid
        System.Diagnostics.Debug.Assert(points.Length >= 2);

        Pen pen = new Pen(color);

        for (int i = 0; i < points.Length - 1; ++i)
        {
            this.canvas.DrawLine(pen, points[i], points[i + 1]);
        }
    }

    public void DrawCircle(int x, int y, int size, Color color)
    {
        Pen pen = new Pen(color);
        this.canvas.DrawEllipse(pen, x, y, size, size);
    }
}
