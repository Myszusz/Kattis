using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiizBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            String liczby = Console.ReadLine();
            String[] ar = liczby.Split(' ');
            int x = int.Parse(ar[0]);
            int y = int.Parse(ar[1]);
            int n = int.Parse(ar[2]);

            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
