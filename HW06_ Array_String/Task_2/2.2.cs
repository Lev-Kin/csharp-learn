using System;
using System.Linq;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №6 Задание 2.2 ===\n");
            Console.Write("\tВведите строку:\n [str]  ");
            string str = Console.ReadLine();

            string chCompare = "";
            int chUnique = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!chCompare.Contains(str[i]) && (str[i] != ' '))
                {
                    chCompare += str[i];
                    {
                        chUnique++;
                    }

                }
            }

            Console.WriteLine("\n------------------------------------------------\n");
            Console.WriteLine($"Введенной строке ({chUnique}) различных символов."); ;

            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую клавишу...");
            //Console.ReadKey();
        }
    }
}
