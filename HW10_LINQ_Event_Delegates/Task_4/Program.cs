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
            Console.WriteLine("\t\t=== Домашняя работа №10 Задание 5 ===\n\n");

            List<Salary> salary = new List<Salary>()
            {
                new Salary(){ Id = 1,  Position = "Chief", Wage = 7777.77m },
                new Salary(){ Id = 2,  Position = "Accountant", Wage = 3003.23m },
                new Salary(){ Id = 3,  Position = "Programmer", Wage = 4242.42m },
                new Salary(){ Id = 4,  Position = "Engineer", Wage = 4424.24m },
                new Salary(){ Id = 5,  Position = "Cleaner", Wage = 755.55m }
            };

            List<Employee> employee = new List<Employee>()
            {
                new Employee()
                {
                      Id = 1, LastName = "Ivanova", Position = "Accountant", Department = "Сounting_H", Age = 22,
                },
                new Employee()
                {
                      Id = 2, LastName = "Larin", Position = "Programmer", Department = "IT", Age = 33
                },
                new Employee()
                {
                      Id = 3, LastName = "Ivanov", Position = "Chief", Department = "Main", Age = 43
                },
                new Employee()
                {
                      Id = 4, LastName = "Marusyk", Position = "Programmer", Department = "IT", Age = 22
                },
                new Employee()
                {
                      Id = 5, LastName = "Voron", Position = "Programmer", Department = "IT", Age = 36
                },
                new Employee()
                {
                      Id = 6, LastName = "Kalyta", Position = "Engineer", Department = "Design", Age = 22
                },
                new Employee()
                {
                      Id = 7, LastName = "Petrov", Position = "Programmer", Department = "IT", Age = 27
                },
                new Employee()
                {
                      Id = 9, LastName = "Sidorov", Position = "Engineer", Department = "Design", Age = 27
                },
                new Employee()
                {
                      Id = 10, LastName = "Baradedov", Position = "Cleaner", Department = "Service_C", Age = 27
                }
            };

            Console.WriteLine("\t\t=== Исходные данные ===\n");
            foreach (Salary item in salary)
            {
                Console.WriteLine(item.Position + ";    \t" + item.Wage);
            }
            Console.WriteLine();
            foreach (Employee item in employee)
            {
                Console.WriteLine(item.Id + ";\t" + item.LastName + ";   \t"
                    + item.Position + ";   \t" + item.Age + ";\t" + item.Department);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 1 ===\n\n" +
           "Cписок сотрудников моложе 30 лет в алфавитном порядке с указанием возраста.\n\nРезультат:");
            employee
                .OrderBy(ln => ln.LastName)
                .Select(list => (list.LastName, list.Age))
                .Where(age => age.Age < 30)
                .ToList()
                .ForEach(list => Console.WriteLine(list.LastName + ";   \t" + list.Age));
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 2 ===\n\n" +
            "Cпискок отделов (без повторений).\n\nРезультат:");
            employee
                .Select(p => p.Position)
                .Distinct()
                .ToList()
                .ForEach(list => Console.WriteLine(list));
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 3 ===\n\n" +
            "Определение среднего возраста сотрудников для каждого отдела.\n\nРезультат:");
            var midAge = from middle in employee
                         group middle by middle.Department into age
                         select
                         (
                             D: age.Key,
                             A: age.Average
                             (delegate (Employee obj)
                             {
                                 return obj.Age;
                             }
                             )
                         );
            foreach (var (D, A) in midAge)
            {
                Console.WriteLine("Cредний возраст: " + (int)A + "   \tОтдел: " + D);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 4 ===\n\n" +
            "Вывод списка сотрудников заданного отдела с указанием зарплаты и должности.\n\nРезультат:");
            var wagePost = from emp in employee
                           join post in salary on emp.Position equals post.Position
                           where emp.Department == "IT"
                           select (Department: emp.Department, LastName: emp.LastName, Wage: post.Wage, Position: emp.Position);
            foreach (var item in wagePost)
            {
                Console.WriteLine
                    (
                    item.LastName + "   \tОтдел: " +
                    item.Department + "\tЗарплата = " +
                    item.Wage + "$  -" + item.Position
                    );
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 5 ===\n\n" +
            "Определение отдела с максимальной средней зарплатой.\n\nРезультат:");
            var joinData = from emp in employee
                           join wage in salary on emp.Position equals wage.Position
                           select new
                           {
                               Department = emp.Department,
                               Position = emp.Position,
                               Wage = wage.Wage
                           };
            var averageWage = from s in joinData
                              group s by s.Department into a
                              select new
                              {
                                  Department = a.Key,
                                  Wage = (from Salary in a select Salary.Wage).Average()
                              };
            decimal max = (from Salary in averageWage select Salary.Wage).Max();
            var maxPay = from dep in averageWage where dep.Wage == max select dep;
            foreach (var item in maxPay)
            {
                Console.WriteLine("Отдел: " + item.Department + " средняя зарплата = " + item.Wage + "$.");
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 6 ===\n\n" +
            "Определение количества сотрудников в каждом отделе.\n\nРезультат:");
            var quantity = from emp in employee
                           group emp by emp.Department into a
                           select new
                           {
                               Departament = a.Key,
                               Quantity = a.Count()
                           };
            foreach (var item in quantity)
            {
                Console.WriteLine("Kол-во сотрудников - " + item.Quantity + " человек\t\tОтдел: " + item.Departament);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\t\t\t=== 7 ===\n\n" +
            "Определение минимального возраста для каждой должности.\n\nРезультат:");
            var minAge = from emp in employee
                         group emp by emp.Position into a
                         select new
                         {
                             Position = a.Key,
                             Age = a.Min(delegate (Employee obj) { return obj.Age; })
                         };
            foreach (var item in minAge)
            {
                Console.WriteLine("Должность: " + item.Position + "\tминимальный возраст = " + item.Age);
            }
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

