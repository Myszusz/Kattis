using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fullSet = ("1 1 2 2 2 8").Split(' ');
            String[] foundPieces = Console.ReadLine().Split(' ');
            int[] missingPieces = new int[foundPieces.Length];
            for (int i = 0; i < fullSet.Length; i++)
            {
                int fullSetNr = int.Parse(fullSet[i]);
                int foundPiecesNr = int.Parse(foundPieces[i]);
                missingPieces[i] = fullSetNr - foundPiecesNr;
                Console.Write(missingPieces[i] + " ");
            }
        }
    }
}
