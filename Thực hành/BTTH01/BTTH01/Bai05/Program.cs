﻿using System;
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
                DateTime dt = new DateTime(nam, thang, ngay);
                Console.WriteLine("Ngay {0} thang {1} nam {2} la thu: {3}",ngay,thang,nam, dt.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Ngay khong hop le!");
            }

        }
    }
}
