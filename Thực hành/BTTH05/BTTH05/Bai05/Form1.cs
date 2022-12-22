using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("ĐH CNTT", new Font("Times New Roman", 26), Brushes.Salmon, 20, 0);
            g.DrawString("ĐH CNTT", new Font("Times New Roman", 36), Brushes.Navy, 20, 30);
            g.DrawString("ĐH CNTT", new Font("Times New Roman", 46, FontStyle.Italic), Brushes.Fuchsia, 20, 70);
            g.DrawString("ĐH CNTT", new Font("Times New Roman", 56, FontStyle.Bold), Brushes.HotPink, 20, 110);
        }
    }
}
