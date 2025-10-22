// See https://aka.ms/new-console-template for more information
using System;
public class FunctionsExample
{
    public static void Main(string[] args)
    {

        Console.WriteLine($" Создайте школу:  ");
        School school1 = new School(Console.ReadLine());
        School school2 = new School(Console.ReadLine());
        Console.WriteLine($" Отлично!!  ");
        List<School> schools = new List<School>();
        schools.Add(school1);
        schools.Add(school2);


  
        Console.WriteLine($" Выберите школу  ");
        foreach (School school in schools)
        {
            System.Console.Write($" {school.SchoolName} \t ");
        }





    }
}
