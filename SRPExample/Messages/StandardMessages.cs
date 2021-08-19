using System;

namespace SRPExample.Messages
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Hello There!");
        }

        public static void DefaultErrorMessage(string filedName)
        {
            Console.WriteLine($" You did not give us a valid {filedName}!");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press enter to close.");
            Console.ReadLine();
        }
        
    }
}