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
        
        public void PlayAgain()
        {

            
            
            while (true)
            {

                Console.WriteLine("Vill du spela igen (ja / nej) ? ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "ja")
                {
                    Console.WriteLine("Kör spelet igen...");

                    break;
                }

                else 
                    break; 

            }


        }
        public void GuessANumber()
        {
            var counter = 1;
            int randomNumber = CreateRandomNumber();

            while (true)
            {
                
                Console.WriteLine("Gissa ett tal mellan 1 och 100.");

                try
                {

                    int guess = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {
                                                
                            if (guess == randomNumber && (guess > 0 && guess < 101))
                            {
                                Console.Clear();
                                Console.WriteLine($"{guess} är rätt! Du gissade rätt på {counter} försök.");
                                randomNumber = CreateRandomNumber();
                                break;
                            }

                            else if (guess < randomNumber && (guess > 0 && guess < 101))
                            {
                                Console.WriteLine($"Gissning: {counter}.");
                                Console.WriteLine("Talet är större. Gissa igen!");
                              
                                counter++;
                                //continue;
                            }

                            else if (guess > randomNumber && (guess > 0 && guess < 101))
                            {
                                Console.WriteLine($"Gissning: {counter}.");
                                Console.WriteLine("Talet är mindre. Gissa igen!");
                              
                                counter++;
                                //continue;
                            }

                            else
                                Console.WriteLine("Skriv in ett tal med siffror mellan 1 och 100.");

                        guess = Convert.ToInt32(Console.ReadLine());


                    }
                    break;

                }
                catch
                {
                    Console.WriteLine("Skriv in ett tal med siffror mellan 1 och 100.");
                    
                }
            }    
        }
        public int CreateRandomNumber()
        {
            Random rnd = new Random();
            var randomNumber = rnd.Next(0, 101);
            return randomNumber;
        }
        public void Run()
        {
                
            Console.ForegroundColor = ConsoleColor.Cyan;
            var continueGame = true;

            while (continueGame)
            {
                
                GuessANumber();
                
                while (continueGame)
                {
                    //try
                    //{
                      
                        Console.WriteLine("Vill du spela igen (ja / nej) ? ");
                        string answer = Console.ReadLine();
                        answer = answer.ToLower();

                        if (answer == "ja")
                        {
                            Console.WriteLine("Kör spelet igen...");

                            break;
                        }
                        else if (answer == "nej")
                        {
                            continueGame = false;
                            break;
                        }
                          
                        else
                            Console.WriteLine("Du kan bara välja ja eller nej. Försök igen!");

                    //}
                    //catch
                    //{
                    //    Console.WriteLine("Du kan bara välja ja eller nej. Försök igen!");
                    //}

                }
                
            }
            Console.WriteLine("Tack för den här gången!");

        }
    }
}
