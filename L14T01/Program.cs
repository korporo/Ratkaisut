using System;

namespace L14T01
{
    class MainClass
    {
        //Tee ohjelma joka luo System.OverflowException poikkeuksen. Korjaa ohjelma niin ettei se kaadu.

        public static void Main(string[] args)
        {
            checked
            {
                try
                {
                    int numero = 1;
                    int value = int.MaxValue;
                    int result = numero + value;

                    Console.WriteLine("Laskun tulos: {0}", result);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Max value of int has been reached! " + ex.Message);
                }

            }

            
   
        }
    }
}
