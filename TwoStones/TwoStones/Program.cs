using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStones
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] ar = Console.ReadLine().Split(' ');
            int x = int.Parse(ar[0]);
            if (x % 2 == 1)
            {
                Console.WriteLine("Alice");
            }
            else
            {
                Console.WriteLine("Bob");
            }
        }
    }
}
