using System;

namespace L12T04
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            int Luku1, Luku2, Luku3, Luku4, Luku5;
            int pieninLuku;
            int suurinLuku;
            int Yhteispisteet;
            int Tyylipisteet;
            int keskiArvo;
            int Keskiarvo;

            Console.WriteLine("Tuomari 1 anna pisteet");
            Luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tuomari 2 anna pisteet");
            Luku2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tuomari 3 anna pisteet");
            Luku3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tuomari 4 anna pisteet");
            Luku4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tuomari 5 anna pisteet");
            Luku5 = Convert.ToInt32(Console.ReadLine());

            pieninLuku = Pienin(Luku1, Luku2, Luku3, Luku4, Luku5);
            suurinLuku = Suurin(Luku1, Luku2, Luku3, Luku4, Luku5);
            Yhteispisteet = Luku1 + Luku2 + Luku3 + Luku4 + Luku5;
            Keskiarvo = Yhteispisteet / 5;
            Tyylipisteet = Yhteispisteet - pieninLuku - suurinLuku;
            keskiArvo = Tyylipisteet / 3;

            Console.WriteLine("Lopulliset yhteispisteesi ovat: {0}", Tyylipisteet);
            Console.WriteLine("Pisteiden lopullinen keskiarvo on: {0:0.0}", keskiArvo);




        }

        private static int Suurin(int luku1, int luku2, int luku3, int luku4, int luku5)
        {
            int suurinLuku = Math.Max(luku1,luku2);
            suurinLuku = Math.Max(suurinLuku, luku3);
            suurinLuku = Math.Max(suurinLuku, luku4);
            suurinLuku = Math.Max(suurinLuku, luku5);
            return suurinLuku;
        }

        private static int Pienin(int luku1, int luku2, int luku3, int luku4, int luku5)
        {
            int pieninLuku = Math.Min(luku1, luku2);
            pieninLuku = Math.Min(pieninLuku, luku3);
            pieninLuku = Math.Min(pieninLuku, luku4);
            pieninLuku = Math.Min(pieninLuku, luku5);
            return pieninLuku;
        }
    }
}
