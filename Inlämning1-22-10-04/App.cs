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
            
            //• Programmet ska välja olika slumptal varje gång genom att använd klassen Random.
            //• Skriver användaren in något som inte är ett tal ska de få uppmaningen att försöka igen tills de
            //skriver in ett tal med siffror. Tips! Använd metoden TryParse() för att testa om texten som
            //skrivits in verkligen är ett tal.
            //• Programmet ska bara räkna gissningar som är heltal. I exemplet ovan skriver
            //användaren ”Fyra” vilket inte är ett heltal och får då försöka igen.
            //• Svara man Ja ska spelet starta om från början med ett helt nytt slumptal.Vid alla andra svar ställs frågan om man vill spela om igen. 
            Random rnd = new Random();
            while (true)
            {
                var counter = 1;
                var randomNumber = rnd.Next(0, 101);
                Console.WriteLine("Gissa ett tal mellan 1 och 100.");
                Int32.TryParse(Console.ReadLine(), out var gissning);
                
                    if (gissning < randomNumber)
                    {
                        Console.WriteLine($"Gissning {counter} \nTalet är större");
                        counter++;
                        continue;
                        
                    }

                    else if (gissning > randomNumber)
                    {
                        Console.WriteLine($"Gissning {counter} \nTalet är mindre");
                        counter++;
                        continue;
                    }
                    else if (gissning == randomNumber)
                    {
                        Console.WriteLine($"Gissning {counter} \nRätt! Du gissade rätt på {counter} försök.");
                        
                        Console.WriteLine("Vill du spela igen (Ja / Nej) ? ");
                        string answer = Console.ReadLine();
                        answer = answer.ToUpper();
                        if (answer == "JA" || answer == "NEJ")
                        {
                        if (answer == "JA")
                        {
                            Console.WriteLine("Kör spelet igen...");
                            counter = 1;
                        }
                        else if (answer == "NEJ")
                        {
                            Console.WriteLine("Tack för den här gången!");
                            break;
                        }
                        }
                        else
                        {
                        Console.WriteLine("Du kan bara välja ja eller nej. Försök igen!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!");
                    }
                
            }
        }
    }
}
