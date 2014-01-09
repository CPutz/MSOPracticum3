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
        FileStream stream = new FileStream(this.filename, FileMode.Create);
        StreamWriter writer = new StreamWriter(stream);

        writer.WriteLine("<?xml version=\"1.0\" standalone=\"no\"?>");
        writer.WriteLine("<!DOCTYPE svg PUBLIC \"-//W3C//DTD SVG 1.1//EN\"");
        writer.WriteLine("\"http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd\">");
        writer.WriteLine("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">");

        writer.Close();
        stream.Close();
    }

    public void End() {
        FileStream stream = new FileStream(this.filename, FileMode.Create);
        StreamWriter writer = new StreamWriter(stream);

        writer.WriteLine("<\\svg>");

        writer.Close();
        stream.Close();
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
