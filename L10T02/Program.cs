using System;

namespace L10T02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 2;

            int param1;
            int param2;
            int param3;
            int param4;
            int param5;

            Init(num, out param1, out param2, out param3, out param4, out param5);

            Console.WriteLine(param1 + "\n" +  param2 + "\n" + param3 + "\n" + param4 + "\n"+ param5);
        }
        public static void Init( int num, out int param1, out int param2, out int param3, out int param4, out int param5)
        {
            param1 = num * 2;
            param2 = num * 10;
            param3 = num * 100;
            param4 = num * 1000;
            param5 = num * 10000;

        }
    }
}
