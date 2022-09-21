using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Inlämning1_22_10_04
{
    internal class App
    {
        public void Run()
        {
            Random rnd = new Random();
            var counter = 1;
            var randomNumber = rnd.Next(0, 101);
            bool spel= true;
            while (spel)
           { 
                Console.WriteLine("Gissa ett tal mellan 1 och 100.");
                
                while (spel)
                {
                    Int32.TryParse(Console.ReadLine(), out var gissning);
                    if (gissning < 1 || gissning > 100)
                    {
                        Console.WriteLine("Skriv in ett tal med siffror mellan 1 och 100.");    
                    }
                    else if (gissning < randomNumber)
                    {
                        Console.WriteLine($"Gissning: {counter} \nTalet är större");
                        counter++;
                        continue;
                    }
                    else if (gissning > randomNumber)
                    {
                        Console.WriteLine($"Gissning: {counter} \nTalet är mindre");
                        counter++;
                        continue;
                    }
                    else if (gissning == randomNumber)
                        break;
                    else
                    {
                        Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!");
                    }
                    
                } Console.WriteLine($"Gissning: {counter} \nRätt! Du gissade rätt på {counter} försök.");

                    
                while (spel)
                {
                    Console.WriteLine("Vill du spela igen (Ja / Nej) ? ");
                    string answer = Console.ReadLine();
                    answer = answer.ToUpper();
                    if (answer == "JA")
                    {
                        Console.WriteLine("Kör spelet igen...");
                        counter = 1;
                        randomNumber = rnd.Next(0, 101);
                        break;
                    }
                    else if (answer == "NEJ")
                        spel = false;
                    else
                    { 
                        Console.WriteLine("Du kan bara välja ja eller nej. Försök igen!"); 
                    }
                }

            }
            Console.WriteLine("Tack för den här gången!");
            
        }  
           
    }
}
