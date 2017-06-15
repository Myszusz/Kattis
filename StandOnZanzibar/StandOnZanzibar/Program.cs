using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandOnZanzibar
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNrTestu = int.Parse(Console.ReadLine());
            for (int nrTestu = 0; nrTestu < maxNrTestu; nrTestu++)
            {
                String[] arTest = Console.ReadLine().Split(' ');
                int sumImp = 0;
                for (int i = 0; i < arTest.Length - 2; i++)
                {
                    int ni = int.Parse(arTest[i]);
                    int ni1 = int.Parse(arTest[i + 1]);
                    int impi = ni1 - 2 * ni;
                    if (impi > 0)
                    {
                        sumImp += impi;
                    }
                }
                Console.WriteLine(sumImp);
            }
        }
    }
}
