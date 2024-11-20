namespace Grupp_12_labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flightHours = 7;
            int flightMinutes = 25;
            int departureHourFromNY = 10;
            int departureMinuteFromNY = 10;
            int departureHourSTHLM = 14;
            int departureMinuteSTHLM = 03;
            int timeDifferenceHours = 6;
            
            /*
            Given data är avgångstid, restiden och tidsskillnaden:
            Det tar 7 timmar och 25 minuter att flyga sträckan enkel resa
            Avgångstiden från New York är 10:10
            Avgångstiden från Stockholm är 14:03
            Tidsskillnaden är 6 timmar
            */

            Console.WriteLine("********************************************************************");
            Console.WriteLine();
            Console.WriteLine("Välkommen till flygtidsberäknaren");
            Console.WriteLine();
            Console.WriteLine("Vilket flyg vill du se detaljerad information om? (svara med siffra)");
            Console.WriteLine("1. Stockholm - New York");
            Console.WriteLine("2. New York - Stockholm");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Skriv ditt val här:"); 
            string userChoice = Console.ReadLine();

            if (userChoice = 1);
                { 
                Console.WriteLine();

                }
        }
    }
}
