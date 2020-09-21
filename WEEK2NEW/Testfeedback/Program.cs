using System;

namespace Testfeedback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what mark did you get on your test");
            string grade = Console.ReadLine().ToLower();

            switch (grade)
            {
                case "a":
                    Console.WriteLine("excellent");
                    break;
                case "b":
                    Console.WriteLine("very good");
                    break;
                case "c":
                    Console.WriteLine("passed");
                    break;
                case "d":
                    Console.WriteLine("failed");
                    break;
                case "default":
                    Console.WriteLine("wasted");
                    break;
            }
        }
    }
}
