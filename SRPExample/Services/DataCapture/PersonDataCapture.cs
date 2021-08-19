using System;
using SRPExample.Domain;

namespace SRPExample.Services.DataCapture
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            var user = new Person();
            
            Console.WriteLine("What is your first name?");
            user.FisrtName = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}