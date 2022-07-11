using System;

namespace SnakeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Правила и управление игры ЗМЕЙКА ===\n\n");

            Console.WriteLine("=== ПРАВИЛА ===");
            Console.WriteLine("Змейка - зеленого цвета:");
            Console.WriteLine("1) Передвигается по полю внутри которого появляются красные фрукты.");
            Console.WriteLine("2) Фрукты необходимо съедать чтоб набирать очки.");
            Console.WriteLine("3) При поедании фруктов размер   змейки будет увеличиваться.");
            Console.WriteLine("4) При поедании фруктов скорость змейки будет увеличиваться до max значения.");
            Console.WriteLine("5) При врезании змейки в стену желтого цвета игра будет завершена.");
            Console.WriteLine("6) При запутывании змейки врезания саму себя игра будет завершена.");

            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("=== УПРАВЛЕНИЕ ===");
            Console.WriteLine("Перемещение змейки:");
            Console.WriteLine("Вверх - нажмите клавишу Вверх на клавиатуре.");
            Console.WriteLine("Вниз - нажмите клавишу Вниз на клавиатуре.");
            Console.WriteLine("Влево - нажмите клавишу Влево на клавиатуре.");
            Console.WriteLine("Вправо - нажмите клавишу Вправо на клавиатуре.");

            Console.WriteLine("\nПауза в Игре:");
            Console.WriteLine("Включить  - нажмите клавишу Пробел на клавиатуре.");
            Console.WriteLine("Отключить - повторно нажмите клавишу Пробел на клавиатуре.");

            Console.WriteLine("\n===============================================================================");
            Console.WriteLine("___ПРИСТУПИТЬ К ИГРЕ___");
            Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
            Console.ReadKey();

            Console.Clear();

            Game game = new Game();
            game.Play();
        }
    }
}

