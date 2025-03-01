namespace test_dotnet_8.Models
{
    public class AdminUser(string name, string emailAddress, AdminType adminType): User(name, emailAddress)
    {
        public void DisplayAdminUserData()
        {
            Console.WriteLine($"Admin Name: {Name}.");
            Console.WriteLine($"Admin Email Address: {EmailAddress}.");
            Console.WriteLine($"Admin Type: {adminType}.");
        }
    }
}
