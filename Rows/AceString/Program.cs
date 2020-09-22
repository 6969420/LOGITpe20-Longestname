using System;

namespace AceString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter some text");
            string userInput = Console.ReadLine();
            char searchCriteria = 'a';
            int counter = 0;

            for(int i = 0; i < userInput.Length; i++)
            {
                if(userInput.ToLower()[i] == searchCriteria)
                {
                    counter = counter + 1;
                }
            }
            if(counter > 0)
            {
                Console.WriteLine($"there are {counter} a's in your text");
            } else
            {
                Console.WriteLine($"there are no a's in your text");
            }
        }  
    }
}
