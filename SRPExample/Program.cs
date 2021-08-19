using SRPExample.Messages;
using SRPExample.Services.Account;
using SRPExample.Services.DataCapture;
using SRPExample.Validator;

namespace SRPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            var user = PersonDataCapture.Capture();

            var isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }
            
            AccountGenerator.CreateAccount(user);
        }
    }
}