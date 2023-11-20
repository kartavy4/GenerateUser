using Bogus;
using Bogus.DataSets;

namespace GenerateUser;

public class UserGenerator
{
    private static Faker<User> _faker;

    public UserGenerator()
    {
        _faker = new Faker<User>()
            .RuleFor(u => u.Gender, f => f.PickRandom<Name.Gender>())
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName(u.Gender))
            .RuleFor(u => u.LastName, (f, u) => f.Name.LastName(u.Gender))
            .RuleFor(u => u.Address, (f, u) => f.Address.FullAddress())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(u => u.Password, (f, u) => f.Internet.Password())
            .RuleFor(u => u.Age, (f, u) => f.Random.Number(18, 65));

    }

    public static User GenerateUser()
    {
        return _faker.Generate();
    }

}

public class User
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
    public Name.Gender Gender { get; set; }
    public string Address { get; set; }
    public string Email {get; set; }
    public string Password { get; set; }
    public int Age { get; set; }
}

