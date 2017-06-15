using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixed_Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int numerator = int.Parse(array[0]);
            int denominator = int.Parse(array[1]);
            while (denominator != 0 && numerator != 0)
            {
                int restFromDv = numerator % denominator;
                int numerator1 = numerator - restFromDv;
                int wholeNr = numerator1 / denominator;
                Console.WriteLine(wholeNr + " " + restFromDv + " " + "/" + " " + denominator);
                string[] array1 = Console.ReadLine().Split(' ');
                numerator = int.Parse(array1[0]);
                denominator = int.Parse(array1[1]);
            }
        }
    }
}
