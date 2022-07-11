using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №6 Задание 2.1 ===\n");

            Console.Write("Введите сообщение: ");
            var str1 = Console.ReadLine();
            var str2 = "";
            if (str1 != null)
                for (var i = 0; i < str1.Length; i++)
                {
                    if (i == 0)
                        str2 += str1[i].ToString();
                    else if (str1[i] == '.' || str1[i] == '?' || str1[i] == '!')
                    {
                        str2 += str1[i].ToString();
                        i += 1;
                        str2 += str1[i].ToString().ToUpper();
                    }
                    else
                        str2 += str1[i].ToString().ToLower();
                }

            Console.WriteLine("Преобразованное сообщение: ");
            Console.WriteLine(str2);
            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую клавишу...");
            //Console.ReadKey();
        }
    }
}
