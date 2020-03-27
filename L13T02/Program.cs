using System;
using System.Collections.Generic;

namespace L13T02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> korttiPakka = Korttipakka();
            //Tulosta(korttiPakka);
            List<string> shuffledDeck = Shuffle(korttiPakka);
            Tulosta(shuffledDeck);
        }

        private static List<string> Shuffle(List<string>sekPakka)
        {
            Random rand = new Random();

            for (int i = sekPakka.Count -1 ; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                string temp = sekPakka[i];
                sekPakka[i] = sekPakka[j];
                sekPakka[j] = temp;
            }
            return sekPakka;
        }

        private static void Tulosta(List<string> Deck)
        {
            foreach (string Kortit in Deck)
            {
                Console.WriteLine(Kortit);
            }
        }

        public static List<string> Korttipakka()
        {
            List<string> Pakka = new List<string>();



            List<string> Maat = new List<string>();
            Maat.Add("Hearts");
            Maat.Add("Diamonds");
            Maat.Add("Clubs");
            Maat.Add("Spades");

            List<string> Arvo = new List<string>();
            Arvo.Add("Ace");
            Arvo.Add("Two");
            Arvo.Add("Three");
            Arvo.Add("Four");
            Arvo.Add("Five");
            Arvo.Add("Six");
            Arvo.Add("Seven");
            Arvo.Add("Eigth");
            Arvo.Add("Nine");
            Arvo.Add("Ten");
            Arvo.Add("Jack");
            Arvo.Add("Queen");
            Arvo.Add("King");

            foreach (string Maa in Maat)
            {
                foreach (string Arvot in Arvo)
                {

                    string kortti = Arvot + " of " + Maa;
                    Pakka.Add(kortti);
                }
            }
            return Pakka;
        }

    }
}
