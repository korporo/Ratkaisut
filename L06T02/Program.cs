using System;

namespace L06T02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Luku1;
            int Luku2;
            int Tulos;

            Console.WriteLine("Anna kokonaisluku");
            Luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonaisluku");
            Luku2 = Convert.ToInt32(Console.ReadLine());

            Tulos = Utils.Subtract(Luku1, Luku2);

            Console.WriteLine("Laskun erotus: {0} ", Tulos);
        }
    }
}
