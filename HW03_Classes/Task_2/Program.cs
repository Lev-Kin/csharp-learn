using System;
 
namespace ProjectC_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №3 Задание 2 ===\n");
 
            Console.WriteLine("Введите данные по книге:");
            Console.Write("1) Название --> ");
            string title = Console.ReadLine();
            Console.Write("2) Автор --> ");
            string author = Console.ReadLine();
            Console.Write("3) Тираж --> ");
            int edition = int.Parse(Console.ReadLine());
            Console.Write("4) Стоимость --> ");
            double cost = double.Parse(Console.ReadLine());
            Console.WriteLine("\n.    .    .    .    .    .    .    .    .    .    .    .    .\n");
 
            Book book1 = new Book();
            Book book2 = new Book(title, author, edition, cost);
            Console.WriteLine("\t=== Книга 1 ===");
            Console.WriteLine(book1.ToString());
            Console.WriteLine("\t=== Книга 2 ===");
            Console.WriteLine(book2.ToString());
            Console.WriteLine("Общий тираж : {0}", Book.SameEdition(book1, book2));
            Console.WriteLine("\n-------------------------------------------------------------\n");
 
            Console.WriteLine("Изменяем издательство на \"Михалыч(R)\".\n"); // (R) - \u24C7
            Book.Typography = "Михалыч(R)";
            Console.WriteLine("\t=== Книга 1 ===");
            Console.WriteLine(book1.ToString());
            Console.WriteLine("\t=== Книга 2 ===");
            Console.WriteLine(book2.ToString());
 
            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            Console.WriteLine("Нажмите - любую кнопку...");
            Console.ReadKey();
        }
    }
}

