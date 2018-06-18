using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AsyncClassLibrary;

namespace MultiThreadedConsoleApp
{
    public class Program
    {
        public class MyThread
        {
            public static void Thread1()
            {
                Console.WriteLine("Thread1 {0}", PrimeNumbers.FindPrimeNumbersSync(250000));
            }

            public static void Thread2()
            {
                Console.WriteLine("Thread2 {0}", PrimeNumbers.FindPrimeNumbersSync(400000));
            }
        }
        public static void Main(string[] args)
        {
            //Mulit Threaded
            Thread tid1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread tid2 = new Thread(new ThreadStart(MyThread.Thread2));

            Console.WriteLine(DateTime.Now);
            tid1.Start();
            Console.WriteLine(DateTime.Now);
            tid2.Start();
            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }
}
