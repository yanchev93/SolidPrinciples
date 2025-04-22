namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void DisplayValidationNameError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}!");
        }

        public static void EndApplicationMessage()
        {
            Console.ReadLine();
        }
    }
}
