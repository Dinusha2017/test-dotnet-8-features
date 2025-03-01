// See https://aka.ms/new-console-template for more information
using test_dotnet_8.Models;

Console.WriteLine("Starting to check out PRIMARY CONSTRUCTORS!");

AdminUser adminUser = new("Dinusha", "test@gmail.com", AdminType.ADMIN);
adminUser.DisplayCommonUserData();
adminUser.DisplayAdminUserData();
adminUser.ChangeUserName("Thiwanthi");
adminUser.DisplayCommonUserData();
adminUser.DisplayAdminUserData();
