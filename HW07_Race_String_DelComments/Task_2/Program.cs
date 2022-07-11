using System;
using System.Linq;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №7 Задание 2 ===\n");

            Console.WriteLine("Текст для обработки согласно условию задания:\n");
            Console.WriteLine("Мама, ax ax,, мыла раму 25/05/2015 ух;25раз!!!\n" +
                "Потом 26/05/2015 смотрела, ох долго, фх,фх Дом2!...\n" +
                "Без хх труда не выловишь и рыбку из пруда?!! 27/05/2015 она ых отдыхала...");

            var data = "Мама, ax ax,, мыла раму 25/05/2015 ух;25раз!!!" +
                " Потом 26/05/2015 смотрела, ох долго, фх,фх Дом2!..." +
                " Без хх труда не выловишь и рыбку из пруда?!! 27/05/2015 она ых отдыхала...";

            var lines = data.Split('!', '?', '.').Where(x => !string.IsNullOrWhiteSpace(x));

            var words = lines.Select(x => x.Split(' ', ',', ';').Where(s =>
             !string.IsNullOrWhiteSpace(s) &&
             !new[] { 'x', 'х' }.Any(s.ToLower().Contains)).ToList());

            var result = words.Where(x => x.Count >= 3 &&
            x.Any(a => DateTime.TryParse(a, out _))).Select(x =>
            x.Select(s => s.Any(char.IsDigit) ? $"({s})" : s).ToList()).ToList();

            Console.WriteLine("\n-------------------------------------------------------------------------------\n");
            Console.WriteLine("Результат:\n");

            result.ForEach(x => Console.WriteLine(string.Join(" ", x.Skip(Math.Max(0, x.Count - 2)))));

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
