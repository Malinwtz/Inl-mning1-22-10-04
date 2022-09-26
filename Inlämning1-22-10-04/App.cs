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
        public bool GissaEttTal( int numberToCompare, int correctNumber)
        {

            
            if (numberToCompare == correctNumber)
                return true;

            else if (numberToCompare < correctNumber)
            {
                Console.WriteLine($"Talet är större");
                return false;              
            }
            else if (numberToCompare > correctNumber)
            {
                Console.WriteLine($"Talet är mindre");
                return false;               
            }   
            else return false;
           
                               
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
        public void Run()
        {
            Random rnd = new Random();
            var antalGissningar = 1;
            var yesOrNo = false;
            var resultat = false;
            var randomNumber = rnd.Next(0, 101);
            bool spel= true;
            while (spel)
           { 
                Console.WriteLine("Gissa ett tal mellan 1 och 100.");

                while (resultat == false)
                {
                    Int32.TryParse(Console.ReadLine(), out var gissning);

                    yesOrNo = IsNumber(gissning); //kollar om gissningen är ett nummer
                    resultat = GissaEttTal(gissning, randomNumber); //kollar om gissningen är rätt eller fel

                    //Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!");


                    if (resultat == true)
                        break;

                    if (yesOrNo == false)
                    {
                        Console.WriteLine($"Skriv in ett nummer");
                    }
                    else if (resultat == false)
                    {
                        Console.WriteLine($"Du gissade fel... \nGissning: {antalGissningar}");
                        antalGissningar++;
                    }
                }
                Console.WriteLine($"Gissning: {antalGissningar} \nRätt! Du gissade rätt på {antalGissningar} försök.");

                    
                while (spel)
                {
                    Console.WriteLine("Vill du spela igen (Ja / Nej) ? ");
                    string answer = Console.ReadLine();
                    answer = answer.ToUpper();
                    if (answer == "JA")
                    {
                        Console.WriteLine("Kör spelet igen...");
                        antalGissningar = 1;
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
