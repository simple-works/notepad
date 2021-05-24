using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Notepad
{
    partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void linkLabel_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:ambratolm@gmail.com");
        }

        private void linkLabel_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://ambratolm.ml");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
