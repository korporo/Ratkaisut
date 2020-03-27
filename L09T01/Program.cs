using System;

namespace L09T01
{
    enum Days
    {
        Maanantai = 0,
        Tiistai = 1,
        Keskiviikko = 2,
        Torstai = 3,
        Perjantai = 4,
        Lauantai = 5,
        Sunnuntai = 6
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Days.Maanantai);
            Console.WriteLine((int)Days.Maanantai);
        }
    }
}
