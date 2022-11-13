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
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void onClickAdd(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem();
            item1.Text = "1";
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tb1.Text });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tb2.Text });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tb3.Text });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tb4.Text });

            listView.Items.Add(item1);
        }
    }
}
