using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BTTLBuoi06
{
    public enum PieceColor { Black, White};
    class Piece
    {
        protected Image _image;
        protected PieceColor _color;


        public Image image
        {
            get { return _image; }
        }

        public PieceColor Color
        {
            get { return _color; }
            set { _color = Color; }
        }

        public Piece(PieceColor color)
        {
            _color = color;
        }
        
    }
}
