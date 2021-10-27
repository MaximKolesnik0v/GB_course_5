using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте вас приветствует математическая программа \nПожалуйста введите число: \nДля выхода нажмите Q");

        String S = Console.ReadLine();

        if (S == "q" || S == "Q")
        {
            Console.WriteLine("До свидания");
            return;
        }
        int M = Int32.Parse(S);
        int c1 = 1; int c2 = 0;
        int c3 = 0;
        for (int i = 1; i <= M; i++)
        {
            c1 = c1 * i;
            c2 = c2 + i;
            if (i % 2 == 0)
            {
                c3 = i;
            }
        }

        Console.WriteLine($"Факториал равет {c1} \nСумма цифр от 1 до {S} равна {c2} \nМаксимальное четное число меньше N равно {c3} " );
        Console.ReadLine();
    }
}