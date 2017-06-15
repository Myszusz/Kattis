using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrassSeedInc
{
    class Program
    {
        static void Main(string[] args)
        {
            double costOfMeter = double.Parse(Console.ReadLine());
            double nrOfLawns = double.Parse(Console.ReadLine());
            double fullCost = 0;
            for (int i = 0; i < nrOfLawns; i++)
            {
                String[] measures = Console.ReadLine().Split(' ');
                double width = double.Parse(measures[0]);
                double lenght = double.Parse(measures[1]);
                double thisLawnMeasure = width * lenght;
                fullCost += thisLawnMeasure * costOfMeter;
            }
            Math.Round(fullCost, 10^-6);
            Console.WriteLine(fullCost);
        }
    }
}
