using System;
using System.Drawing;

public static class ColorConverter
{
    public static string ColorToHex(Color color)
    {
        return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
    }
}
