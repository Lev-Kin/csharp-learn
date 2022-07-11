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
 
            string number;
 
            Console.WriteLine("\n=== Перевернуть введенное число ===\n");
            do
            {
                Console.WriteLine("\nВведите целое число N, где (N > 0): ");
                number = Console.ReadLine();
 
            } while (Convert.ToInt32(number) < 0);
 
            Console.WriteLine("\n.  .  .  .  .  .  .  .  .  .  .  .  .\n");
 
            Console.WriteLine("Переворачиваем введенное число.");
            Console.Write("Результат: ");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
    }
}

