using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Notepad
{
    public static partial class API
    {
        public static void AllowText(this DragEventArgs e)
        {
            //e.Effect = e.Data.GetDataPresent(DataFormats.Text)
            //    ? DragDropEffects.Copy : DragDropEffects.None;
            e.Effect = DragDropEffects.All;
        }

        public static string[] GetPaths(this DragEventArgs e)
        {
            return e.Data.GetData(DataFormats.FileDrop, false) as string[];
        }

        public static void DrawPage(this PrintPageEventArgs e, string text, Font font)
        {
            e.Graphics.DrawString(text, font, Brushes.Black, 100, 100);
        }
    }
}
