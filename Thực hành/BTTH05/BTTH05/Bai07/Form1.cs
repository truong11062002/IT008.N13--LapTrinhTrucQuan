using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private float X, Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawTimer();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            DrawTimer();
        }

        private void DrawTimer()
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString(DateTime.Now.ToString("HH:mm:ss"), new Font("Arial", 80, FontStyle.Bold), new SolidBrush(Color.Red), ClientRectangle, sf);
        }
    }
}
