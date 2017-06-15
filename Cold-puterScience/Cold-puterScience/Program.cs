using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cold_puterScience
{
    class Program
    {
        static void Main(string[] args)
        {
            String arLenght = Console.ReadLine();
            int arLenght1 = int.Parse(arLenght);
            String[] temperatureAr = Console.ReadLine().Split(' ');
            int output = 0;
            for (int i = 0; i < arLenght1; i++)
            {
                int temperatureAr1 = int.Parse(temperatureAr[i]);
                if (temperatureAr1 < 0)
                {
                    output += 1;
                }
            }
            Console.WriteLine(output);
        }
    }
}
