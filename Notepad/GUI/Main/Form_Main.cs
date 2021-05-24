using System;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form_Main : Form
    {
        private API.RichTextBoxSearchInfos _searchInfos = new API.RichTextBoxSearchInfos();

        public Form_Main()
        {
            InitializeComponent();
            SetupDisplay();
            LoadSettings();
            UpdateDisplay();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveFileOnConfirm();
            SaveSettings();
        }

        private void Form_Main_DragEnter(object sender, DragEventArgs e)
        {
            e.AllowText();
        }

        private void Form_Main_DragDrop(object sender, DragEventArgs e)
        {
            LoadFileByDragDrop(e.GetPaths());
        }

        private void printDocument_Main_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.DrawPage(richTextBox_Main.Text, richTextBox_Main.Font);
        }

        private void richTextBox_Main_SelectionChanged(object sender, EventArgs e)
        {
            _searchInfos.LatestResultStartIndex = richTextBox_Main.SelectionStart;
            _searchInfos.LatestResultEndIndex = richTextBox_Main.SelectionStart;
            int line = richTextBox_Main.GetSelectedLineIndex() + 1;
            int column = richTextBox_Main.GetSelectedColumnIndex() + 1;
            tssl_columnLine.Text = string.Format("Ln {0}, Col {1}", line, column);
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmi_about_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog();
        }

        private void tsmi_pageSetup_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument_main.DocumentName = Path.GetFileName(_filePath);
                printPreviewDialog_main.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    text: exception.Message,
                    caption: Application.ProductName,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
        }

        private void tsmi_print_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument_main.DocumentName = Path.GetFileName(_filePath);
                if (printDialog_main.ShowDialog() == DialogResult.OK)
                {
                    printDocument_main.Print();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    text: exception.Message,
                    caption: Application.ProductName,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
        }

        private void tsmi_save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void tsmi_new_Click(object sender, EventArgs e)
        {
            if (SaveFileOnConfirm())
            {
                richTextBox_Main.Clear();
                _filePath = "";
                UpdateDisplay();
            }
        }

        private void tsmi_open_Click(object sender, EventArgs e)
        {
            if (SaveFileOnConfirm())
            {
                if (openFileDialog_main.ShowDialog() == DialogResult.OK)
                {
                    _filePath = openFileDialog_main.FileName;
                    richTextBox_Main.LoadFile(_filePath, RichTextBoxStreamType.PlainText);
                    richTextBox_Main.Modified = false;
                    UpdateDisplay();
                }
            }
        }

        private void tsmi_saveAs_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void tsmi_undo_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Undo();
        }

        private void tsmi_redo_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Redo();
        }

        private void tsmi_cut_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Cut();
        }

        private void tsmi_copy_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Copy();
        }

        private void tsmi_paste_Click(object sender, EventArgs e)
        {
            richTextBox_Main.PastePlainText();
        }

        private void tsmi_delete_Click(object sender, EventArgs e)
        {
            richTextBox_Main.DeleteSelection();
        }

        private void tsmi_find_Click(object sender, EventArgs e)
        {
            new Form_Find(richTextBox_Main, _searchInfos).Show(this);
        }

        private void tsmi_findNext_Click(object sender, EventArgs e)
        {
            richTextBox_Main.FindNext(_searchInfos);
        }

        private void tsmi_replace_Click(object sender, EventArgs e)
        {
            new Form_Replace(richTextBox_Main, _searchInfos).Show(this);
        }

        private void tsmi_goto_Click(object sender, EventArgs e)
        {
            new Form_GoTo(richTextBox_Main).ShowDialog(this);
        }

        private void tsmi_selectAll_Click(object sender, EventArgs e)
        {
            richTextBox_Main.SelectAll();
        }

        private void tsmi_timeDate_Click(object sender, EventArgs e)
        {
            string timeDateText = string.Format(
                "{0} {1}",
                DateTime.Now.ToShortTimeString(),
                DateTime.Now.ToShortDateString()
            );
            richTextBox_Main.ReplaceSelection(timeDateText);
        }

        private void tsmi_statusBar_Click(object sender, EventArgs e)
        {
            tsmi_statusBar.Checked = !tsmi_statusBar.Checked;
            UpdateDisplay();
        }

        private void tsmi_wordWrap_Click(object sender, EventArgs e)
        {
            tsmi_wordWrap.Checked = !tsmi_wordWrap.Checked;
            UpdateDisplay();
        }

        private void tsmi_font_Click(object sender, EventArgs e)
        {
            if (fontDialog_main.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox_Main.Font = fontDialog_main.Font;
            }
        }

        private void ctsmi_undo_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Undo();
        }

        private void ctsmi_cut_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Cut();
        }

        private void ctsmi_copy_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Copy();
        }

        private void ctsmi_paste_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Paste();
        }

        private void ctsmi_delete_Click(object sender, EventArgs e)
        {
            richTextBox_Main.DeleteSelection();
        }

        private void ctsmi_selectAll_Click(object sender, EventArgs e)
        {
            richTextBox_Main.SelectAll();
        }

        private void ctsmi_rightToLeft_Click(object sender, EventArgs e)
        {
            ctsmi_rightToLeft.Checked = richTextBox_Main.ToggleRightToLeft();
        }
    }
}
