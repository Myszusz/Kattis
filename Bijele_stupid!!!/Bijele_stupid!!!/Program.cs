using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijele_stupid___
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] foundPieces = Console.ReadLine().Split(' ');
            int nrOfKing = 1 - int.Parse(foundPieces[0]);
            int nrOfQueen = 1 - int.Parse(foundPieces[1]);
            int nrOfRook = 2 - int.Parse(foundPieces[2]);
            int nrOfBishop = 2 - int.Parse(foundPieces[3]);
            int nrOfKnight = 2 - int.Parse(foundPieces[4]);
            int nrOfPawn = 8 - int.Parse(foundPieces[5]);
            Console.WriteLine(nrOfKing + " " + nrOfQueen + " " + nrOfRook + " " + nrOfBishop + " " + nrOfKnight + " " + nrOfPawn);
        }
    }
}
