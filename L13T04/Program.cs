using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace L13T04
{
    struct Elokuvat
    {
        public string movieName;
        public string directorName;
        public int anniversary;

    }
    // 10000 Elokuvan luomiseen menee 140 millisekuntia ja 1000 etsimiseen elokuvan nimen perusteella menee n. 700-800 millisekuntia kun käytetään List-rakennetta.
    // 10000 Elokuvan luomiseen menee keskimäärin 800-900 millisekuntia ja 1000 etsimiseen elokuvan nimen perusteella menee n. 10 millisekuntia kun käytetään Dictionary-rakennetta.
    class MainClass
    {
        // Luodaan randomi jota käytetään
       public static Random rnd = new Random();


        public static void Main(string[] args)
        {
            // Käynnistetään ajastin
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Luodaan lista mihin tallennetaan elokuvat
           List<Elokuvat> Movies = new List<Elokuvat>();


            // Luodaan for-silmukka, jossa elokuvat luodaan 10000 kertaa.
            for (int i = 0; i < 10000; i++)
            {
               Movies.Add(luoElokuva());
            }

            // Otetaan kulunut aika talteen
            stopwatch.Stop();
            long milliSec = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} milliseconds", milliSec);

            stopwatch.Restart();


             for (int i = 0; i < 1000; i++)

             {
                    etsiSana(Movies, LuoSana());
             }


            stopwatch.Stop();
            
            Console.WriteLine("Time elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);

            stopwatch.Start();

            Dictionary<string, Elokuvat> Movies2 = new Dictionary<string, Elokuvat>();

            for (int i = 0; i <10000; i++)
            {
                Elokuvat elokuva = luoElokuva();
                Movies2.Add(elokuva.movieName, elokuva);
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();

            for (int i = 0; i <1000; i++)
            {
                string title = LuoSana();
                if (Movies2.ContainsKey(title))
                {
                    Console.WriteLine("Elokuvan nimi: {0} Elokuvan ohjaaja: {1}, Vuosiluku: {2}", Movies2[title].movieName, Movies2[title].directorName, Movies2[title].anniversary);

                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);


        }

        // Luodaan aliohjelma jossa verrataan Movies listassa olevien elokuvien nimiin random sanaa.
        private static void etsiSana(List<Elokuvat> movies, string rndNimi)
        {
            foreach (var Elokuva in movies)
            {
                if (rndNimi == Elokuva.movieName)
                {
                    Console.WriteLine("Elokuvan nimi: {0} Elokuvan ohjaaja: {1}, Vuosiluku: {2}", Elokuva.movieName, Elokuva.directorName, Elokuva.anniversary);

                }
            }
        }

        //Luodaan elokuva ja tulostetaan elokuvan tiedot ja palautetaan arvona Elokuva mainiin.
        private static Elokuvat luoElokuva()
        {
            Elokuvat Elokuva;
            Elokuva.movieName = LuoSana();
            Elokuva.directorName = LuoSana();
            Elokuva.anniversary = rnd.Next(1900, 2020);

            // Console.WriteLine("Elokuvan nimi: {0} Elokuvan ohjaaja: {1}, Vuosiluku: {2}", Elokuva.movieName, Elokuva.directorName, Elokuva.anniversary);
            return Elokuva;
        }

        // Aliohjelmassa luodaan sana. Tehdään for-silmukka missä sanoista tehdään erilaisia. Ja lopuksi palautetaan Name.
        private static string LuoSana()
        {

            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q","r","s","t","v","w","x","z"};
            string[] vowels = { "a", "e", "i", "o", "u", "y" };
            string Name = "";


            Name = Name + consonants[rnd.Next(consonants.Length)].ToUpper();
            Name = Name + vowels[rnd.Next(vowels.Length)];


            for (int i = 0; i < rnd.Next(2, 8); i++)
            {
                Name += consonants[rnd.Next(consonants.Length)];
                Name += vowels[rnd.Next(vowels.Length)];
            }
            return Name;
        }
    }
}
