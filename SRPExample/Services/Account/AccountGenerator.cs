using System;
using SRPExample.Domain;
using SRPExample.Messages;

namespace SRPExample.Services.Account
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Welcome {user.FisrtName.Substring(0, 3) + user.LastName}!");
            StandardMessages.EndApplication();
        }
    }
}