using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        bool canPaint;
        Graphics g;
        int x, y;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            canPaint = false;
        }

        private void form1MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;
            x = e.X;
            y = e.Y;
        }

        private void form1MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint)
            {
                g.DrawLine(Pens.Blue, x, y, e.X, e.Y);
            }
            x = e.X;
            y = e.Y;
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            Label lb = new Label
            {
                Text = "Paint Event",
                Top = rnd.Next(0, this.Height),
                Left = rnd.Next(0, this.Width),
            };
            this.Controls.Add(lb);
        }

        private void form1MouseLeave(object sender, EventArgs e)
        {
            canPaint = false;
        }
    }
}
