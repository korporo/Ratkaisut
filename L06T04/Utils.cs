using System;

namespace L06T04
{
    public class Utils
    {
        public static void CalcConsumption(decimal gasoline, decimal cost, int distance )
        {
            decimal kulutus = gasoline / 100 * distance;
            decimal hinta = kulutus * cost;


            Console.WriteLine("Autosi kuluttaa: {0:0.00}" , kulutus);
            Console.WriteLine("Bensaan kulunut raha: {0:0.00}", hinta);
        }
    }
}
