using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nrOfLines = Console.ReadLine().Split(' ');
            int nrOfLines1 = int.Parse(nrOfLines[0]);
            double output = 0;
            for (double i = 0; i < nrOfLines1; i++)
            {
                String wholeNum = Console.ReadLine();
                char pow = wholeNum[wholeNum.Length - 1];
                double pow1 = (int)Char.GetNumericValue(pow);
                String num = wholeNum.Remove(wholeNum.Length - 1);
                double num1 = int.Parse(num);
                double equal = Math.Pow(num1, pow1);
                output += equal;
            }
            Console.WriteLine(output);
        }
    }
}
