using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class movie : Form
    {
        public movie()
        {
            InitializeComponent();
            HandleColor();
        }

        public void HandleColor()
        {
            foreach (Button item in pn.Controls)
            {
                item.Click += new EventHandler(ChangeColor);
            }
        }


        private void getButton(Button btn)
        {
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }

            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vị trí đã được đặt! Mời bạn chọn chỗ khác");
            }
        }
        public void ChangeColor(object sender, EventArgs e)
        {
            getButton((Button)sender);
        }

        public void calcMoney()
        {
            int tongTien = 0;
            foreach (Button item in pn.Controls)
            {
                string str = (item.Name).Substring(4);
                if (item.BackColor == Color.Blue)
                {
                    
                    if (int.Parse(str) <= 5)
                    {
                        tongTien += 5000;
                        
                    }

                    else if (int.Parse(str) <= 10)
                    {
                        tongTien += 6500;
                    }
                    if (int.Parse(str) >= 11)
                    {
                        tongTien += 8000;
                    }
                }

            }
            txt_money.Text = tongTien.ToString();
        }

        private void onClick_Chon(object sender, EventArgs e)
        {
            calcMoney();
            foreach (Button item in pn.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    item.BackColor = Color.Yellow;
                }
            }
        }

        private void onClick_HuyBo(object sender, EventArgs e)
        {
            txt_money.Text = "0";
            foreach (Button item in pn.Controls)
            {
                if(item.BackColor == Color.Blue)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void onClick_KetThuc(object sender, EventArgs e)
        {
            DialogResult inform = MessageBox.Show("Bạn có chắc muốn thoát?", "", MessageBoxButtons.YesNo);
            if (inform == DialogResult.Yes)
            {
                this.Close();
            }
            else if (inform == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
