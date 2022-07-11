using System;

namespace ProjectCSharp
{
    class Car
    {
        int color;
        int number;
        bool breaking;

        public Car()
        {
            color = 1;
            number = 0;
            breaking = false;
        }
        public Car(int i, int number, bool flag)
        {
            color = i;
            this.number = number;
            breaking = flag;
        }
        public int Number
        {
            get
            {
                return number;
            }
        }
        public int Color
        {
            get
            {
                return color;
            }
        }
        public bool Breaking
        {
            get
            {
                return breaking;
            }
            set
            {
                breaking = value;
            }
        }

        public void CarSideOne(int i, int str)
        {
            Console.SetCursorPosition(i, str);
            Console.WriteLine("╕ ▄  ___  ▄ ┬");
        }
        public void CarCore(int i, int str)
        {
            Console.SetCursorPosition(i, str);
            Console.WriteLine("╞═╬═╡[o:╞═╬═╡");
        }
        public void CarSideTwo(int i, int str)
        {
            Console.SetCursorPosition(i, str);
            Console.WriteLine("╛ ▀ ``" + number + "`` ▀ ┴");
        }

        public void CrarBreaking(int way)
        {
            int countWay = way * 13;
            int countProc = 5;
            int r;

            Random randomNumber = new Random();
            int[] numberBreak = new int[countProc];
            for (int i = 0; i < countProc; i++)
            {
                if (i != 0)
                {
                    r = randomNumber.Next(1, countWay);
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (r == numberBreak[j])
                        {
                            r = randomNumber.Next(1, countWay);
                            j = i;
                        }
                    }
                    numberBreak[i] = r;
                }
                else
                    numberBreak[i] = randomNumber.Next(1, countWay);
            }
            int rand = randomNumber.Next(1, countWay);
            for (int i = 0; i < countProc; i++)
            {
                if (numberBreak[i] == rand)
                {
                    breaking = true;
                }
            }
        }
    }
}
