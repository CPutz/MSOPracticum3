using System;
using System.Collections.Generic;
using System.Drawing;

public interface IGraphics
{
    void DrawPolyLine(Point[] points);
    void DrawCircle(int x, int y, int size);
}
