using System;
 
namespace ProjectC_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №3 Задание 3 ===\n");
 
            University univer1 = new University();
            University univer2 = new University
                (
                year: 1953,
                rector: "Ю.И Кулаженко",
                quantity: 10000,
                univer: "БелГУТ"
                );
            Console.WriteLine(univer1.ToString());
            Console.WriteLine("\n.    .    .    .    .    .    .    .    .    .    .    .    .\n");
            Console.WriteLine(univer2.ToString());
            Console.WriteLine("\n-------------------------------------------------------------\n");
 
            if (University.Compare(univer1, univer2) == 100)
                Console.WriteLine("ГГТУ им. П.О.Сухого обучает больше студентов, чем БелГУТ.\n");
            if (University.Compare(univer1, univer2) == -100)
                Console.WriteLine("ГГТУ им. П.О.Сухого обучает меньше студентов, чем БелГУТ.\n");
            if (University.Compare(univer1, univer2) == 0)
                Console.WriteLine("Количество студентов ,обучаемых в данных университетах одинаково.");
            Console.WriteLine("-------------------------------------------------------------\n");
 
            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            Console.WriteLine("Нажмите - любую кнопку...");
            Console.ReadKey();
        }
    }
}

