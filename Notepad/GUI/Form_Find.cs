using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form_Find : Form
    {
        public RichTextBox SrcRichTextBox { get; set; }
        public API.RichTextBoxSearchInfos SearchInfos { get; set; }

        public Form_Find(RichTextBox srcRichTextBox, API.RichTextBoxSearchInfos searchInfos)
        {
            InitializeComponent();
            this.SrcRichTextBox = srcRichTextBox;
            this.SearchInfos = searchInfos;
            textBox_keyword.Text = this.SearchInfos.Keyword;
            radioButton_up.Checked = this.SearchInfos.HasOption(RichTextBoxFinds.Reverse);
            checkBox_case.Checked = this.SearchInfos.HasOption(RichTextBoxFinds.MatchCase);
        }

        private void button_findNext_Click(object sender, EventArgs e)
        {
            if (SrcRichTextBox.FindNext(SearchInfos) == -1)
            {
                API.ShowNotFoundMessageBox(SearchInfos.Keyword);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_keyword_TextChanged(object sender, EventArgs e)
        {
            SearchInfos.Keyword = textBox_keyword.Text;
        }

        private void checkBox_case_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_case.Checked)
            {
                SearchInfos.Options |= RichTextBoxFinds.MatchCase;
            }
            else
            {
                SearchInfos.Options -= RichTextBoxFinds.MatchCase;
            }
        }

        private void radioButton_up_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_up.Checked)
            {
                SearchInfos.Options |= RichTextBoxFinds.Reverse;
            }
            else
            {
                SearchInfos.Options -= RichTextBoxFinds.Reverse;
            }
        }
    }
}
