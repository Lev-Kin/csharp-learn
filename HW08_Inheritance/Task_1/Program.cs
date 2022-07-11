using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №8 Задание 1 ===\n");

            Product[] products =
            {
                new Product("Коньяк 7 Звезд", 77.77M, 1),
                new Product("Лимон 1 кг",  3.99M, 1),
                new FixedDiscountProduct("Сыр Пармезан Классический 45% 1 кг", 17.09M, 1, 2.09M),
                new FixedDiscountProduct("Вода минеральная Боржоми 1л", 3.99M, 3, 0.99M),
                new DiscountedProduct("Виноград зеленый 1кг", 9.99M, 2, 1.09m),
                new DiscountedProduct("Миндаль 1 кг", 24.49M, 1, 0.45m)
            };

            Product maxCostProduct = products[0];
            bool equal = true;

            Console.WriteLine("Товары:\n");
            foreach (var item in products)
            {
                if (equal)
                {
                    equal = maxCostProduct.Equals(item);
                }

                if (item.GetCost() > maxCostProduct.GetCost())
                {
                    maxCostProduct = item;
                }

                Console.WriteLine(item.Name + " - " + item.GetCost());
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("Результат:\n");
            Console.WriteLine("Покупка с максимальной стоимостью - " + maxCostProduct.Name);
            Console.WriteLine("Являются ли покупки равными? - " + (equal ? "ДА" : "НЕТ").ToString());

            Console.WriteLine("\n\t\t\t╔═════════════════╗");
            Console.WriteLine("\t\t\t║   До свидания   ║");
            Console.WriteLine("\t\t\t╚═════════════════╝\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
            //Console.ReadKey();

        }
    }
}
