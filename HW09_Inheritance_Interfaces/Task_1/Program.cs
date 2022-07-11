using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №9 Задание 2 ===\n\n");

            Commodity[] commodity =
            {
                new Commodity("Коньяк 7 Звезд", 77.77M, 1095, new DateTime(2020, 09, 25)),
                new Commodity("Вода минеральная Боржоми 1л", 3.99M, 270, new DateTime(2021,01,2)),
                new Commodity("Виноград зеленый 1кг", 9.99M, 60, new DateTime(2020,11,12)),
                new Commodity("Миндаль 1 кг",  24.49M, 230, new DateTime(2020,07,12)),
                new Commodity("Сыр Пармезан Классический 45% 1 кг", 17.09M, 61, new DateTime(2021,01,15))
            };

            AbstractPurchase[] purchase =
            {
                new Reduce(5,2,commodity[0]),
                new Reduce(5,2,commodity[1]),
                new Reduce(10,5,commodity[1]),
                new Оutlay(1.99m,7,commodity[2]),
                new Оutlay(8.00m,7,commodity[3]),
                new Оutlay(3.09m,7,commodity[4]),
            };

            foreach (AbstractPurchase item in purchase)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Array.Sort(purchase);

            Console.WriteLine("\nМассив после сортировки:\n");
            foreach (AbstractPurchase item in purchase)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\nОбъединяем покупки \"Вода минеральная Боржоми 1л\" в одну покупку:\n");
            AbstractPurchase water = purchase[3];
            for (int i = 0; i < purchase.Length; i++)
            {
                if (i != 3)
                    try
                    {
                        water += purchase[i];
                    }
                    catch { };
            }
            Console.WriteLine(water);
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\nПокупки с истечением срока годности менее 7 дней:\n");
            foreach (AbstractPurchase item in purchase)
            {
                if ((item.Product.GetExpirationDate() - DateTime.Now).TotalDays < 7)
                    Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

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
