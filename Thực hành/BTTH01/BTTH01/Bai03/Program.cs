using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        public static bool ktDate(int day,int month,int year)
        {
            try
            {
                DateTime time = new DateTime(year, month, day);
                String.Format("dd/MM/yyyy", time);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            if (ktDate(ngay, thang, nam))
            {
                Console.WriteLine("Ngay hop le!");
            }
            else
            {
                Console.WriteLine("Ngay khong hop le!");
            }

        }
    }
}
