namespace Notepad
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.richTextBox_Main = new System.Windows.Forms.RichTextBox();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_pageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_find = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_findNext = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_goto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_timeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_format = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_wordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_font = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_statusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument_main = new System.Drawing.Printing.PrintDocument();
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.tssl_empty = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_columnLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog_main = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_main = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog_main = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog_main = new System.Windows.Forms.PrintDialog();
            this.fontDialog_main = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctsmi_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctsmi_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ctsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctsmi_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.ctsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ctsmi_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ctsmi_rightToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_main.SuspendLayout();
            this.statusStrip_main.SuspendLayout();
            this.contextMenuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Main
            // 
            this.richTextBox_Main.ContextMenuStrip = this.contextMenuStrip_main;
            this.richTextBox_Main.DetectUrls = false;
            this.richTextBox_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Main.HideSelection = false;
            this.richTextBox_Main.Location = new System.Drawing.Point(0, 24);
            this.richTextBox_Main.Name = "richTextBox_Main";
            this.richTextBox_Main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_Main.Size = new System.Drawing.Size(665, 362);
            this.richTextBox_Main.TabIndex = 0;
            this.richTextBox_Main.Text = "";
            this.richTextBox_Main.WordWrap = false;
            this.richTextBox_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragDrop);
            this.richTextBox_Main.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragEnter);
            this.richTextBox_Main.SelectionChanged += new System.EventHandler(this.richTextBox_Main_SelectionChanged);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_edit,
            this.tsmi_format,
            this.tsmi_view,
            this.tsmi_help});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(665, 24);
            this.menuStrip_main.TabIndex = 1;
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_new,
            this.tsmi_open,
            this.toolStripSeparator,
            this.tsmi_save,
            this.tsmi_saveAs,
            this.toolStripSeparator1,
            this.tsmi_pageSetup,
            this.tsmi_print,
            this.toolStripSeparator2,
            this.tsmi_exit});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(37, 20);
            this.tsmi_file.Text = "&File";
            // 
            // tsmi_new
            // 
            this.tsmi_new.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_new.Image")));
            this.tsmi_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_new.Name = "tsmi_new";
            this.tsmi_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_new.Size = new System.Drawing.Size(149, 22);
            this.tsmi_new.Text = "&New";
            this.tsmi_new.Click += new System.EventHandler(this.tsmi_new_Click);
            // 
            // tsmi_open
            // 
            this.tsmi_open.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_open.Image")));
            this.tsmi_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_open.Name = "tsmi_open";
            this.tsmi_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmi_open.Size = new System.Drawing.Size(149, 22);
            this.tsmi_open.Text = "&Open";
            this.tsmi_open.Click += new System.EventHandler(this.tsmi_open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(146, 6);
            // 
            // tsmi_save
            // 
            this.tsmi_save.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_save.Image")));
            this.tsmi_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_save.Name = "tsmi_save";
            this.tsmi_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_save.Size = new System.Drawing.Size(149, 22);
            this.tsmi_save.Text = "&Save";
            this.tsmi_save.Click += new System.EventHandler(this.tsmi_save_Click);
            // 
            // tsmi_saveAs
            // 
            this.tsmi_saveAs.Name = "tsmi_saveAs";
            this.tsmi_saveAs.Size = new System.Drawing.Size(149, 22);
            this.tsmi_saveAs.Text = "S&ave As...";
            this.tsmi_saveAs.Click += new System.EventHandler(this.tsmi_saveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // tsmi_pageSetup
            // 
            this.tsmi_pageSetup.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_pageSetup.Image")));
            this.tsmi_pageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_pageSetup.Name = "tsmi_pageSetup";
            this.tsmi_pageSetup.Size = new System.Drawing.Size(149, 22);
            this.tsmi_pageSetup.Text = "Pa&ge Setup...";
            this.tsmi_pageSetup.Click += new System.EventHandler(this.tsmi_pageSetup_Click);
            // 
            // tsmi_print
            // 
            this.tsmi_print.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_print.Image")));
            this.tsmi_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_print.Name = "tsmi_print";
            this.tsmi_print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmi_print.Size = new System.Drawing.Size(149, 22);
            this.tsmi_print.Text = "&Print...";
            this.tsmi_print.Click += new System.EventHandler(this.tsmi_print_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(149, 22);
            this.tsmi_exit.Text = "&Exit";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_undo,
            this.tsmi_redo,
            this.toolStripSeparator3,
            this.tsmi_cut,
            this.tsmi_copy,
            this.tsmi_paste,
            this.tsmi_delete,
            this.toolStripSeparator4,
            this.tsmi_find,
            this.tsmi_findNext,
            this.tsmi_replace,
            this.tsmi_goto,
            this.toolStripSeparator9,
            this.tsmi_selectAll,
            this.tsmi_timeDate});
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(39, 20);
            this.tsmi_edit.Text = "&Edit";
            // 
            // tsmi_undo
            // 
            this.tsmi_undo.Name = "tsmi_undo";
            this.tsmi_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmi_undo.Size = new System.Drawing.Size(167, 22);
            this.tsmi_undo.Text = "&Undo";
            this.tsmi_undo.Click += new System.EventHandler(this.tsmi_undo_Click);
            // 
            // tsmi_redo
            // 
            this.tsmi_redo.Name = "tsmi_redo";
            this.tsmi_redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmi_redo.Size = new System.Drawing.Size(167, 22);
            this.tsmi_redo.Text = "&Redo";
            this.tsmi_redo.Click += new System.EventHandler(this.tsmi_redo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // tsmi_cut
            // 
            this.tsmi_cut.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_cut.Image")));
            this.tsmi_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_cut.Name = "tsmi_cut";
            this.tsmi_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmi_cut.Size = new System.Drawing.Size(167, 22);
            this.tsmi_cut.Text = "&Cut";
            this.tsmi_cut.Click += new System.EventHandler(this.tsmi_cut_Click);
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_copy.Image")));
            this.tsmi_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmi_copy.Size = new System.Drawing.Size(167, 22);
            this.tsmi_copy.Text = "C&opy";
            this.tsmi_copy.Click += new System.EventHandler(this.tsmi_copy_Click);
            // 
            // tsmi_paste
            // 
            this.tsmi_paste.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_paste.Image")));
            this.tsmi_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_paste.Name = "tsmi_paste";
            this.tsmi_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmi_paste.Size = new System.Drawing.Size(167, 22);
            this.tsmi_paste.Text = "&Paste";
            this.tsmi_paste.Click += new System.EventHandler(this.tsmi_paste_Click);
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmi_delete.Size = new System.Drawing.Size(167, 22);
            this.tsmi_delete.Text = "&Delete";
            this.tsmi_delete.Click += new System.EventHandler(this.tsmi_delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(164, 6);
            // 
            // tsmi_find
            // 
            this.tsmi_find.Name = "tsmi_find";
            this.tsmi_find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmi_find.Size = new System.Drawing.Size(167, 22);
            this.tsmi_find.Text = "&Find...";
            this.tsmi_find.Click += new System.EventHandler(this.tsmi_find_Click);
            // 
            // tsmi_findNext
            // 
            this.tsmi_findNext.Name = "tsmi_findNext";
            this.tsmi_findNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmi_findNext.Size = new System.Drawing.Size(167, 22);
            this.tsmi_findNext.Text = "Find Next";
            this.tsmi_findNext.Click += new System.EventHandler(this.tsmi_findNext_Click);
            // 
            // tsmi_replace
            // 
            this.tsmi_replace.Name = "tsmi_replace";
            this.tsmi_replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsmi_replace.Size = new System.Drawing.Size(167, 22);
            this.tsmi_replace.Text = "&Replace...";
            this.tsmi_replace.Click += new System.EventHandler(this.tsmi_replace_Click);
            // 
            // tsmi_goto
            // 
            this.tsmi_goto.Name = "tsmi_goto";
            this.tsmi_goto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmi_goto.Size = new System.Drawing.Size(167, 22);
            this.tsmi_goto.Text = "&Go To...";
            this.tsmi_goto.Click += new System.EventHandler(this.tsmi_goto_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(164, 6);
            // 
            // tsmi_selectAll
            // 
            this.tsmi_selectAll.Name = "tsmi_selectAll";
            this.tsmi_selectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmi_selectAll.Size = new System.Drawing.Size(167, 22);
            this.tsmi_selectAll.Text = "&Select All";
            this.tsmi_selectAll.Click += new System.EventHandler(this.tsmi_selectAll_Click);
            // 
            // tsmi_timeDate
            // 
            this.tsmi_timeDate.Name = "tsmi_timeDate";
            this.tsmi_timeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmi_timeDate.Size = new System.Drawing.Size(167, 22);
            this.tsmi_timeDate.Text = "&Time/Date";
            this.tsmi_timeDate.Click += new System.EventHandler(this.tsmi_timeDate_Click);
            // 
            // tsmi_format
            // 
            this.tsmi_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_wordWrap,
            this.tsmi_font});
            this.tsmi_format.Name = "tsmi_format";
            this.tsmi_format.Size = new System.Drawing.Size(57, 20);
            this.tsmi_format.Text = "&Format";
            // 
            // tsmi_wordWrap
            // 
            this.tsmi_wordWrap.Name = "tsmi_wordWrap";
            this.tsmi_wordWrap.Size = new System.Drawing.Size(134, 22);
            this.tsmi_wordWrap.Text = "&Word Wrap";
            this.tsmi_wordWrap.Click += new System.EventHandler(this.tsmi_wordWrap_Click);
            // 
            // tsmi_font
            // 
            this.tsmi_font.Name = "tsmi_font";
            this.tsmi_font.Size = new System.Drawing.Size(134, 22);
            this.tsmi_font.Text = "Font...";
            this.tsmi_font.Click += new System.EventHandler(this.tsmi_font_Click);
            // 
            // tsmi_view
            // 
            this.tsmi_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_statusBar});
            this.tsmi_view.Name = "tsmi_view";
            this.tsmi_view.Size = new System.Drawing.Size(44, 20);
            this.tsmi_view.Text = "&View";
            // 
            // tsmi_statusBar
            // 
            this.tsmi_statusBar.Name = "tsmi_statusBar";
            this.tsmi_statusBar.Size = new System.Drawing.Size(126, 22);
            this.tsmi_statusBar.Text = "Status Bar";
            this.tsmi_statusBar.Click += new System.EventHandler(this.tsmi_statusBar_Click);
            // 
            // tsmi_help
            // 
            this.tsmi_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_about});
            this.tsmi_help.Name = "tsmi_help";
            this.tsmi_help.Size = new System.Drawing.Size(24, 20);
            this.tsmi_help.Text = "&?";
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(107, 22);
            this.tsmi_about.Text = "&About";
            this.tsmi_about.Click += new System.EventHandler(this.tsmi_about_Click);
            // 
            // printDocument_main
            // 
            this.printDocument_main.DocumentName = "Document";
            this.printDocument_main.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_Main_PrintPage);
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_empty,
            this.tssl_columnLine});
            this.statusStrip_main.Location = new System.Drawing.Point(0, 364);
            this.statusStrip_main.Name = "statusStrip_main";
            this.statusStrip_main.Size = new System.Drawing.Size(665, 22);
            this.statusStrip_main.TabIndex = 2;
            this.statusStrip_main.Text = "statusStrip1";
            // 
            // tssl_empty
            // 
            this.tssl_empty.Name = "tssl_empty";
            this.tssl_empty.Size = new System.Drawing.Size(438, 17);
            this.tssl_empty.Spring = true;
            // 
            // tssl_columnLine
            // 
            this.tssl_columnLine.Margin = new System.Windows.Forms.Padding(0, 3, 150, 2);
            this.tssl_columnLine.Name = "tssl_columnLine";
            this.tssl_columnLine.Size = new System.Drawing.Size(62, 17);
            this.tssl_columnLine.Text = "Ln 1, Col 1";
            this.tssl_columnLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog_main
            // 
            this.openFileDialog_main.DefaultExt = "txt";
            this.openFileDialog_main.FileName = "*.txt";
            this.openFileDialog_main.Filter = "Text Files (*.txt)|*.txt|All Filess (*.*)|*.*";
            // 
            // saveFileDialog_main
            // 
            this.saveFileDialog_main.DefaultExt = "txt";
            this.saveFileDialog_main.FileName = "*.txt";
            this.saveFileDialog_main.Filter = "Text Files (*.txt)|*.txt|All Filess (*.*)|*.*";
            // 
            // printPreviewDialog_main
            // 
            this.printPreviewDialog_main.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_main.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_main.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog_main.Document = this.printDocument_main;
            this.printPreviewDialog_main.Enabled = true;
            this.printPreviewDialog_main.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog_main.Icon")));
            this.printPreviewDialog_main.Name = "printPreviewDialog_main";
            this.printPreviewDialog_main.Visible = false;
            // 
            // printDialog_main
            // 
            this.printDialog_main.Document = this.printDocument_main;
            this.printDialog_main.UseEXDialog = true;
            // 
            // contextMenuStrip_main
            // 
            this.contextMenuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctsmi_undo,
            this.toolStripSeparator5,
            this.ctsmi_cut,
            this.ctsmi_copy,
            this.ctsmi_paste,
            this.ctsmi_delete,
            this.toolStripSeparator6,
            this.ctsmi_selectAll,
            this.toolStripSeparator7,
            this.ctsmi_rightToLeft});
            this.contextMenuStrip_main.Name = "contextMenuStrip_main";
            this.contextMenuStrip_main.Size = new System.Drawing.Size(217, 176);
            // 
            // ctsmi_undo
            // 
            this.ctsmi_undo.Name = "ctsmi_undo";
            this.ctsmi_undo.Size = new System.Drawing.Size(216, 22);
            this.ctsmi_undo.Text = "Undo";
            this.ctsmi_undo.Click += new System.EventHandler(this.ctsmi_undo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(213, 6);
            // 
            // ctsmi_cut
            // 
            this.ctsmi_cut.Name = "ctsmi_cut";
            this.ctsmi_cut.Size = new System.Drawing.Size(216, 22);
            this.ctsmi_cut.Text = "Cut";
            this.ctsmi_cut.Click += new System.EventHandler(this.ctsmi_cut_Click);
            // 
            // ctsmi_copy
            // 
            this.ctsmi_copy.Name = "ctsmi_copy";
            this.ctsmi_copy.Size = new System.Drawing.Size(216, 22);
            this.ctsmi_copy.Text = "Copy";
            this.ctsmi_copy.Click += new System.EventHandler(this.ctsmi_copy_Click);
            // 
            // ctsmi_paste
            // 
            this.ctsmi_paste.Name = "ctsmi_paste";
            this.ctsmi_paste.Size = new System.Drawing.Size(216, 22);
            this.ctsmi_paste.Text = "Paste";
            this.ctsmi_paste.Click += new System.EventHandler(this.ctsmi_paste_Click);
            // 
            // ctsmi_delete
            // 
            this.ctsmi_delete.Name = "ctsmi_delete";
            this.ctsmi_delete.Size = new System.Drawing.Size(216, 22);
            this.ctsmi_delete.Text = "Delete";
            this.ctsmi_delete.Click += new System.EventHandler(this.ctsmi_delete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(213, 6);
            // 
            // ctsmi_selectAll
            // 
            this.ctsmi_selectAll.Name = "ctsmi_selectAll";
            this.ctsmi_selectAll.Size = new System.Drawing.Size(216, 22);
            this.ctsmi_selectAll.Text = "Select All";
            this.ctsmi_selectAll.Click += new System.EventHandler(this.ctsmi_selectAll_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(213, 6);
            // 
            // ctsmi_rightToLeft
            // 
            this.ctsmi_rightToLeft.Name = "ctsmi_rightToLeft";
            this.ctsmi_rightToLeft.Size = new System.Drawing.Size(216, 22);
            this.ctsmi_rightToLeft.Text = "Right to Left Reading order";
            this.ctsmi_rightToLeft.Click += new System.EventHandler(this.ctsmi_rightToLeft_Click);
            // 
            // Form_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 386);
            this.Controls.Add(this.statusStrip_main);
            this.Controls.Add(this.richTextBox_Main);
            this.Controls.Add(this.menuStrip_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Untitled - Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragEnter);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.statusStrip_main.ResumeLayout(false);
            this.statusStrip_main.PerformLayout();
            this.contextMenuStrip_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmi_save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_saveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_print;
        private System.Windows.Forms.ToolStripMenuItem tsmi_pageSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_undo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_cut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_selectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format;
        private System.Windows.Forms.ToolStripMenuItem tsmi_help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
        private System.Windows.Forms.ToolStripMenuItem tsmi_font;
        private System.Windows.Forms.ToolStripMenuItem tsmi_find;
        private System.Windows.Forms.ToolStripMenuItem tsmi_findNext;
        private System.Windows.Forms.ToolStripMenuItem tsmi_replace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsmi_timeDate;
        private System.Drawing.Printing.PrintDocument printDocument_main;
        public System.Windows.Forms.RichTextBox richTextBox_Main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_view;
        private System.Windows.Forms.ToolStripMenuItem tsmi_statusBar;
        private System.Windows.Forms.StatusStrip statusStrip_main;
        private System.Windows.Forms.ToolStripStatusLabel tssl_columnLine;
        private System.Windows.Forms.ToolStripStatusLabel tssl_empty;
        private System.Windows.Forms.ToolStripMenuItem tsmi_goto;
        private System.Windows.Forms.ToolStripMenuItem tsmi_wordWrap;
        private System.Windows.Forms.OpenFileDialog openFileDialog_main;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_main;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog_main;
        private System.Windows.Forms.PrintDialog printDialog_main;
        private System.Windows.Forms.FontDialog fontDialog_main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem ctsmi_undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ctsmi_cut;
        private System.Windows.Forms.ToolStripMenuItem ctsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem ctsmi_paste;
        private System.Windows.Forms.ToolStripMenuItem ctsmi_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ctsmi_selectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem ctsmi_rightToLeft;
    }
}