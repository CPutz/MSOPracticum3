using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle : Shape
{

	private int size;

    public Circle(int x, int y, int size)
        : base(x, y)
    {
        this.size = size;
    }

    public override void Draw()
    {
        base.Draw();

		Pen pen = new Pen(Color.Black);
        Canvas.DrawEllipse(pen, this.x, this.y, this.size, this.size);
    }

}
