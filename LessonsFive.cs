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

    public static void GetChar()
    {
        char c = Convert.ToChar(Console.ReadLine()!);
        int nuberChar = (int)c;
        // int nuberCharTwo = nuberChar - 32;


        if (nuberChar <= 65 && nuberChar <= 124)
        {
            System.Console.WriteLine(" сэтим ничего недлья сделать");
        }
        else if (nuberChar >= 65 && nuberChar <= 96)
        {
            System.Console.WriteLine(Convert.ToChar(nuberChar + 32));
        }
        else
        {
            System.Console.WriteLine(Convert.ToChar(nuberChar - 32));
        }
    }
}