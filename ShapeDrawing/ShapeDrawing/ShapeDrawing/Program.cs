using System;
using System.Windows.Forms;

namespace ShapeDrawing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Application.Run(new ShapeDrawingForm());
        }
    }
}
