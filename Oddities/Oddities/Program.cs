using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            String nrOfLines = Console.ReadLine();
            int nrOfLines1 = int.Parse(nrOfLines);
            for (double i = 0; i < nrOfLines1; i++)
            {
                String num = Console.ReadLine();
                int num1 = int.Parse(num);
                int num2 = num1 % 2;
                if (num2 == 0)
                {
                    Console.WriteLine(num1 + " is even");
                }
                else
                {
                    Console.WriteLine(num1 + " is odd");
                }
            }
        }
    }
}
