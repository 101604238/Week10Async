using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncClassLibrary;

namespace SyncConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Synchronous
            Console.WriteLine(DateTime.Now);

            var task = PrimeNumbers.FindPrimeNumbersSync(250000);
            Console.WriteLine(task);

            Console.WriteLine(DateTime.Now);

            var task1 = PrimeNumbers.FindPrimeNumbersSync(400000);
            Console.WriteLine(task1);

            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }
}
