using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.WindowHeight = 25 * 2;
            Console.WindowWidth = 79;

            int carInRace;
            int bet;

            Car[] car;
            CarCollection carCollection;
            Random random;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t=== Домашняя работа №7 Задание 1 ===\n");
                Console.WriteLine("\nДобро пожаловать в игру ГОНКИ!!!\n");

                Console.WriteLine("\t=== I ===");
                carInRace = CheckInput();

                car = new Car[carInRace];
                random = new Random();

                int amount = 0;
                for (int i = 0; i < car.Length; i++)
                {
                    car[i] = new Car(random.Next(1, 7), ++amount, false);
                }
                carCollection = new CarCollection(car);
                Console.WriteLine("\n-------------------------------------------------------------------------------\n");

                Console.WriteLine("\t=== II ===");
                bet = Bet(car);
                Console.WriteLine("\nМашин участвует в гонке: " + car.Length + "\nВаша ставка на машину под номером: " + bet);
                Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                Console.Write("Остановить гонку закончить игру Q\nНАЧАТЬ ГОНКУ нажмите любую кнопку.\n-> ");
                cki = Console.ReadKey();
                if (cki.KeyChar == 'Q' || cki.KeyChar == 'q')
                {
                    break;
                }

                //Console.WriteLine("\t=== III ===");

                carCollection.Race(bet);

                Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                Console.Write("Сыграть заново нажмите Y\nВыйти из игры нажмите любую кнопку.\n-> ");
                cki = Console.ReadKey();

            } while (cki.KeyChar == 'y' || cki.KeyChar == 'Y');

            Console.WriteLine("\n\n\t| Спасибо за игру |");
            Console.WriteLine("\t|   До свидания   |");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую клавишу...");
            //Console.ReadKey();
        }

        static int CheckInput()
        {
            int amount;
            bool amountRight = false;
            do
            {
                Console.Write("\nВведите количество машин для участия (от 2 до 7):\n-> ");
                if (!int.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("\nОШИБКА!\n" +
                        "Разрешен ввод только целых чисел.\n" +
                        "Повторите ввод.");
                }
                else if (amount < 2 || amount > 7)
                {
                    Console.WriteLine("\nВведено неверное количество машин!\n" +
                        "Внимательно читайте условие\n" +
                        "Повторите ввод.");
                }
                else
                {
                    amountRight = true;
                }

            } while (!amountRight);

            return amount;
        }

        static int Bet(Car[] car)
        {
            int bet;
            bool betRight = false;
            do
            {
                Console.Write("\nКоличество участвующих машин в гонке (от 1 до " + car.Length + ").\n" +
                    "Введите номер машины на которую будете ставить:\n-> ");
                if (!int.TryParse(Console.ReadLine(), out bet))
                {
                    Console.WriteLine("\nОШИБКА!\n" +
                       "Разрешен ввод только целых чисел.\n" +
                       "Повторите ввод.");
                }
                else if (bet <= 0 || bet > car.Length)
                {
                    Console.WriteLine("\nВведено неверное количество машин!\n" +
                       "Внимательно посмотрите на количество машин участвующих в гонке.\n" +
                       "Повторите ввод.");
                }
                else
                {
                    betRight = true;
                }

            } while (!betRight);

            return bet;
        }
    }
}
