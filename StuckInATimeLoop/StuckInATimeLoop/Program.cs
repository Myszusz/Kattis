using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] ar = Console.ReadLine().Split(' ');
            int n = int.Parse(ar[0]);
            for (int v = 1; v <= n; v++)
            {
                Console.WriteLine(v + " Abracadabra");
            }
        }
    }
}
