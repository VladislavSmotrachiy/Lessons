public class Four
{
    public static void TasksFour()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        while (number > 0)
        {
            int check = number % 10;
            sum = sum + check;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            System.Console.WriteLine("Yes");
        }
        else
        {
            System.Console.WriteLine("NO");
        }

    }

    public static void FourTastTwo()
    {
    int number = Convert.ToInt32(Console.ReadLine());
    while (number > 0)
        {
            int check = number % 10;
            number /= 10;
            System.Console.Write(check);
        }
}



}