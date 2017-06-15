using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nrOfTests = Console.ReadLine();
            int nrOfTests1 = int.Parse(nrOfTests);
            while (nrOfTests1 != -1)
            {
                int time1 = 0;
                int road = 0;
                for (int i = 0; i < nrOfTests1; i++)
                {
                    string[] speedAndTime = Console.ReadLine().Split(' ');
                    int speed = int.Parse(speedAndTime[0]);
                    int time = int.Parse(speedAndTime[1]);
                    int actualTime = time - time1;
                    time1 = time;
                    road += speed * actualTime;
                }
                Console.WriteLine(road + " miles");
                nrOfTests = Console.ReadLine();
                nrOfTests1 = int.Parse(nrOfTests);
            }
        }
    }
}
