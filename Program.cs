// See https://aka.ms/new-console-template for more information
using System;
public class FunctionsExample
{
    public static void Main(string[] args)
    {

        // Console.WriteLine("");
        // Console.WriteLine("Здравствуй,");
        // Console.WriteLine("Василий!");
        // Console.WriteLine("");
        // Console.WriteLine("Здравствуй, Василий!");
        // Console.Write("Здравствуй, ");
        // Console.WriteLine("Василий!");
        // Console.WriteLine("");

        // Console.WriteLine("првет, как тебя зовут?");
        // string name = Console.ReadLine();
        // Console.WriteLine("Привет!" + name);
        // Console.ReadLine();

        // string result = "";
        // for (int i = 0; i < 5; i++)
        // {
        //     result += "*";
        //     Console.WriteLine(result);
        // }
        // Console.WriteLine("");

        // int numOne = 0;
        // numOne += 6;
        // int numSecond = Convert.ToInt32(Console.ReadLine());
        // int numThri = Convert.ToInt32(Console.ReadLine());
        // int ask = numSecond + numThri;

        // System.Console.WriteLine(numSecond / numThri);
        // System.Console.WriteLine(numSecond % numThri);

        // System.Console.WriteLine("Ведите пароль");
        // string password = Console.ReadLine()!;

        // System.Console.WriteLine("Повторите пароль");
        // string passwordTWo = Console.ReadLine()!;
        // if (password == passwordTWo)
        // {
        //     System.Console.WriteLine("Пароль принят");
        // }
        // else
        // {
        //     System.Console.WriteLine("Упс ошибка");
        // }

        // System.Console.WriteLine("Ведите свой возраст");
        // int age = Convert.ToInt32(Console.ReadLine());

        // if (age > 12)
        // {
        //     System.Console.WriteLine("Доступ разрешон");

        // }
        // else if (age >= 12)
        // {
        //     System.Console.WriteLine("Доступ будет разрешен,заявка на расмотрение ");
        // }
        // else
        // {
        //     System.Console.WriteLine("Доступ запрещен!");
        // }
        System.Console.WriteLine("Первое чилсло");
        int oneNumber = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Второе чилсло");
        int twoNumber = Convert.ToInt32(Console.ReadLine());

        if (oneNumber == twoNumber)
        {
            System.Console.WriteLine("твои число " + oneNumber + " они имеют одинковое знаечение");
        } else if (oneNumber > twoNumber ){
            System.Console.WriteLine(oneNumber);
        }else if (oneNumber < twoNumber ){
            System.Console.WriteLine(twoNumber);
        }

    }

}
