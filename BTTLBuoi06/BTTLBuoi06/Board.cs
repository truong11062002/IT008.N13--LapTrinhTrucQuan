using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace BTTLBuoi06
{
    public class Board
    {
        public const int DEFAULT_SQUARE_WIDTH = 64;
        public const int DEFAULT_SQUARE_HEIGHT = 64;

        protected Piece _piece;
        public Square[,] _square;

        protected int _squareWidth;
        protected int _squareHeight;

        protected Form ParentForm;
        public Board(Form parent, int width = DEFAULT_SQUARE_WIDTH, int height = DEFAULT_SQUARE_HEIGHT)
        {
            _square = new Square[8, 8];
            _squareWidth = DEFAULT_SQUARE_WIDTH;
            _squareHeight = DEFAULT_SQUARE_HEIGHT;
            _init();
        }

        protected void _init()
        {
            int left = 0;
            int top = 0;

            SquareColor c = SquareColor.White;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square sq = new Square(c, this, _piece);
                    sq.Width = _squareWidth;
                    sq.Height = _squareHeight;

                    sq.Left = left;
                    sq.Top = top;

                    left += _squareWidth;

                    if (c == SquareColor.White)
                        c = SquareColor.Black;
                    else c = SquareColor.White;

                    _square[i, j] = sq;

                }

            }
        }
    }
}
