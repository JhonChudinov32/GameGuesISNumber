using System;

namespace GameGuesISNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите начало интервала: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("конец интервала: ");
            int y = int.Parse(Console.ReadLine());

            Random rand = new Random();

            int A = rand.Next(x, y);
            int l = 0;
            while (true)
            {
                Console.WriteLine("Введите число");

                int B = int.Parse(Console.ReadLine());

                l++;
                if (B == A)
                {
                    Console.WriteLine("Вы угадали c {0} попытки:", l);

                    break;
                }

                else if (B > A)
                {
                    Console.WriteLine("Ваше число больше");
                }
                else
                {
                    Console.WriteLine("Ваше число меньше");
                }

            }
            Console.WriteLine("Нажмите q для выхода");
            if (Console.Read() != 'q')
                Main();

        }
    }
}
