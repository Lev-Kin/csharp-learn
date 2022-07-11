using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №6 Задание 2.4 ===\n");

            int wordCount = 0;

            Console.Write("\tВведите строку:\n [str]  ");
            string str = Console.ReadLine();

            Console.Write("\n\tВведите слово для поиска в строке:\n [word] ");
            string wordFind = Console.ReadLine();

            string[] word = str.Split(' ');
            foreach (string wordCompare in word)
            {
                if (wordCompare == wordFind)
                {
                    ++wordCount;
                }
            }

            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            if (wordCount > 0)
                Console.WriteLine($"Обнаружено _{wordCount}_ слов \"{wordFind}\" в веденной строке.\n");
            else
                Console.WriteLine($"Введенной строке слова {wordFind} не обнаружено."); ;
            
            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую клавишу...");
            //Console.ReadKey();
        }
    }
}
