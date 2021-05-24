namespace Notepad
{
    partial class Form_GoTo
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
            this.button_goto = new System.Windows.Forms.Button();
            this.textBox_lineNumber = new System.Windows.Forms.TextBox();
            this.label_lineNumber = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.toolTip_error = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button_goto
            // 
            this.button_goto.Location = new System.Drawing.Point(116, 59);
            this.button_goto.Name = "button_goto";
            this.button_goto.Size = new System.Drawing.Size(75, 23);
            this.button_goto.TabIndex = 2;
            this.button_goto.Text = "Go To";
            this.button_goto.UseVisualStyleBackColor = true;
            this.button_goto.Click += new System.EventHandler(this.button_goto_Click);
            // 
            // textBox_lineNumber
            // 
            this.textBox_lineNumber.Location = new System.Drawing.Point(14, 30);
            this.textBox_lineNumber.Name = "textBox_lineNumber";
            this.textBox_lineNumber.Size = new System.Drawing.Size(257, 20);
            this.textBox_lineNumber.TabIndex = 1;
            this.textBox_lineNumber.Text = "1";
            this.textBox_lineNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lineNumber_KeyPress);
            // 
            // label_lineNumber
            // 
            this.label_lineNumber.AutoSize = true;
            this.label_lineNumber.Location = new System.Drawing.Point(11, 14);
            this.label_lineNumber.Name = "label_lineNumber";
            this.label_lineNumber.Size = new System.Drawing.Size(69, 13);
            this.label_lineNumber.TabIndex = 0;
            this.label_lineNumber.Text = "Line number:";
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(197, 59);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // toolTip_error
            // 
            this.toolTip_error.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip_error.ToolTipTitle = "Unauthorized Character";
            // 
            // Form_GoTo
            // 
            this.AcceptButton = this.button_goto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(282, 96);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_lineNumber);
            this.Controls.Add(this.textBox_lineNumber);
            this.Controls.Add(this.button_goto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GoTo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Go To Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_goto;
        private System.Windows.Forms.TextBox textBox_lineNumber;
        private System.Windows.Forms.Label label_lineNumber;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ToolTip toolTip_error;
    }
}