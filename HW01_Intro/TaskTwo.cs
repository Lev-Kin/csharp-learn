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
            string ticket;
            int digit_1, digit_2, digit_3, digit_4, digit_5, digit_6;
 
            Console.WriteLine("\n=== Счастливый билет ===");
            Console.WriteLine("\nВведите 6 значный билет:");
            ticket = Console.ReadLine();
 
            while (ticket.Length <= 0 || ticket.Length < 6 || ticket.Length > 6)
            { 
                Console.WriteLine("\nВведите 6 значный билет:");
                ticket = Console.ReadLine();
            }
 
            digit_1 = Convert.ToInt32(Convert.ToString(ticket)[0].ToString());
            digit_2 = Convert.ToInt32(Convert.ToString(ticket)[1].ToString());
            digit_3 = Convert.ToInt32(Convert.ToString(ticket)[2].ToString());
            digit_4 = Convert.ToInt32(Convert.ToString(ticket)[3].ToString());
            digit_5 = Convert.ToInt32(Convert.ToString(ticket)[4].ToString());
            digit_6 = Convert.ToInt32(Convert.ToString(ticket)[5].ToString());
 
            if (digit_1 + digit_2 + digit_3 == digit_4 + digit_5 + digit_6)
                Console.WriteLine("\nВаш билет {0} считается счастливым!", ticket);
            else
                Console.WriteLine("\nВаш билет {0} НЕ ЯВЛЯЕТСЯ счастливым!", ticket);
        }
    }
}

