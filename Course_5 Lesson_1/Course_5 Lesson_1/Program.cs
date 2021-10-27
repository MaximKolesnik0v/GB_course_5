using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Здравствуйте вас приветствует математическая программа \nПожалуйста введите целое,положительное число: \nДля выхода нажмите Q");

        String S = Console.ReadLine();

        if(S == "q" || S == "Q")
        {
            Console.WriteLine("До свидания");
            return;
        }

        int M;
        int c1 = 1;
        int c2 = 0;
        int c3 = 0;

        bool success = int.TryParse(S ,out M);

        if (success)
        {
            for (int i = 1; i <= M; i++)
            {
                c1 = c1 * i;
                c2 = c2 + i;
                if (i % 2 == 0)
                {
                    if (i - 2 % 2 != 0)
                    {
                        c3 = i - 2;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("До свидания");
            return;
        }

        Console.WriteLine($"Факториал равен {c1} \nСумма цифр от 1 до {S} равна {c2} \nМаксимальное четное число меньше N равно {c3} " );
        Console.ReadLine();
    }
}