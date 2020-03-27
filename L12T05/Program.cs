using System;

namespace L12T05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] Numero = new int[10];
            Random Num = new Random();

            for (int i = 0; i <Numero.Length; i++)
            {
                Numero[i] = Num.Next(minValue: 1, maxValue: 100);
            }

            Array.Sort(Numero);
            Array.Reverse(Numero);
            foreach (var Number in Numero)
            {
                Console.WriteLine(Number);
            }
        }
    }
}
