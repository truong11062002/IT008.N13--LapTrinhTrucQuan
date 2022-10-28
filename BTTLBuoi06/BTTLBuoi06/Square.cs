using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace BTTLBuoi06
{
    public enum SquareColor { White, Black };
    public class Square : PictureBox
    {
        protected SquareColor _color;
        protected Board _board;
        protected Piece _piece;

        public Piece Piece
        {
            get { return _piece}
            set
            {
                _piece = value;
                if(_piece != null)
            }
        }


        public SquareColor Color
        {
            get { return _color; }
            set
            {
                _color = value;

                if(_color == SquareColor.White)
                {
                    this.BackColor = System.Drawing.Color.White;
                }
                else
                    this.BackColor = System.Drawing.Color.Black;
            }
        }

        public Square(SquareColor c, Board b, Piece p)
        {
            _board = b;
        }
    }
}
