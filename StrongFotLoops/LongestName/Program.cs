using System;

namespace LongestName
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks for two names;
             * The program compares the names by their lenght;
             * The program displays wich name is the longest.
             * Do not use the Length property!
             * E.g.
             * Name1 is longer than Name2."*/
            Console.WriteLine("enter the first name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter second name");
            string name2 = Console.ReadLine();
            int length1 = 0;
            int length2 = 0;
            foreach(char letter in name1)
            {
                length1 = length1 + 1;

            }
            foreach (char letter in name2)
            {
                length2 = length2 + 1;
            }

            if (length1 > length2)
            {
                Console.WriteLine("Name 1 is the longest.");
            }else if (length1 < length2)
            {
                Console.WriteLine("Name 2 is the longest");
            }else
            {
                Console.WriteLine("Both names are of the same length");
            }


        }
    }
}
