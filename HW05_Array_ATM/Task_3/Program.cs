using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №5 Задание 3 ===\n");

            bool check = true;
            Buy[] purchase = new Buy[6];
            purchase[0] = new Buy();
            purchase[1] = new Buy("Лимон 1 кг", 3.99M, 1);
            purchase[2] = new Buy("Миндаль 1 кг", 24.49M, 1);
            purchase[3] = new Buy("Сыр Пармезан Классический 45% 1 кг", 17.09M, 1);
            purchase[4] = new Buy("Виноград зеленый 1кг", 9.99M, 1);
            purchase[5] = new Buy("Вода минеральная Боржоми 1л", 3.99M, 3);

            Buy max = purchase[0];
            for (int i = 0; i < purchase.Length; i++)
            {
                Console.WriteLine(purchase[i]);
                max = (max.GetCost() > purchase[i].GetCost()) ? max : purchase[i];
                if (!purchase[0].Equals(purchase[i]))
                    check = false;
            }
            if (check)
                Console.WriteLine("\nПокупки равны.\n");
            else
                Console.WriteLine("\nПокупки не равны.\n");

            Console.WriteLine(max + "\nявляется покупкой с максимальной стоимостью.\n");

            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую клавишу...");
            //Console.ReadKey();
        }
    }
}