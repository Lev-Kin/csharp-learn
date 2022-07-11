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
            Console.WriteLine();
            Console.WriteLine("=== Задние 1 ===\n");
 
            Random rand = new Random();
            int bank;             // сумма игрока
            int hiddenNum;        // скрытые числа компьютером
            int attempt;          // кол-во попыток
            int guess;            // угадываем число компьютера
            int countTry = 1;     // счетчик кол-во попыток
            bool exceed = false;
 
            bank = rand.Next(100, 500);
            Console.WriteLine("Ваша сумма: " + bank + "$\n");
            Console.WriteLine("Компьютер загадывает число в диапазоне от 1 до 100.");
            hiddenNum = rand.Next(1, 100);
            Console.WriteLine("За сколько попыток (N) вы отгадаете это число?");
            Console.Write("N --> ");
            attempt = Convert.ToInt32(Console.ReadLine());
 
            while (true)
            {
                Console.WriteLine("Читерство " + hiddenNum);
                Console.WriteLine("\nВведите число которое загадал компьютер");
                Console.Write("G --> ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == hiddenNum)
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Вы угадали число.");
                    Console.WriteLine("Ваша сумма увеличилась и составляет: " +
                        (bank += (bank / countTry)) + "$\n");
 
                    if (bank >= 1000)
                        break;
 
                    Console.WriteLine("Компьютер загадывает число в диапазоне от 1 до 100.");
                    hiddenNum = rand.Next(1, 100);
                    Console.WriteLine("За сколько попыток (N) вы отгадаете это число?");
                    Console.Write("N --> ");
                    attempt = Convert.ToInt32(Console.ReadLine());
                    countTry = 0;
                    exceed = false;
                }
                else
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Вы не угадали число.");
                    if(exceed == true)
                    {
                        Console.WriteLine("Ваша сумма уменьшилась и составила: " +
                      (bank -= ((bank / (countTry - 1)) * attempt)) + "$");
                    }
                }
 
                if (countTry >= attempt)
                {
                    if (bank != 0)
                    {
                        Console.WriteLine("Количество попыток превышено.\n");
                        Console.WriteLine("Попытка будет стоит: " + ((bank / countTry) * attempt) + "$");
                        exceed = true;
                    }
                    else
                        break;
                }
                countTry++;
            }
 
            if (bank == 0)
                Console.WriteLine("Конец игры компьютер остался в выигрыше.\n");
            else
                Console.WriteLine("Конец игры сумма выигрыша составила: " + bank + "$\n");
 
            Console.WriteLine("Спасибо за игру.");
            Console.ReadLine();
        }
    }
}

