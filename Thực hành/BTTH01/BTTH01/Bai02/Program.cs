using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int Tong = TongNguyenTo(n, arr);
            Console.WriteLine("Tong nguyen to < n la: {0}", Tong);
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

        public static int TongNguyenTo(int n, int[] arr)
        {
            int s = 0;
            for(int i = 0; i < n - 1; i++)
            {
                if (checkNguyenTo(arr[i]) == true)
                {
                    s += arr[i];
                }
            }
            return s;
        }
    }
}
