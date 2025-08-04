public class Three
{
    public static void TasksThreePointOne()
    {
        // Задача 1
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

        // Задача 2

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

        // Задача 3

        for (int i = 0; i < 19; i++)
        {
            System.Console.WriteLine("Привет Андрей!");

        }

        // Задача 4

        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            System.Console.WriteLine("Привет Андрей! " + i);
        }

        // Задача 5

        int numberTwo = Convert.ToInt32(Console.ReadLine());
        string? word = Console.ReadLine();

        for (int i = 0; i < number; i++)
        {
            System.Console.WriteLine(word + " " + i);
        }
    }


    public static void TasksThreePointTwo()
    {
        // Задача 1
        int count = Convert.ToInt32(Console.ReadLine());
        int countTwo = 0;

        for (int i = 0; i < count; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 10 == 0)
            {
                countTwo += 1;
            }
        }
        System.Console.WriteLine("Чисел с окончанием на 0" + " " + countTwo + "шт");

        // Задача 2

        int countNumber = 0;
        int countThree = 0;

        for (int i = 0; i < count; i++)
        {
            countNumber = Convert.ToInt32(Console.ReadLine());
            if (countNumber == 0)
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

    public static void TasksThreePointTwoPointOne()
    {
        // Задача 1
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine(i);
            }
        }
    }
    public static void TasksThreePointThree()
    {
        // Задача 1
         System.Console.WriteLine("Задача 1");
        int number = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;

        for (int i = factorial; i <= number; i++)
        {
            if ((i % 2) == 0)
            {
                factorial *=  i;
            }
        }
        System.Console.WriteLine(factorial);

        // Задача 2
        System.Console.WriteLine("Задача 2");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        int factorialTwo = 1;

        for (int i = numberOne; i <= numberTwo; i++)
        {
            factorialTwo *= i;
        }
        System.Console.WriteLine(factorialTwo);

    }

}