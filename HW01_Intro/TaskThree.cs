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
            char symbol_char;
            int symbol = 0;
 
            Console.WriteLine("\n=== Конвертация нижнего регистра в ВЕРХНИЙ И наоборот ===\n");
            Console.WriteLine("Для окончания ввода нажмите символ '.' точку");
            Console.WriteLine("Введите символы:");
            while (symbol != '.' )
            {
                do
                {
                    symbol = Console.Read();
 
                }while (symbol == '\n' || symbol == '\r');
 
                if (symbol >= 65 && symbol <= 90)
                {
                    symbol += 32;
                    symbol_char = (char)symbol;
                    Console.Write(symbol_char);
                }
                else if (symbol >= 97 && symbol <= 122)
                {
                    symbol -= 32;
                    symbol_char = (char)symbol;
                    Console.Write(symbol_char);
                }
                else
                {
                    symbol_char = (char)symbol;
                    Console.Write(symbol_char);
                }
            }
            Console.WriteLine();
        }
    }
}

