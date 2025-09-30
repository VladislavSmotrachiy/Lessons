public class Nine
{

    public static void Calculater()
    {
        int answer = 0;
        System.Console.WriteLine("Ввиди символ");
        char character = Convert.ToChar(Console.ReadLine()!);
        System.Console.WriteLine("Число");
        int numberOne = Convert.ToInt32(Console.ReadLine()!);
        System.Console.WriteLine("Второе Число");
        int numberTwo = Convert.ToInt32(Console.ReadLine()!);

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
        else if (character == '/' && numberTwo > 0)
        {
            answer = numberOne / numberTwo;
            System.Console.WriteLine(answer);
        }
        else
        {
            System.Console.WriteLine("не сегодня");
        }

    }

    public static void Questionnaire()
    {
        System.Console.WriteLine("Привет, ввиде свое имя");
        string name = Console.ReadLine()!;
        System.Console.WriteLine(" теперь фамилию");
        string surname = Console.ReadLine()!;
        System.Console.WriteLine("сколько тебе лет?");
        int age = Convert.ToInt32(Console.ReadLine()!);

        System.Console.WriteLine($"Отлично, приятно познакомиться, {name + surname}, тебе уже {age}лет");
    }

    public static void StartGame()
    {
        System.Console.WriteLine("Привет, хочшеь сыграть в игру?");
        int answer = 0;

        while (answer != 3){
        System.Console.WriteLine("Тебе нужно выбрать, 1:калькулятор; 2: опросник; 3: выход");
        answer = Convert.ToInt32(Console.ReadLine()!);
       
            if (answer == 1)
            {
                Calculater();
            }
            else if (answer == 2)
            {
                Questionnaire();
            }
        }
    }
}