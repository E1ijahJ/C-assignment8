namespace AdvLINQ;

public class People
{
private class Person{
  public int Id {get; set;}
  public string Name{ get; set;}
  public DateTime Birthday {get; set;}
  public Person(int id, string name, DateTime birthday){

    Id=id;
    Name=name;
    Birthday=birthday;
  }
}
}