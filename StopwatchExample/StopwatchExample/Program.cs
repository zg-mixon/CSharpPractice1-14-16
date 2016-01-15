using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumbers = new List<int>();
            var rand = new Random();

            for (int i = 0; i < 10000; i++)
            {
                randomNumbers.Add(rand.Next(1000));
            }

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            foreach (var n1 in randomNumbers) {
                Console.WriteLine("{0} has {1} duplicates", n1, randomNumbers.Count(n => n == n1));
            }

            stopwatch.Stop();   
            
            


            Console.WriteLine("Total time was {0} milliseconds", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
