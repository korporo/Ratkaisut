using System;

namespace L07T01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int ika;

            Console.WriteLine("Kuinka vanha olet?");
            ika = Convert.ToInt32(Console.ReadLine());

            if (ika <=13)
            {
                Console.WriteLine("Child");
            }
            else if (ika <=19)
            {
                Console.WriteLine("Teen");
            }
            else if (ika <=65)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior");
            }
        }
    }
}
