﻿using System;

namespace AInUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*a program asks the users name,
             * and counts A letters, and displays the result.
             * If there are no A letters found the program
             * displays "No A's found." 
             */
            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            char searchCriteria = 'a';
            int counter = 0;

            foreach (char letter in name)

                if (letter == searchCriteria)
                {
                    counter = counter + 1;
                }

            if (counter) > 0)
            {       
                Console.WriteLine($"there are {counter} As in your name.");
            }
            else
            {
                Console.WriteLine("There are no A's in your name.");
            }


        }
    }
}
