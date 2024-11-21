namespace Grupp_12_labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Flygtidskonstanter, Flygtid i timmar och minuter, samt tidsskillnaden.
            const int flightHours = 7;
            const int flightMinutes = 25;
            const int timeDifferenceHours = 6;
            
            // Variabler för tiden då flygen avgår 
            int departureHourFromNY = 10;
            int departureMinuteFromNY = 10;
            int departureHourFromSTHLM = 14;
            int departureMinuteFromSTHLM = 03;
        while (true)
        {
            // Välkomstmeddelande och användaren får instruktioner
            Console.WriteLine("******************************************************************* \n\n" +
                "välkommen till flygtidsberäknaren!\n\n" + "vilket flyg vill du se detaljerad information om (svara i siffror) \n" +
                "1. Stockholm - New York \n" + "2. New York - Stockholm \n" + "3. Avsluta programmet\n");
            Console.Write("Skriv in ditt val här:");
            string userChoice = Console.ReadLine();

            // If-sats ifall användaren väljer 1, för att visa information om flyg från Stockholm till New York
            if (userChoice == "1")
            {

                int arrivalHour = (departureHourFromSTHLM + flightHours - timeDifferenceHours) % 24;
                int arrivalMinute = departureMinuteFromSTHLM + flightMinutes;

                if (arrivalMinute >= 60)
                {
                    arrivalMinute = 60;
                    arrivalHour = (arrivalHour + 1) % 24;
                }

                Console.WriteLine("\n************************************************************************\n\n");
                Console.WriteLine($"Avgångstid från Stockholm: {departureHourFromSTHLM:00}:{departureMinuteFromSTHLM:00}");
                Console.WriteLine($"Ankomsttid i New York: {arrivalHour:00}:{arrivalMinute:00}");
                Console.WriteLine("\n\n************************************************************************");
                break;
            }

            // If-sats ifall användaren väljer 2, för att visa information om flyg från New York till Stockholm.
            else if (userChoice == "2") 
            {

                int arrivalHour = (departureHourFromNY + flightHours + timeDifferenceHours) % 24;
                int arrivalMinute = departureMinuteFromNY + flightMinutes;

                if (arrivalMinute >= 60)
                {
                    arrivalMinute = 60;
                    arrivalHour = (arrivalHour + 1) % 24;
                }

                Console.WriteLine("\n************************************************************************\n\n");
                Console.WriteLine($"Avgångstid från New York: {departureHourFromNY:00}:{departureMinuteFromNY:00}");
                Console.WriteLine($"Ankomsttid i Stockholm: {arrivalHour:00}:{arrivalMinute:00}");
                Console.WriteLine("\n\n************************************************************************");
                break;
            }

            // If-sats ifall användaren väljer alternativ 3, för att avsluta programmet.
            else if (userChoice == "3") 
            {
                Console.WriteLine("\n************************************************************************\n\n");
                Console.WriteLine("Du har valt att avsluta programmet, välkommen åter!");
                Console.WriteLine("\n\n************************************************************************");
                break;
            }

            else
            {
                Console.WriteLine("\n************************************************************************\n\n");
                Console.WriteLine("Du skrev något helt otydligt, var vänlig försök igen");
                Console.WriteLine("\n\n************************************************************************\n");
            }
        }
        }
    }
}
