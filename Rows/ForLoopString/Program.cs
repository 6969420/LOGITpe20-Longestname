using System;

namespace ForLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Erik";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i+1}. {name[i]}");
            }
        }
    }
}
