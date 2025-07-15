// See https://aka.ms/new-console-template for more information
using System;
vlad.nikitenkov95@gmail.com
public class FunctionsExample
{
    public static void Main(string [] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Здравствуй,");
        Console.WriteLine("Василий!");
        Console.WriteLine("");
        Console.WriteLine("Здравствуй, Василий!");
        Console.Write("Здравствуй, ");
        Console.WriteLine("Василий!");
        Console.WriteLine("");

        string result = "";
        for (int i = 0; i < 5; i++)
        {
            result += "*";
            Console.WriteLine(result);
        }
        Console.WriteLine("");
    }
}
