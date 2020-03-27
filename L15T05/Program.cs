using System;
using System.IO;

namespace L15T05
{
    struct TvOhjelmat
    {
        public string programName;
        public string channelName;
        public int startTime;
        public int endTime;
        public string infoText;


        public override string ToString()
        {
            return "\n" + "Ohjelman nimi: " + programName + "\n" + "Kanavan nimi: " + channelName + "\n" + "Lahetysaika klo: " + startTime + "-" + endTime + "\n" + "Info: " + infoText + "\n";
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamWriter Sarjat = new StreamWriter("Sarjat.txt");
            string path = "/Users/Korporo/Projektit/ttzc0200/Code/L15T05/bin/Debug/Sarjat.txt";


            TvOhjelmat WlkngDd;
            TvOhjelmat Dxtr;
            TvOhjelmat Pwr;

            WlkngDd.programName = "The Walking Dead";
            WlkngDd.channelName = "Jim";
            WlkngDd.startTime = 23;
            WlkngDd.endTime = 24;
            WlkngDd.infoText = "Joukko eloonjaaneita taistelee selviytymisestaan elavien kuolleiden valtaamassa maailmassa.";
            Sarjat.Write(WlkngDd);

            Dxtr.programName = "Dexter";
            Dxtr.channelName = "Fox";
            Dxtr.startTime = 21;
            Dxtr.endTime = 22;
            Dxtr.infoText = "Dexter pohjautuu Floridalaisen Jeff Lindsayn vangitsevaan romaaniin Dexterin pimeat unet.";
            Sarjat.Write(Dxtr);

            Pwr.programName = "Power";
            Pwr.channelName = "HBO";
            Pwr.startTime = 22;
            Pwr.endTime = 23;
            Pwr.infoText = "Power on Amerikkalainen rikosdraama-sarja.";
            Sarjat.Write(Pwr);

            // Suljetaan kirjuri.
            Sarjat.Close();

            // Tulostetaan ohjelmien tiedot konsoliinöl
            /*Console.Write(WlkngDd);
            Console.Write(Dxtr);
            Console.Write(Pwr);*/

             StreamReader reader = new StreamReader(path);
             string input = reader.ReadToEnd();
             Console.WriteLine("Tiedosto sisaltaa tiedot: ");
             Console.Write(input);
             reader.Close();
           
        }
    }
}
