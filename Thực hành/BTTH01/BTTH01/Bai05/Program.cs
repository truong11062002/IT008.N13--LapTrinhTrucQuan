using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        public static bool checkDate(int year, int month, int day)
        {
            string timeString;
            try
            {
                DateTime time = new DateTime(year, month, day);
                timeString = String.Format("dd/MM/yyyy", time);
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

            if (checkDate(nam, thang, 01))
            {
                DateTime Date = new DateTime(nam, thang, ngay);
                Console.WriteLine("Thu {0} cua ngay {1} thang {2} nam {3}", Date.DayOfWeek, ngay, thang, nam);
            }
            else
            {
                Console.WriteLine("Ngay khong hop le!");
            }

        }
    }
}
