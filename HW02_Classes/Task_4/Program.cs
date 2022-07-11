using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			Console.WriteLine("\t\t=== Задние 4 ===\n");
			Console.WriteLine("\n\t1) Создаем два объекта класса «Функция».\n" +
							  "\t   f(x) = 1 + cos^2(x + a) / |x^3 - 2*b^2|\n");
			Function function1 = new Function();
			Console.WriteLine("Введите значения для function1:");
			Console.Write("a = ");
			function1.A = Convert.ToDouble(Console.ReadLine());
			Console.Write("b = ");
			function1.B = Convert.ToDouble(Console.ReadLine());
 
			Console.WriteLine();
			Console.WriteLine("Введите значения для function2:");
			Function function2 = new Function();
			Console.Write("a = ");
			function2.A = Convert.ToDouble(Console.ReadLine());
			Console.Write("b = ");
			function2.B = Convert.ToDouble(Console.ReadLine());
 
			Console.WriteLine("\n\t2) Для каждого объекта вычисляем значения\n" +
							  "\t   для трех различных значений аргумента.\n");
			Console.WriteLine("Введите значения трех аргументов:");
			Console.Write("x1 = ");
			double x1 = double.Parse(Console.ReadLine());
			Console.Write("x2 = ");
			double x2 = double.Parse(Console.ReadLine());
			Console.Write("x3 = ");
			double x3 = double.Parse(Console.ReadLine());
 
			Console.WriteLine("\nТаблица 1 - function1");
			Table table1 = new Table(function1.ToString(), "x", 10, "f1(x)", 15);
			table1.Up();
			table1.Middle(x1, function1.F(x1));
			table1.Middle(x2, function1.F(x2));
			table1.Middle(x3, function1.F(x3));
			table1.Down();
 
			Console.WriteLine("\nТаблица 2 - function2");
			Table table2 = new Table(function2.ToString(), "x", 10, "f2(x)", 15);
			table2.Up();
			table2.Middle(x1, function2.F(x1));
			table2.Middle(x2, function2.F(x2));
			table2.Middle(x3, function2.F(x3));
			table2.Down();
 
			Console.WriteLine("\n\t3) Для каждого объекта–функции выполняем\n" +
							  "\t   табулирование для ряда значений аргумента.\n");
			double begin;
			double end;
			double step;
			Function.Input(out begin, out end, out step);
			Console.WriteLine("\nТаблица 1 - табулирование function1");
			function1.TabulationFunction(begin, end, step);
			Console.WriteLine("\nТаблица 2 - табулирование function2");
			function2.TabulationFunction(begin, end, step);
 
			Console.WriteLine("\n\t| Всего хорошего |\n");
			Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
			Console.WriteLine("Hажмите - любую кнопку...");
			Console.ReadKey();
		}
	}
}
