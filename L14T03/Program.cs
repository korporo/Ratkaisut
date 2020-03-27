using System;

namespace L14T03
{
    class MainClass
    {
        //Tee taulukko jossa on 5 merkkijonoa.
        //Kysy käyttäjältä indeksi mihin kohtaan taulukkoa käyttäjä haluaa syöttää uuden tekstin.
        //Kysy käyttäjältä uusi teksti ja laita se taulukkoon käyttäjän antamaan indeksiin.
        //Tulosta taulukon sisältö.
        //Korjaa ohjelma niin ettei se kaadu jos käyttäjä syöttää indeksin joka on taulukon ulkopuolella.
        //Kerro käyttäjälle mikäli indeksi ei ole kelvollinen ja pyydä syöttämään se uudestaan

        public static void Main(string[] args)
        {
            int muuttuja;
            string teksti;

            string [] Taulukko = new string[5];
            Taulukko[0] = "Kameli";
            Taulukko[1] = "Elefantti";
            Taulukko[2] = "Zeepra";
            Taulukko[3] = "Kirahvi";
            Taulukko[4] = "Alligaattori";

            try
            {
                Console.WriteLine("Anna indeksi valilta 0-4, mihin kohtaan haluat syottaa tekstia.");
                muuttuja = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kirjoita jotain tekstia.");
                teksti = Console.ReadLine();
                Taulukko[muuttuja] = teksti;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Syottamasi luku ei ollut valilta 0-4, yrita uudelleen! " + ex.Message);
                Console.WriteLine("Anna indeksi valilta 0-4, mihin kohtaan haluat syottaa tekstia.");
                muuttuja = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kirjoita jotain tekstia.");
                teksti = Console.ReadLine();
                Taulukko[muuttuja] = teksti;

            }

            foreach (string animals in Taulukko)
            {
                Console.WriteLine(animals);
            }

        }
    }
}
