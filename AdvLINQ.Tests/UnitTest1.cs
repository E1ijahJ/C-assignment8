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
}
