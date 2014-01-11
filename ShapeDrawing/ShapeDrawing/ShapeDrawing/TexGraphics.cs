using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;


class TexGraphics : IGraphics
{
    private string filename;


    public TexGraphics(string filename)
    {
        this.filename = filename;
    }


    public void Begin()
    {

        using (StreamWriter writer = new StreamWriter(this.filename, false))
        {
            writer.WriteLine("\begin{tikzpicture}");
        }
    }

    public void End()
    {
        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.WriteLine("\\end{tikzpicture}");
        }
    }


    public void DrawPolyLine(Point[] points)
    {
        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.Write("  \\draw ");

            for (int i = 0; i < points.Length; ++i)
            {
                writer.Write("(" + points[i].X + "," + points[i].Y + ")");

                //after every pair of points we need to add " -- ", except the last pair.
                if (i < points.Length - 1)
                {
                    writer.Write(" -- ");
                }

                writer.WriteLine(";");
            }
        }
    }

    public void DrawCircle(int x, int y, int size)
    {
        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.WriteLine("  \\draw (" + x + "," + y + ") circle (" + size + "pt);");
        }
    }

/*\begin{tikzpicture}
\draw (-1.5,0) -- (1.5,0);
\draw (0,-1.5) -- (0,1.5);
\draw (0,0) circle (1cm);
\end{tikzpicture}*/
}
