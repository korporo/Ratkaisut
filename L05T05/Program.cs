using System;
using System.Text;

namespace L05T05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double euro;
            double sentti;
            double pankkiSaldo = 0;

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Kuinka monta euroa lisätään pankkitilille?");
            euro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kuinka monta senttiä lisätään pankkitilille?");
            sentti = Convert.ToDouble(Console.ReadLine());

            pankkiSaldo = euro + sentti / 100;

            Console.WriteLine("Pankkitilin loppusaldo on {0:0.00}€", pankkiSaldo);



        }
    }
}
