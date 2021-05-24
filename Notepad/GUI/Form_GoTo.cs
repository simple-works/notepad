using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form_GoTo : Form
    {
        public RichTextBox SrcRichTextBox { get; set; }

        public Form_GoTo(RichTextBox srcRichTextBox)
        {
            InitializeComponent();
            this.SrcRichTextBox = srcRichTextBox;
        }

        public bool ValidateLineNumberInput(out int lineNumber)
        {
            int linesCount = SrcRichTextBox.Lines.Length;
            if (int.TryParse(textBox_lineNumber.Text, out lineNumber) && lineNumber >= 1)
            {
                if (linesCount == 0)
                {
                    return true;
                }
                else
                {
                    return (lineNumber <= linesCount);
                }
            }
            return false;
        }

        public bool ValidateLineNumberInput()
        {
            int lineNumber;
            return ValidateLineNumberInput(out lineNumber);
        }

        private void button_goto_Click(object sender, EventArgs e)
        {
            int lineNumber;
            if (ValidateLineNumberInput(out lineNumber))
            {
                int index = SrcRichTextBox.GetFirstCharIndexFromLine(lineNumber - 1);
                SrcRichTextBox.Select(index, 0);
                SrcRichTextBox.ScrollToCaret();
                this.Close();
            }
            else
            {
                MessageBox.Show("Line number exceeds total number of lines",
                    Application.ProductName);
                textBox_lineNumber.Text = "1";
                textBox_lineNumber.Focus();
            }
        }

        private void textBox_lineNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            toolTip_error.RemoveAll();
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (e.Handled)
            {
                toolTip_error.Show("You can only enter a number here.", textBox_lineNumber,
                    0, textBox_lineNumber.Height);
            }
        }
    }
}
