using System;

namespace L07T02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Luku1;
            int Luku2;
            int Luku3;

            Console.WriteLine("Anna kokonaisluku");
            Luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonaisluku");
            Luku2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna kolmas kokonaisluku");
            Luku3 = Convert.ToInt32(Console.ReadLine());

            if (Luku1 > Luku2 && Luku1 > Luku3)
            {
                Console.WriteLine("Eka kokonaisluku on isoin: {0}", Luku1);
            }
            else if (Luku2 > Luku1 && Luku2 > Luku3)
            {
                Console.WriteLine("Toinen kokonaisluku on isoin: {0}", Luku2);
            }
            else if (Luku3 > Luku1 && Luku3 > Luku2)
            {
                Console.WriteLine("Kolmas kokonaisluku on isoin: {0}", Luku3);
            }
        }
    }
}
