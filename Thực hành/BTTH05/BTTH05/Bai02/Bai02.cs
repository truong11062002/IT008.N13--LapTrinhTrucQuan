using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Bai02 : Form
    {

        Rectangle rec = new Rectangle(100, 100, 90, 90);
        private Point MouseDownLocation;
        public Bai02()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rec.Width = e.X - rec.X;
                rec.Height = e.Y - rec.Y;
                this.Invalidate();
            }

            if (e.Button == MouseButtons.Right)
            {
                rec.Location = new Point((e.X - MouseDownLocation.X) + rec.Left, (e.Y - MouseDownLocation.Y) + rec.Top);
                MouseDownLocation = e.Location;
                this.Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            //can also use this one:
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                rec = new Rectangle(e.X, e.Y, 0, 0);
                Invalidate();

            }
            if (e.Button == MouseButtons.Right)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, rec);
        }
    }
}
