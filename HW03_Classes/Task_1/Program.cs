using System;
 
namespace ProjectC_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №3 Задание 1 ===\n");
            Education education = null;
            try
            {
                Console.Write("Введите год постройки учреждения образования: ");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine(".    .    .    .    .    .    .    .    .    .    .    .    .");
                education = new Education(year: year, institution: "БелГУТ", type: "Университет");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
                Console.ReadKey();
            }
 
            Console.WriteLine(education.ToString());
            Console.WriteLine("Изменяем фамилию министра на Карпенко.\n");
            Education.Minister_name = "Карпенко";
            Console.WriteLine(education.ToString());
 
            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            Console.WriteLine("Нажмите - любую кнопку...");
            Console.ReadKey();
        }
    }
}

