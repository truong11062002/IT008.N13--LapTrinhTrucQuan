using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Bai04 : Form
    {
        Font defaultFont = new Font("Tahoma", 14, FontStyle.Regular);
        FontDialog fontDlg = new FontDialog();
        private ColorDialog colorDialog;

        public Bai04()
        {
            InitializeComponent();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            comboBox_Font.SelectedItem = "Arial";
            comboBox_Size.SelectedItem = "28";
            radioButton_Left.Checked = true;

            checkBox_Bold.Checked = true;
            checkBox_italic.Checked = true;
            checkBox_underline.Checked = true;

            fontDlg.Font = defaultFont;
            fontDlg.ShowColor = true;

            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily font in col.Families)
                    comboBox_Font.Items.Add(font.Name);
            }

            List<int> fontSize = new List<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in fontSize)
            {
                comboBox_Size.Items.Add(size);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_Left_CheckedChanged(object sender, EventArgs e)
        {
            label_text.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radioButton_Center_CheckedChanged(object sender, EventArgs e)
        {
            label_text.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton_Right_CheckedChanged(object sender, EventArgs e)
        {
            label_text.TextAlign = ContentAlignment.MiddleRight;
        }

        private void comboBox_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_text.Font = new Font(comboBox_Font.SelectedItem.ToString(), label_text.Font.Size, label_text.Font.Style);
        }

        private void comboBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_text.Font = new Font(label_text.Font.Name, (int)comboBox_Size.SelectedItem, label_text.Font.Style);
        }

        private void EditFontStyle()
        {
            if (checkBox_Bold.CheckState == CheckState.Unchecked && checkBox_italic.CheckState == CheckState.Unchecked && checkBox_underline.CheckState == CheckState.Unchecked)
            {
                label_text.Font = new Font(label_text.Font.Name, label_text.Font.Size, FontStyle.Regular);
                fontDlg.Font = label_text.Font;
                return;
            }
            if (checkBox_Bold.CheckState == CheckState.Checked && checkBox_italic.CheckState == CheckState.Checked && checkBox_underline.CheckState == CheckState.Checked)
            {
                label_text.Font = new Font(label_text.Font.Name, label_text.Font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                fontDlg.Font = label_text.Font;
                return;
            }

            if (checkBox_Bold.CheckState == CheckState.Checked && checkBox_italic.CheckState == CheckState.Checked && checkBox_underline.CheckState == CheckState.Unchecked)
            {
                label_text.Font = new Font(label_text.Font.Name, label_text.Font.Size, FontStyle.Bold | FontStyle.Italic);
                fontDlg.Font = label_text.Font;
                return;
            }

            if (checkBox_Bold.CheckState == CheckState.Checked && checkBox_italic.CheckState == CheckState.Unchecked && checkBox_underline.CheckState == CheckState.Checked)
            {
                label_text.Font = new Font(label_text.Font.Name, label_text.Font.Size, FontStyle.Bold | FontStyle.Underline);
                fontDlg.Font = label_text.Font;
                return;
            }

            if (checkBox_Bold.CheckState == CheckState.Checked && checkBox_italic.CheckState == CheckState.Unchecked && checkBox_underline.CheckState == CheckState.Unchecked)
            {
                label_text.Font = new Font(label_text.Font.Name, label_text.Font.Size, FontStyle.Bold);
                fontDlg.Font = label_text.Font;
                return;
            }

            if (checkBox_Bold.CheckState == CheckState.Unchecked && checkBox_italic.CheckState == CheckState.Checked && checkBox_underline.CheckState == CheckState.Checked)
            {
                label_text.Font = new Font(label_text.Font.Name, label_text.Font.Size, FontStyle.Italic | FontStyle.Underline);
                fontDlg.Font = label_text.Font;
                return;
            }

            if (checkBox_Bold.CheckState == CheckState.Unchecked && checkBox_italic.CheckState == CheckState.Checked && checkBox_underline.CheckState == CheckState.Unchecked)
            {
                label_text.Font = new Font(label_text.Font.Name, label_text.Font.Size, FontStyle.Italic);
                fontDlg.Font = label_text.Font;
                return;
            }

            if (checkBox_Bold.CheckState == CheckState.Unchecked && checkBox_italic.CheckState == CheckState.Unchecked && checkBox_underline.CheckState == CheckState.Checked)
            {
                label_text.Font = new Font(label_text.Font.Name, label_text.Font.Size, FontStyle.Underline);
                fontDlg.Font = label_text.Font;
                return;
            }
        }

        private void checkBox_Bold_CheckedChanged(object sender, EventArgs e)
        {
            EditFontStyle();
        }

        private void checkBox_italic_CheckedChanged(object sender, EventArgs e)
        {
            EditFontStyle();
        }

        private void checkBox_underline_CheckedChanged(object sender, EventArgs e)
        {
            EditFontStyle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog();
            try
            {

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    label_text.ForeColor = colorDialog.Color;
                    btnColor.BackColor = colorDialog.Color;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
