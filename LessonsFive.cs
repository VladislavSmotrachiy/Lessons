public class Five
{
    public static void FiveTask()
    {
        char c = Convert.ToChar(Console.ReadLine()!);
        for (char i = c; i <= 'z'; i++)
        {
            System.Console.Write(i + " ");
        }
    }
}