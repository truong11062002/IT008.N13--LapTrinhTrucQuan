using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_Processing
{
    class MyForm : Form
    {
        const float rwgt = 0.3086f;
        const float gwgt = 0.6094f;
        const float bwgt = 0.0820f;

        public static MyForm form;
        public static PictureBox pic_ori = new PictureBox();
        public static PictureBox pic_change = new PictureBox();
        // public static Image temp;

        Button btn1;
        Button btn2;
        Button btn3;

        public static TrackBar tb1;
        public static TrackBar tb2;

        public static Label lb1 = new Label();
        public static Label lb2 = new Label();

        public MyForm()
        {
            this.Height = 600;
            this.Width = 600;
            this.CenterToScreen();

            // Trackbar 
            tb2 = new TrackBar();
            tb2.Location = new Point(100, 500);
            tb2.SetRange(-125, 125);
            tb2.Value = 0;
            tb2.Width = 300;
            tb2.Scroll += new EventHandler(TrackBar_Scroll_Saturation);


            // Trackbar brightness
            tb1 = new TrackBar();
            tb1.Location = new Point(100, 400);
            tb1.SetRange(0, 200);
            tb1.Value = 0;
            tb1.Width = 300;
            tb1.Scroll += new EventHandler(TrackBar_Scroll_Brightness);

            // Picture box origin

            pic_ori.Width = 280;
            pic_ori.Height = 300;
            pic_ori.Left = 300;
            pic_ori.BackColor = Color.Blue;
            pic_ori.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_ori.BorderStyle = BorderStyle.FixedSingle;


            // Picture box 
            pic_change.BackColor = Color.Yellow;
            pic_change.Width = 280;
            pic_change.Height = 300;
            pic_change.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_change.BorderStyle = BorderStyle.FixedSingle;

            // Button load
            btn1 = new Button();
            btn1.Text = "Load";
            btn1.Location = new Point(450, 400);
            btn1.Click += new EventHandler(BtnOpenImage_Click);

            // Button save
            btn2 = new Button();
            btn2.Text = "Save";
            btn2.Location = new Point(450, 500);
            btn2.Click += new EventHandler(SaveImage);

            // Button reset;
            btn3 = new Button();
            btn3.Text = "Reset";
            btn3.Location = new Point(450, 450);
            btn3.Click += new EventHandler(ResetImage);


            // Label

            lb1.Text = "Brightness";
            lb2.Text = "Saturation";

            lb1.Left = 45;
            lb1.Top = tb1.Top;

            lb2.Left = 45;
            lb2.Top = tb2.Top;
   
            // -------------
            this.Controls.Add(pic_ori);
            this.Controls.Add(pic_change);
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(tb1);
            this.Controls.Add(tb2);
            this.Controls.Add(lb1);
            this.Controls.Add(lb2);
        }

        private static void changeBrightNess_Saturation(float value1, float value2)
        {
            pic_change.Image = AdjustBrightness(pic_ori.Image, value1);
            pic_change.Image = AdjustSaturation(pic_change.Image, value2);

        }
        public static void TrackBar_Scroll_Brightness(object sender, EventArgs e)
        {
            changeBrightNess_Saturation((float)tb1.Value / 100, (float)tb2.Value / 100);
        }

        public static void TrackBar_Scroll_Saturation(object sender, EventArgs e)
        {
            changeBrightNess_Saturation((float)tb1.Value / 100, (float)tb2.Value / 100);
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pic_ori.Image = new Bitmap(dlg.FileName);
                    pic_change.Image = new Bitmap(dlg.FileName);

                    // temp = new Bitmap(dlg.FileName);
                }
            }
        }
        private void ResetImage(object sender, EventArgs e)
        {
            pic_change.Image = pic_ori.Image;
        }

        private void SaveImage(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pic_change.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pic_change.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pic_change.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }
        
        private static Bitmap AdjustBrightness(Image image, float brightness)
        {
            // Make the ColorMatrix.
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

        [STAThread]
        static void Main(string[] args)
        {
            form = new MyForm();
            Application.Run(form);
            Console.ReadKey();
        }
    }
}
