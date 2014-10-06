using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._2_Rita_Asteriker_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ett program som endast använder följande satse, en gång vardena, för utskrift
            // 2 for-satser där den ena är nästlad/ i den andra..
            // 39 kolumner och 25 rader.

            for (int rader = 0; rader <= 25; rader++)
            {
                for (int kolumner = 0; kolumner <= 39; kolumner++)
  
                {
                   
                    Console.Write("* ");
                    

                 }
                Console.WriteLine();
                if (rader % 2 == 0)
                {
                    Console.Write(" ");
                }
             }

                    // färgerna ska vara (ConsoleColor.Yellow)   (ConsoleColor.Magneta)   (ConsoleColor.Green)
                    // För att bestämma färgerna för vilken rad ska en switch-sats användas.

        }

    }

}
    
