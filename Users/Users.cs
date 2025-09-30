public class Users
{
    public string Name;
    public string lastName;
    public int age;
    public Faculty Faculty = new Faculty();
    public MaritalStatus maritalStatus = new MaritalStatus();




    public void PrintUsers()

    {

        Console.WriteLine($" {Name} {lastName} {age} лет \n семейное положение: " + 
        $"{maritalStatus.Status} около: {maritalStatus.Years} лет ");
    }
}