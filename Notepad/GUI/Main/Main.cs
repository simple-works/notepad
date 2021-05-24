using System.IO;
using System.Windows.Forms;
using Notepad.Properties;

namespace Notepad
{
    public partial class Form_Main
    {
        private string _filePath = "";

        public string Title
        {
            get
            {
                return string.IsNullOrEmpty(_filePath)
                    ? "Untitled" : Path.GetFileName(_filePath);
            }
        }

        public void SetupDisplay()
        {
            richTextBox_Main.AllowDrop = true;
        }

        public void UpdateDisplay()
        {
            this.Text = string.Format("{0} - {1}", this.Title, Application.ProductName);
            richTextBox_Main.WordWrap = tsmi_wordWrap.Checked;
            statusStrip_main.Visible = tsmi_statusBar.Checked && !richTextBox_Main.WordWrap;
            tsmi_statusBar.Enabled = !richTextBox_Main.WordWrap;
        }

        public void LoadSettings()
        {
            richTextBox_Main.Font = Settings.Default.Font;
            richTextBox_Main.WordWrap = tsmi_wordWrap.Checked = Settings.Default.WordWrap;
            fontDialog_main.Font = Settings.Default.Font;
            statusStrip_main.Visible = Settings.Default.StatusBar;

            this.Location = UISettings.Default.Location.IsEmpty
                ? this.Location : UISettings.Default.Location;
            this.Size = UISettings.Default.Size.IsEmpty ? this.Size : UISettings.Default.Size;
        }

        public void SaveSettings()
        {
            Settings.Default.Font = richTextBox_Main.Font;
            Settings.Default.WordWrap = richTextBox_Main.WordWrap;
            Settings.Default.Font = richTextBox_Main.Font;
            Settings.Default.StatusBar = statusStrip_main.Visible;
            Settings.Default.Save();

            UISettings.Default.Location = this.Location;
            UISettings.Default.Size = this.Size;
            UISettings.Default.Save();
        }

        private bool SaveFileOnConfirm()
        {
            if (richTextBox_Main.Modified)
            {
                DialogResult dialogResult = MessageBox.Show(
                    text: string.Format("Do you want to save the changes to {0} ?", this.Title),
                    caption: Application.ProductName,
                    buttons: MessageBoxButtons.YesNoCancel
                );
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        return SaveFile();
                    case DialogResult.No:
                        return true;
                    default:
                        return false;
                }
            }
            return true;
        }

        private void LoadFileByDragDrop(string[] filesPaths)
        {
            if (SaveFileOnConfirm())
            {
                _filePath = filesPaths[0];
                richTextBox_Main.LoadFile(_filePath, RichTextBoxStreamType.PlainText);
            }
        }

        private bool SaveFile()
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                if (saveFileDialog_main.ShowDialog() == DialogResult.OK)
                {
                    _filePath = saveFileDialog_main.FileName;
                }
                else
                {
                    return false;
                }
            }
            richTextBox_Main.SaveFile(_filePath, RichTextBoxStreamType.PlainText);
            UpdateDisplay();
            return true;
        }
    }
}
