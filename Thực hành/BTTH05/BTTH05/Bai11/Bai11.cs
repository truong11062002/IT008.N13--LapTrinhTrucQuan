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

namespace Bai11
{
    public partial class Bai11 : Form
    {
        public int shape = 1;
        public int brushes = 1;
        public Color clor = Color.Black;
        public bool paint = false;
        public float X1, Y1;
        public float X2, Y2;
        public Bitmap bm;
        public Graphics g;
        public float width = 0;
        public float height = 0;

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog pickColor = new ColorDialog();
            pickColor.FullOpen = true;
            if (pickColor.ShowDialog() == DialogResult.OK)
            {
                clor = pickColor.Color;
                btnColor.BackColor = pickColor.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox_ShowPen.Refresh();
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            shape = 1;
            groupBoxBrushes.Visible = false;
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            shape = 2;
            groupBoxBrushes.Visible = true;
        }

        private void radioButtonEl_CheckedChanged(object sender, EventArgs e)
        {
            shape = 3;
            groupBoxBrushes.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            brushes = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            brushes = 2;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            brushes = 3;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            brushes = 4;
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownWidth.Value == 0)
                numericUpDownWidth.Value = 1;
        }

        private void pictureBox_ShowPen_MouseDown(object sender, MouseEventArgs e)
        {
            X1 = e.X;
            Y1 = e.Y;
            paint = true;
        }

        private void pictureBox_ShowPen_MouseMove(object sender, MouseEventArgs e)
        {
            if (!paint)
            {
                return;
            }

            width = e.X - X1;
            height = e.Y - Y1;
            X2 = e.X;
            Y2 = e.Y;
            pictureBox_ShowPen.Refresh();
        }

        private void pictureBox_ShowPen_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape == 1)
            {
                Pen pend = new Pen(clor, int.Parse(numericUpDownWidth.Value.ToString()));
                g.DrawLine(pend, X1, Y1, e.X, e.Y);
            }
            if (shape == 2)
            {
                if (brushes == 1)
                {
                    SolidBrush drawBrush = new SolidBrush(Color.YellowGreen);
                    g.FillRectangle(drawBrush, X1, Y1, width, height);
                }
                if (brushes == 2)
                {
                    HatchStyle style = HatchStyle.Horizontal;
                    HatchBrush hatchBrush = new HatchBrush(style, Color.Blue, Color.YellowGreen);
                    g.FillRectangle(hatchBrush, X1, Y1, width, height);

                }
                if (brushes == 3)
                {
                    TextureBrush textureBrush;
                    Image img = new Bitmap(Resource1.text);
                    textureBrush = new TextureBrush(img);
                    g.FillRectangle(textureBrush, X1, Y1, width, height);

                }
                if (brushes == 4)
                {
                    Point pt1 = new Point((int)(Width / 2), (int)Width);
                    Point pt2 = new Point((int)(Width / 2), 0);
                    LinearGradientBrush gradienBrush = new LinearGradientBrush(pt1,
                    pt2, Color.Red, Color.YellowGreen);
                    g.FillRectangle(gradienBrush, X1, Y1, width, height);

                }
            }
            if (shape == 3)
            {
                if (brushes == 1)
                {
                    SolidBrush drawBrush = new SolidBrush(Color.YellowGreen);
                    g.FillEllipse(drawBrush, X1, Y1, width, height);
                }
                if (brushes == 2)
                {
                    HatchStyle style = HatchStyle.Horizontal;
                    HatchBrush hatchBrush = new HatchBrush(style, Color.Blue, Color.YellowGreen);
                    g.FillEllipse(hatchBrush, X1, Y1, width, height);

                }
                if (brushes == 3)
                {
                    TextureBrush textureBrush;
                    Image img = new Bitmap(Resource1.text);
                    textureBrush = new TextureBrush(img);
                    g.FillEllipse(textureBrush, X1, Y1, width, height);

                }
                if (brushes == 4)
                {
                    Point pt1 = new Point((int)(Width / 2), (int)Width);
                    Point pt2 = new Point((int)(Width / 2), 0);
                    LinearGradientBrush gradienBrush = new LinearGradientBrush(pt1,
                    pt2, Color.Red, Color.YellowGreen);
                    g.FillEllipse(gradienBrush, X1, Y1, width, height);

                }
            }
            pictureBox_ShowPen.Refresh();
            paint = false;
        }

        private void pictureBox_ShowPen_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            if (paint)
            {
                if (shape == 1)
                {
                    Pen pend = new Pen(clor, int.Parse(numericUpDownWidth.Value.ToString()));
                    gr.DrawLine(pend, X1, Y1, X2, Y2);
                }
                if (shape == 2)
                {
                    if (brushes == 1)
                    {
                        SolidBrush drawBrush = new SolidBrush(Color.YellowGreen);
                        gr.FillRectangle(drawBrush, X1, Y1, width, height);
                    }
                    if (brushes == 2)
                    {
                        HatchStyle style = HatchStyle.Horizontal;
                        HatchBrush hatchBrush = new HatchBrush(style, Color.Blue, Color.YellowGreen);
                        gr.FillRectangle(hatchBrush, X1, Y1, width, height);

                    }
                    if (brushes == 3)
                    {
                        TextureBrush textureBrush;
                        Image img = new Bitmap(Resource1.text);
                        textureBrush = new TextureBrush(img);
                        gr.FillRectangle(textureBrush, X1, Y1, width, height);

                    }
                    if (brushes == 4)
                    {
                        Point pt1 = new Point((int)(Width / 2), (int)Width);
                        Point pt2 = new Point((int)(Width / 2), 0);
                        LinearGradientBrush gradienBrush = new LinearGradientBrush(pt1,
                        pt2, Color.Red, Color.YellowGreen);
                        gr.FillRectangle(gradienBrush, X1, Y1, width, height);

                    }
                }
                if (shape == 3)
                {
                    if (brushes == 1)
                    {
                        SolidBrush drawBrush = new SolidBrush(Color.YellowGreen);
                        gr.FillEllipse(drawBrush, X1, Y1, width, height);
                    }
                    if (brushes == 2)
                    {
                        HatchStyle style = HatchStyle.Horizontal;
                        HatchBrush hatchBrush = new HatchBrush(style, Color.Blue, Color.YellowGreen);
                        gr.FillEllipse(hatchBrush, X1, Y1, width, height);

                    }
                    if (brushes == 3)
                    {
                        TextureBrush textureBrush;
                        Image img = new Bitmap(Resource1.text);
                        textureBrush = new TextureBrush(img);
                        gr.FillEllipse(textureBrush, X1, Y1, width, height);

                    }
                    if (brushes == 4)
                    {
                        Point pt1 = new Point((int)(Width / 2), (int)Width);
                        Point pt2 = new Point((int)(Width / 2), 0);
                        LinearGradientBrush gradienBrush = new LinearGradientBrush(pt1,
                        pt2, Color.Red, Color.YellowGreen);
                        gr.FillEllipse(gradienBrush, X1, Y1, width, height);

                    }
                }
            }
        }

        private void Bai11_Load(object sender, EventArgs e)
        {
            groupBoxBrushes.Visible = false;
            bm = new Bitmap(pictureBox_ShowPen.Width, pictureBox_ShowPen.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox_ShowPen.Image = bm;
        }


        public Bai11()
        {
            InitializeComponent();

        }
    }
}
