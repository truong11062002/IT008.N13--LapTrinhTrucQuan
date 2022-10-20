using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tetris_game
{
    public partial class Tetris : Form
    {

        int[,] map = new int[8, 16];
        public Tetris()
        {
            this.Text = "Tetris game";
            this.Height = 600;
            this.Width = 600;
            this.CenterToScreen();
        }

        public void init()
        {

        }
        public void DrawMap(Graphics g)
        {
            for (int i = 0; i < 8; i++)
            {
                for(int j =0; j< 16; j++)
                {
                    g.DrawLine();
                }
            }
        }

        
        static void Main(string[] args)
        {
            Tetris f_tetris = new Tetris();
            Application.Run(f_tetris);
        }
    }


}
