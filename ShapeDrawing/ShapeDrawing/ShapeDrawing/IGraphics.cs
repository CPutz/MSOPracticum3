using System;
using System.Collections.Generic;
using System.Drawing;

public interface IGraphics
{
    void DrawPolyLine(Point[] points, Color color);
    void DrawCircle(int x, int y, int size, Color color);
    void Begin();
    void End();
}
