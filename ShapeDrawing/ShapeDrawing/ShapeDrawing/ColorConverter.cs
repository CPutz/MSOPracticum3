using System;
using System.Drawing;

public static class ColorConverter
{
    //converts a Color object to a string representing the hexadecimal value of the color.
    public static string ColorToHex(Color color)
    {
        return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
    }
}
