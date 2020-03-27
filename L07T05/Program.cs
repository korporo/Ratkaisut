using System;

namespace L07T05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Number;

            Console.WriteLine("Anna kokonaisluku");

            do
            {
                Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Annoit numeron: {0}", Number);
            }
            while (Number != 0);
            Console.WriteLine("Painoit 0 ja lopetit ohjelman.");
        }
    }
}
