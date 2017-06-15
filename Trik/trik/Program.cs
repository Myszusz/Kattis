using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trik
{
    class Program
    {
        static void Main(string[] args)
        {
            String allMoves = Console.ReadLine();
            char[] move = allMoves.ToCharArray();
            int correctCup = 1;
            for (int i = 0; i < move.Length; i++)
            {
                switch (move[i])
                {
                    case 'A':
                        if (correctCup == 1)
                        {
                            correctCup = 2;
                        }
                        else if(correctCup == 2)
                        {
                            correctCup = 1;
                        }
                        break;
                    case 'B':
                        if (correctCup == 2)
                        {
                            correctCup = 3;
                        }
                        else if (correctCup == 3)
                        {
                            correctCup = 2;
                        }
                        break;
                    case 'C':
                        if (correctCup == 1)
                        {
                            correctCup = 3;
                        }
                        else if (correctCup == 3)
                        {
                            correctCup = 1;
                        }
                        break;
                }

            }
            Console.WriteLine(correctCup);
        }
    }
}
