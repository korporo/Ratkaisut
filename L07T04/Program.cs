using System;

namespace L07T04
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int Points;

            Console.WriteLine("Anna pistemaara");
            Points = Convert.ToInt32(Console.ReadLine());

            switch (Points)
            {
                case 0:
                case 1:
                    Console.WriteLine("Arvosanasi on 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Arvosanasi on 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Arvosanasi on 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Arvosanasi on 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Arvosanasi on 4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Arvosanasi on 5");
                    break;
            }
        }
    }
}
