using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        Font defaultFont = new Font("Tahoma", 14, FontStyle.Regular);
        FontDialog fontDlg = new FontDialog();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontDlg.ShowColor = true;

            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily font in col.Families)
                    cbbFont.Items.Add(font.Name);
            }

            List<int> fontSize = new List<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in fontSize)
            {
                cbbSize.Items.Add(size);
            }
            newPage();
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            newPage();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void newPage()
        {
            this.Text = "Bai04-New page";
            oFileDlg.FileName = "";

            rtbField.Clear();
            rtbField.Font = defaultFont;
            rtbField.LanguageOption = RichTextBoxLanguageOptions.DualFont;

            fontDlg.Font = defaultFont;

            btnBoldStyle.Checked = false;
            btnItalicStyle.Checked = false;
            btnUnderlineStyle.Checked = false;

            cbbFont.SelectedIndex = cbbFont.Items.IndexOf("Tahoma");
            cbbSize.SelectedIndex = cbbSize.Items.IndexOf(14);
        }
        private void SaveFile()
        {
            sFileDlg.CheckPathExists = true;
            sFileDlg.Title = "Save File As-Bai04";
            sFileDlg.ValidateNames = true;
            sFileDlg.Filter = "rtf Files (*.rtf*)|*.rtf*";

            if (File.Exists(oFileDlg.FileName))
            {
                if (Path.GetExtension(oFileDlg.FileName) == ".txt")
                {
                    try
                    {
                        File.WriteAllLines(oFileDlg.FileName, rtbField.Lines);
                        MessageBox.Show("File save successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error File In Saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (Path.GetExtension(oFileDlg.FileName) == ".rtf")
                {
                    try
                    {
                        rtbField.SaveFile(oFileDlg.FileName, RichTextBoxStreamType.RichText);
                        MessageBox.Show("File saved successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error File in Saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (sFileDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtbField.SaveFile(sFileDlg.FileName + ".rtf", RichTextBoxStreamType.RichText);
                    MessageBox.Show("File saved successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error File Saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenFile()
        {
            oFileDlg.CheckFileExists = true;
            oFileDlg.CheckPathExists = true;
            oFileDlg.Title = "Open File-Bai04";
            oFileDlg.ValidateNames = true;
            oFileDlg.Filter = "txt Files (*.txt*)|*.txt*|rtf Files (*.rtf*)|*.rtf*";
            oFileDlg.FileName = "";

            if (oFileDlg.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(oFileDlg.FileName) == ".txt")
                {
                    try
                    {
                        rtbField.Text = File.ReadAllText(oFileDlg.FileName);
                        this.Text = "Bai04-" + oFileDlg.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("Error File Opening!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (Path.GetExtension(oFileDlg.FileName) == ".rtf")
                {
                    try
                    {
                        rtbField.LoadFile(oFileDlg.FileName);
                        this.Text = "Bai04-" + oFileDlg.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("Error File In Opening!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void menuItemEdit_Click(object sender, EventArgs e)
        {
            fontDlg.Font = rtbField.SelectionFont;
            fontDlg.Color = rtbField.SelectionColor;

            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                rtbField.SelectionFont = fontDlg.Font;
                rtbField.SelectionColor = fontDlg.Color;
                btnBoldStyle.Checked = fontDlg.Font.Bold ? true : false;
                btnItalicStyle.Checked = fontDlg.Font.Italic ? true : false;
                btnUnderlineStyle.Checked = fontDlg.Font.Underline ? true : false;
                cbbFont.SelectedIndex = cbbFont.Items.IndexOf(fontDlg.Font.Name);
                cbbSize.SelectedIndex = cbbSize.Items.IndexOf((int)Math.Round(fontDlg.Font.Size));
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newPage();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void EditFontStyle()
        {
            if (btnBoldStyle.CheckState == CheckState.Unchecked && btnItalicStyle.CheckState == CheckState.Unchecked && btnUnderlineStyle.CheckState == CheckState.Unchecked)
            {
                rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, rtbField.SelectionFont.Size, FontStyle.Regular);
                fontDlg.Font = rtbField.SelectionFont;
                return;
            }
            if (btnBoldStyle.CheckState == CheckState.Checked && btnItalicStyle.CheckState == CheckState.Checked && btnUnderlineStyle.CheckState == CheckState.Checked)
            {
                rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, rtbField.SelectionFont.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                fontDlg.Font = rtbField.SelectionFont;
                return;
            }

            if (btnBoldStyle.CheckState == CheckState.Checked && btnItalicStyle.CheckState == CheckState.Checked && btnUnderlineStyle.CheckState == CheckState.Unchecked)
            {
                rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, rtbField.SelectionFont.Size, FontStyle.Bold | FontStyle.Italic);
                fontDlg.Font = rtbField.SelectionFont;
                return;
            }

            if (btnBoldStyle.CheckState == CheckState.Checked && btnItalicStyle.CheckState == CheckState.Unchecked && btnUnderlineStyle.CheckState == CheckState.Checked)
            {
                rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, rtbField.SelectionFont.Size, FontStyle.Bold | FontStyle.Underline);
                fontDlg.Font = rtbField.SelectionFont;
                return;
            }

            if (btnBoldStyle.CheckState == CheckState.Checked && btnItalicStyle.CheckState == CheckState.Unchecked && btnUnderlineStyle.CheckState == CheckState.Unchecked)
            {
                rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, rtbField.SelectionFont.Size, FontStyle.Bold);
                fontDlg.Font = rtbField.SelectionFont;
                return;
            }

            if (btnBoldStyle.CheckState == CheckState.Unchecked && btnItalicStyle.CheckState == CheckState.Checked && btnUnderlineStyle.CheckState == CheckState.Checked)
            {
                rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, rtbField.SelectionFont.Size, FontStyle.Italic | FontStyle.Underline);
                fontDlg.Font = rtbField.SelectionFont;
                return;
            }

            if (btnBoldStyle.CheckState == CheckState.Unchecked && btnItalicStyle.CheckState == CheckState.Checked && btnUnderlineStyle.CheckState == CheckState.Unchecked)
            {
                rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, rtbField.SelectionFont.Size, FontStyle.Italic);
                fontDlg.Font = rtbField.SelectionFont;
                return;
            }

            if (btnBoldStyle.CheckState == CheckState.Unchecked && btnItalicStyle.CheckState == CheckState.Unchecked && btnUnderlineStyle.CheckState == CheckState.Checked)
            {
                rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, rtbField.SelectionFont.Size, FontStyle.Underline);
                fontDlg.Font = rtbField.SelectionFont;
                return;
            }
        }

        private void cbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbField.SelectionFont = new Font(cbbFont.SelectedItem.ToString(), rtbField.SelectionFont.Size, rtbField.SelectionFont.Style);
        }

        private void cbbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbField.SelectionFont = new Font(rtbField.SelectionFont.Name, (int)cbbSize.SelectedItem, rtbField.SelectionFont.Style);
        }

        private void btnBoldStyle_Click(object sender, EventArgs e)
        {
            EditFontStyle();
        }

        private void btnItalicStyle_Click(object sender, EventArgs e)
        {
            EditFontStyle();
        }

        private void btnUnderlineStyle_Click(object sender, EventArgs e)
        {
            EditFontStyle();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.Msg == 256)
            {
                if (keyData == (Keys.Control | Keys.S))
                {
                    SaveFile();
                }

                if (keyData == (Keys.Control | Keys.N))
                {
                    newPage();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
