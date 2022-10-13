using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
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
            Console.WriteLine("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            if (checkDate(nam, thang, 01))
            {
                // Lấy ngày từ tháng và năm đã được nhập vào
                int days = DateTime.DaysInMonth(nam, thang);
                Console.WriteLine("So ngay cua thang {0} nam {1} la: {2}", thang, nam, days);
            }
            else
            {
                Console.WriteLine("Ngay khong hop le!");
            }

        }
    }
}
