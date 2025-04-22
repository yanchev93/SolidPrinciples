using System;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            StandardMessages.WelcomeMessage();

            //Ask for user information
            Person user = GetPersonData.FillUserInformation();

            //Checks fto be sure the first and last name are valid
            bool isPersonValid = PersonValidator.Validate(user);
            
            if (isPersonValid == false)
            {
                StandardMessages.EndApplicationMessage();
                return;
            }

            //Create a username for the person
            PersonGenerator.Generate(user);

            StandardMessages.EndApplicationMessage();
        }
    }
}
