namespace ConsoleUI
{
    public class GetPersonData
    {
        public static Person FillUserInformation()
        {
            Person user = new Person();

            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            user.LastName = Console.ReadLine();
        
            return user;
        }
    }
}
