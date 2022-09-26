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
        public string IsNumberCorrect( int numberToCompare, int correctNumber)
        {
            if (numberToCompare == correctNumber)
                return "Talet är rätt.";
            else if (numberToCompare < correctNumber)
                return "Talet är större.";
            else 
                return "Talet är mindre.";
        }
        public void PlayAgain()
        {
            
        }
        public string IsNumberHigher( int numberToCompare, int correctNumber)
        {
            if (numberToCompare > correctNumber)
                return "Talet är större.";
            else return "Talet är mindre";
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
           // bool IsGuessCorrect;

            while (continueGame)
            {
                Console.WriteLine("Gissa ett tal mellan 1 och 100.");

                //while (continueGame)
                
                   // Int32.TryParse(Console.ReadLine(), out var gissning);

                //IsGuessCorrect = IsNumberCorrect(gissning, randomNumber);

                while (continueGame)
                {
                    Int32.TryParse(Console.ReadLine(), out var gissning);
                    var answerGuessing = IsNumberCorrect(gissning, randomNumber); 


                    if (gissning < 1 || gissning > 100)
                    {
                        Console.WriteLine("Skriv in ett tal med siffror mellan 1 och 100.");
                    }

                    else if (gissning < randomNumber)
                    {
                        Console.WriteLine($"Gissning: {counter}. \n{answerGuessing}");
                        
                        counter++;
                        continue;
                    }

                    else if (gissning > randomNumber)
                    {
                        Console.WriteLine($"Gissning: {counter} \n{answerGuessing}");
                        counter++;
                        continue;
                    }

                    else if (gissning == randomNumber)
                    {
                        Console.WriteLine($"Gissning: {counter} \n{answerGuessing} Du gissade rätt på {counter} försök.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine($"{answerGuessing}");
                    }

                }
                //Console.WriteLine($"Gissning: {counter} \n{answerGuessing} Du gissade rätt på {counter} försök.");


                while (continueGame)
                {
                    Console.WriteLine("Vill du spela igen (ja / nej) ? ");
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
