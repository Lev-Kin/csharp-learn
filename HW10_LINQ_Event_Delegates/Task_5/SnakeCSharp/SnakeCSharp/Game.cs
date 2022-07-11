using System;
using System.Threading;

namespace SnakeCSharp
{
    class Game
    {
        public static int Width { get; } = 78;
        public static int Height { get; } = 26;

        ConsoleKeyInfo keyInfo;
        ConsoleKey consoleKey;

        Snake snake;
        Fruit fruit;

        bool isLost;
        bool isWin;

        public Game()
        {
            Console.CursorVisible = false;
            snake = new Snake();
            fruit = new Fruit();
        }

        void Restart()
        {
            Field.Write(Width, Height);
            Menu();
            Console.Clear();

            keyInfo = new ConsoleKeyInfo();
            consoleKey = new ConsoleKey();

            isLost = false;
            isWin = false;

            snake.Restart();
            fruit.Restart();

            Field.Write(Width, Height);
        }

        void Control()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;
            }

            switch (consoleKey)
            {
                case ConsoleKey.UpArrow:
                    if ((snake.Y[0] - snake.Y[1]) == 1) goto case ConsoleKey.DownArrow;
                    else snake.Shift(Snake.Direction.Top);
                    break;
                case ConsoleKey.DownArrow:
                    if ((snake.Y[0] - snake.Y[1]) == -1) goto case ConsoleKey.UpArrow;
                    else snake.Shift(Snake.Direction.Bottom);
                    break;
                case ConsoleKey.LeftArrow:
                    if ((snake.X[0] - snake.X[1]) == 1) goto case ConsoleKey.RightArrow;
                    else snake.Shift(Snake.Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    if ((snake.X[0] - snake.X[1]) == -1) goto case ConsoleKey.LeftArrow;
                    else snake.Shift(Snake.Direction.Right);
                    break;
                case ConsoleKey.Spacebar:
                    //Console.Write("<Пробел> продолжить...");
                    while (Console.ReadKey(true).Key != ConsoleKey.Spacebar) { }
                    consoleKey = ConsoleKey.Enter;
                    break;

                default:
                    if ((snake.Y[0] - snake.Y[1]) == -1) goto case ConsoleKey.UpArrow;
                    if ((snake.Y[0] - snake.Y[1]) == 1) goto case ConsoleKey.DownArrow;
                    if ((snake.X[0] - snake.X[1]) == -1) goto case ConsoleKey.LeftArrow;
                    if ((snake.X[0] - snake.X[1]) == 1) goto case ConsoleKey.RightArrow;
                    break;
            }
        }

        void Logic()
        {
            Control();
            fruit.Logic(ref snake);
            snake.Logic(ref isLost, ref isWin);
        }

        void Menu()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            ConsoleKey consoleKey = new ConsoleKey();

            Console.SetCursorPosition(Width / 2 - 6, 2);
            Console.Write("ИГРА ЗМЕЙКА");
            Console.SetCursorPosition(Width / 2 - 16, 4);
            Console.Write("Начать   Игру - Нажмите <ENTER>");
            Console.SetCursorPosition(Width / 2 - 16, 5);
            Console.Write("Выйти из Игры - Нажмите <ESC>");

        chooseButton:
            keyInfo = Console.ReadKey(true);
            consoleKey = keyInfo.Key;
            switch (consoleKey)
            {
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Escape:
                    {
                        Console.SetCursorPosition(1, 15);
                        Console.Write("------------------------------------------------------------------------------");
                        Console.SetCursorPosition(Width / 2 - 12, 16);
                        Console.Write("╔══════════════════════╗");
                        Console.SetCursorPosition(Width / 2 - 12, 17);
                        Console.Write("║    Спасибо за игру   ║");
                        Console.SetCursorPosition(Width / 2 - 12, 18);
                        Console.Write("║    Заходите еще!!!   ║");
                        Console.SetCursorPosition(Width / 2 - 12, 19);
                        Console.Write("╚══════════════════════╝\n");
                        Console.SetCursorPosition(1, 20);
                        Console.Write("==============================================================================");
                        Console.SetCursorPosition(1, 21);
                        Console.Write("___ПРОГРАММА ЗАВЕРШЕНА___");
                        Console.SetCursorPosition(1, 22);
                        Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    break;

                default:
                    goto chooseButton;
            }
        }

        public void Play()
        {
            while (true)
            {
                Restart();

                while (isLost == false && isWin == false)
                {
                    Logic();
                }
                if (isWin == true)
                {
                    Console.SetCursorPosition(Width / 2 - 25, Height / 2);
                    Console.Write("Поздравляем Вы набрали максимальное количество очков!!!");
                    Console.SetCursorPosition(Width / 2 - 20, Height / 2 + 1);
                    Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
                }
                else if (isLost == true)
                {
                    Console.SetCursorPosition(Width / 2 - 20, Height / 2);
                    Console.Write("Игра завершена!");
                    Console.SetCursorPosition(Width / 2 - 20, Height / 2 + 1);
                    Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
                }

                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}

