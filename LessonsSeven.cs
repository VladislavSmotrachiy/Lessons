using System.Net.WebSockets;

public class Seven
{

    public static void GetText()
    {
        System.Console.WriteLine(" Злых людей нет на свете, есть только люди несчастливые");
    }
    public static void Repeat(string word, int count)
    {
        for (int i = 0; i < count; i++)
        {
            System.Console.WriteLine(word);
        }
    }

    public static string GetMessage()
    {
        string text = "В час жаркого весеннего заката на Патриарших прудах появилось двое граждан";
        return text;

    }
    public static int GetNumber(int numberOne, int numberTwo, char character)
    {
        int answer = 0;
        if (character == '+')
        {
            answer = numberOne + numberTwo;
            System.Console.WriteLine(answer);
        }
        else if (character == '-')
        {
            answer = numberOne - numberTwo;
            System.Console.WriteLine(answer);
        }
        else if (character == '*')
        {
            answer = numberOne * numberTwo;
            System.Console.WriteLine(answer);
        }
        else if (character == '/'  && numberTwo > 0)
        {
            answer = numberOne / numberTwo;
            System.Console.WriteLine(answer);
        }
        else
        {
            System.Console.WriteLine("не сегодня");
        }

        return answer;
    }
}