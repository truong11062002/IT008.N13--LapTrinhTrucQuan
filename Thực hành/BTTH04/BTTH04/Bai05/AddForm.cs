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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public Alumnus GetNewAlumnus()
        {
            while (this.ShowDialog() == DialogResult.OK)
                try
                {
                    return new Alumnus
                        (
                            txbID.Text,
                            txbName.Text,
                            cbbBranch.SelectedItem.ToString(),
                            txbAVGRecord.Text
                        );
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                }

            return null;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            this.cbbBranch.SelectedIndex = 0;
        }
    }
}
