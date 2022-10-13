using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // Random ngẫu nhiên
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(20);
                Console.WriteLine(arr[i]);
            }

            // Câu a: Tính tổng các số lẻ trong mảng
            int TongSoLe = TongLe(n, arr);
            Console.WriteLine("Tong so le: " + TongSoLe);

            // Câu b: Đếm số nguyên tố trong mảng
            int SLNguyenTo = TongNguyenTo(n, arr);
            Console.WriteLine("So luong nguyen to la: {0}", SLNguyenTo);

            // Câu c: Tìm số chính phương nhỏ nhất
            findMinChinhPhuong(n, arr);
            Console.ReadLine();
        }

        public static bool checkLe(int n)
        {
            if (n % 2 == 1)
                return true;
            return false;
        }

        public bool checkChan(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
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

        public static int TongLe(int n, int[] arr)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (checkLe(arr[i]))
                {
                    s += arr[i];
                }
            }
            return s;
        }
        public static int TongNguyenTo(int n, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (checkNguyenTo(arr[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool checkChinhPhuong(int n, int[] arr)
        {
            for (int i = 1; i * i <= n; i++)
                if (i * i == n)
                    return true;
            return false;
        }

        public static void findMinChinhPhuong(int n, int[] arr)
        {
            Array.Sort(arr);
            int[] cp = new int[n];
            int minCP = 0;
            for (int i = 0; i < n; i++)
            {
                if (checkChinhPhuong(n, arr))
                {
                    minCP = arr[i];
                    break;
                }
            }
            if (minCP == 0)
            {
                Console.WriteLine("Khong co so chinh phuong");
            }
            else
            {
                Console.WriteLine("So chinh phuong nho nhat mang: " + minCP);
            }
        }
    }
}
