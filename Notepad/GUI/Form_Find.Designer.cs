namespace Notepad
{
    partial class Form_Find
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
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.button_findNext = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_case = new System.Windows.Forms.CheckBox();
            this.groupBox_direction = new System.Windows.Forms.GroupBox();
            this.radioButton_down = new System.Windows.Forms.RadioButton();
            this.radioButton_up = new System.Windows.Forms.RadioButton();
            this.groupBox_direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_find
            // 
            this.label_find.AutoSize = true;
            this.label_find.Location = new System.Drawing.Point(11, 15);
            this.label_find.Name = "label_find";
            this.label_find.Size = new System.Drawing.Size(58, 13);
            this.label_find.TabIndex = 0;
            this.label_find.Text = "Find what:";
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Location = new System.Drawing.Point(86, 12);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(215, 20);
            this.textBox_keyword.TabIndex = 1;
            this.textBox_keyword.TextChanged += new System.EventHandler(this.textBox_keyword_TextChanged);
            // 
            // button_findNext
            // 
            this.button_findNext.Location = new System.Drawing.Point(318, 12);
            this.button_findNext.Name = "button_findNext";
            this.button_findNext.Size = new System.Drawing.Size(75, 23);
            this.button_findNext.TabIndex = 2;
            this.button_findNext.Text = "Find Next";
            this.button_findNext.UseVisualStyleBackColor = true;
            this.button_findNext.Click += new System.EventHandler(this.button_findNext_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(318, 41);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // checkBox_case
            // 
            this.checkBox_case.AutoSize = true;
            this.checkBox_case.Location = new System.Drawing.Point(14, 82);
            this.checkBox_case.Name = "checkBox_case";
            this.checkBox_case.Size = new System.Drawing.Size(80, 17);
            this.checkBox_case.TabIndex = 4;
            this.checkBox_case.Text = "Match case";
            this.checkBox_case.UseVisualStyleBackColor = true;
            this.checkBox_case.CheckedChanged += new System.EventHandler(this.checkBox_case_CheckedChanged);
            // 
            // groupBox_direction
            // 
            this.groupBox_direction.Controls.Add(this.radioButton_down);
            this.groupBox_direction.Controls.Add(this.radioButton_up);
            this.groupBox_direction.Location = new System.Drawing.Point(175, 41);
            this.groupBox_direction.Name = "groupBox_direction";
            this.groupBox_direction.Size = new System.Drawing.Size(126, 48);
            this.groupBox_direction.TabIndex = 5;
            this.groupBox_direction.TabStop = false;
            this.groupBox_direction.Text = "Direction";
            // 
            // radioButton_down
            // 
            this.radioButton_down.AutoSize = true;
            this.radioButton_down.Checked = true;
            this.radioButton_down.Location = new System.Drawing.Point(69, 19);
            this.radioButton_down.Name = "radioButton_down";
            this.radioButton_down.Size = new System.Drawing.Size(52, 17);
            this.radioButton_down.TabIndex = 0;
            this.radioButton_down.TabStop = true;
            this.radioButton_down.Text = "Down";
            this.radioButton_down.UseVisualStyleBackColor = true;
            // 
            // radioButton_up
            // 
            this.radioButton_up.AutoSize = true;
            this.radioButton_up.Location = new System.Drawing.Point(15, 19);
            this.radioButton_up.Name = "radioButton_up";
            this.radioButton_up.Size = new System.Drawing.Size(38, 17);
            this.radioButton_up.TabIndex = 0;
            this.radioButton_up.Text = "Up";
            this.radioButton_up.UseVisualStyleBackColor = true;
            this.radioButton_up.CheckedChanged += new System.EventHandler(this.radioButton_up_CheckedChanged);
            // 
            // Form_Find
            // 
            this.AcceptButton = this.button_findNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(404, 111);
            this.Controls.Add(this.groupBox_direction);
            this.Controls.Add(this.checkBox_case);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_findNext);
            this.Controls.Add(this.textBox_keyword);
            this.Controls.Add(this.label_find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Find";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher";
            this.TopMost = true;
            this.groupBox_direction.ResumeLayout(false);
            this.groupBox_direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_find;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.Button button_findNext;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_case;
        private System.Windows.Forms.GroupBox groupBox_direction;
        private System.Windows.Forms.RadioButton radioButton_down;
        private System.Windows.Forms.RadioButton radioButton_up;
    }
}