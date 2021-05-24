using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form_Replace : Form
    {
        public RichTextBox SrcRichTextBox { get; set; }
        public API.RichTextBoxSearchInfos SearchInfos { get; set; }

        public Form_Replace(RichTextBox srcRichTextBox, API.RichTextBoxSearchInfos searchInfos)
        {
            InitializeComponent();
            this.SrcRichTextBox = srcRichTextBox;
            this.SearchInfos = searchInfos;
            textBox_keyword.Text = this.SearchInfos.Keyword;
        }

        public bool FindNext()
        {
            if (SrcRichTextBox.FindNext(SearchInfos) == -1)
            {
                API.ShowNotFoundMessageBox(SearchInfos.Keyword);
                return false;
            }
            return true;
        }

        private void button_findNext_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void button_replace_Click(object sender, EventArgs e)
        {
            if (SearchInfos.LatestResultIndex != -1)
            {
                SrcRichTextBox.ReplaceText(SearchInfos.Keyword, textBox_replacement.Text,
                    SearchInfos.LatestResultIndex);
                FindNext();
            }
            else
            {
                FindNext();
            }
        }

        private void button_replaceAll_Click(object sender, EventArgs e)
        {
            if (FindNext())
            {
                SrcRichTextBox.ReplaceTextAll(SearchInfos.Keyword,
                    textBox_replacement.Text);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox_keyword_TextChanged(object sender, EventArgs e)
        {
            SearchInfos.Keyword = textBox_keyword.Text;
        }

        private void textBox_replacement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
