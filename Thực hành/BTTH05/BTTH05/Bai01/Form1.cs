using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    label1.Location = new Point(label1.Location.X, label1.Location.Y - 5);
                    break;
                case Keys.Down:
                    label1.Location = new Point(label1.Location.X, label1.Location.Y + 5);
                    break;
                case Keys.Right:
                    label1.Location = new Point(label1.Location.X + 5, label1.Location.Y);
                    break;
                case Keys.Left:
                    label1.Location = new Point(label1.Location.X - 5, label1.Location.Y);
                    break;
            }
        }
    }
}
