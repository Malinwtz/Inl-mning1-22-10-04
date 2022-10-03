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
                                Console.WriteLine($"Rätt! Du gissade rätt på {counter} försök.");
                                randomNumber = CreateRandomNumber();
                                break;
                            }

                            else if (guess < randomNumber && (guess > 0 && guess < 101))
                            {
                                Console.WriteLine($"Gissning: {counter}.");
                                Console.WriteLine("Talet är större. ");
                                counter++;
                            }

                            else if (guess > randomNumber && (guess > 0 && guess < 101))
                            {
                                Console.WriteLine($"Gissning: {counter}.");
                                Console.WriteLine("Talet är mindre. ");
                                counter++;
                            }

                            else
                                Console.WriteLine("Skriv in ett tal med siffror mellan 1 och 100.");

                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    break;

                }
                catch
                {
                    Console.WriteLine("Du kan bara välja ett tal med siffror. Försök igen!");
                }
            }    
        }
        public int CreateRandomNumber()
        {
            Random rnd = new Random();
            var randomNumber = rnd.Next(0, 101);
            return randomNumber;
        }
        private void EndOfGame()
        {
            Console.Clear();
            Console.WriteLine("Tack för den här gången!\n\n\n\n");
            Console.WriteLine("                    _\r\n                  _(_)_                         " +
                " wWWWw   _\r\n      @@@@       (_)@(_)   vVVVv     _     @@@@  (___) _(_)_\r\n     " +
                "@@()@@ wWWWw  (_)\\    (___)   _(_)_  @@()@@   Y  (_)@(_)\r\n      @@@@  (___)     `|/    Y    " +
                "(_)@(_)  @@@@   \\|/   (_)\\\r\n       /      Y       \\|    \\|/    /(_)    \\|      |/      |\r\n" +
                "    \\ |     \\ |/       | / \\ | /  \\|/       |/    \\|      \\|/\r\n    \\\\|//   \\\\|///  \\\\\\" +
                "|//\\\\\\|/// \\|///  \\\\\\|//  \\\\|//  \\\\\\|// \r\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^" +
                "^^^^^^^^^^^^^^^^^^^");
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
                }
            }
            EndOfGame();
        }
    }
}
