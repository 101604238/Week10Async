using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AsyncClassLibrary;

namespace AsyncConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Asynchronous
            Console.WriteLine(DateTime.Now);

            PrimeNumbers.FindPrime(250000);

            Console.WriteLine(DateTime.Now);

            PrimeNumbers.FindPrime(400000);

            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }
}
