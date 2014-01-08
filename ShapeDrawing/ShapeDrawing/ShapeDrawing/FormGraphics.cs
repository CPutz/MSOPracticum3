using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShapeDrawing
{
    class FormGraphics : IGraphics
    {
        private Graphics canvas;

        public FormGraphics(Graphics canvas)
        {
            this.canvas = canvas;
        }

        public void DrawPolyLine(Point[] points)
        {
            throw new NotImplementedException();
        }

        public void DrawCircle(int x, int y, int size)
        {
            throw new NotImplementedException();
        }
    }
}
