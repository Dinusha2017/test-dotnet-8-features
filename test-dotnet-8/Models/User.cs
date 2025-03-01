namespace test_dotnet_8.Models
{
    public class User(string name, string emailAddress)
    {
        public string Name { get; private set; } = name;
        public string EmailAddress { get; private set; } = emailAddress;

        public void DisplayCommonUserData()
        {
            Console.WriteLine($"User Name: {Name}.");
            Console.WriteLine($"User Email Address: {EmailAddress}.");
        }

        public void ChangeUserName(string name)
        {
            Console.WriteLine("Changing User Name...");
            Name = name;
        }
    }
}
