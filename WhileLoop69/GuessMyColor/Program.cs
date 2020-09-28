using System;

namespace GuessMyColor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* a computer generates a color, The user tries to guess the color*/
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 4);
            bool rightGuess = false;

            while(!rightGuess)
            {
                Console.WriteLine("What's my color? ");
                string userInput = Console.ReadLine().ToLower();

                if (computerNumber == 1 && userInput == "red")
                {
                    Console.WriteLine("You Won!");
                    rightGuess = true;
                }
                else if (computerNumber == 2 && userInput == "green")
                {
                    Console.WriteLine("you won");
                    rightGuess = true;
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
        }
    }
}
