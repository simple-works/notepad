using System.Windows.Forms;

namespace Notepad
{
    public static partial class API
    {
        public class RichTextBoxSearchInfos
        {
            public string Keyword { get; set; }
            public int LatestResultStartIndex { get; set; }
            public int LatestResultEndIndex { get; set; }
            public RichTextBoxFinds Options { get; set; }
            public bool Ready
            {
                get
                {
                    return !string.IsNullOrEmpty(this.Keyword)
                        && this.LatestResultStartIndex >= 0;
                }
            }
            public int LatestResultIndex { get; set; }

            public RichTextBoxSearchInfos()
            {
                this.LatestResultIndex = -1;
            }
            public bool HasOption(RichTextBoxFinds option)
            {
                return this.Options.HasFlag(option);
            }
        }

        public static void PastePlainText(this RichTextBox richTextBox)
        {
            richTextBox.Paste(new DataFormats.Format(DataFormats.Text, 1));
        }

        public static void ReplaceSelection(this RichTextBox richTextBox, string text)
        {
            richTextBox.SelectedText = text;
        }

        public static void DeleteSelection(this RichTextBox richTextBox)
        {
            richTextBox.SelectedText = string.Empty;
        }

        public static int FindNext(this RichTextBox richTextBox, RichTextBoxSearchInfos searchInfos)
        {
            if (richTextBox.TextLength != 0 && searchInfos.Ready)
            {
                bool reverse = searchInfos.HasOption(RichTextBoxFinds.Reverse);
                int start = reverse ? 0 : searchInfos.LatestResultEndIndex;
                int end = reverse ? searchInfos.LatestResultStartIndex : richTextBox.TextLength;
                searchInfos.LatestResultIndex = richTextBox
                    .Find(searchInfos.Keyword, start, end, searchInfos.Options);
                if (searchInfos.LatestResultIndex != -1)
                {
                    searchInfos.LatestResultStartIndex = searchInfos.LatestResultIndex;
                    searchInfos.LatestResultEndIndex = searchInfos.LatestResultIndex + searchInfos.Keyword.Length;
                }
                else
                {
                    searchInfos.LatestResultStartIndex = richTextBox.SelectionStart;
                    searchInfos.LatestResultEndIndex = richTextBox.SelectionStart;
                }
                return searchInfos.LatestResultIndex;
            }
            return -1;
        }

        public static void ReplaceText(this RichTextBox richTextBox, string oldText, string newText,
            int startIndex = -1)
        {
            startIndex = (startIndex == -1) ? richTextBox.Text.IndexOf(oldText) : startIndex;
            if (oldText.Length != 0 && startIndex >= 0)
            {
                richTextBox.Text = richTextBox.Text
                    .Remove(startIndex, oldText.Length).Insert(startIndex, newText);
            }
        }

        public static void ReplaceTextAll(this RichTextBox richTextBox, string oldText, string newText)
        {
            if (oldText.Length != 0)
            {
                richTextBox.Text = richTextBox.Text.Replace(oldText, newText);
            }
        }

        public static int GetSelectedLineIndex(this RichTextBox richTextBox)
        {
            return richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart);
        }

        public static int GetSelectedColumnIndex(this RichTextBox richTextBox)
        {
            int line = richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart);
            return richTextBox.SelectionStart - richTextBox.GetFirstCharIndexFromLine(line);
        }

        public static bool ToggleRightToLeft(this RichTextBox richTextBox)
        {
            if (richTextBox.RightToLeft == RightToLeft.No)
            {
                richTextBox.RightToLeft = RightToLeft.Yes;
                return true;
            }
            else
            {
                richTextBox.RightToLeft = RightToLeft.No;
                return false;
            }
        }
    }
}
