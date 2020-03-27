using System;
using System.IO;


namespace L15T02
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Luodaan StreamWriter nimeltään testeri ja tehdään nimi-tiedosto taulukkoon ja foreachin avulla tiedostot kirjoitetaan
            // tekstitiedostoon L15T02.txt.
            try
            {
                string path = "/Users/Korporo/Projektit/ttzc0200/Code/L15T02/bin/Debug/L15T02.txt";

                StreamWriter testeri = new StreamWriter("L15T02.txt");

                string[] Nimet = { "Aku", "Adrian", "Nikolai", "Riku", "Jaakko", "Marko", "Tuomas" };

                foreach (var Names in Nimet)
                {
                    testeri.WriteLine(Names);
                }
                testeri.Close();

            // Luodaan Streamreader, jolla tekstitiedosto luetaan alusta loppuun, samalla tarkistetaan montako yksittäistä nimeä teksti-
            // tiedostosta ylipäätään löytyy.

                StreamReader reader = new StreamReader(path);
                string input = reader.ReadToEnd();
                Console.WriteLine("Tiedosto sisaltaa nimet: " + input);
                Console.WriteLine("Tiedostosta loytyy {0} nimea.", Nimet.Length);
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Poikkeus: "+ ex.Message);
            }


            // Tarkistetaan mikäli tiedosto löytyy.
            try
            {
                if (File.Exists("L15T02.txt"))
                {
                    Console.WriteLine("Tiedosto loytyy.");
                }
                else
                {
                    Console.WriteLine("Tiedostoa ei loydy.");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Poikkeus: " + ex.Message);
            }

            Console.WriteLine("");

        }
    }
}
