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
        users1.Gender = 'М';
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
        users2.Gender = 'Ж';
        users2.Faculty.PhoneNumber = "+79992321231";
        users2.Faculty.Profession = "Логист";
        users2.Faculty.Сourse = '2';
        users2.Faculty.Salary = 1000000;
        users2.maritalStatus.Status = "активный поиск";
        users2.maritalStatus.Years = '1';


        Users users3 = new Users();
        users3.Name = "Гриша";
        users3.lastName = "Петров";
        users3.age = 16;
        users3.Gender = 'М';
        users3.Faculty.PhoneNumber = "+79344321231";
        users3.Faculty.Profession = "Слесарь";
        users3.Faculty.Сourse = '1';
        users3.Faculty.Salary = 40000;
        users3.maritalStatus.Status = "активный поиск";
        users3.maritalStatus.Years = '1';

        Users users4 = new Users();
        users4.Name = "Роза";
        users4.lastName = "Маркина";
        users4.Gender = 'Ж';
        users4.age = 56;
        users4.Faculty.PhoneNumber = "+79992321231";
        users4.Faculty.Profession = "Бухалтер";
        users4.Faculty.Salary = 55000;
        users4.maritalStatus.Status = "Замужем";
        users4.maritalStatus.Years = '9';





        List<Users> users = new List<Users>();
        users.Add(users1);
        users.Add(users2);
        users.Add(users3);
        users.Add(users4);


        foreach (Users user in users)
        {
            if (users1.Gender != user.Gender)
            {
                System.Console.WriteLine("совпало" + user.Gender);

            }

        }

        CheckSimilarity.Chek(users1.maritalStatus.Status, users2.maritalStatus.Status);
    }
}
