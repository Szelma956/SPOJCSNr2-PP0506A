using System;
using System.Collections.Generic;

namespace PP0506A
{

    class Punkt : IComparable<Punkt>
    {

        private string nazwa;
        private int x;
        private int y;

        public Punkt(string nazwa, int x, int y)
        {

            this.nazwa = nazwa;
            this.x = x;
            this.y = y;

        }

        public override string ToString()
        {
            return nazwa + " " + x + " " + y;
        }

        public static Punkt Parse(string str)
        {

            string[] tabstr = str.Split(" ");
            string nazwa = tabstr[0];
            int x = int.Parse(tabstr[1]);
            int y = int.Parse(tabstr[2]);

            return new Punkt(nazwa, x, y);

        }

        public double OdlegloscOdSrodka()
        {

            int kwadratx = x * x;
            int kwadraty = y * y;
            int suma = kwadratx + kwadraty;
            return Math.Sqrt(suma);

        }

        public int CompareTo(Punkt other)
        {
            if (other == null)
            {
                return 1;
            }

            double daneWyjsciowe = this.OdlegloscOdSrodka() - other.OdlegloscOdSrodka();

            if (daneWyjsciowe > 0)
            {
                return 1;
            }
            else if (daneWyjsciowe < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int lt = int.Parse(Console.ReadLine());

            for (int i = 0; i < lt; i++)
            {
                WykonajTest();



            }
        }

        public static void WykonajTest()
        {

            int lp = int.Parse(Console.ReadLine());
            List<Punkt> listaPunktow = new List<Punkt>();
            for (int i = 0; i < lp; i++)
            {
                Punkt punkt = Punkt.Parse(Console.ReadLine());
                listaPunktow.Add(punkt);

            }

            listaPunktow.Sort();

            foreach (Punkt punkt in listaPunktow)
            {
                Console.WriteLine(punkt);

            }

            Console.ReadLine();


        }
    }
}
