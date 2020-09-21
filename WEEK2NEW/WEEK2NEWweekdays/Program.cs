using System;

namespace WEEK2NEWweekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a day");
            string day = Console.ReadLine().ToLower();
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                Console.WriteLine("This is a weekday");
            }
            else if (day == "saturday" || day == "sunday")
            {
                Console.WriteLine("This is a weekend day");
            }else
            {
                Console.WriteLine("This is not a day of the weekend");
            }

        }
    }
}
