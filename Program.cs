using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Nelilaskin.Nelilaskin_Test())
            {
                Nelilaskin nelilaskin = new Nelilaskin();

                Console.WriteLine("Lasketaan laskuja:");
                Console.WriteLine("Kaksi plus kolme on " + nelilaskin.Plus(2, 3));
                Console.WriteLine("Neljä miinus viisi on " + nelilaskin.Miinus(4, 5));
                //testataan
            }

            Console.ReadLine();
        }
    }
}
