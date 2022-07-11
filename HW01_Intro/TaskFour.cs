using System;
using System.Collections.Generic;
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
 
            int a, b;
            do
            {
                Console.WriteLine("\n=== Задание 4 ===\n");
                do
                {
                    Console.WriteLine("\nВведите целое положительное число А");
                    Console.Write("А = ");
                    a = Convert.ToInt32(Console.ReadLine());
                } while (a < 0);
 
                Console.WriteLine("\n.  .  .  .  .  .  .  .  .  .  .  .  .");
                do
                {
                    Console.WriteLine("\nВведите целое положительное число B");
                    Console.Write("B = ");
                    b = Convert.ToInt32(Console.ReadLine());
                } while (b < 0);
 
                if(a >= b || a <= 0 || b <= 0)
                {
                    Console.Write("\nУсловие (A < B) не выполнено." +
                        "\nПовторите ввод А и B." +
                        "\nпродолжить-<Enter>");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (a >= b || a <= 0 || b <= 0);
 
            Console.WriteLine("\n.  .  .  .  .  .  .  .  .  .  .  .  .\n");
 
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}

