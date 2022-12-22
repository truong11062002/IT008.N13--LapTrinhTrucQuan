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

namespace Bai06
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void Bai06_Load(object sender, EventArgs e)
        {
            listBox_font.ItemHeight = 30;

            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {

                    listBox_font.Items.Add(fa.Name);
                }
                listBox_font.DrawMode = DrawMode.OwnerDrawFixed;
            }
        }

        private void listBox_font_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(listBox_font.Items[e.Index].ToString(), new Font(listBox_font.Items[e.Index].ToString(), 20), Brushes.Black, e.Bounds);
        }
    }
}
