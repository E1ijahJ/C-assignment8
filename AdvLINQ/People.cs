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
private string GenerateRandomName(Random random){
  int nameLength = random.Next(3,12);
  const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
  return new string(Enumerable.Range(0,nameLength).Select(_=> chars[random.Next(chars.Length)]).ToArray());
}
}