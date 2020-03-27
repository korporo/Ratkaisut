    using System;

namespace L10T01
{
    struct Vehicle
    {
        public string Name;
        public int ModelYear;
        public int Efficiency;

        public override string ToString()
        {
            return Name + ", " + ModelYear + ", " + Efficiency;
        }
    }

    class MainClass
    {

        public static void Main(string[] args)
        {
            Vehicle Toyota;

            Toyota.Name = "Mobiili";
            Toyota.ModelYear = 2004;
            Toyota.Efficiency = 40;

            CheckEfficiency(ref Toyota);
            Console.WriteLine(Toyota);
        }




        public static void CheckEfficiency(ref Vehicle ajoneuvo)
        {
            if (ajoneuvo.ModelYear <= 1990)
            {
                ajoneuvo.Efficiency = 10;
            }
            else if (ajoneuvo.ModelYear <= 2010)
            {
                ajoneuvo.Efficiency = 50;
            }
            else
            {
                ajoneuvo.Efficiency = 100;
            }
        }
    }
}