using System;

namespace CountDown
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 11; i >= i--) 
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
