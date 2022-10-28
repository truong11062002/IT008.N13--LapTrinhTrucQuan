using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;
namespace BTTLBuoi07
{
    public class Program
    {
        
        private static void DrawArc_Paint(object sender, PaintEventArgs e)
        {
            float startAngle = 45.0f;
            float sweepAngle = 90.0f;
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(200, 20, 200, 200);
            g.DrawArc(Pens.Red, rect, startAngle, sweepAngle);
        }

        private Bitmap AdjustBrightness(Image image, float brightness)
        {
            // Make the ColorMatrix.
            float b = brightness;
            System.Drawing.Imaging.ColorMatrix cm = new System.Drawing.Imaging.ColorMatrix(new float[][]
                {
                    new float[] {b, 0, 0, 0, 0},
                    new float[] {0, b, 0, 0, 0},
                    new float[] {0, 0, b, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
            System.Drawing.Imaging.ImageAttributes attributes = new System.Drawing.Imaging.ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Draw the image onto the new bitmap while applying the new ColorMatrix.
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Make the result bitmap.
            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
            }

            // Return the result.
            return bm;
        }
        public static void f_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap curBitmap = new Bitmap("Image.jpg");

            g.DrawImage(curBitmap, 0, 0, curBitmap.Width, curBitmap.Height);
            for (int i = 100; i < 500; i++)
            {
                for (int j = 150; j < 500; j++)
                {
                    Color curColor = curBitmap.GetPixel(i, j);
                    int ret = (curColor.R + curColor.G + curColor.B) / 3;
                    curBitmap.SetPixel(i, j, Color.FromArgb(ret, ret, ret));
                }
            }
            g.DrawImage(curBitmap, 0, 0, curBitmap.Width, curBitmap.Height);
        }
        static void Main(string[] args)
        {
            Form f = new Form();

            f.Height = 600;
            f.Width = 600;
            

            f.Paint += new PaintEventHandler(f_Paint);
            
            //f.Paint += new PaintEventHandler(DrawArc_Paint);

            Application.Run(f);
            

        }
        
        
    }
}
