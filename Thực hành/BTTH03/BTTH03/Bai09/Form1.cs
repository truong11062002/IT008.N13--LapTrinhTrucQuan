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
        Modify modify;
        SinhVien sinhvien;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.second_rtb.Text = this.first_rtb.Text;
            this.first_rtb.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.first_rtb.Text = this.second_rtb.Text;
            this.second_rtb.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllSinhVien();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mssv = this.maSV_textbox.Text;
            string hoten = this.hoten_textBox.Text;
            string chuyennganh = this.chuyennganh_comboBox.Text;
            string gioitinh = (nam_radioButton.Checked) ? nam_radioButton.Text : nu_radioButton.Text;
            string somon = second_rtb.Lines.Count().ToString();
            // --------------------
            sinhvien = new SinhVien(mssv, hoten,chuyennganh, gioitinh, somon);

            if (this.second_rtb.Text != "")
            {
                if (modify.insert(sinhvien))
                {
                    dataGridView1.DataSource = modify.getAllSinhVien();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đủ môn học!");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridView1.DataSource = modify.getAllSinhVien();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
