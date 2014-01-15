using System;
using System.Drawing;

class Circle : Shape
{

	private int size;

    public Circle(int x, int y, int size, Color color)
        : base(x, y, color)
    {
        this.size = size;
    }

    public override void Draw()
    {
        base.Draw();

        this.graphics.DrawCircle(this.x, this.y, this.size, this.color);
    }

}
