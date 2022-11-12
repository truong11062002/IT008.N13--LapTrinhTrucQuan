using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            BackColor = randomColor;
        }
    }
}
