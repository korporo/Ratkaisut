using System;
using System.Collections.Generic;

namespace L13T03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Luodaan jono ja lisätään jonottajia
            Queue<int> Customers = new Queue<int>();

            Customers.Enqueue(1);
            Customers.Enqueue(2);
            Customers.Enqueue(3);
            Customers.Enqueue(4);
            Customers.Enqueue(5);
            Customers.Enqueue(6);
            Customers.Enqueue(7);
            Customers.Enqueue(8);
            Customers.Enqueue(9);
            Customers.Enqueue(10);

            //Luodaan toinen jono johon tyytymättömät asiakkaat siirtyvät
            Queue<int> Service = new Queue<int>();



            // Luodaan while-silmukan sisäisen if-ehtolause, mikäli asiakas on 
            // tyytyväinen palveluun hän poistuu jonosta ja mikäli asiakas
            // ei ole tyytyväinen hän menee jonottamaan asiakaspalvelu-jonoon.


            while (Customers.Count != 0)
            {
                Console.WriteLine("Were you happy with the customer service? Type Yes if you were.");

                string Yes = Console.ReadLine();

                if (Yes == "Yes")
                {
                    Customers.Dequeue();
                    Console.WriteLine("Thank you and please come again!");
                    Console.WriteLine("Customers on the line: {0}", Customers.Count);
                    Console.WriteLine("");

                }
                else
                {
                    Customers.Dequeue(); // Asiakkaat poistuvat kassajonosta
                    Service.Enqueue(1); // Mutta jono kasvaa asiakaspalvelu-kassalla.

                    Console.WriteLine("We are happy to help you whatever the problem is.");
                    Console.WriteLine("Customers on the line: {0}", Service.Count);
                    Console.WriteLine("First in queue is: {0}", Service.Peek());
                    Console.WriteLine("");
                }

                // Toinen While-silmukka joka pyörii kunnes jono Asiakaspalvelu-kassalla on tyhjä.
                while (Service.Count != 0)
                {

                    Console.WriteLine("Did you get your problem solved? Type Yep if you did.");
                    string Yep = Console.ReadLine();

                    if (Yep == "Yep")
                    {
                        Service.Dequeue();
                        Console.WriteLine("We are happy that we assisted you with the problem in hand.");
                        Console.WriteLine("");
                    }
                }
            }

        }
    }
}
