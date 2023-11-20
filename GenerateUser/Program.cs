using Bogus.DataSets;
using Bogus;
using GenerateUser;

var userGenerate = new UserGenerator();
var user = UserGenerator.GenerateUser();

Console.WriteLine($"Gender:{user.Gender}");
Console.WriteLine($"Name: {user.FirstName}");
Console.WriteLine($"LastName:{user.LastName}");
Console.WriteLine($"Address:{user.Address}");
Console.WriteLine($"Email:{user.Email}");
Console.WriteLine($"Password:{user.Password}");
Console.WriteLine($"Age:{user.Age}");

Console.ReadKey();
