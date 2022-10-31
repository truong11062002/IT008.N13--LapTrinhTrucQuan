using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class MaTran
    {
        private const int SIZE = 50;
        private int _n; // n dòng
        private int _m; // m cột
        private int[,] matrix;

        public int n
        {
            get { return _n; }
            set { _n = value; }
        }
        public int m
        {
            get { return _m; }
            set { _m = value; }
        }

        public MaTran()
        {
            m = 0;
            n = 0;
            matrix = new int[m, n];
        }

        public MaTran(int n, int m)
        {
            if (n >= SIZE || m >= SIZE)
            {
                m = 3;
                n = 3;
                matrix = new int[m, n];
            }
            else
            {
                this.n = n;
                this.m = m;
                matrix = new int[m, n];
            }
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap so hang: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dong: ");
            m = int.Parse(Console.ReadLine());

            matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Phan tu thu [" + (i + 1) + "][" + (j + 1) + "]:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void display()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void Search()
        {
            Console.WriteLine("Nhap phan tu can tim kiem: ");
            int ele = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matrix[i,j] == ele)
                    {
                        Console.WriteLine("Vi tri can tim la [{0}][{1}]",i+1,j+1);
                    }
                }
                
            }
        }


        public bool checkNguyenTo(int ele)
        {
            if (ele < 2)
                return false;

            for (int i = 2; i < ele - 1; i++)
            {
                if (ele % i == 0)
                    return false;
            }
            return true;
        }
        public void ShowPrimeNumber()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (checkNguyenTo(matrix[i,j]))
                    {
                        Console.WriteLine("So nguyen to can tim la: " +  matrix[i,j]);
                    }
                }
            }
        }
        public void BestRowPrimeNumber()
        {
            int count;
            List<int> listPrime = new List<int> { };
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < m; j++)
                {
                    
                    if (checkNguyenTo(matrix[i, j]))
                    {
                        count++;
                    }
                }
                listPrime.Add(count);
                
            }
            int maxValue = listPrime.Max();
            int maxIndex = listPrime.IndexOf(maxValue) + 1;
            Console.WriteLine("Maximum element {0} present at index {1}", maxValue, maxIndex);
        }
    }
}
