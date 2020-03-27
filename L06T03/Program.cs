using System;

namespace L06T03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Luku1;
            int Luku2;
            int Luku3;

            double keskiArvo;

            Console.WriteLine("Anna eka kokonaisluku");
            Luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonaisluku");
            Luku2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna kolmas kokonaisluku");
            Luku3 = Convert.ToInt32(Console.ReadLine());

            keskiArvo = Utils.Average(Luku1, Luku2, Luku3);

            Console.WriteLine("Laskun keskiarvo on: {0:0.0}", keskiArvo);
        }
    }
}
