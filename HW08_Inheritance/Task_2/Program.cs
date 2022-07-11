using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №8 Задание 2 ===\n");

            try
            {
                Polygon[] polygon =
                {
                    new Triangle (6,7,9),
                    new Rectangle(4,2),
                    new Triangle (3,4,5),
                    new Rectangle(2,5),
                };

                Console.WriteLine("\tТаблица - Фигур с их заданными параметрами.");
                Console.WriteLine("\t╔════════════════╦══════════════╦════════════╦══════════╗");
                Console.WriteLine("\t║     Фигура     ║   Стороны    ║   Площадь  ║ Периметр ║");
                Console.WriteLine("\t╠════════════════╬══════════════╬════════════╬══════════╣");
                for (int i = 0; i < 4; ++i)
                {
                    Console.WriteLine(polygon[i].ToString());
                }
                Console.WriteLine("\t╚════════════════╩══════════════╩════════════╩══════════╝");
                Console.WriteLine("\n-------------------------------------------------------------------------------\n");

                Array.Sort(polygon);

                Console.WriteLine("\tТаблица - Фигур отсортированных по убыванию площади.");
                Console.WriteLine("\t╔════════════════╦══════════════╦════════════╦══════════╗");
                Console.WriteLine("\t║     Фигура     ║   Стороны    ║   Площадь  ║ Периметр ║");
                Console.WriteLine("\t╠════════════════╬══════════════╬════════════╬══════════╣");
                foreach (Polygon p in polygon)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine("\t╚════════════════╩══════════════╩════════════╩══════════╝");
                Console.WriteLine("\n-------------------------------------------------------------------------------\n");

                Console.Write("Задайте площадь для сравнения площадей заданных фигур: ");
                int square = Convert.ToInt32(Console.ReadLine());
                if (square <= 0)
                {
                    throw new Exception("Площадь не может быть меньше или равно нулю!");
                }

                int j = 0;
                foreach (Polygon p in polygon)
                {
                    if (p.S() < square)
                    {
                        j++;
                    }
                }
                Console.WriteLine("Количество фигур, площадь которых меньше заданной = " + j);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

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
