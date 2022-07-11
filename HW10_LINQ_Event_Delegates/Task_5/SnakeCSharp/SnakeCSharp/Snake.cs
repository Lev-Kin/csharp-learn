using System;
using System.Threading;

namespace SnakeCSharp
{
    class Snake
    {
        public int[] X { private set; get; }
        public int[] Y { private set; get; }
        public int Length { set; get; }
        public int Speed { set; get; }
        public enum Direction { Left, Right, Top, Bottom }

        public void Restart()
        {
            X = new int[777];
            Y = new int[777];

            X[0] = X[1] = X[2] = Game.Width / 2;
            Y[0] = Game.Height / 2;
            Y[1] = Game.Height / 2 + 1;
            Y[2] = Game.Height / 2 + 2;

            Length = 3;
            Speed = 210;
        }

        public void Shift(Direction direction)
        {
            for (int i = Length + 1; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
            }

            switch (direction)
            {
                case Direction.Left:
                    X[0]--;
                    break;
                case Direction.Right:
                    X[0]++;
                    break;
                case Direction.Top:
                    Y[0]--;
                    break;
                case Direction.Bottom:
                    Y[0]++;
                    break;
            }
        }

        void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(X[i], Y[i]);
                Console.Write("█");
            }

            if (X[Length] != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.SetCursorPosition(X[Length], Y[Length]);
                Console.Write("%");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void Logic(ref bool isLost, ref bool isWin)
        {
            if (Length == 770)
            {
                isWin = true;
            }
            else
            {
                Draw();

                Thread.Sleep(Speed);

                if (X[0] <= 0 || X[0] >= Game.Width + 1 || Y[0] <= 0 || Y[0] >= Game.Height + 1)
                {
                    isLost = true;
                }

                for (int i = Length; i >= 2; i--)
                {
                    if (X[0] == X[i - 1] && Y[0] == Y[i - 1])
                    {
                        isLost = true;
                    }
                }
            }
        }
    }
}

