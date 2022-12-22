using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        private Graphics g;
        float X, Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            X = ((float)this.Size.Width) / 2;
            Y = ((float)this.Size.Height) / 2;
            if (comboBox_Item.SelectedItem.ToString() == "Square")
            {
                g.DrawRectangle(Pens.DarkRed, X - 50, Y - 50, 100, 100);
            }
            else if (comboBox_Item.SelectedItem.ToString() == "Circle")
            {
                g.DrawEllipse(Pens.DarkRed, X - 50, Y - 50, 100, 100);
            }
            else if (comboBox_Item.SelectedItem.ToString() == "Elipse")
            {
                g.DrawEllipse(Pens.DarkRed, X - 100, Y - 50, 200, 100);
            }
            else if (comboBox_Item.SelectedItem.ToString() == "Pie")
            {
                g.DrawPie(Pens.DarkRed, X - 150, Y - 150, 200, 200, 0.0F, 45.0F);
            }
            else if (comboBox_Item.SelectedItem.ToString() == "Filled Square")
            {
                g.FillRectangle(new SolidBrush(Color.DarkRed), X - 50, Y - 50, 100, 100);
            }
            else if (comboBox_Item.SelectedItem.ToString() == "Filled Circle")
            {
                g.FillEllipse(new SolidBrush(Color.DarkRed), X - 50, Y - 50, 100, 100);
            }
            else if (comboBox_Item.SelectedItem.ToString() == "Filled Elipse")
            {
                g.FillEllipse(new SolidBrush(Color.DarkRed), X - 100, Y - 50, 200, 100);
            }
            else if (comboBox_Item.SelectedItem.ToString() == "Filled Pie")
            {
                g.FillPie(new SolidBrush(Color.DarkRed), X - 150, Y - 150, 200, 200, 0.0F, 45.0F);
            }
        }
    }
}
