public class Dog
{

   public string Name;
   public int Age;

     public Dog(string name, int age)   
    {
        Name = name;   
        Age = age;

    }

    public string GetDescription()
    {
        return ($"{Name} is {Age} years old");
    }
    
    public string Speak( string sound)
    {
         return ($"{Name} is {sound}");
    }






}