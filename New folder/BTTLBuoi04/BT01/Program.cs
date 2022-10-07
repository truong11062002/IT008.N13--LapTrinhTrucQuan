using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BT01
{
    class Program
    {
        static Form form1 = new Form();
        static ComboBox mybox = new ComboBox();
        static ComboBox choose_calc = new ComboBox();
        static Label lb = new Label();
        static Button equal = new Button();


        static TextBox[,] matrix1;
        static TextBox[,] matrix2;
        static TextBox[,] matrix_result;

        static public void ShowMatrix(TextBox[,] matrix, int size, int Top, int Left)
        {

            int fixed_Left = Left; // Cố định vị trí Left
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = new TextBox();
                    
                    matrix[i, j].Width = 22;
                    matrix[i, j].Height = 22;

                    matrix[i, j].Top = Top;
                    matrix[i, j].Left = Left;
                    Left += 25; // Mỗi row cách nhau 25

                    form1.Controls.Add(matrix[i, j]);
                }
                Left = fixed_Left;
                Top += 30; // Mỗi lần thực hiện xong 1 row dời xuống top dời xuống 30
            }    
        }

        
        static void SelectedChanged(Object sender, EventArgs e)
        {
            int size = int.Parse(mybox.Text);
            matrix1 = new TextBox[size, size];
            matrix2 = new TextBox[size, size];
            matrix_result = new TextBox[size, size];

            ShowAllMatrix(matrix1, matrix2, matrix_result, size, 50, 15);

            // Khi change kích thước matrix sẽ show ra nút chọn phương thức và dấu bằng để click
            choose_calc.Visible = true;
            equal.Visible = true;
        }
        static public void ShowAllMatrix(TextBox[,] matrix1, TextBox[,] matrix2, TextBox[,] matrix_result, int size, int Top, int Left)
        {
            ShowMatrix(matrix1, size, Top, Left); // Matrix 1
            ShowMatrix(matrix1, size, Top, Left + 200); // Matrix cách matrix 2 dời thêm 200
            ShowMatrix(matrix1, size, Top, Left + 400);
        }

        static void Main(string[] args)
        {
            // form1
            form1.Text = "Nhân 2 ma trận";
            form1.Width = 650;
            form1.Height = 500;
            form1.StartPosition = FormStartPosition.CenterScreen;

            //Label Size
            lb.Text = "Kích thước";
            lb.Size = new Size(60,20);
            lb.Left = 20;
            lb.Top = 23;

            //ComboBox Size
            mybox.Location = new Point(30, 77);
            mybox.Size = new Size(100, 50);
            mybox.Top = 20;
            mybox.Left = 80;
            mybox.Items.Add("2");
            mybox.Items.Add("3");
            mybox.Items.Add("4");
            mybox.Items.Add("5");
            mybox.SelectedIndexChanged += new EventHandler(SelectedChanged);


            //ComboBox Choose Calculate
            choose_calc.Items.Add("+");
            choose_calc.Items.Add("x");
            choose_calc.Width = 40;
            choose_calc.Top = 80;
            choose_calc.Left = 160;
            choose_calc.Visible = false;

            // Button equal
            equal.Text = "=";
            equal.Width = 20;
            equal.Top = 80;
            equal.Left = 350;
            equal.Visible = false;

            // Add into form1
            form1.Controls.Add(lb);
            form1.Controls.Add(mybox);
            form1.Controls.Add(choose_calc);
            form1.Controls.Add(equal);
            Application.Run(form1);
        }
    }
}
