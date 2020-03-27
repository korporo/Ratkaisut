using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace harjoitustyo
{
    // Luodaan struct-rakenne mihin kaikki pelaajaan liittyvät tiedot tallennetaan.
    struct Pelaaja
    {
        public string birthName;
        public string natioNality;
        public int age;
        public int height;
        public int weight;

        public string position;
        public string team;
        public string league;
        public string preferredFoot;
        public int weakFoot;
        public int skillMoves;

        public int pace;
        public int shooting;
        public int passing;
        public int dribbling;
        public int defence;
        public int physical;

        public int overallRating;
        public int kokonaisuus;

        // Tehdään override, millä määritetään tulostuksen muoto ja se missä muodossa se tallennetaan tekstitiedostoon.
        public override string ToString()
        {
            return "\n" + "Personal Info: " +"\n" + "Player name: " + birthName + "\n" +
                "Nationality: " + natioNality + "\n" + "Player age: " + age + "\n" +
                "Height: " + height + "cm" + "\n" + "Weight: " + weight + "kg" + "\n" + "\n" + "Player Info: " + "\n" +
                "Position: " + position + "\n" + "Team: " + team + "\n" + "League: " + league + "\n" +
                "Preferred foot: " + preferredFoot + "\n" + "Weak foot: " + weakFoot + " stars" + "\n" +
                "Skill-moves: " + skillMoves + " stars" + "\n" + "\n" + "Stats: " + "\n" + "Pace: " + pace + "\n" +
                "Shooting: " +  shooting + "\n" + "Passing: " + passing + "\n" + "Dribbling: " + dribbling + "\n" +
                "Defence: " + defence + "\n" + "Physical: " + physical + "\n" + "\n" + "Overall: " + kokonaisuus;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Ohjelmassa kysytään monta kysymystä niin tehdään niistä muuttujia ja lähetetään parametreinä aliohjelmiin.
            // Tällä säästetään aikaa siltä, ettei tarvitse kirjoittaa jokaista kysymystä erikseen ja moneen kertaan.

            string kysymys = "Name: ";
            string kysymys1 = "Nationality: ";
            string kysymys2 = "Age: ";
            string kysymys3 = "Height (in cm): ";
            string kysymys4 = "Weight (in kg): ";
            string kysymys5 = "Position: ";
            string kysymys6 = "Team: ";
            string kysymys7 = "League: ";
            string kysymys8 = "Which one is your preferred foot?: ";
            string kysymys9 = "Rate your weakfoot from 1 to 5 stars: ";
            string kysymys10 = "Rate your skillmoves from 1 to 5 stars: ";
            string kysymys11 = "Rate your pace: ";
            string kysymys12 = "Rate your shooting: ";
            string kysymys13 = "Rate your passing: ";
            string kysymys14 = "Rate your dribbling: ";
            string kysymys15 = "Rate your defence: ";
            string kysymys16 = "Rate your physical: ";

            ConsoleKeyInfo stopCreating;

            // Tehdään koko pakkaus doWhile-silmukan sisään syystä, että käyttäjä saa valita aina ohjelman lopussa tehdäänkö pelaajia lisää vai ei.
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome! Let's create your Fifa 20-UltimateTeam playercard.");
                Console.WriteLine("Let's start by adding your personal info. ");
                Console.WriteLine("");

                //Luodaan streamwriter millä tekstitiedosto tehdään. Ja lisätään "true", ettei tapahdu päällekirjoitusta.
                StreamWriter Kirjuri = new StreamWriter("Pelaaja.txt", true);


                // Täytetään struct-tietueen arvot siten, että annetaan käyttäjän inputista arvot muuttujille. Kysymys ja vastaus periaatteella.
                // Lähetetään aliohjelmakutsu ja annetaan parametrinä kysymys, jossa käyttäjän input tarkistetaan ja palautetaan oikeanlainen arvo yksi kerrallaan.
                Pelaaja Player1;

                Player1.birthName = checkString(kysymys);
                Player1.natioNality = checkString(kysymys1);
                Player1.age = checkInteger(kysymys2);
                Player1.height = checkInteger(kysymys3);
                Player1.weight = checkInteger(kysymys4);
                Console.WriteLine("");
                Console.WriteLine("Next up your player info: ");
                Console.WriteLine("");
                Player1.position = checkString(kysymys5);
                Player1.team = checkString(kysymys6);
                Player1.league = checkString(kysymys7);
                Player1.preferredFoot = checkString(kysymys8);
                Player1.weakFoot = checkInteger(kysymys9);
                Player1.skillMoves = checkInteger(kysymys10);
                Console.WriteLine("");
                Console.WriteLine("And lastly, give your self stats from 1 to 99: ");
                Console.WriteLine("");
                Player1.pace = checkStats(kysymys11);
                Player1.shooting = checkStats(kysymys12);
                Player1.passing = checkStats(kysymys13);
                Player1.dribbling = checkStats(kysymys14);
                Player1.defence = checkStats(kysymys15);
                Player1.physical = checkStats(kysymys16);

                Player1.overallRating = Player1.pace + Player1.shooting + Player1.passing + Player1.dribbling + Player1.defence + Player1.physical;
                Player1.kokonaisuus = Player1.overallRating / 6;

                Console.WriteLine(Player1);
                Console.WriteLine("");

                // Kirjoitetaan tekstitiedostoon Player1 ja sen jälkeen suljetaan kirjuri.
                Kirjuri.Write(Player1 + "\n");
                Kirjuri.Close();


                // Tehdään if-lauseke, ja tehdään se toimimaan niin että lasketaan kaikki 6 annettua statsia yhteen ja jaetaan 6:lla.
                // Siitä saadaan kokonaisuus ja sen avulla saadaan selville harvinaisuus.

                if (Player1.kokonaisuus <= 55)
                {
                    Console.Write("Rarity: Bronze Non-rare");
                }
                else if (Player1.kokonaisuus <= 63)
                {
                    Console.Write("Rarity: Bronze Rare");
                }
                else if (Player1.kokonaisuus <= 73)
                {
                    Console.Write("Rarity: Silver Non-rare");
                }
                else if (Player1.kokonaisuus <= 78)
                {
                    Console.Write("Rarity: Silver Rare");
                }
                else if (Player1.kokonaisuus <= 83)
                {
                    Console.Write("Rarity: Gold Non-Rare");
                }
                else if (Player1.kokonaisuus <= 94)
                {
                    Console.Write("Rarity: Gold Rare");
                }
                else
                {
                    Console.WriteLine("Rarity: You're a legend");
                }

                Console.WriteLine("");

                // Annetaan käyttäjälle mahdollisuus päättää lopetetaanko ohjelman ajo tai mahdollisuus luoda uusi pelaaja.
                Console.WriteLine("Press ESC if you're done creating players or press ENTER to create another one.");
                stopCreating = Console.ReadKey();
            }
            while (stopCreating.Key != ConsoleKey.Escape);
        }
           

        // Tässä aliohjelmassa tarkastetaan käyttäjän syöte ja palautetaan kayttajanInput.
        public static int checkInteger(string kysymys)
        {
            Console.WriteLine(kysymys);
            int kayttajanInput;
            while (!int.TryParse(Console.ReadLine().Trim(),out kayttajanInput))
            {
                Console.WriteLine("You can only give integer numbers. For example: 24");
                Console.WriteLine(kysymys);
            }

            return kayttajanInput;
        }

        // Luodaan aliohjelman kopio ja tehdään overload ja käytetään apuna intin- arvon chekkaukseen.
        public static int checkInteger()
        {
            
            int kayttajanInput;
            while (!int.TryParse(Console.ReadLine().Trim(), out kayttajanInput))
            {
                Console.WriteLine("You can only give integer numbers. For example: 24");
             
            }

            return kayttajanInput;
        }

        // Tässä aliohjelmassa tarkistetaan käyttäjän syöte statseja kysyttäessä ja vaaditaan käyttäjää syöttämään luku 1-99 väliltä.
        // Käytetään apuna toista aliohjelmaa jota kutsutaan ja tarkistetaan, että käyttäjän syöte on edelleen int-luku.
        private static int checkStats(string kysymys)
        {
            Console.WriteLine(kysymys);
            int statsInput;
            while (!int.TryParse(Console.ReadLine().Trim(), out statsInput))
            {
                Console.WriteLine("You can only give integer numbers. For example: 24");
                Console.WriteLine(kysymys);
            }

            while (statsInput < 1 || statsInput > 99)
            {
                    Console.WriteLine("You can only give numbers between 1-99.");
                    Console.WriteLine(kysymys);
                    statsInput = checkInteger();
            }

            return statsInput;
        }


        // Tässä aliohjelmassa tarkastetaan käyttäjän syöte string-tyyppiseen muuttujaan ja palautetaan userInput.
        public static string checkString(string kysymys)
        {
            Console.WriteLine(kysymys);
            string userInput = Console.ReadLine().Trim();

            // Tehdään Regex chekkaus ja tarkistetaan että input sisältää vain aakkosia. Ja pyydetään käyttäjää kirjoittamaan uudelleen mikäli regex ei matchää.
            Regex alphabet = new Regex("^[a-zA-Z ]+$");


            while (!alphabet.IsMatch(userInput))
            {
                Console.WriteLine("You can only use alphabets! Try again.");
                Console.WriteLine(kysymys);
                userInput = Console.ReadLine().Trim();
            }

            return userInput;
        }
    }
}
