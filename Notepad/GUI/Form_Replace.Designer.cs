namespace Notepad
{
    partial class Form_Replace
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
            this.label_find = new System.Windows.Forms.Label();
            this.label_replace = new System.Windows.Forms.Label();
            this.checkBox_case = new System.Windows.Forms.CheckBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_findNext = new System.Windows.Forms.Button();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.textBox_replacement = new System.Windows.Forms.TextBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.button_replaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_find
            // 
            this.label_find.AutoSize = true;
            this.label_find.Location = new System.Drawing.Point(10, 20);
            this.label_find.Name = "label_find";
            this.label_find.Size = new System.Drawing.Size(58, 13);
            this.label_find.TabIndex = 0;
            this.label_find.Text = "Find what:";
            // 
            // label_replace
            // 
            this.label_replace.AutoSize = true;
            this.label_replace.Location = new System.Drawing.Point(10, 48);
            this.label_replace.Name = "label_replace";
            this.label_replace.Size = new System.Drawing.Size(72, 13);
            this.label_replace.TabIndex = 2;
            this.label_replace.Text = "Replace with:";
            // 
            // checkBox_case
            // 
            this.checkBox_case.AutoSize = true;
            this.checkBox_case.Location = new System.Drawing.Point(13, 107);
            this.checkBox_case.Name = "checkBox_case";
            this.checkBox_case.Size = new System.Drawing.Size(80, 17);
            this.checkBox_case.TabIndex = 5;
            this.checkBox_case.Text = "Match case";
            this.checkBox_case.UseVisualStyleBackColor = true;
            this.checkBox_case.CheckedChanged += new System.EventHandler(this.checkBox_case_CheckedChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(331, 98);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_findNext
            // 
            this.button_findNext.Location = new System.Drawing.Point(331, 11);
            this.button_findNext.Name = "button_findNext";
            this.button_findNext.Size = new System.Drawing.Size(87, 23);
            this.button_findNext.TabIndex = 6;
            this.button_findNext.Text = "Find Next";
            this.button_findNext.UseVisualStyleBackColor = true;
            this.button_findNext.Click += new System.EventHandler(this.button_findNext_Click);
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Location = new System.Drawing.Point(98, 17);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(215, 20);
            this.textBox_keyword.TabIndex = 1;
            this.textBox_keyword.TextChanged += new System.EventHandler(this.textBox_keyword_TextChanged);
            // 
            // textBox_replacement
            // 
            this.textBox_replacement.Location = new System.Drawing.Point(98, 45);
            this.textBox_replacement.Name = "textBox_replacement";
            this.textBox_replacement.Size = new System.Drawing.Size(215, 20);
            this.textBox_replacement.TabIndex = 2;
            this.textBox_replacement.TextChanged += new System.EventHandler(this.textBox_replacement_TextChanged);
            // 
            // button_replace
            // 
            this.button_replace.Location = new System.Drawing.Point(331, 40);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(87, 23);
            this.button_replace.TabIndex = 6;
            this.button_replace.Text = "Replace";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // button_replaceAll
            // 
            this.button_replaceAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_replaceAll.Location = new System.Drawing.Point(331, 69);
            this.button_replaceAll.Name = "button_replaceAll";
            this.button_replaceAll.Size = new System.Drawing.Size(87, 23);
            this.button_replaceAll.TabIndex = 7;
            this.button_replaceAll.Text = "Replace All";
            this.button_replaceAll.UseVisualStyleBackColor = true;
            this.button_replaceAll.Click += new System.EventHandler(this.button_replaceAll_Click);
            // 
            // Form_Replace
            // 
            this.AcceptButton = this.button_findNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(428, 135);
            this.Controls.Add(this.textBox_replacement);
            this.Controls.Add(this.textBox_keyword);
            this.Controls.Add(this.button_replaceAll);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_findNext);
            this.Controls.Add(this.checkBox_case);
            this.Controls.Add(this.label_replace);
            this.Controls.Add(this.label_find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Replace";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_find;
        private System.Windows.Forms.Label label_replace;
        private System.Windows.Forms.CheckBox checkBox_case;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_findNext;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.TextBox textBox_replacement;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Button button_replaceAll;
    }
}