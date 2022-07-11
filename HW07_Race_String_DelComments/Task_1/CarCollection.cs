using System;
using System.Threading;

namespace ProjectCSharp
{
    class CarCollection
    {
        Car[] car;
        public CarCollection(params Car[] car)
        {
            this.car = car;
        }
        public Car this[int i]
        {
            get
            {
                return car[i];
            }
            set
            {
                car[i] = value;
            }
        }

        public ConsoleColor ConsoleColor(Car car)
        {
            if (car.Color == 1)
                return System.ConsoleColor.Red;
            if (car.Color == 2)
                return System.ConsoleColor.White;
            if (car.Color == 3)
                return System.ConsoleColor.Yellow;
            if (car.Color == 4)
                return System.ConsoleColor.Green;
            if (car.Color == 5)
                return System.ConsoleColor.Cyan;
            if (car.Color == 6)
                return System.ConsoleColor.Blue;
            if (car.Color == 7)
                return System.ConsoleColor.Magenta;

            return System.ConsoleColor.DarkGray;
        }

        public void Race(int bet)
        {
            Random random = new Random();

            int i;
            int l;
            int max = 0;
            int carMove = 0;
            int number = 0;

            int[] carNumber = new int[car.Length];
            for (i = 0; i < carNumber.Length; i++)
            {
                carNumber[i] = 0;
            }

            int[] carNumberStr = new int[car.Length * 4];
            for (i = 0; i < carNumberStr.Length; i++)
            {
                carNumberStr[i] = i + 2;
            }

            while (max < Console.WindowWidth - 13)
            {
                Console.Clear();

                l = 0;
                for (i = 0; i < car.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor(car[i]);
                    car[i].CarSideOne(carNumber[i], carNumberStr[l]);
                    car[i].CarCore(carNumber[i], carNumberStr[l + 1]);
                    car[i].CarSideTwo(carNumber[i], carNumberStr[l + 2]);
                    l += 4;
                    Console.ResetColor();
                }

                for (i = 0; i < car.Length; i++)
                {
                    if (car[i].Breaking == true)
                        carMove++;
                }

                if (carMove == car.Length)
                    break;

                for (i = 0; i < car.Length; i++)
                {
                    if (car[i].Breaking == false)
                        carNumber[i] += random.Next(1, 5);
                }

                for (int j = 0; j < car.Length; j++)
                {
                    if (car[j].Breaking == false)
                        car[j].CrarBreaking(Console.WindowWidth - 13);
                    try
                    {
                        if (car[j].Breaking == true)
                            throw new Exception();
                    }
                    catch
                    {
                        j++;
                    }
                }

                max = carNumber[0];
                for (int k = 0; k < carNumber.Length; k++)
                {
                    if (carNumber[k] > max)
                    {
                        max = carNumber[k];
                        number = k;
                    }
                }

                for (int k = 0; k < carNumber.Length; k++)
                {
                    if ((carNumber[k] > Console.WindowWidth - 13) && carNumber[k] == max)
                        carNumber[k] = Console.WindowWidth - 13;
                    else if (carNumber[k] > Console.WindowWidth - 13)
                        carNumber[k] = Console.WindowWidth - 13 - (max - carNumber[k]);
                }

                Thread.Sleep(50);
            }

            Console.WriteLine("\n\t=== III ===");
            Console.WriteLine("\nМашин участвует в гонке: " + car.Length + "\nВаша ставка на машину под номером: " + bet);
            Console.WriteLine("\n.   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .\n");

            if (carMove == car.Length)
                Console.WriteLine("Все автомобили сломались.");
            else
                Console.WriteLine("Победитель гонки автомобиль под номером " + car[number].Number);

            if (car[number].Number != bet)
                Console.WriteLine("Вы проиграли :(\nПопробуйте еще раз в другой раз повезет.");
            else if (car[number].Number == bet)
                Console.WriteLine("Вы выиграли :)\nПоздравляем!!!");
            else
                Console.WriteLine("Гонка не состоялась.");
        }
    }
}
