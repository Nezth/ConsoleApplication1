using System;


namespace ConsoleApplication1
{
    class Program
    {
        // Dette program er fjollet
        static void Main(string[] args)
        {

            Console.WriteLine("Hvad er dit navn? ");
            string navn = Console.ReadLine();

            Console.WriteLine("Du er: ");
            Console.WriteLine(navn);

            /*
             * Opgave 1a
             * 
             * Udvid dette program til at spoerge om navn, alder og 
             * Naar alle ting er indtastet skal programmet skrive det tilbage til brugeren!
             */
            Console.WriteLine("Hvor gammel er du? ");
            string alder = Console.ReadLine();
            int iAlder;
            // since this is c#, we can do this check, since it checks from left to right
            while (!int.TryParse(alder, out iAlder) && iAlder >= 0)
            {
                Console.WriteLine("Din alder skal være et heltal");
                Console.WriteLine("Hvor gammel er du? ");
                alder = Console.ReadLine();
            }
            Console.WriteLine("Hej {0}, du er {1} aar", navn, iAlder);
            Console.ReadKey();
        }
    }
}
