namespace ConsoleUI
{
    public class PersonGenerator
    {
        public static void Generate(Person user)
        {
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
