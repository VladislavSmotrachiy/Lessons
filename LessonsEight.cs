public class Eight
{
    public static void CheckNumber()
    {
        int[] numbers = new int[6];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 6;
        numbers[4] = 3;
        numbers[5] = 4;


        for (int i = 0; i < numbers.Length; i++)
        {

            if (i % 2 == 0)
            {
                Console.WriteLine($" Элемент: {numbers[i]}");
            }
        }

        int[] numbersTwo = new int[Convert.ToInt32(Console.ReadLine())];

        for (int i = 0; i < numbersTwo.Length; i++)
        {
            numbersTwo[i] = Convert.ToInt32(Console.ReadLine());

        }

        for (int i = 0; i < numbersTwo.Length; i++)
        {
            System.Console.WriteLine(numbersTwo[i]);
        }

    }

    public static void CheckNumber2()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[a];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < myArray.Length; i++)
        {

            if (myArray[i] % 3 == 0)
            {
                Console.WriteLine($" Элемент: {myArray[i]}");
            }
        }
    }
}