namespace Notepad
{
    partial class Form_About
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label_product = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.linkLabel_email = new System.Windows.Forms.LinkLabel();
            this.linkLabel_website = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label_product, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label_copyright, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.button_ok, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.linkLabel_email, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.linkLabel_website, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(393, 131);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::Notepad.Properties.Resources.notepad_green;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 5);
            this.logoPictureBox.Size = new System.Drawing.Size(123, 125);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // label_product
            // 
            this.label_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_product.Location = new System.Drawing.Point(135, 0);
            this.label_product.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label_product.MaximumSize = new System.Drawing.Size(0, 17);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(255, 17);
            this.label_product.TabIndex = 19;
            this.label_product.Text = "Notepad 1.0 (32bits)";
            this.label_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_copyright
            // 
            this.label_copyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_copyright.Location = new System.Drawing.Point(135, 26);
            this.label_copyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label_copyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(255, 17);
            this.label_copyright.TabIndex = 0;
            this.label_copyright.Text = "© 2016 Abdelhakim El hafid @Ambratolm";
            this.label_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ok.Location = new System.Drawing.Point(315, 107);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 21);
            this.button_ok.TabIndex = 24;
            this.button_ok.Text = "&OK";
            this.button_ok.Click += new System.EventHandler(this.okButton_Click);
            // 
            // linkLabel_email
            // 
            this.linkLabel_email.AutoSize = true;
            this.linkLabel_email.Location = new System.Drawing.Point(132, 52);
            this.linkLabel_email.Name = "linkLabel_email";
            this.linkLabel_email.Size = new System.Drawing.Size(114, 13);
            this.linkLabel_email.TabIndex = 25;
            this.linkLabel_email.TabStop = true;
            this.linkLabel_email.Text = "ambratolm@gmail.com";
            this.linkLabel_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel_email.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_email_LinkClicked);
            // 
            // linkLabel_website
            // 
            this.linkLabel_website.AutoSize = true;
            this.linkLabel_website.Location = new System.Drawing.Point(132, 78);
            this.linkLabel_website.Name = "linkLabel_website";
            this.linkLabel_website.Size = new System.Drawing.Size(71, 13);
            this.linkLabel_website.TabIndex = 25;
            this.linkLabel_website.TabStop = true;
            this.linkLabel_website.Text = "ambratolm.ml";
            this.linkLabel_website.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel_website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_website_LinkClicked);
            // 
            // Form_About
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 149);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.LinkLabel linkLabel_email;
        private System.Windows.Forms.LinkLabel linkLabel_website;
    }
}
