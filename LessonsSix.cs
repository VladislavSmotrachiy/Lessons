public class Six
{
    public static void GetCountText()
    {
        string? text = Console.ReadLine();
        int count = 1;// 1 потому что понимаем это будет первое слово 

        for (int i = 0; i < text?.Length; i++)
        {
            if ((int)text[i] == 32)
            {
                count++;
            }
        }
        System.Console.WriteLine(count);

    }

    public static void GetCharForText()
    {

        string? text = Console.ReadLine();
        bool marker = false; // маркер проверки нахождения символов

        for (int i = 0; i < text?.Length; i++)
        {
            if ((int)text[i] == 87 || (int)text[i] == 119)
            {
                System.Console.WriteLine(text[i]);
                marker = true;
                break;
            }
            else if ((int)text[i] == 88 || (int)text[i] == 120)
            {
                System.Console.WriteLine(text[i]);
                marker = true;
                break;
            }
        }
        if (!marker) // проверяю если после проверки строки на симфол маркер не стал True
        {
            System.Console.WriteLine("-1");
        }

    }
}