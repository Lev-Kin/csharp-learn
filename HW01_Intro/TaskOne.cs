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
            ConsoleKeyInfo button;
            int count_space = 0;
 
            Console.WriteLine("\n=== Подсчет символов ' ' ===");
            Console.WriteLine("Для окончания ввода нажмите символ '.' точку");
            Console.WriteLine("Введите символы:");
            do
            {
                button = Console.ReadKey();
 
                if (button.KeyChar == ' ')
                    count_space++;
 
                //Console.Clear();
                //Console.WriteLine(button.KeyChar);
 
            } while (button.KeyChar != '.');
 
            Console.WriteLine("\n\nКоличество пробелов = " + count_space);
        }
    }
}

