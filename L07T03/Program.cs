using System;

namespace L07T03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Number;

            Console.WriteLine("Anna kokonaisluku");
            Number = Convert.ToInt32(Console.ReadLine());

            switch (Number)
            {
                case 10:
                case 20:
                    Console.WriteLine("Number is 10 or 20");
                    break;

                case 100:
                case 200:
                    Console.WriteLine("Number is 100 or 200");
                    break;
                default:
                    Console.WriteLine("Antamasi numero on: {0}", Number);
                    break;
            }
        }
    }
}
