using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Threeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            int userInput = Int32.Parse(Console.ReadLine());

            int counter = 0;

            while (counter < 3)
            {
                if (randomNumber == userInput)
                {
                    Console.WriteLine("Congratlations, you have won!");
                    break;
                } else
                {
                    Console.WriteLine("Try again!");
                     counter = counter + 1;

                }
            }
        }
        
    }
}
