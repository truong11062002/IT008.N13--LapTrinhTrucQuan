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

namespace Bai10
{
    public partial class Bai10 : Form
    {
        public Bitmap bm;
        public float X1, Y1;
        public bool paint = false;
        public float X2, Y2;
        public Graphics g;

        private void pictureBox_showPen_MouseDown(object sender, MouseEventArgs e)
        {
            X1 = e.X;
            Y1 = e.Y;
            paint = true;
        }

        private void pictureBox_showPen_MouseMove(object sender, MouseEventArgs e)
        {
            if (!paint)
                return;
            X2 = e.X;
            Y2 = e.Y;
            pictureBox_showPen.Refresh();
        }

        private void pictureBox_showPen_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawLine(draw(), X1, Y1, X2, Y2);
            paint = false;
        }

        private void pictureBox_showPen_Paint(object sender, PaintEventArgs e)
        {
            if (paint)
            {
                Graphics gr = e.Graphics;
                gr.DrawLine(draw(), X1, Y1, X2, Y2);
            }
        }

        public Bai10()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBox_showPen.Width, pictureBox_showPen.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox_showPen.Image = bm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Insert item dash style
            comboBox_DashStyle.Items.Add(DashStyle.Custom);
            comboBox_DashStyle.Items.Add(DashStyle.Dash);
            comboBox_DashStyle.Items.Add(DashStyle.DashDot);
            comboBox_DashStyle.Items.Add(DashStyle.DashDotDot);
            comboBox_DashStyle.Items.Add(DashStyle.Dot);
            comboBox_DashStyle.Items.Add(DashStyle.Solid);
            comboBox_DashStyle.SelectedIndex = 0;
            // Insert item width
            for (int i = 1; i < 72; i++)
            {
                comboBox_Width.Items.Add(i.ToString());
            }
            // Insert item line join
            comboBox_LineJoin.Items.Add(LineJoin.Bevel);
            comboBox_LineJoin.Items.Add(LineJoin.Round);
            comboBox_LineJoin.Items.Add(LineJoin.Miter);
            comboBox_LineJoin.Items.Add(LineJoin.MiterClipped);
            comboBox_LineJoin.SelectedIndex = 0;
            // Insert item dash cap
            comboBox_DashCap.Items.Add(DashCap.Flat);
            comboBox_DashCap.Items.Add(DashCap.Round);
            comboBox_DashCap.Items.Add(DashCap.Triangle);
            comboBox_DashCap.SelectedIndex = 0;
            // Insert item start cap
            comboBox_StartCap.Items.Add(LineCap.AnchorMask);
            comboBox_StartCap.Items.Add(LineCap.ArrowAnchor);
            comboBox_StartCap.Items.Add(LineCap.Custom);
            comboBox_StartCap.Items.Add(LineCap.DiamondAnchor);
            comboBox_StartCap.Items.Add(LineCap.Flat);
            comboBox_StartCap.Items.Add(LineCap.NoAnchor);
            comboBox_StartCap.Items.Add(LineCap.Round);
            comboBox_StartCap.Items.Add(LineCap.RoundAnchor);
            comboBox_StartCap.Items.Add(LineCap.Square);
            comboBox_StartCap.Items.Add(LineCap.SquareAnchor);
            comboBox_StartCap.Items.Add(LineCap.Triangle);
            comboBox_StartCap.SelectedIndex = 0;
            // Insert item end cap
            comboBox_EndCap.Items.Add(LineCap.AnchorMask);
            comboBox_EndCap.Items.Add(LineCap.ArrowAnchor);
            comboBox_EndCap.Items.Add(LineCap.Custom);
            comboBox_EndCap.Items.Add(LineCap.DiamondAnchor);
            comboBox_EndCap.Items.Add(LineCap.Flat);
            comboBox_EndCap.Items.Add(LineCap.NoAnchor);
            comboBox_EndCap.Items.Add(LineCap.Round);
            comboBox_EndCap.Items.Add(LineCap.RoundAnchor);
            comboBox_EndCap.Items.Add(LineCap.Square);
            comboBox_EndCap.Items.Add(LineCap.SquareAnchor);
            comboBox_EndCap.Items.Add(LineCap.Triangle);
            comboBox_EndCap.SelectedIndex = 0;
        }

        private Pen draw()
        {
            Pen myPen = new Pen(Color.Red, int.Parse(comboBox_Width.Text.ToString()));
            if (comboBox_DashStyle.SelectedIndex == 0)
                myPen.DashStyle = DashStyle.Custom;
            if (comboBox_DashStyle.SelectedIndex == 1)
                myPen.DashStyle = DashStyle.Dash;
            if (comboBox_DashStyle.SelectedIndex == 2)
                myPen.DashStyle = DashStyle.DashDot;
            if (comboBox_DashStyle.SelectedIndex == 3)
                myPen.DashStyle = DashStyle.DashDotDot;
            if (comboBox_DashStyle.SelectedIndex == 4)
                myPen.DashStyle = DashStyle.Dot;
            if (comboBox_DashStyle.SelectedIndex == 5)
                myPen.DashStyle = DashStyle.Solid;

            // Line join 
            if (comboBox_LineJoin.SelectedIndex == 0)
                myPen.LineJoin = LineJoin.Bevel;
            if (comboBox_LineJoin.SelectedIndex == 1)
                myPen.LineJoin = LineJoin.Miter;
            if (comboBox_LineJoin.SelectedIndex == 2)
                myPen.LineJoin = LineJoin.MiterClipped;
            if (comboBox_LineJoin.SelectedIndex == 3)
                myPen.LineJoin = LineJoin.Round;

            // Dask cap
            if (comboBox_DashCap.SelectedIndex == 0)
                myPen.DashCap = DashCap.Flat;
            if (comboBox_DashCap.SelectedIndex == 1)
                myPen.DashCap = DashCap.Round;
            if (comboBox_DashCap.SelectedIndex == 2)
                myPen.DashCap = DashCap.Triangle;

            // Start cap

            if (comboBox_StartCap.SelectedIndex == 0)
                myPen.StartCap = LineCap.AnchorMask;
            if (comboBox_StartCap.SelectedIndex == 1)
                myPen.StartCap = LineCap.ArrowAnchor;
            if (comboBox_StartCap.SelectedIndex == 2)
                myPen.StartCap = LineCap.Custom;
            if (comboBox_StartCap.SelectedIndex == 3)
                myPen.StartCap = LineCap.DiamondAnchor;
            if (comboBox_StartCap.SelectedIndex == 4)
                myPen.StartCap = LineCap.Flat;
            if (comboBox_StartCap.SelectedIndex == 5)
                myPen.StartCap = LineCap.NoAnchor;
            if (comboBox_StartCap.SelectedIndex == 6)
                myPen.StartCap = LineCap.Round;
            if (comboBox_StartCap.SelectedIndex == 7)
                myPen.StartCap = LineCap.RoundAnchor;
            if (comboBox_StartCap.SelectedIndex == 8)
                myPen.StartCap = LineCap.Square;
            if (comboBox_StartCap.SelectedIndex == 9)
                myPen.StartCap = LineCap.SquareAnchor;
            if (comboBox_StartCap.SelectedIndex == 10)
                myPen.StartCap = LineCap.Triangle;
            
            // End cap

            if (comboBox_EndCap.SelectedIndex == 0)
                myPen.EndCap = LineCap.AnchorMask;
            if (comboBox_EndCap.SelectedIndex == 1)
                myPen.EndCap = LineCap.ArrowAnchor;
            if (comboBox_EndCap.SelectedIndex == 2)
                myPen.EndCap = LineCap.Custom;
            if (comboBox_EndCap.SelectedIndex == 3)
                myPen.EndCap = LineCap.DiamondAnchor;
            if (comboBox_EndCap.SelectedIndex == 4)
                myPen.EndCap = LineCap.Flat;
            if (comboBox_EndCap.SelectedIndex == 5)
                myPen.EndCap = LineCap.NoAnchor;
            if (comboBox_EndCap.SelectedIndex == 6)
                myPen.EndCap = LineCap.Round;
            if (comboBox_EndCap.SelectedIndex == 7)
                myPen.EndCap = LineCap.RoundAnchor;
            if (comboBox_EndCap.SelectedIndex == 8)
                myPen.EndCap = LineCap.Square;
            if (comboBox_EndCap.SelectedIndex == 9)
                myPen.EndCap = LineCap.SquareAnchor;
            if (comboBox_EndCap.SelectedIndex == 10)
                myPen.EndCap = LineCap.Triangle;
            return myPen;
        }

    }
}
