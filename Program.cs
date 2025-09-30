// See https://aka.ms/new-console-template for more information
using System;
public class FunctionsExample
{
    public static void Main(string[] args)
    {

        Users users1 = new Users();
        users1.Name = "Влад";
        users1.lastName = "Смотрящий";
        users1.age = 30;
        users1.Faculty.PhoneNumber = "+7922323212";
        users1.Faculty.Profession = "Экономист";
        users1.Faculty.Сourse = '3';
        users1.Faculty.Salary = 1400000;
        users1.maritalStatus.Status = "активный поиск";
        users1.maritalStatus.Years = '2';


        Users users2 = new Users();
        users2.Name = "Вита";
        users2.lastName = "Гришина";
        users2.age = 30;
        users2.Faculty.PhoneNumber = "+79992321231";
        users2.Faculty.Profession = "Логист";
        users2.Faculty.Сourse = '2';
        users2.Faculty.Salary = 1000000;
        users2.maritalStatus.Status = "активный поиск";
        users2.maritalStatus.Years = '1';


        users1.PrintUsers();
        CheckSimilarity.Chek(users1.maritalStatus.Status, users2.maritalStatus.Status);

        

    }
}
