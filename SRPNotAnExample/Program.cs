using System;

namespace SRPNotAnExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!");

            var user = new Person();
            
            Console.WriteLine("What is your first name?");
            user.FisrtName = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            user.LastName = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(user.FisrtName))
            {
                Console.WriteLine($" You did not give us a valid first name");
                Console.ReadLine();;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine($" You did not give us a valid last name!");
                Console.ReadLine();
            }
            
            Console.WriteLine($"Welcome {user.FisrtName.Substring(0, 3) + user.LastName}!");
            Console.ReadLine();
        }
    }
}