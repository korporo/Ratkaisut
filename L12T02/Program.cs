using System;

namespace L12T02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int vastaus;

            Console.WriteLine("Kuinka monta kokonaislukua luodaan?");
            vastaus = Convert.ToInt32(Console.ReadLine());

            int[] Kokonaisluku;
            Kokonaisluku = new int[vastaus];


            Console.WriteLine("");

            for (int i = 0; i < vastaus; i++)
            {
                Kokonaisluku[i] = i + 10;
                Console.WriteLine(Kokonaisluku[i]);
            }

            Console.WriteLine("");

            Console.WriteLine("Kaanteinen jarjestys");
            Console.WriteLine("\n");

            Array.Reverse(Kokonaisluku);

            for (int i = 0 ; i < vastaus; i++)
            {
                Console.WriteLine(Kokonaisluku[i]);
            }

        }
    }
}
