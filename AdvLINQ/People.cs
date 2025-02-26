namespace AdvLINQ;

public class People
{
/// <summary>
/// This is the nested class Person whihc has the name id and
/// the birthdate of said indvidual
/// </summary>
public class Person{
  public int Id {get; set;}
  public string Name{ get; set;}
  public DateTime Birthday {get; set;}
  public Person(int id, string name, DateTime birthday){

    Id=id;
    Name=name;
    Birthday=birthday;
  }
}
private Person[] data;
/// <summary>
/// this initalizes the class when it is ran automatcailly generating a million people with random birth dates, names and unique ids
/// </summary>
public People(){
  Random random = new Random();
  data = Enumerable.Range(1,1000000).Select(id => new Person(id,GenerateRandomName(random),GenerateRandomBirthday(random))).ToArray();
}
/// <summary>
/// Helper fucntions to help generate the random name that there is
/// </summary>
/// <param name="random"> jus uses the random library </param>
/// <returns></returns>
private string GenerateRandomName(Random random){
  int nameLength = random.Next(3,12);
  const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
  return new string(Enumerable.Range(0,nameLength).Select(_=> chars[random.Next(chars.Length)]).ToArray());
}
/// <summary>
/// Another helper funciton to help generate birthdays for all the differnt Persons
/// </summary>
/// <param name="random"></param>
/// <returns></returns>
private DateTime GenerateRandomBirthday(Random random){
  int year = random.Next(1930,2025);
  int month = random.Next(1,13);
  int maxiDay = DateTime.DaysInMonth(year,month);
  int day = random.Next(1,maxiDay+1);
  return new DateTime(year, month,day);
}
/// <summary>
/// This right here gets the the amount of people born after a certain date 
/// </summary>
/// <param name="date"> this is the date that is inouted in a year, month day format</param>
/// <returns></returns>
public Person[] GetPeopleBornAfter(DateTime date){
  return data.Where(p=> p.Birthday> date).ToArray();
}
/// <summary>
/// This is gettig people by name autmatically returning it when  if a name exists
/// </summary>
/// <param name="name">name that is being searched for</param>
/// <returns></returns>
public Person[] GetPeopleByName(string name){
  return data.Where(p=> p.Name == name).ToArray();
}
/// <summary>
/// Getting a person by there id if it exist s we are using an ? in case that we input and id that does not exist 
/// </summary>
/// <param name="id"></param>
/// <returns></returns>
public Person? GetPersonById(int id){
  return data.FirstOrDefault(p=> p.Id==id);
}


}