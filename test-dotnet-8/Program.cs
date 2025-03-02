// See https://aka.ms/new-console-template for more information
using System.Text;
using test_dotnet_8.Models;

Console.WriteLine("Starting to check out PRIMARY CONSTRUCTORS!");

AdminUser adminUser = new("Dinusha", "test@gmail.com", AdminType.ADMIN);
adminUser.DisplayCommonUserData();
adminUser.DisplayAdminUserData();
adminUser.ChangeUserName("Thiwanthi");
adminUser.DisplayCommonUserData();
adminUser.DisplayAdminUserData();

Console.WriteLine();
Console.WriteLine("Starting to check out COLLECTION EXPRESSIONS!");

List<string> batch1Students = [ "Anne", "John", "George" ];
List<string> batch2Students = [ "Catherine", "Paul", "Alex" ];
List<string> allStudents = [..batch1Students, ..batch2Students];
Console.WriteLine("Students: ");
StringBuilder allNamesBuilder = new();
foreach(string name in allStudents)
{
    allNamesBuilder.Append($"{name}, ");
}
Console.WriteLine(allNamesBuilder.Remove(allNamesBuilder.Length - 2, 2).ToString());

Console.WriteLine();
Console.WriteLine("Starting to check out INLINE ARRAYS!");
SearchFields searchFields = new();
searchFields[0] = "Id";
searchFields[1] = "Name";
searchFields[2] = "City";
Console.WriteLine("Search Fields: ");
foreach(string field in searchFields)
{
    Console.WriteLine(field);
}
Console.WriteLine($"Field Name property: {searchFields.FieldName}.");

Console.WriteLine();