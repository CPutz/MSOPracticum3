using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

	private int width;
	private int height;

    public Rectangle(int x, int y, int width, int height)
        : base(x, y)
    {
		this.width = width;
		this.height = height;
    }
    
	public override void Draw()
    {
        base.Draw();

		Pen pen = new Pen(Color.Black);
        Point[] points = new Point[] { 
            new Point(this.x, this.y), 
            new Point(this.x + this.width, this.y),
            new Point(this.x + this.width, this.y + this.height), 
            new Point(this.x, this.y + this.height) 
        };

        this.graphics.DrawPolyLine(points);
    }
}

