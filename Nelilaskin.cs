using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nelilaskin
    {
        public int Plus(int luku1, int luku2)
        {
            return luku1 + luku2;
        }

        private static bool Plus_Test(Nelilaskin nelilaskin)
        {
            bool onnistuukoPlus = true;
            onnistuukoPlus &= nelilaskin.Plus(1, 1) == 2;
            onnistuukoPlus &= nelilaskin.Plus(123, 432) == 555;
            onnistuukoPlus &= nelilaskin.Plus(-2, 4) == 2;
            onnistuukoPlus &= nelilaskin.Plus(2, -4) == -2;

            if (!onnistuukoPlus)
            {
                Console.WriteLine("Ongelmia Nelilaskin-luokan Plus-metodissa");
            }

            return onnistuukoPlus;
        }

        public int Miinus(int luku1, int luku2)
        {
            return luku1 - luku2;
        }

        private static bool Miinus_Test(Nelilaskin nelilaskin)
        {
            bool onnistuukoMiinus = true;
            onnistuukoMiinus &= nelilaskin.Miinus(1, 1) == 0;
            onnistuukoMiinus &= nelilaskin.Miinus(1, 5) == -4;
            onnistuukoMiinus &= nelilaskin.Miinus(234, 212) == 22;

            if (!onnistuukoMiinus)
            {
                Console.WriteLine("Ongelmia Nelilaskin-luokan Miinus-metodissa");
            }

            return onnistuukoMiinus;
        }

        public static bool Nelilaskin_Test()
        {
            Console.WriteLine("Testauksen tulos:");
            
            var nelilaskin = new Nelilaskin();

            bool onnistuuko = true;
            onnistuuko &= Plus_Test(nelilaskin);
            onnistuuko &= Miinus_Test(nelilaskin);
            
            if (onnistuuko)
            {
                Console.WriteLine("Kaikki ok");
            }
            else
            {
                Console.WriteLine("Ei läpäise testiä");
            }

            return onnistuuko;
        }
    }
}
