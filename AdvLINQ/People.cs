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
private DateTime GenerateRandomBirthday(Random random){
  int year = random.Next(1930,2025);
  int month = random.Next(1,13);
  int day = random.Next(1,31);
  return new DateTime(year, month,day);
}
}