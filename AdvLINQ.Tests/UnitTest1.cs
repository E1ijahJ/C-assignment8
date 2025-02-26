namespace AdvLINQ.Tests;

public class UnitTest1
{
    [Fact]
    public void TestingGetPeopleBornAfter()
    {
        People people = new People();
        var afterbirth = people.GetPeopleBornAfter(new DateTime(2000,1,1));
        Console.WriteLine($"People Born after 2000:{afterbirth.Length}");
    }
    [Fact]
    public void TestingGetPeopleByName()
    {
        People people = new People();
        Console.WriteLine(people.GetPeopleByName("awefg"));
    }
    [Fact]
    public void TestingIds()
    {
        People people = new People();
        var person = people.GetPersonById(500000);
        Console.WriteLine(person != null ? $"Found person: {person.Name}": "Person not found");
    }
}
