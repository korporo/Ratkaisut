using System;
using System.IO;

namespace L15T01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string syote = "";

            try
            {

                StreamWriter testi = new StreamWriter("L15T01.txt");
                Console.WriteLine("Kirjoita jotain konsoliin.");
                syote = Console.ReadLine();
                testi.Write(syote);
                testi.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Poikkeus: " +ex.Message);
            }

            Console.WriteLine("");


            try
            {
                string path = "/Users/Korporo/Projektit/ttzc0200/Code/L15T01/bin/Debug/L15T01.txt";
                StreamReader reader = new StreamReader(path);
                string input = reader.ReadToEnd();
                Console.Write("Tiedosto sisaltaa: " + input);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tiedostoa ei loytynyt: " +ex.Message);
            }


  

        }
    }
}
