using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_1._3_GLP
{
    class Program
    {
        static void Main(string[] args)
        {

            do // Börjar med att skapa en While sats som är san! Satsen är för att skapa ett felmedelande som lopar om man mantar in mindre än 2 löner! 
            {
                Console.Clear();
                int amountSalaries = ReadInt("Ange antal löner: "); // Skapar variablen amountSalaries och sätter att dess värde som skickars från ReadInt i Static int ReadInt!

                if (amountSalaries >= 2) // Förklarar vilka tal som ej går att mata in! I det här fallet alla tal som är minde än 2!
                {

                    ProcessSalaries(amountSalaries);

                }
                else                                              //Om inte if-satsen är true hoppar programet vidare till else-satsen! Detta händer när man manar in mindre än 2 löner! 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\nMata in minst 2 löner");

                    Console.ResetColor();
                    //Olika writeLines som skriver ut saker och vissa av de skapar mellansteg i consolen!
                    Console.WriteLine();
                }

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nTryck valfri knapp för att påbörja ny Kalkulering. ESC stänger ner.");
                Console.ResetColor();

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
        static void ProcessSalaries(int salaries) // Skapar en ny variabel!
        {
            int[] numbers;                         // Skapar min array!
            numbers = new int[salaries];      // Sätter att min numbers är samma som salaries!

            int[] numbers2;
            numbers2 = new int[salaries];   // skapar en ny variabel numbers2! 

            for (int i = 0; i < salaries; ++i)  // Uträkning för vilken lön man skriver ut! Med hjälp av en forsats eftersom vi vet hur många löner vi vill skriva ut!
            {

                numbers[i] = ReadInt(String.Format("Ange lön nummer {0}: ", i + 1)); // skriver ut raden som står inom "" (i+1) förklarar nummeret på inmatningslönen och ökar med 1 var gång!
                // ReadInt skickar informationen till ReadInt("Ange antal löner: "); Högre upp! 
            }

            numbers2 = (int[])numbers.Clone(); // Här klonas min andra array så den har samma värde som min första array!

            Array.Sort(numbers2);                  // Gör så att min nya array att den ska bli soterad! (storleksordning)

            int median; // Skapar ny variabel!

            if (salaries % 2 == 0) // Uträkning med hjälp av modelus (2ans gångertabell är tankegången)!
            // Om vi vill räkna ut 8 löner så tar vi 8 % 2 så blir det 0 kvar eftersom att det inte blir något över!
            {
                int value1 = salaries / 2;   // De 8 delas på 2 som blir 4!
                int value2 = value1 - 1;     // Sedan tar vi 4 - 1 eftersom vi vill ha de 2 mellersta värdena!
                median = (numbers2[value1] + numbers2[value2]) / 2; // Sedan läggs dessa värdena ihop och man får ut merdianen!
            }

            else  // Om vi dock skulle haft ett värde som är ojämt exempelvis 7 och tar modolos på det 7 % 2 så får vi ut 1 eftersom det går att dela 3 ggr sedan blir det 1 över!
            {
                median = numbers2[salaries / 2]; // Då hoppar progrmet vidare till else-satsen så 7 delas på 2 som blir 3,5! här finns bara ett mitten tal som bli tal 3
            }                                         // eftersom detta är formen int som inte skriver ut decimaler!  

            int numbercalc = numbers.Max() - numbers.Min(); // Här görs uträkningen till Lönespridningen! 

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Medianlön:{0:c0} ", median);
            Console.WriteLine("Medellön: {0:c0}", numbers.Average());   // skriver ut det som står i ""!
            Console.WriteLine("Lönespridning: {0:c0}", numbercalc);

            Console.WriteLine("-------------------------------");

            for (int j = 0; j < salaries; j++) // Här har vi en for-sats som bestämmer vilka värden som skrivs på samma rad!
            {
                if (j % 3 == 0)  // Här förklarar vi för programet (Om j % 3 är = 0 så 
                {
                    Console.WriteLine(); // Ska programet hoppa ner en rad!
                }

                Console.Write("{0,10}", numbers[j]); // Här skriver programet ut lönerna med ett inhopp och mellansteg på 0,10!
            }

          /*  Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("\nTryck valfri knapp för att påbörja ny kalkulering. ESC stänger ner.");  //Skriver ut raden och undantaget fungerar presis som innan!
            Console.ResetColor();
            */
        }

        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);         // Skickar upp ett värde till ReadInt!
                string numberOfUse;
                numberOfUse = (Console.ReadLine()); //Här skapars en Console.ReadLine som är för att skriva ut en sträng! altså är numberOfUse = Console.ReadLine nu!

                try
                {

                    int otherNumber = int.Parse(numberOfUse); //Här omformarterat vi med hjälp av int.Parse så att stängen!
                    return otherNumber; // här skickar vi upp otherNumber till vår ReadInt!
                }

                catch (FormatException)    // Felmedelande om man skulle skriva in något annat än siffror!
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Error! {0} Är inte rätt format.", numberOfUse);
                    Console.ResetColor();
                }
            }
        }
    }
}

