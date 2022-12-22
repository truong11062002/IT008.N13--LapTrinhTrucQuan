using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Bai03 : Form
    {
        private Graphics g;
        private float X = 300, Y = 200;
        private float r = 50;
        public Bai03()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Bai03_Load(object sender, EventArgs e)
        {
            

        }

        private void Bai03_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract)
            {
                r = Math.Max(r - 10, 0);
                g.Clear(Color.WhiteSmoke);
                g.DrawEllipse(Pens.Red, X - r / 2, Y - r / 2, r, r);

            }
            if (e.KeyCode == Keys.Add)
            {
                r = r + 10;
                g.Clear(Color.WhiteSmoke);
                g.DrawEllipse(Pens.Red, X - r / 2, Y - r / 2, r, r);

            }
        }

        private void Bai03_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.Clear(Color.WhiteSmoke);
                X = e.X;
                Y = e.Y;
                g.DrawEllipse(Pens.Blue, X - 25, Y - 25, r, r);
            }
        }
        
    }
}
