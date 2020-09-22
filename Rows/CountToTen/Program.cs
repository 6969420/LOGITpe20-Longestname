using System;
using System.Security.Cryptography;

namespace CountToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program ases for loop to display numbers from 0 to 10 including 0*/
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}");
            }
        }
    }
}
