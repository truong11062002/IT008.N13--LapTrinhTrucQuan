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
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("button: " + e.Button.ToString() + "\nlocation: " + e.Location.ToString(), "mouseclick");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("ASCII: " + Convert.ToInt32(e.KeyChar).ToString() + "\nkey: " + e.KeyChar.ToString(), "keypress");
        }
    }
}
