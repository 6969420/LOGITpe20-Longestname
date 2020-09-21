using System;

namespace WEEK2NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Seasons
             * A program asks the user what month they were born in
             * December, January or February - You were born in the winter
             * March, April or may - You were born in spring
             * June, July or August - You were born in summer
             * September, October or November - you were born in autumn
             * */
            Console.WriteLine("What month were you born?");
            string month = Console.ReadLine().ToLower();

            if (month == "December" || month == "January" || month == "February")
            {
                Console.WriteLine("You were born in winter");
            }
            else if (month == "March" || month == "April" || month == "May")
            {
                Console.WriteLine("You were born in spring");
            }
            else if (month == "June" || month == "July" || month == "August")
            {
                Console.WriteLine("Your were born in summer");
            }
            else if (month == "September" || month == "July" || month == "August")
            {
                Console.WriteLine("Your were born in autumn");
            }

        }
    }
}
