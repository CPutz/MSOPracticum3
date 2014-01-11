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
            writer.WriteLine("\\begin{tikzpicture}");
        }
    }

    public void End()
    {
        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.WriteLine("\\end{tikzpicture}");
        }
    }


    public void DrawPolyLine(Point[] points, Color color)
    {
        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.WriteLine("  \\definecolor{TikZcolor}{HTML}{" + ColorConverter.ColorToHex(color) + "}");
            writer.Write("  \\draw[TikZcolor] ");

            for (int i = 0; i < points.Length; ++i)
            {
                writer.Write("(" + points[i].X + "pt," + -points[i].Y + "pt)");

                //after every pair of points we need to add " -- ", except the last pair.
                if (i < points.Length - 1)
                {
                    writer.Write(" -- ");
                }
            }

            writer.WriteLine(";");
        }
    }

    public void DrawCircle(int x, int y, int size, Color color)
    {
        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.WriteLine("  \\definecolor{TikZcolor}{HTML}{" + ColorConverter.ColorToHex(color) + "}");

            float radius = (float)size / 2;
            writer.WriteLine(
                "  \\draw[TikZcolor] (" + ((float)x + radius).ToString(System.Globalization.CultureInfo.InvariantCulture) +
                "pt," + (-(float)y - radius).ToString(System.Globalization.CultureInfo.InvariantCulture) +
                "pt) circle (" + radius.ToString(System.Globalization.CultureInfo.InvariantCulture) + 
                "pt);");
        }
    }

/*\begin{tikzpicture}
\draw (-1.5,0) -- (1.5,0);
\draw (0,-1.5) -- (0,1.5);
\draw (0,0) circle (1cm);
\end{tikzpicture}*/
}
