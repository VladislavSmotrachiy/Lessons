public class Three
{
    public static void Сycle()
    {
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine("BB");

        }
        System.Console.WriteLine("CCC");
        for (int i = 0; i < 4; i++)
        {
            System.Console.WriteLine("DDDD");
        }
        System.Console.WriteLine("E");
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("FFFFF");
        }
        System.Console.WriteLine("GG");




        System.Console.WriteLine("ww");

        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("B");

        }

        System.Console.WriteLine("DDD");
        System.Console.WriteLine("FFF");


        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("GG");
        }

        System.Console.WriteLine("EE");
        System.Console.WriteLine("HH");


        for (int i = 0; i < 19; i++)
        {
            System.Console.WriteLine("Привет Андрей!");

        }

        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            System.Console.WriteLine("Привет Андрей! " + i);
        }

        int numberTwo = Convert.ToInt32(Console.ReadLine());
        string? word = Console.ReadLine();

        for (int i = 0; i < number; i++)
        {
            System.Console.WriteLine(word + " " + i);
        }
    }


    public static void СycleTwo()
    {
        int count = Convert.ToInt32(Console.ReadLine());
        int countTwo = 0;

        for (int i = 0; i < count; i++)
        {
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberTwo % 10 == 0)
            {
                countTwo += 1;
            }
        }
        System.Console.WriteLine("Чисел с окончанием на 0" + " " + countTwo + "шт");

        int number = 0;
        int countThree = 0;

        for (int i = 0; i < count; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                countThree += 1;
            }
        }

        if (countThree >= 1)
        {
            System.Console.WriteLine("Yes");
        }
        else
        {
            System.Console.WriteLine("No");
        }
    }





}