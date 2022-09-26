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
        public bool IsNumberCorrect( int numberToCompare, int correctNumber)
        {
            int count = 1;
            bool game = true; 
            while (game)
            {

                if (numberToCompare < 1 || numberToCompare > 100)
                {
                    Console.WriteLine("Skriv in ett tal med siffror mellan 1 och 100.");
                }
                else if (numberToCompare < correctNumber)
                {
                    Console.WriteLine($"Gissning: {count} \nTalet är större");
                    count++;
                    continue;
                }
                else if (numberToCompare > correctNumber)
                {
                    Console.WriteLine($"Gissning: {count} \nTalet är mindre");
                    count++;
                    continue;
                }
                else if (numberToCompare == correctNumber)
                    game = false;
                else
                {
                    Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!");
                }
               
            }
            return true;

            //if (numberToCompare == correctNumber)
            //    return true;

            //else if (numberToCompare < correctNumber)
            //{
            //    Console.WriteLine($"Talet är större");
            //    return false;              
            //}
            //else if (numberToCompare > correctNumber)
            //{
            //    Console.WriteLine($"Talet är mindre");
            //    return false;               
            //}   
            //else return false;


        }
        public void PlayAgain()
        {
            
        }
        public bool IsNumber( int gissning)
        {
            if (gissning > 0 && gissning < 101)
                return true;
            else
                return false;
        
        }
        public int CreateARandomNumber()
        {
            Random rnd = new Random();
            var randomNumber = rnd.Next(0, 101);
            return randomNumber;
        }
        public void Run()
        {
            
            var counter = 1;
            bool continueGame = true;
            int  randomNumber = CreateARandomNumber();
            bool IsGuessCorrect;

            while (continueGame)
            {
                Console.WriteLine("Gissa ett tal mellan 1 och 100.");

                //while (continueGame)
                
                   // Int32.TryParse(Console.ReadLine(), out var gissning);

                //IsGuessCorrect = IsNumberCorrect(gissning, randomNumber);

                while (continueGame)
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

                }
                Console.WriteLine($"Gissning: {counter} \nRätt! Du gissade rätt på {counter} försök.");
                

                while (continueGame)
                {
                    Console.WriteLine("vill du spela igen (ja / nej) ? ");
                    string answer = Console.ReadLine();
                    answer = answer.ToUpper();
                    
                    if (answer == "JA")
                    {
                        Console.WriteLine("Kör spelet igen...");
                        counter = 1;
                        randomNumber = CreateARandomNumber();
                        break;
                    }
                    else if (answer == "NEJ")
                        continueGame = false;
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
