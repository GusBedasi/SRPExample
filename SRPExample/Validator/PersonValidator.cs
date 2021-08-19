using SRPExample.Domain;
using SRPExample.Messages;

namespace SRPExample.Validator
{
    public class PersonValidator
    {
        public static bool Validate(Person user)
        {
            var isNameValid = string.IsNullOrWhiteSpace(user.FisrtName);

            if (isNameValid)
            {
                StandardMessages.DefaultErrorMessage(nameof(user.FisrtName));
                return false;
            }

            var isLastNameValid = string.IsNullOrWhiteSpace(user.LastName);
            
            if (isLastNameValid)
            {
                StandardMessages.DefaultErrorMessage(nameof(user.LastName));
                return false;
            }

            return true;
        }
    }
}