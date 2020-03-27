using System;

namespace L05T02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int pituus;

            Console.WriteLine("Tervehdys! Kuinka pitkä olet senttimetreinä?");
            pituus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pituus + " cm ");


        }
    }
}
