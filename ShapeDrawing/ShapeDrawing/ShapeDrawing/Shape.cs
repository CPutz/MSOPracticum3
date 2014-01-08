using System;
using System.Drawing;

public abstract class Shape
{

    protected int x;
    protected int y;
    protected IGraphics graphics;

	public Shape(int x, int y)
	{
        this.x = x;
        this.y = y;
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