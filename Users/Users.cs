public class Users
{
    public string Name;
    public string lastName;

    public char Gender;
    public int age;
    public Faculty Faculty = new Faculty();
    public MaritalStatus maritalStatus = new MaritalStatus();

    public void PrintUsers()

    {
        


        Console.WriteLine($" {Name} {lastName} {age} лет \n семейное положение: " + 
        $"{maritalStatus.Status} около: {maritalStatus.Years} лет \n " +
        $"номер телефона: {Faculty.PhoneNumber}, профессия: {Faculty.Profession}" +
        $"на {Faculty.Сourse} курсе, зарплата: {Faculty.Salary} рублей \n");
    }
}