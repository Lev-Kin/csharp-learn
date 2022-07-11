using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №6 Задание 2.3 ===\n");

            int wordCount = 0;
            string wordStr = "";

            Console.Write("\tВведите строку:\n [str]  ");
            string[] str = Console.ReadLine().ToLower().Split(" -,.:()[]{}\'\"".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in str)
            {
                if (word[0] == word[word.Length - 1])
                {
                    wordCount++;
                    wordStr += word + " ";
                }
            }

            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            if (wordCount > 0)
            {
                Console.WriteLine($"Обнаружено _{wordCount}_ слов заканчивающихся на одну и туже букву.\n");
                Console.WriteLine("Слова заканчивающихся на одну и туже букву в строке следующее:");
                Console.WriteLine(wordStr);
            }
            else
            {
                Console.WriteLine("Введенной строке слов заканчивающихся на одну и туже букву не обнаружено.");
            }

            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую клавишу...");
            //Console.ReadKey();
        }
    }
}
