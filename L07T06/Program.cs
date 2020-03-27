using System;

namespace L07T06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int karkausVuosi;

            Console.WriteLine("Anna vuosiluku");
            karkausVuosi = Convert.ToInt32(Console.ReadLine());

            if ((karkausVuosi % 4 == 0 && karkausVuosi % 100 != 0) || (karkausVuosi % 400 == 0))
            {
                Console.WriteLine("{0} on karkausvuosi", karkausVuosi);
            }
            else
            {
                Console.WriteLine("{0} ei ole karkasvuosi", karkausVuosi);
            }
        }
    }
}
