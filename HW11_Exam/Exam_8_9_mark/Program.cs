using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LevanovExamCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\n\t\t=== Экзаменационная работа. Задача на \"8\" - \"9\" ===\n\n");

            Collection<Sportsman> collect = new Collection<Sportsman>();
            Console.WriteLine("\t\t\t=== 1 ===\n\n" +
            "Считываем из текстового файла данные о спортсменах \n" +
            "и создаем объект-коллекцию с элементами соответствующего типа.\n\nРезультат:");
            try
            {
                using (StreamReader sr = new StreamReader("Sport.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] rec = line.Split(';');
                        switch (rec[2])
                        {
                            case "Гимнаст":
                                collect.Add(new Gymnast(rec[0], int.Parse(rec[1]))
                                {
                                    Ring = double.Parse(rec[3]),
                                    Bars = double.Parse(rec[4]),
                                    Jump = double.Parse(rec[5])
                                });
                                break;

                            case "Пловец":
                                double[] res = new double[rec.Count() - 3];
                                for (int i = 3; i < rec.Count(); i++)
                                    res[i - 3] = double.Parse(rec[i]);
                                collect.Add(new Swimmer(rec[0], int.Parse(rec[1]))
                                {
                                    Swim = res
                                });
                                break;
                        }
                    }
                    Console.WriteLine("Файл \"Sport.txt\" - успешно считан.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Не удалось прочитать файл:");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 2 ===\n\n" +
            "Выводим на экран всю информацию.\n\nТаблица - Данные спортсменов");
            Table.Show(collect);
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 3 ===\n\n" +
            "Сортируем информацию по убыванию возраста с использованием класса,\n" +
            "реализующего интерфейс IСomparer\n\nТаблица - Возраст спортсменов по убыванию");
            collect.Sort(new Сomparison());
            Table.Show(collect);
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 4 ===\n\n" +
            "Сериализуем коллекцию в двоичном формате.\n\nРезультат:");
            collect.Serialization("Sport.bin", new BinaryFormatter());
            Console.WriteLine("Колекция сериализована в двоичном формате \"Sport.bin\" - записан.");
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 5 ===\n\n" +
            "Выводим на экран информацию о пловцах моложе 20 лет\n " +
            "с указанием среднего результата в 1-м, 2-м и 5-м заплывах.\n\nТаблица - Информация о пловцах моложе 20 лет");
            List<Sportsman> sw = collect.Where(s => s.GetType() == typeof(Swimmer) && s.Age < 20).ToList();
            Console.WriteLine("╔══════════════╦═══════╦═══════════════╦════════════════╗");
            Console.WriteLine("║     Name     ║  Age  ║     Sport     ║ Average result ║");
            foreach (Sportsman s in sw)
            {
                Console.WriteLine("╠══════════════╬═══════╬═══════════════╬════════════════╣");
                Console.WriteLine("║ {0, -12} ║ {1, -5} ║ {2, -13} ║ {3, -14} ║",
                    s.Name, s.Age, s.Kind, (s as Swimmer).AverageResult(1, 2, 5));
            }
            Console.WriteLine("╚══════════════╩═══════╩═══════════════╩════════════════╝");
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 6 ===\n\n" +
            "Сравниваем двух указанных гимнастов по результатам.\n\nВведите фамилию:");
            try
            {
                Gymnast g1 = null;
                Gymnast g2 = null;

                Console.Write("Первого гимнаста -> ");
                string s1 = Console.ReadLine();
                g1 = collect.Where(g => g.Name.Contains(s1)).Single() as Gymnast;

                Console.Write("Второго гимнаста -> ");
                string s2 = Console.ReadLine();
                g2 = collect.Where(g => g.Name.Contains(s2)).Single() as Gymnast;

                Console.WriteLine("\n\nРезультат:");
                if (g1 > g2)
                    Console.WriteLine("{0} лучший по результатам.", g1.Name);
                else if (g1 < g2)
                    Console.WriteLine("{0} лучший по результатам.", g2.Name);
            }
            catch
            {
                Console.WriteLine("Гимнаст с такой фамилией не найден.");
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 7 ===\n\n" +
            "Сериализуем информацию о гимнастах в формате XML.\n\nРезультат:");
            Type[] types = { typeof(Gymnast), typeof(Swimmer) };
            collect.Serialization("Sport.xml", new XmlSerializer(typeof(Collection<Sportsman>), types));
            Console.WriteLine("Информация сериализована в формате XML \"Sport.xml\" - записан.");
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 8 ===\n\n" +
            "Выводим на экран фамилию слушателя, текущую дату и время.\n\nРезультат:");
            Console.WriteLine("Леванов.  Дата: " + DateTime.Now);
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\n\t\t\t╔═════════════════╗");
            Console.WriteLine("\t\t\t║   До свидания   ║");
            Console.WriteLine("\t\t\t╚═════════════════╝\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}

