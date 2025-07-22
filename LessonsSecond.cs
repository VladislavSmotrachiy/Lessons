using System;

public class Second
{
    public static void getNumber()
    {
        System.Console.WriteLine("номер билета");
        int number = Convert.ToInt32(Console.ReadLine());
        int first = number / 100000;
        int second = number / 10000 % 10;
        int thri = number / 1000 % 10;
        int four = number / 100 % 10;
        int five = number / 10 % 10;
        int six = number / 1 % 10;

        int sum = first + second + thri;
        int sumSecond = four + five + six;

        System.Console.WriteLine(first);
        System.Console.WriteLine(second);
        System.Console.WriteLine(thri);
        System.Console.WriteLine(four);
        System.Console.WriteLine(five);
        System.Console.WriteLine(six);

        if (sum == sumSecond)
        {
            System.Console.WriteLine("Yes");
        }
        else
        {
            System.Console.WriteLine("No");
        }

    }

    public static void calculater()
    {

        System.Console.WriteLine("Число");
        int number = Convert.ToInt32(Console.ReadLine());
        string operato = Console.ReadLine();
        int numberSecond = Convert.ToInt32(Console.ReadLine());

        if (operato != "/" && operato != "*" && operato != "-" && operato != "+")
        {
            System.Console.WriteLine("ошибка у тебя ничего не получиться");

        }
        else
        {
            if (operato == "/")
            {
                if (number == 0 || numberSecond == 0)
                {
                    System.Console.WriteLine("делить на 0 нельзя");
                }
                else
                {
                    System.Console.WriteLine(number / numberSecond);
                }
            }
            else if (operato == "*")
            {
                if (number == 0 || numberSecond == 0)
                {
                    System.Console.WriteLine("умножать на 0 нельзя");
                }
                else
                {
                    System.Console.WriteLine(number * numberSecond);
                }
            }
            else if (operato == "-")
            {
                System.Console.WriteLine(number - numberSecond);
            }
            else if (operato == "+")
            {
                System.Console.WriteLine(number + numberSecond);
            }
        }



    }


}