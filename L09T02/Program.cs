using System;

namespace L09T02
{
    struct Ajoneuvot
    {

        public string Merkki;
        public string Malli;
        public int Kilometrit;
        public int Ika;

    public override string ToString()
    {
        return Merkki + ", " + Malli + ", " + Kilometrit + "km, " + "vm. " + Ika;
    }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Ajoneuvot Auto1;
            Ajoneuvot Auto2;

            Auto1.Merkki = "Audi";
            Auto1.Malli = "A4 Allroad";
            Auto1.Kilometrit = 200000;
            Auto1.Ika = 2010;

            Auto2.Merkki ="Toyota";
            Auto2.Malli = "Avensis";
            Auto2.Kilometrit = 225000;
            Auto2.Ika = 2003;

            Console.WriteLine(Auto1);
            Console.WriteLine(Auto2);
        }

    }
}
