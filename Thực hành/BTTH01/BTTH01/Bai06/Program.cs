using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    class Program
    {
        
        public static int maxOfMatrix(int[,] matrix)
        {
            int max = 0;

            for(int d = 0; d < matrix.GetLength(0); d++)
            {
                for(int c = 0; c < matrix.GetLength(1); c++)
                {
                    if(matrix[d,c] > max)
                    {
                        max = matrix[d, c];
                    }
                }
            }
            return max;
        }

        public static int findColumeMaxOfMatrix(int[,] matrix)
        {
            int max = 0;
            int max_column = 0;
            for (int d = 0; d < matrix.GetLength(0); d++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[d, c] > max)
                    {
                        max = matrix[d, c];
                        max_column = c;
                    }
                }
            }
            return max_column;
        }

        public static int minOfMatrix(int[,] matrix)
        {
            int min = 99999;

            for (int d = 0; d < matrix.GetLength(0); d++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[d, c] < min)
                    {
                        min = matrix[d, c];
                    }
                }
            }
            return min;
        }

        public static int Tong(int[] arr) // Chua dung
        {
            int s = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }

            return s;
        }

        public static List<int> sumMaxRow(int[,] matrix)
        {
            
            int idx = -1;
            int maxSum = 0;
            

            for (int d = 0; d < matrix.GetLength(0); d++)
            {
                int sum = 0;
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    sum += matrix[d, c];
                }

                if(maxSum < sum)
                {
                    maxSum = sum;

                    idx = d;
                }
            }

            List<int> res = new List<int>();

            res.Add(idx);
            res.Add(maxSum);

            return res;
        }

        public static bool checkNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static int TongNotNguyenTo(int[,] matrix)
        {
            int sum = 0;

            for(int d = 0;d < matrix.GetLength(0); d++)
            {
                for(int c = 0; c < matrix.GetLength(1); c++)
                {
                    if(checkNguyenTo(matrix[d,c]) == false)
                    {
                        sum += matrix[d, c];
                    }
                }
            }
            return sum;
        }

        static public void XoaDongThuk(int[,] matrix, int k)
        {
            int dong = matrix.GetLength(0);
            for(int i = k; i < matrix.GetLength(0) - 1; i++)
            {
                for(int j = 0; j< matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i + 1, j];
                }
            }
            dong--;
            showMatrix(matrix, dong, matrix.GetLength(1));
        }

        static public void showMatrix(int[,] matrix, int matrix_rows, int matrix_columns)
        {
            for (int dong = 0; dong < matrix_rows; dong++)
            {
                for (int cot = 0; cot < matrix_columns; cot++)
                {
                    Console.Write(matrix[dong, cot] + "\t");
                }
                Console.WriteLine();
            }
        }

        static public void Del_ColumnMaxElement(int[,] matrix, int cotCanXoa)
        {
            int m = matrix.GetLength(1);
            for(int i = 0; i < matrix.GetLength(0); i++)
                for(int j = cotCanXoa; j < matrix.GetLength(1) - 1; j++)
                {
                    matrix[i, j] = matrix[i, j + 1];
                }
            m--;
            showMatrix(matrix, matrix.GetLength(0), m);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int matrix_rows = n;
            int matrix_columns = n;

            int[,] matrix = new int[matrix_rows, matrix_columns];
            Random random = new Random();
            for (int dong = 0; dong < matrix_rows; dong++)
            {
                for(int cot = 0; cot < matrix_columns; cot++)
                {

                    /*
                     int input;
                    Console.WriteLine("Nhap gia tri cho: ({0},{1})", dong, cot);
                    while (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.Write("Nhap gia tri dung cho ({0},{1}): ", dong, cot);
                    }
                    matrix[dong, cot] = input;
                     */

                    matrix[dong, cot] = random.Next(100);
                }
            }
            // Cau a: Xuất ma trận

            showMatrix(matrix, matrix_rows, matrix_columns);

            // Cau b: Tìm phần tử lớn nhất
            int maxMatrix = maxOfMatrix(matrix);
            Console.WriteLine("Gia tri lon nhat cua ma tran la: " + maxMatrix);
            // Cau b: Tìm phần tử nhỏ nhất
            int minMatrix = minOfMatrix(matrix);
            Console.WriteLine("Gia tri nho nhat cua ma tran la: " + minMatrix);

            // Cau c: Tìm dòng có tổng lớn nhất
            List<int> result = sumMaxRow(matrix);
            Console.WriteLine("Dong " + (result[0] + 1) + " co tong lon nhat la: " + result[1]);

            // Cau d: Tính tổng các số không phải là số nguyên tố
            int sumNotNguyenTo = TongNotNguyenTo(matrix);
            Console.WriteLine("Tong cac so khong phai la nguyen to la: " + sumNotNguyenTo);

            // Cau e: Xóa dòng thứ k trong ma trận
            Console.WriteLine("Nhap dong thu k can xoa: ");
            int k = int.Parse(Console.ReadLine());
            XoaDongThuk(matrix, k);

            // Cau f: Xóa cột chứa phần tử lớn nhất trong ma trận
            int max_colume = findColumeMaxOfMatrix(matrix);
            Console.WriteLine("Sau khi xoa cot thu {0} co phan tu lon nhat: ", max_colume + 1);
            Del_ColumnMaxElement(matrix, max_colume);

            Console.ReadLine();
        }
    }
}
