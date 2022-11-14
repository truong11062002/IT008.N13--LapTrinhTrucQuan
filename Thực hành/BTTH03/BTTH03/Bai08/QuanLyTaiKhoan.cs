using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class QuanLyTaiKhoan : Form
    {
        private int stt = 1;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void onClickAdd(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                int tmp = CheckSTK();
                if (tmp == -1)
                {

                    ListViewItem item1 = new ListViewItem();
                    item1.Text = stt.ToString();
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tb1.Text });
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tb2.Text });
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tb3.Text });
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tb4.Text });

                    list1.Items.Add(item1);

                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    stt++;
                }
                else
                {
                    for (int i = 0; i < list1.Items.Count; i++)
                    {
                        if (tmp == i)
                        {
                            list1.Items[i].SubItems[1].Text = tb1.Text;
                            list1.Items[i].SubItems[2].Text = tb2.Text;
                            list1.Items[i].SubItems[3].Text = tb3.Text;
                            list1.Items[i].SubItems[4].Text = tb4.Text;
                        }
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                long sum = 0;

                for (int i = 0; i < list1.Items.Count; i++)
                {
                    sum = sum + long.Parse(list1.Items[i].SubItems[4].Text);
                }

                tb5.Text = sum.ToString();
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
                tb4.Text = "";
            }

        }
        private bool Check()
        {
            if (tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || tb4.Text == "")
            {
                return false;
            }
            return true;
        }

        private int CheckSTK()
        {
            for (int i = 0; i < list1.Items.Count; i++)
            {
                if (tb1.Text.Equals(list1.Items[i].SubItems[1].Text))
                    return i;
            }

            return -1;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int temp = CheckSTK();

                if (temp == -1)
                {
                    MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
                }
                else
                {
                    for (int i = 0; i < list1.Items.Count; i++)
                    {
                        if (temp == i)
                        {
                            list1.Items[i].Remove();
                            MessageBox.Show("Xóa tài khoản thành công");
                            stt--;
                        }

                    }
                }
                long sum = 0;

                for (int i = 0; i < list1.Items.Count; i++)
                {
                    sum = sum + long.Parse(list1.Items[i].SubItems[4].Text);
                }
                tb5.Text = sum.ToString();
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
                tb4.Text = "";
            }
        }

        private void list_Click(object sender, EventArgs e)
        {
            tb1.Text = list1.SelectedItems[0].SubItems[1].Text;
            tb2.Text = list1.SelectedItems[0].SubItems[2].Text;
            tb3.Text = list1.SelectedItems[0].SubItems[3].Text;
            tb4.Text = list1.SelectedItems[0].SubItems[4].Text;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
