using System;
using System.Drawing;

public abstract class Shape
{

    protected int x;
    protected int y;
    protected Color color;
    protected IGraphics graphics;

	public Shape(int x, int y, Color color)
	{
        this.x = x;
        this.y = y;
        this.color = color;
	}

    public virtual void Draw()
    {
        System.Diagnostics.Debug.Assert(this.graphics != null);
    }

    public void setGraphics(IGraphics graphics)
    {
        this.graphics = graphics;
    }
}