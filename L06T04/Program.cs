using System;

namespace L06T04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal Fuel;
            decimal Price;
            int Length;

            Console.WriteLine("Kuinka paljon bensaa kuluu /100km?");
            Fuel = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Kuinka paljon bensa maksaa /L?");
            Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Kuinka pitka matka on edessa?");
            Length = Convert.ToInt32(Console.ReadLine());

            Utils.CalcConsumption(Fuel, Price, Length);

        }
    }
}
