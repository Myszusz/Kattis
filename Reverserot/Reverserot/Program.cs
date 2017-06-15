using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverserot
{
    class Program
    {
        static void Main(string[] args)
        {
            String pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.";

            String first = Console.ReadLine();
            String[] ar = first.Split(' ');
            int x = int.Parse(ar[0]);
            while (x != 0)
            {

                String s1 = ar[1];
                String s2 = String.Empty;
                String s3 = String.Empty;


                for (int i = 0; i < s1.Length; i++)
                {
                    char l1 = s1[i];
                    int poz = pattern.IndexOf(l1);
                    int poz2 = poz + x;
                    if (poz2 >= 28)
                    {
                        poz2 = poz2 - 28;
                    }
                    char l2 = pattern[poz2];
                    s2 += l2;
                }
                for (int u = s2.Length - 1; u > -1; u--)
                {
                    s3 += s2[u];
                }
                Console.WriteLine(s3);

                first = Console.ReadLine();
                ar = first.Split(' ');
                x = int.Parse(ar[0]);
            }
        }
    }
}
