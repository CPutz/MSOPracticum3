﻿using System;
using System.Collections.Generic;

namespace ShapeDrawing
{
    interface IGraphics
    {
        void DrawPolyLine(Point[] points);
        void DrawCircle(int size);
    }
}
