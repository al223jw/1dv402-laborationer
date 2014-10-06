using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labration_1._1_Vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0d;
            double subtotal = 0d;
            double roundingOffAmount = 0d;
            uint sum = 0;
            uint moneyBack1 = 0;
            uint cashback = 0;

       while (true)                                                                         //  Lopar tills det stämmer, vid fels ger ett nytt försök!
        {
            try
            {
                Console.Write("Ange totalsumman    : ");   //  total = Vad kunden ska betala!
                total = double.Parse(Console.ReadLine());
                break;
            }
            catch 
            {
                Console.BackgroundColor = ConsoleColor.Red; // Felmedelande, Abc. 
                Console.WriteLine("Felaktigt belopp");
                Console.ResetColor();
            }
          }
           
            if (total < 1)                                                                              //  Stämmer av om summan är större än 1 om inte stängs programmet.
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("För liten summa köpet kan ej genomföras"); // Felmedelande, Summan kunden ska betala understiger 1!

                Console.ResetColor();
                return;
        }
        while (true)                                                                                    // Lopar tills det stämmer, vid fel gers nytt försök!
        {
            try
            {
                
                Console.Write("Ange erhållet belopp: ");   // Sum = Det kunden betalar!
                  sum = uint.Parse(Console.ReadLine());
            break;
            }
                catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel format");            // Felmedelande, allmänt + Abc

                Console.ResetColor(); 
            }
        }

            if (sum < total)                                                                          // Stämmer av om sum är större än total om inte stängs programmet.
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Inmatad betalning förliten"); // Felmedelande om kunden betalat förlite.
                    
                    Console.ResetColor();
                    return;
                }

       

                    subtotal = (uint)Math.Round(total);     //
                                                              //
                    roundingOffAmount = subtotal - total;        //  Uträkning till roundingOffAmount! 
                                                              //    
                    moneyBack1 = sum - (uint)total;        //


                    Console.WriteLine();     //  Mellan steg!


                    Console.WriteLine("KVITTO");

                    Console.WriteLine("-------------------------------");

                    Console.WriteLine(String.Format("Totalt              :{0,15:c} ", total));
                    Console.WriteLine(String.Format("Öresavrundning      :{0,15:c} ", roundingOffAmount));   // Writelines som visar statestik! 
                    Console.WriteLine(String.Format("Att betala          :{0,15:c0} ", total));
                    Console.WriteLine(String.Format("Kontant             :{0,15:c0} ", sum));
                    Console.WriteLine(String.Format("Tillbaka            :{0,15:c0} ", moneyBack1));

                    Console.WriteLine("-------------------------------\n");


                    if (total == sum)
                    {   
                        Console.WriteLine("Inga pengar tillbaka!");
                    }

                    if (moneyBack1 >= 500)
                    {
                        cashback = moneyBack1 / 500;
                        moneyBack1 = moneyBack1 % 500;
                        Console.WriteLine("500-lappar          :{0}", cashback);
                    }
                
                    if (moneyBack1 >= 100)
                    {
                        cashback = moneyBack1 / 100;
                        moneyBack1 = moneyBack1 % 100;
                        Console.WriteLine("100-lappar          :{0}", cashback);  // Writelines och uträkningar som visar statestik!
                    }
                    
                    if (moneyBack1 >= 20)
                    {
                        cashback = moneyBack1 / 20;
                        moneyBack1 = moneyBack1 % 20;
                        Console.WriteLine(" 20-lappar          :{0}", cashback);
                    }

                    if (moneyBack1 >= 5)
                    {
                        cashback = moneyBack1 / 5;
                        moneyBack1 = moneyBack1 % 5;
                        Console.WriteLine("  5-kronor          :{0}", cashback);
                    }

                    if (moneyBack1 >= 1)
                    {
                        cashback = moneyBack1 / 1;
                        moneyBack1 = moneyBack1 % 1;
                        Console.WriteLine("  1-kronor          :{0}", cashback);
                    }

           }
         }   
      }

