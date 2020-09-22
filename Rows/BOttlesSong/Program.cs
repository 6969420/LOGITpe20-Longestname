using System;

namespace BOttlesSong
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink;
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            if (age < 18)
            {
                drink = "milk";
            }else
            {
                drink = "beer";
            }

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{i} bottles of {drink} on the wall, \n {i} bottle of");
                Console.WriteLine("take one down pass it around");
                
               
                
            }
        }
    }
}
