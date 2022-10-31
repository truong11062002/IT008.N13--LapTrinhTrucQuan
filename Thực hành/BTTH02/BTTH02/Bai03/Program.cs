using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            MaTran m1 = new MaTran();
            MaTran m2 = new MaTran();

            // Câu a: Nhập/Xuất ma trận
            Console.WriteLine("Nhap vao ma tran thu nhat: ");
            m1.Nhap();
            Console.WriteLine("Ma tran thu nhat: ");
            m1.display();

            //Console.WriteLine("Nhap vao ma tran thu hai: ");
            //m2.Nhap();
            //Console.WriteLine("Ma tran thu hai: ");
            //m2.display();
            // Câu b: Tìm kiếm một phần tử trong ma trận
            m1.Search();

            // Câu c: Xuất các phần tử là số nguyên tố
            m1.ShowPrimeNumber();

            // Câu d: Dòng có nhiều số nguyên tố nhất
            m1.BestRowPrimeNumber();
            Console.ReadKey();
        }
    }
}
