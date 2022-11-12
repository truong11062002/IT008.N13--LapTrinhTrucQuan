using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace BTTLBuoi08
{
    class MyForm : Form
    {
        const float rwgt = 0.3086f;
        const float gwgt = 0.6094f;
        const float bwgt = 0.0820f;
        public static TextBox t;
        public static PictureBox pic_ori;
        public static PictureBox pic_change;
        public Button b;        
        public Bitmap bitmap;

        OpenFileDialog open = new OpenFileDialog();
        
        public MyForm()
        {
            this.Height = 600;
            this.Width = 600;
            this.CenterToScreen();

            TrackBar tb = new TrackBar();
            tb.SetRange(-125, 125);
            tb.Value = 50;
            tb.Width = 512;
            tb.TickFrequency = 10;
            tb.Scroll += new EventHandler(TrackBar_Scroll);

            t = new TextBox();
            t.Top = 100;
            t.Width = 30;

            Bitmap bitmap1 = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Bitmap bitmap2 = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            AdjustBrightness(bitmap, tb.Value);

            // PictureBox
            pic_ori = new PictureBox();
            pic_change = new PictureBox();

            pic_ori.Image = Image.FromFile("image.jpg");
            pic_ori.BackgroundImageLayout = ImageLayout.Stretch;
            pic_ori.Location = new Point(50, 50);
            pic_ori.Size = new Size(200, (int)((0.13 * 200) - 2));
            pic_ori.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_ori.Left = 300;
            pic_change = new PictureBox();
            bitmap1 = AdjustBrightness(bitmap, tb.Value);
            bitmap2 = AdjustSaturation(bitmap, tb.Value);
            Graphics graphics1 = Graphics.FromImage(bitmap1);
            Graphics graphics2 = Graphics.FromImage(bitmap2);


            Pen pen = new Pen(Color.Blue, 2);
            graphics1.DrawArc(pen, 0, 0, 700, 700, 0, 180);
            graphics2.DrawArc(pen, 0, 0, 700, 700, 0, 180);

            bitmap.Save("Bitmap.png");
            t.Text = tb.Value.ToString();

            // pic_change.Refresh();
            pic_change.Location = new Point(10, 10);
            pic_change.Size = new Size(100, (int)((0.13 * 100) - 2));
            pic_change.Location = new Point(400, 300);
            // pic_change.Image.Save("output.jpg");


            // Button 
            b = new Button();
            b.Text = "Load";
            b.Location = new Point(100, 50);
            b.Click += new EventHandler(BtnOpenImage_Click);
            

            this.Controls.Add(pic_ori);
            this.Controls.Add(pic_change);
            this.Controls.Add(tb);
            this.Controls.Add(t);
            this.Controls.Add(b);
        }
        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == open.ShowDialog())
            {
                bitmap = (Bitmap)Bitmap.FromFile(open.FileName);
                pic_ori.Image = bitmap;
            }
        }

        public static void TrackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)(sender);
            t.Text = tb.Value.ToString();
        }

        static private Bitmap AdjustBrightness(Image image, float brightness)
        {
            float b = brightness;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {b, 0, 0, 0, 0},
                    new float[] {0, b, 0, 0, 0},
                    new float[] {0, 0, b, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
            }

            return bm;
        }

        static private Bitmap AdjustSaturation(Image image, float saturation)
        {
            ColorMatrix colorMatrix = new ColorMatrix();
            float s = 1f - saturation;
            float baseSat = 1.0f - saturation;

            colorMatrix[0, 0] = baseSat * rwgt + saturation;
            colorMatrix[0, 1] = baseSat * rwgt;
            colorMatrix[0, 2] = baseSat * rwgt;
            colorMatrix[1, 0] = baseSat * gwgt;
            colorMatrix[1, 1] = baseSat * gwgt + saturation;
            colorMatrix[1, 2] = baseSat * gwgt;
            colorMatrix[2, 0] = baseSat * bwgt;
            colorMatrix[2, 1] = baseSat * bwgt;
            colorMatrix[2, 2] = baseSat * bwgt + saturation;
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);

            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
            }
            return bm;
        }
        static void Main(string[] args)
        {
            MyForm form = new MyForm();



            Application.Run(form);
            Console.ReadKey();
        }
    }
}
