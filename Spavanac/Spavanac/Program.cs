using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spavanac
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] time = Console.ReadLine().Split(' ');
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);
            minute -= 45;
            if (minute < 0)
            {
                minute += 60;
                hour -= 1;
                if (hour < 0)
                {
                    hour = 23;
                }
            }
            Console.WriteLine(hour + " " + minute);
        }
    }
}
