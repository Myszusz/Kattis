using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubies
{
    class Teletuby
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void ShoutInfo()
        {
            Console.WriteLine("Hello i'm {0} and i'm {1} years old.", Name, Age);
        }
        static public void Hugsy()
        {
            Console.WriteLine("Hugsies for everyone");
        }
        public int Age;
        public Teletuby(string name, int age)
        {
            Name = name;
            Age = age;
            if (Teletuby.arTeletuby[0] == null)
            {
                Teletuby.arTeletuby[0] = this;
            }
        }
        static public Teletuby[] arTeletuby = new Teletuby[4];
    }
}
