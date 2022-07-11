using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №10 Задание 3 ===\n\n");

            List<Department> department = new List<Department>()
            {
                new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
                new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department(){ Id = 3, Country = "France", City = "Paris" },
                new Department(){ Id = 4, Country = "Russia", City = "Moscow" }
            };

            List<Employee> employee = new List<Employee>()
            {
                new Employee()
                {
                      Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2
                },
                new Employee()
                {
                      Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1
                },
                new Employee()
                {
                      Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3
                },
                new Employee()
                {
                      Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2
                },
                new Employee()
                {
                      Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4
                },
                new Employee()
                {
                      Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2
                },
                new Employee()
                {
                      Id = 7, FirstName = "Nikita", LastName = "Krotov", Age = 27, DepId = 4
                }
            };

            Console.WriteLine("\t\t=== Исходные данные ===\n");
            foreach (Department item in department)
            {
                Console.WriteLine(item.Id + ";\t" + item.Country + ";   \t" + item.City);
            }
            Console.WriteLine();
            foreach (Employee item in employee)
            {
                Console.WriteLine(item.Id + ";\t" + item.FirstName + ";   \t"
                    + item.LastName + ";   \t" + item.Age + ";\t" + item.DepId);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 1 ===\n\n" +
               "Упорядочить имена и фамилии сотрудников по алфавиту, проживающие в Украине.\n\nРезультат:");
            employee
                .Join
                (
                department,
                name => name.DepId,
                dept => dept.Id,
                (name, dept) => (name.FirstName, name.LastName, dept.Country)
                )
                .Where(country => country.Country == "Ukraine")
                .Select(list => (list.FirstName, list.LastName, list.Country))
                .OrderBy(list => list.FirstName)
                .ToList()
                .ForEach
                (list => Console.WriteLine(list.FirstName + ";   \t" + list.LastName + ";   \t" + list.Country));
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 2 ===\n\n" +
              "Отсортировать сотрудников по возрастам, по убыванию.\nВывести Id, FirstName, LastName, Age.\n\nРезультат:");
            employee
                .OrderByDescending(age => age.Age)
                .Select(newList => (newList.Id, newList.FirstName, newList.LastName, newList.Age))
                .ToList()
                .ForEach
                (list => Console.WriteLine(list.Id + ";   \t" + list.FirstName + ";   \t" + list.LastName + ";   \t" + list.Age));
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 3 ===\n\n" +
                "Сгруппировать студентов по возрасту.\nВывести возраст и сколько раз он встречается.\n\nРезультат:");
            employee
                .GroupBy(age => age.Age)
                .Select(group => (group.Key, Count: group.Count()))
                .ToList()
                .ForEach
                (list => Console.WriteLine(list.Key + ";   \t" + list.Count));
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

