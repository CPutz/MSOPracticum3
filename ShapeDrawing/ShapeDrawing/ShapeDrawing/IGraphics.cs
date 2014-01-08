using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShapeDrawing
{
    interface IGraphics
    {
        void DrawPolyLine(Point[] points);
        void DrawCircle(int x, int y, int size);
    }
}
