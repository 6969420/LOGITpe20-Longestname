using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.Tracing;

namespace StrongFotLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string helloworld = "hello World";
            Console.WriteLine(helloworld[0]);
            Console.WriteLine(helloworld[6]);

            int stringLength = helloworld.Length;
            Console.WriteLine($"Your text is {stringLength} symbols long.");
            /*write a program that counts "O" letters in a string*/
            char searchCriteria = 'o';
            int counter = 0;

            foreach(char letter in helloworld)
            {
                if(letter == searchCriteria)
                {
                   counter = counter + 1;
                }
            }
            Console.WriteLine($"There are {counter} Os in your text");

        }
    }
}
