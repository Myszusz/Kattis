using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSumOfPoints = 0;
            int winner = 0;
            int winningPoints = 0;
            for (int a = 1; a <= 5; a++)
            {
                string points1 = Console.ReadLine();
                string[] points = points1.Split(' ');
                int sumOfPoints = 0;
                for (int i = 0; i < points.Length; i++)
                {
                    int mark = int.Parse(points[i]);
                    sumOfPoints += mark;
                }
                if (maxSumOfPoints < sumOfPoints)
                {
                    winner = a;
                    winningPoints = sumOfPoints;
                    maxSumOfPoints = sumOfPoints;
                }
            }
            Console.WriteLine(winner + " " + winningPoints);
        }
    }
}
