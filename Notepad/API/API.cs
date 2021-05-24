using System.Windows.Forms;

namespace Notepad
{
    public static partial class API
    {
        static API()
        {

        }

        public static void ShowNotFoundMessageBox(string keyword)
        {
            MessageBox.Show(
                text: string.Format("Could not find \"{0}\"", keyword),
                caption: Application.ProductName,
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Asterisk
            );
        }
    }
}
