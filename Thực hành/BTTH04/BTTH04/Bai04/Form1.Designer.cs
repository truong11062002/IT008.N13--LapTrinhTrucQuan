
namespace Bai04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbField = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cbbFont = new System.Windows.Forms.ToolStripComboBox();
            this.cbbSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnBoldStyle = new System.Windows.Forms.ToolStripButton();
            this.btnItalicStyle = new System.Windows.Forms.ToolStripButton();
            this.btnUnderlineStyle = new System.Windows.Forms.ToolStripButton();
            this.oFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.sFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbField
            // 
            this.rtbField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbField.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbField.Location = new System.Drawing.Point(0, 61);
            this.rtbField.Name = "rtbField";
            this.rtbField.Size = new System.Drawing.Size(978, 478);
            this.rtbField.TabIndex = 2;
            this.rtbField.Text = "";
            this.rtbField.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.menuItemEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemSave,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuItemNew
            // 
            this.menuItemNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuItemNew.Image = global::Bai04.Properties.Resources.newpage;
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.ShortcutKeyDisplayString = "Ctrl+N";
            this.menuItemNew.Size = new System.Drawing.Size(285, 26);
            this.menuItemNew.Text = "Tạo văn bản mới";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Image = global::Bai04.Properties.Resources.Open;
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(285, 26);
            this.menuItemOpen.Text = "Mở tập tin";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Image = global::Bai04.Properties.Resources.Save;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.menuItemSave.Size = new System.Drawing.Size(285, 26);
            this.menuItemSave.Text = "Lưu nội dung văn bản";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(92, 26);
            this.menuItemEdit.Text = "Định dạng";
            this.menuItemEdit.Click += new System.EventHandler(this.menuItemEdit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.toolStripButton2,
            this.cbbFont,
            this.cbbSize,
            this.btnBoldStyle,
            this.btnItalicStyle,
            this.btnUnderlineStyle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::Bai04.Properties.Resources.newpage;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(29, 28);
            this.btnNew.Text = "toolStripButton1";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Bai04.Properties.Resources.Save;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // cbbFont
            // 
            this.cbbFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFont.DropDownHeight = 100;
            this.cbbFont.IntegralHeight = false;
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(151, 31);
            this.cbbFont.SelectedIndexChanged += new System.EventHandler(this.cbbFont_SelectedIndexChanged);
            // 
            // cbbSize
            // 
            this.cbbSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSize.DropDownHeight = 100;
            this.cbbSize.IntegralHeight = false;
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(121, 31);
            this.cbbSize.SelectedIndexChanged += new System.EventHandler(this.cbbSize_SelectedIndexChanged);
            // 
            // btnBoldStyle
            // 
            this.btnBoldStyle.CheckOnClick = true;
            this.btnBoldStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBoldStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoldStyle.Image = ((System.Drawing.Image)(resources.GetObject("btnBoldStyle.Image")));
            this.btnBoldStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoldStyle.Name = "btnBoldStyle";
            this.btnBoldStyle.Size = new System.Drawing.Size(29, 28);
            this.btnBoldStyle.Text = "B";
            this.btnBoldStyle.Click += new System.EventHandler(this.btnBoldStyle_Click);
            // 
            // btnItalicStyle
            // 
            this.btnItalicStyle.CheckOnClick = true;
            this.btnItalicStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnItalicStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalicStyle.Image = ((System.Drawing.Image)(resources.GetObject("btnItalicStyle.Image")));
            this.btnItalicStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalicStyle.Name = "btnItalicStyle";
            this.btnItalicStyle.Size = new System.Drawing.Size(29, 28);
            this.btnItalicStyle.Text = "I";
            this.btnItalicStyle.Click += new System.EventHandler(this.btnItalicStyle_Click);
            // 
            // btnUnderlineStyle
            // 
            this.btnUnderlineStyle.CheckOnClick = true;
            this.btnUnderlineStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUnderlineStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderlineStyle.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderlineStyle.Image")));
            this.btnUnderlineStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderlineStyle.Name = "btnUnderlineStyle";
            this.btnUnderlineStyle.Size = new System.Drawing.Size(29, 28);
            this.btnUnderlineStyle.Text = "U";
            this.btnUnderlineStyle.Click += new System.EventHandler(this.btnUnderlineStyle_Click);
            // 
            // oFileDlg
            // 
            this.oFileDlg.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 539);
            this.Controls.Add(this.rtbField);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbField;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox cbbFont;
        private System.Windows.Forms.ToolStripComboBox cbbSize;
        private System.Windows.Forms.ToolStripButton btnBoldStyle;
        private System.Windows.Forms.ToolStripButton btnItalicStyle;
        private System.Windows.Forms.ToolStripButton btnUnderlineStyle;
        private System.Windows.Forms.OpenFileDialog oFileDlg;
        private System.Windows.Forms.SaveFileDialog sFileDlg;
    }
}

