using System;
using System.Drawing;
using System.IO;


class SVGGraphics : IGraphics
{
    private string filename;


    public SVGGraphics(string filename)
    {
        this.filename = filename;
    }


    public void Begin() {
        
        using (StreamWriter writer = new StreamWriter(this.filename, false))
        {
            writer.WriteLine("<?xml version=\"1.0\" standalone=\"no\"?>");
            writer.WriteLine("<!DOCTYPE svg PUBLIC \"-//W3C//DTD SVG 1.1//EN\"");
            writer.WriteLine("\"http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd\">");
            writer.WriteLine("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">");
        }
    }

    public void End() {
        
        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.WriteLine("</svg>");
        }
    }


    public void DrawPolyLine(Point[] points)
    {

        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.Write("<polyline points=\"");

            for (int i = 0; i < points.Length; ++i)
            {
                writer.Write(points[i].X + "," + points[i].Y);

                //after every pair of points we need to add a space, except the last pair.
                if (i < points.Length - 1)
                {
                    writer.Write(" ");
                }
            }

            writer.Write("\" style=\"fill:none;stroke:black;stroke-width:1\" />\n");
        }
    }

    public void DrawCircle(int x, int y, int size)
    {

        using (StreamWriter writer = new StreamWriter(this.filename, true))
        {
            writer.WriteLine(
                "<circle cx=\"" + x + 
                "\" cy=\"" + y + 
                "\" r=\"" + ((float)size / 2).ToString(System.Globalization.CultureInfo.InvariantCulture) + 
                "\" stroke-width=\"1\" fill=\"none\" stroke=\"black\" />");
        }
    }
}
