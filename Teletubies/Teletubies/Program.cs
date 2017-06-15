using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubies
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("teleName.txt"))
            {
                string content = File.ReadAllText("teleName.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
                Console.WriteLine("Please enter new constent for the file:");
                string newContent = Console.ReadLine();
                File.WriteAllText("teleName.txt", newContent);
            }
            else
            {
                Teletuby t1 = new Teletuby("Tinkywinky", 16);
                t1.ShoutInfo();
                Teletuby t2 = new Teletuby("Dipsy", 15);
                t2.ShoutInfo();
                var t3 = new Teletuby("Lala", 14);
                t3.ShoutInfo();
                var t4 = new Teletuby("Po", 13);
                t4.ShoutInfo();
            }
            Teletuby.Hugsy();
        }
    }
}
