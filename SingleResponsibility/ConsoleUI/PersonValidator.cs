namespace ConsoleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person user)
        {
            bool isValid = false;

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                StandardMessages.DisplayValidationNameError("first name");
                return isValid;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessages.DisplayValidationNameError("last name");
                return isValid;
            }

            isValid = true;
            return isValid;
        }
    }
}
