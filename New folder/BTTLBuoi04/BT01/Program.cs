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

        static int[,] m1;
        static int[,] m2;
        static int[,] r;

        static TextBox[,] matrix1;
        static TextBox[,] matrix2;
        static TextBox[,] matrix_result;
        
        static void resetMatrix()
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    form1.Controls.Remove(matrix1[i, j]);
                    form1.Controls.Remove(matrix2[i, j]);
                    form1.Controls.Remove(matrix_result[i, j]);
                }
        }
        static public int[,] getMatrix(TextBox[,] matrix)
        {
            int[,] x = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for(int i = 0; i < matrix.GetLength(0); i++)
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    x[i, j] = new int();
                    x[i, j] = int.Parse(matrix[i, j].Text);
                }
            return x;
        }

        static public void setMatrix(int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix_result[i, j].Text = matrix[i, j].ToString();
                }
        }
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
            resetMatrix();
            int size = int.Parse(mybox.Text);
            matrix1 = new TextBox[size, size];
            matrix2 = new TextBox[size, size];
            matrix_result = new TextBox[size, size];
            ShowAllMatrix(matrix1, matrix2, matrix_result, size, 50, 15);
        }

        static void Calc_Two_Matrix(Object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(mybox.Text);
                string calc = choose_calc.Text;
                if (calc == "+")
                {
                    m1 = getMatrix(matrix1);
                    m2 = getMatrix(matrix2);

                    r = AddTwoMatrix(m1, m2, size);
                    setMatrix(r);
                    //ShowMatrix(matrix_result, size, 50, 415);
                }
                else
                {
                    m1 = getMatrix(matrix1);
                    m2 = getMatrix(matrix2);
                    r = MultiplyTwoMatrix(m1, m2, size);
                    setMatrix(r);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số vào ô!");
            }
            
        }
        static public void ShowAllMatrix(TextBox[,] matrix1, TextBox[,] matrix2, TextBox[,] matrix_result, int size, int Top, int Left)
        {
            ShowMatrix(matrix1, size, Top, Left); // Matrix 1
            ShowMatrix(matrix2, size, Top, Left + 200); // Matrix cách matrix 2 dời thêm 200
            ShowMatrix(matrix_result, size, Top, Left + 400);
        }

        static public int[,] AddTwoMatrix(int[,] matrix1, int[,] matrix2, int size)
        {
            r = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    r[i, j] = matrix1[i,j] + matrix2[i,j];
                }
            }
            return r;
        }

        static public int[,] MultiplyTwoMatrix(int[,] matrix1, int[,] matrix2, int size)
        {
            r = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for(int i = 0; i < size; i++)
                for(int j = 0; j < size; j++)
                {
                    int sum = 0;
                    for(int k = 0; k < size; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    r[i,j] = sum;
                }
            return r;
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
            mybox.Text = "2";
            matrix1 = new TextBox[2, 2];
            matrix2 = new TextBox[2, 2];
            matrix_result = new TextBox[2, 2];
            ShowAllMatrix(matrix1, matrix2, matrix_result, 2, 50, 15);
            mybox.SelectedIndexChanged += new EventHandler(SelectedChanged);


            //ComboBox Choose Calculate
            choose_calc.Items.Add("+");
            choose_calc.Items.Add("x");
            choose_calc.Width = 40;
            choose_calc.Top = 80;
            choose_calc.Left = 160;
            choose_calc.Text = "+";
            choose_calc.Font = new Font(choose_calc.Font.FontFamily, 20);

            // Button equal
            equal.Text = "=";
            equal.Width = 20;
            equal.Top = 80;
            equal.Left = 350;
            equal.Click += new EventHandler(Calc_Two_Matrix);

            // Add into form1
            form1.Controls.Add(lb);
            form1.Controls.Add(mybox);
            form1.Controls.Add(choose_calc);
            form1.Controls.Add(equal);
            Application.Run(form1);

            Console.ReadLine();
        }
    }
}
