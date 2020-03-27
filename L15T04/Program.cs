using System;
using System.IO;


namespace L15T04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Luodaan muuttujat, int-tyyppisille luvuille oma ja float-tyyppisille luvuille oma. Lisäksi tehdään string-tyyppinen muuttuja, jolla otetaan talteen syotettä.
            int kokonainenluku;
            float liukuva;
            string luvut;

            // Tehdään muuttujat StreamReaderille.
            string path = "/Users/Korporo/Projektit/ttzc0200/Code/L15T04/bin/Debug/kokonaisluku.txt";
            string osoite = "/Users/Korporo/Projektit/ttzc0200/Code/L15T04/bin/Debug/liukuluku.txt";

            // Luodaan StreamWriterit kokonais- ja liukuluvuille.
            StreamWriter kokonaisLuku = new StreamWriter("kokonaisluku.txt");
            StreamWriter liukuLuku = new StreamWriter("liukuluku.txt");

            
            Console.WriteLine("Syota kokonais- tai liukulukuja ja kun haluat lopettaa kirjoita L");

            // Tehdään doWhile-silmukka missä tarkistetaan käyttäjän syotettä ja sen mukaan kirjoitetaan tekstitiedostoa. Silmukan lopetusehtona käytetään L-kirjainta.
            do
            {
                luvut = Console.ReadLine();
                if (int.TryParse(luvut, out kokonainenluku))
                {
                    kokonaisLuku.Write(kokonainenluku + " ");

                }
                else if (float.TryParse(luvut, out liukuva))
                {
                    liukuLuku.Write(liukuva + " ");
                }

            } while (luvut != "L");

            kokonaisLuku.Close();
            liukuLuku.Close();


            //Luodaan 2 StreamReaderiä, toinen kokonaisluvuille ja toinen liukuluvuille.
            StreamReader reader = new StreamReader(path);
            string input = reader.ReadToEnd();
            Console.WriteLine("Tiedosto sisaltaa luvut: ");
            Console.WriteLine(input);
            reader.Close();

            StreamReader lukija = new StreamReader(osoite);
            string syote = lukija.ReadToEnd();
            Console.WriteLine("Tiedosto sisaltaa liukuluvut: ");
            Console.WriteLine(syote);
            lukija.Close();



            

        }
    }
}
