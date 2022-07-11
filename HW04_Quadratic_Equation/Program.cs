using System;
 
namespace ProjectC_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №4 ===\n");
 
            QEquation q_equation1 = new QEquation();
            double a1 = 1, b1 = -2, c1 = 3;
            QEquation q_equation2 = new QEquation(a1, b1, c1);
            double a2 = -3, b2 = 2, c2 = 1;
            QEquation q_equation3 = new QEquation(a2, b2, c2);
            Console.WriteLine(q_equation1);
            Console.WriteLine(q_equation2);
            Console.WriteLine(q_equation3);
 
            Console.WriteLine($"\tУравнение\t | \tДискрименант\t | \tKорни\t\t\t|");
            Console.Write(q_equation1.ToString()+ "\t\t\t\t");
            Console.Write(q_equation1.Discriminant + "\t\t\t");
            q_equation1.Radical();
 
            Console.Write(q_equation2.ToString() + "\t");
            Console.Write(q_equation2.Discriminant + "\t\t\t");
            q_equation2.Radical();
 
            Console.Write(q_equation3.ToString() + "\t");
            Console.Write(q_equation3.Discriminant + "\t\t\t");
            q_equation3.Radical();
 
            Console.WriteLine("\nСтатический метод для проверки, совпадают ли корни уравнений" +
                "\n(входные параметры – объекты класса, результат -  true или false).\n");
            Console.WriteLine("Сравниваем корни уравнения:");
            Console.Write(q_equation1.ToString() + " <-- И --> " + q_equation2.ToString() + " --> ");
            Console.WriteLine(QEquation.Сompare(q_equation1, q_equation2));
 
            Console.Write(q_equation1.ToString() + " <-- И --> " + q_equation3.ToString() + " --> ");
            Console.WriteLine(QEquation.Сompare(q_equation1, q_equation3));
 
            Console.Write(q_equation2.ToString() + " <-- И --> " + q_equation3.ToString() + " --> ");
            Console.WriteLine(QEquation.Сompare(q_equation2, q_equation3));
 
            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            Console.WriteLine("Нажмите - любую кнопку...");
            Console.ReadKey();
        }
    }
}


