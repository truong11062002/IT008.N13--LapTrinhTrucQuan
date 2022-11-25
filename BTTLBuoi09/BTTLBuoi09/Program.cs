using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTTLBuoi09
{
    class Program
    {
        public static long a = 1000000000;
        public static long counter = 0;
        public static object x = new object();
        public static void Main(string[] args)
        {


            Thread myThread1 = new Thread(new ThreadStart(thread_1));
            Thread myThread2 = new Thread(new ThreadStart(thread_1));

            myThread1.Start();
            myThread2.Start();

            myThread1.Join();
            myThread2.Join();

            Console.WriteLine(counter);
            Console.ReadKey();
        }

        public static bool checkNguyenTo(long n)
        {
            if (n < 2)
                return false;

            for (long i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void thread_1()
        {
            for (long i = 0; i < 100000; i++)
            {
                lock(x)
                {
                    counter += 1;
                }
                
            }

        }

       
    }

    
}
