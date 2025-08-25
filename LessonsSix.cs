public class Six
{
    public static void GetChar()
    {
        string? text = Console.ReadLine();
        int count = 1;// 1 потому что понимаем это будет первое слово 
        bool marker = true; // маркер которы будет остлиживать когда будет пробел

        for (int i = 0; i < text.Length; i++)
        {
            int nuberChar = (int)text[i];

            if (nuberChar != 32)
            {
                marker = false;
            }
            else
            {
                marker = true;
                count++;
            }
        }
        System.Console.WriteLine(count);

    }

    








}