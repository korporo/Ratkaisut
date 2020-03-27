using System;

namespace L12T03
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] Parillinen;
            Parillinen = new int [9];

            Parillinen[0] = 1;
            Parillinen[1] = 2;
            Parillinen[2] = 33;
            Parillinen[3] = 44;
            Parillinen[4] = 55;
            Parillinen[5] = 68;
            Parillinen[6] = 77;
            Parillinen[7] = 96;
            Parillinen[8] = 100;

            foreach (var item in Parillinen)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("Luku on parillinen: {0}", item);
                }
                else
                {
                    Console.WriteLine("Luku on pariton: {0}", item);
                }
            }

        }
    }
}
