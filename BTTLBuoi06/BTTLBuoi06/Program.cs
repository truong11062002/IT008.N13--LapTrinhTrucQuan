using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BTTLBuoi06
{
    class Program
    {
        static void Main(string[] args)
        {

            Form form = new Form();
            form.Size = new Size(768, 768);
            form.StartPosition = FormStartPosition.CenterScreen;

            //PictureBox pb = new PictureBox();
            //pb.Size = new Size(128, 128);
            //pb.SizeMode = PictureBoxSizeMode.StretchImage;
            //pb.Image = Image.FromFile("images\\knight_black.png");

            Board board = new Board(form);
            
            //form.Controls.Add(pb);
            Application.Run(form);
        }
    }
}
