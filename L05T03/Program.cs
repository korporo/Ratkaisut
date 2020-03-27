using System;

namespace L05T03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Luku1;
            int Luku2;

            Console.WriteLine("Anna kokonaisluku");
            Luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonaisluku");
            Luku2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yhteenlaskettu summa on: {0}" , Luku1 + Luku2);

        }
    }
}
