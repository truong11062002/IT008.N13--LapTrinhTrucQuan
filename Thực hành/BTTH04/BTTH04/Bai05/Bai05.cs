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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bai05_Load(object sender, EventArgs e)
        {
            SetUpDataDridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
        }

        private void AddNewStudent()
        {

        }
        

        private void UpdateDataDridView(Student student)
        {
            if (student == null)
            {
                return;
            }

            string[] row = new string[]
            {
                dgvStudent.Rows.Count.ToString(),student.ID,student.Name,student.Faculty,student.Record.ToString()
            };

            dgvStudent.Rows.Add(row);
        }
        private void SetUpDataDridView()
        {
            dgvStudent.ColumnCount = 5;

            dgvStudent.Columns[0].Name = "Số TT";
            dgvStudent.Columns[1].Name = "Mã Số SV";
            dgvStudent.Columns[2].Name = "Tên Sinh Viên";
            dgvStudent.Columns[3].Name = "Khoa";
            dgvStudent.Columns[4].Name = "Điểm TB";

            dgvStudent.Columns[0].DisplayIndex = 0;
            dgvStudent.Columns[1].DisplayIndex = 1;
            dgvStudent.Columns[2].DisplayIndex = 2;
            dgvStudent.Columns[3].DisplayIndex = 3;
            dgvStudent.Columns[4].DisplayIndex = 4;

            dgvStudent.Columns[0].Width = 70;
            dgvStudent.Columns[1].Width = 120;
            dgvStudent.Columns[2].Width = 190;
            dgvStudent.Columns[3].Width = 191;
            dgvStudent.Columns[4].Width = 85;

            dgvStudent.Columns[0].Resizable = DataGridViewTriState.False;
            dgvStudent.Columns[1].Resizable = DataGridViewTriState.False;
            dgvStudent.Columns[2].Resizable = DataGridViewTriState.False;
            dgvStudent.Columns[3].Resizable = DataGridViewTriState.False;
            dgvStudent.Columns[4].Resizable = DataGridViewTriState.False;

            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
