using System;
using System.Linq;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №10 Задание 2 ===\n\n");

            int[] values1 = new int[5] { 1, 10, 5, 13, 4 };
            int[] values2 = new int[5] { 19, 1, 4, 9, 8 };

            var uniqueQuery = values1.Except(values2);
            var sortValues1Query = values1.OrderByDescending(list => list);
            var sortValues2Query = values2.OrderByDescending(list => list);

            Console.Write("\t\t\t=== 1 ===\n\n" +
                "Среднее значение четных элементов, которые больше 10.\nРезультат: ");
            Console.WriteLine($"{values1.Concat(values2).Where(list => list < 10 && (list % 2 == 0)).Average(list => list):f2}");
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.Write("\t\t\t=== 2 ===\n\n" +
                "Только уникальные элементы из массивов values1 и values2.\nРезультат: ");
            foreach (var item in uniqueQuery)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.Write("\t\t\t=== 3 ===\n\n" +
                "Максимальный элемент массива values2, который есть в массиве values1.\nРезультат: ");
            Console.WriteLine(values2.Join(values1, list => list, list2 => list2, (list, list2) => list).Max(list => list));
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.Write("\t\t\t=== 4 ===\n\n" +
                "Сумма элементов массивов values1 и values2,\nкоторые попадают в диапазон от 5 до 15\nРезультат: ");
            Console.WriteLine(values1.Concat(values2).Where(list => list >= 5 && list <= 15).Sum(list => list));
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.Write("\t\t\t=== 5 ===\n\n" +
                "Отсортированные элементы values1 и values2 по убыванию\nРезультат:");
            Console.Write("\tvalues1: ");
            foreach (var item in sortValues1Query)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            Console.Write("\t\tvalues2: ");
            foreach (var item in sortValues2Query)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
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

