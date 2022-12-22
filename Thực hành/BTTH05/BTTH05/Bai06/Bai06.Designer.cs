
namespace Bai06
{
    partial class Bai06
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
            this.listBox_font = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_font
            // 
            this.listBox_font.FormattingEnabled = true;
            this.listBox_font.ItemHeight = 16;
            this.listBox_font.Location = new System.Drawing.Point(10, 22);
            this.listBox_font.Name = "listBox_font";
            this.listBox_font.Size = new System.Drawing.Size(572, 548);
            this.listBox_font.TabIndex = 0;
            this.listBox_font.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_font_DrawItem);
            // 
            // Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 595);
            this.Controls.Add(this.listBox_font);
            this.Name = "Bai06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bai06_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_font;
    }
}

