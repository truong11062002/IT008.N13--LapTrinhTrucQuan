using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        Point[,] hands_score = new Point[3, 2]
        {
            {new Point(0,0), new Point(0,120) },
            { new Point(0,0), new Point(0,140) },
            { new Point(0,0), new Point(0,140) }
        };

        DateTime cur;
        DateTime prev;

        Boolean change;
        public Form1()
        {
            InitializeComponent();
        }

        private void RotatePoint(Point[] pt, int iRotate, int iAngle)
        {
            Point ptTemp = new Point(0, 0);
            for (int i = 0; i < iRotate; i++)
            {
                ptTemp.X = (int)(pt[i].X * Math.Cos(2 * Math.PI * iAngle / 360) - pt[i].Y * Math.Sin(2 * Math.PI * iAngle / 360));
                ptTemp.Y = (int)(pt[i].Y * Math.Cos(2 * Math.PI * iAngle / 360) + pt[i].X * Math.Sin(2 * Math.PI * iAngle / 360));
                pt[i] = ptTemp;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Size.Width / 2, this.Size.Height / 2);
            e.Graphics.RotateTransform(180);
            DrawClock(e.Graphics);
            DrawHands(e.Graphics, prev, true, Color.FromArgb(255, 255, 255, 255));
        }

        private void DrawClock(Graphics g)
        {
            Point[] pt = new Point[2];
            for (int iAngle = 0; iAngle < 360; iAngle += 6)
            {
                pt[0].X = 0;
                pt[0].Y = 150;

                RotatePoint(pt, 1, iAngle);
                pt[1].X = pt[1].Y = (iAngle % 5 == 0 ? 10 : 5);
                pt[0].X -= pt[1].X / 2;

                pt[0].Y -= pt[1].Y / 2;
                Pen p = new Pen(Color.FromArgb(255, 255, 255, 255));
                g.DrawEllipse(p, pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
                g.FillEllipse(new SolidBrush(Color.FromArgb(255, 255, 255, 255)), pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
            }
        }

        private void DrawHands(Graphics g, DateTime dt, bool change, Color c)
        {
            Point[,] temppt = new Point[3, 2];
            int[] iAngle = new int[3];
            iAngle[0] = (int)((dt.Hour * 30) % 360 + dt.Minute / 2);
            iAngle[1] = (int)(dt.Minute * 6);
            iAngle[2] = (int)(dt.Second * 6);

            temppt = (Point[,])hands_score.Clone();

            for (int i = change ? 0 : 2; i < 3; i++)
            {

                Point[] tt = { temppt[i, 0], temppt[i, 1] };
                Pen p = new Pen(c);

                // Draw hour
                if (i == 0)
                {
                    RotatePoint(tt, 2, iAngle[i]);
                    g.DrawLine(p, tt[0], tt[1]);
                }
                // Draw minuate
                if (i == 1)
                {
                    RotatePoint(tt, 2, iAngle[i]);
                    g.DrawLine(p, tt[0], tt[1]);
                }
                // Draw second
                if (i == 2)
                {
                    RotatePoint(tt, 2, iAngle[i]);
                    g.DrawLine(p, tt[0], tt[1]);
                }
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cur = DateTime.Now;
            change = cur.Hour != prev.Hour || cur.Minute != prev.Minute;
            DrawHands(this.CreateGraphics(), cur, change, Color.FromArgb(255, 255, 255, 255));
            DrawHands(this.CreateGraphics(), cur, true, Color.FromArgb(255, 255, 0, 0));

            prev = cur;
            Invalidate();
        }
    }
}
