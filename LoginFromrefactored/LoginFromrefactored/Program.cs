using System;

namespace LoginFromrefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            string Login, Password;
            Console.WriteLine("login: ");
            Login = Console.ReadLine();
            Console.WriteLine("password: ");
            Password = Console.ReadLine();

            if (Login == "admin" && Password == "pass1234")
            {
                Console.WriteLine("welcome , Admin!");
            }
            else
            {
                Console.WriteLine("login failed. try again.");

            }

            
        }
    }
}
