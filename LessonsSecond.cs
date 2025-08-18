using System;

public class Second
{
    public static void getNumber()
    {
        System.Console.WriteLine("номер билета");
        int number = Convert.ToInt32(Console.ReadLine());
        int first = number / 100000;
        int second = number / 10000 % 10;
        int three = number / 1000 % 10;
        int four = number / 100 % 10;
        int five = number / 10 % 10;
        int six = number / 1 % 10;

        int sum = first + second + three;
        int sumSecond = four + five + six;

        System.Console.WriteLine(first);
        System.Console.WriteLine(second);
        System.Console.WriteLine(three);
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

    public static void calculate()
    {


        System.Console.WriteLine("Число");
        int number = Convert.ToInt32(Console.ReadLine());
        string? operato = Console.ReadLine() ?? " ну и что ты ввел придерживайся условия";
        int numberSecond = Convert.ToInt32(Console.ReadLine());


        if (operato != "/" && operato != "*" && operato != "-" && operato != "+")
        {
            System.Console.WriteLine("ошибка у тебя ничего не получиться");

        }
        else
        {
            if (operato == "/")
            {
                if (numberSecond == 0)
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
                System.Console.WriteLine(number * numberSecond);
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

    public static void testMonth()
    {
        System.Console.WriteLine("Введи месяц");
        int month = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1: Console.WriteLine("Январь 31день."); break;
            case 2: Console.WriteLine("Феварль 28 день"); break;
            case 3: Console.WriteLine("Март 30 день"); break;
            case 4: Console.WriteLine("Апрель 31день"); break;
            case 5: Console.WriteLine("Май 30 дней"); break;
            case 6: Console.WriteLine("Июнь 31 "); break;
            case 7: Console.WriteLine("Июль 31"); break;
            case 8: Console.WriteLine("август 31"); break;
            case 9: Console.WriteLine("сентябрь 30!"); break;
            case 10: Console.WriteLine("Октябрь 31"); break;
            case 11: Console.WriteLine("ноябрь 30"); break;
            case 12: Console.WriteLine("декабрь 31"); break;
            default: Console.WriteLine("Пока еще не приудмали такой месяц и там дней 0"); break;
        }
    }


}