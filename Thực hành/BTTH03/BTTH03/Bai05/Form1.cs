using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r = 0;
            //------------------------------
            double.TryParse(this.first_num.Text, out fn);
            double.TryParse(this.second_num.Text, out sn);
            //------------------------------

            r = fn + sn;

            this.answer.Text = r.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r = 0;
            //------------------------------
            double.TryParse(this.first_num.Text, out fn);
            double.TryParse(this.second_num.Text, out sn);
            //------------------------------

            r = fn - sn;

            this.answer.Text = r.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r = 0;
            //------------------------------
            double.TryParse(this.first_num.Text, out fn);
            double.TryParse(this.second_num.Text, out sn);
            //------------------------------

            r = fn * sn;

            this.answer.Text = r.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r = 0;
            //------------------------------
            double.TryParse(this.first_num.Text, out fn);
            double.TryParse(this.second_num.Text, out sn);
            //------------------------------

            r = fn / sn;

            this.answer.Text = r.ToString();
        }
    }
}
