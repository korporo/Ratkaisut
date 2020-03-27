using System;

namespace L05T04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Luku1;
            int Luku2;

            Console.WriteLine("Anna ensimmäinen kokonaisluku");
            Luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonaisluku");
            Luku2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annettujen lukujen summa on: {0}", Luku1 + Luku2);
            Console.WriteLine("Annettujen lukujen erotus on: {0}", Luku1 - Luku2);
            Console.WriteLine("Annettujen lukujen tulo on: {0}", Luku1 * Luku2);
            Console.WriteLine("Annettujen lukujen jakolaskun tulos on: {0}", Luku1 / Luku2);
        }
    }
}
