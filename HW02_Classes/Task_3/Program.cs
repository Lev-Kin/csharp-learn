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
			Console.WriteLine("\t\t=== Задние 3 ===\n");
            double x2;
            double y2;
            double r2;
            double x3;
            double y3;
            double r3;
 
            double r1;
            double value;
            int direction;
            int menu;
 
            Console.WriteLine("\t1) Создаем три объекта класса «Окружность».\n");
			Console.WriteLine("Координаты окружности №1 - добавлены");
			Circle circle1 = new Circle();
 
			Console.WriteLine("\nВведите координаты окружности №2");
			Console.Write("X2 = ");
			x2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Y2 = ");
			y2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("R2 = ");
			r2 = Convert.ToDouble(Console.ReadLine());
			Circle circle2 = new Circle(x2, y2, r2);
 
			Console.WriteLine("\nВведите координаты окружности №3");
			Console.Write("X3 = ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y3 = ");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("R3 = ");
            r3 = Convert.ToDouble(Console.ReadLine());
            Circle circle3 = new Circle(x3, y3, r3);
 
			Console.WriteLine("\n\t2) Выводим информацию об окружностях.\n");
			Console.WriteLine("      |         |        |        |   Лежит ли в одной     |");
			Console.WriteLine("№ п/п |  Центр  | Радиус | Длина  | координатной плоскости |");
			Console.WriteLine("-----------------------------------------------------------|");
			Console.WriteLine("{0,6}|({1,3};{2,3})|{3,8:f2}|{4,8:f2}|   {5,8}",
					1, circle1.X, circle1.Y, circle1.R, circle1.L, circle1.Fourth() ? "ДА " : "НЕТ");
			Console.WriteLine("{0,6}|({1,3};{2,3})|{3,8:f2}|{4,8:f2}|   {5,8}",
					2, circle2.X, circle2.Y, circle2.R, circle2.L, circle2.Fourth() ? "ДА " : "НЕТ");
			Console.WriteLine("{0,6}|({1,3};{2,3})|{3,8:f2}|{4,8:f2}|   {5,8}",
					3, circle3.X, circle3.Y, circle3.R, circle3.L, circle3.Fourth() ? "ДА " : "НЕТ");
 
			Console.WriteLine("\n\t3) Определяем, пересекаются ли какие-нибудь из данных окружностей.\n");
			if (Circle.Intersecting(circle1, circle2))
				Console.WriteLine("Окружности 1 и 2 пересекаются.");
			else
				Console.WriteLine("Окружности 1 и 2 не пересекаются.");
 
			if (Circle.Intersecting(circle2, circle3))
				Console.WriteLine("Окружности 2 и 3 пересекаются.");
			else
				Console.WriteLine("Окружности 2 и 3 не пересекаются.");
 
			if (Circle.Intersecting(circle1, circle3))
				Console.WriteLine("Окружности 1 и 3 пересекаются.");
			else
				Console.WriteLine("Окружности 1 и 3 не пересекаются.");
 
            while (true)
            {
                Console.WriteLine("\n\t4) Осуществляем перемещение или увеличение (по выбору пользователя).\n");
                Console.WriteLine("1) Увеличить   окружность 1.");
                Console.WriteLine("2) Переместить окружность 1.");
                Console.WriteLine("3)  | ВыхоД |");
                Console.Write(">");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1 || menu == 2 || menu == 3)
                {
                    if (menu == 3)
                        break;
 
                    if (menu == 1)
                    {
                        Console.Write("\nВведите на сколько увеличить радиус: ");
                        r1 = Convert.ToDouble(Console.ReadLine());
                        circle1.Increase(r1);
                        Console.WriteLine("\nНовые данные окружности 1:");
                        Console.WriteLine("      |         |        |        |   Лежит ли в одной     |");
                        Console.WriteLine("№ п/п |  Центр  | Радиус | Длина  | координатной плоскости |");
                        Console.WriteLine("-----------------------------------------------------------|");
                        Console.WriteLine("{0,6}|({1,3};{2,3})|{3,8:f2}|{4,8:f2}|   {5,8}",
                                1, circle1.X, circle1.Y, circle1.R, circle1.L, circle1.Fourth() ? "ДА " : "НЕТ");
                    }
 
                    if (menu == 2)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - смещение по горизонтали.");
                            Console.WriteLine("2 - смещение по вертикали.");
                            Console.Write(">");
                            direction = Convert.ToInt32(Console.ReadLine());
 
                            if (direction < 0 || direction > 2)
                            {
                                Console.WriteLine("\nНекоpректный ввод.");
                                Console.WriteLine("Смещение по X - нажмите 1.\nсмещение по Y - нажмите 2.");
                                Console.WriteLine("Пожалуйста повторите ввод.");
                            }
                        } while (direction < 0 || direction > 2);
 
                        Console.Write("Введите величину перемещения: ");
                        value = Convert.ToDouble(Console.ReadLine());
                        circle1.Move(value, direction);
 
                        Console.WriteLine("\nНовые данные окружности 1:");
                        Console.WriteLine("      |         |        |        |   Лежит ли в одной     |");
                        Console.WriteLine("№ п/п |  Центр  | Радиус | Длина  | координатной плоскости |");
                        Console.WriteLine("-----------------------------------------------------------|");
                        Console.WriteLine("{0,6}|({1,3};{2,3})|{3,8:f2}|{4,8:f2}|   {5,8}",
                                1, circle1.X, circle1.Y, circle1.R, circle1.L, circle1.Fourth() ? "ДА " : "НЕТ");
                    }
                }
                else
                {
                    Console.WriteLine("\nОшибка ввода пункта меню.\nПожалуйста повторите ввод.");
                    Console.ReadLine();
                }
            }
 
            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            Console.WriteLine("Hажмите - любую кнопку...");
            Console.ReadKey();
        }
    }
}

