using System;

namespace Week2ifstatements2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            
                Console.WriteLine("What is your birth year");

                string UserInput;
                UserInput = Console.ReadLine();
                int Year;
                Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;

            if (Age < 18)

            {
                Console.WriteLine("you are too young to have a driver license.");

            }
            else if (Age > 18)
            {
                Console.WriteLine("you are old enough to have a driver license");
            } 
            else
            {
                Console.WriteLine("you are 18 old enough to have a drivers license");
            }
        }
    }
}
