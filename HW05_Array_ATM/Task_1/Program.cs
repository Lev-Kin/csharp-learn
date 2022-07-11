using System;
using АТМ.SpaceAccount;
using АТМ.SpaceClient;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            uint accountNumber = (uint)new Random().Next(100000000, 999999999);
            uint pin = (uint)new Random().Next(100, 999);
            uint numberAttempts = 3;
            uint checkPin;

            double cash;
            double сorrectionCash;

            string firstName;
            string lastName;

            bool workОN = true;
            bool firstNameON;
            bool lastNameON;

            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №5 Задание 1 ===\n");
            Console.WriteLine("\t\t=== I ===");
            Console.WriteLine("\tПроизводится открытие счета!\n");
            Console.WriteLine("Введите данные для получения ПИН-кода и № счета:\n");
            do
            {
                firstNameON = true;
                lastNameON = true;

                Console.Write("    Имя => ");
                firstName = Console.ReadLine();
                if (firstName == "\n" || firstName.Length < 2)
                    firstNameON = false;

                Console.Write("Фамилия => ");
                lastName = Console.ReadLine();
                if (lastName == "\n" || lastName.Length < 2)
                    lastNameON = false;

                if ((firstNameON == false) || (lastNameON == false))
                {
                    Console.WriteLine("\nНекорректный ввод данныx!!!\n" +
                                        "Пожалуйста повторите ввод.\n");
                }

            } while ((firstNameON == false) || (lastNameON == false));

            //---------------------------------------------
            var clientBank = new АТМ.SpaceBank.Bank
            {
                objClient = new Client(firstName, lastName)
            };
            clientBank.objClient.objAccount = new Account(accountNumber, pin);
            //---------------------------------------------

            do
            {
                try
                {
                    Console.Write("\nВведите начальную сумму на счету  min = 100$:\n|-> ");
                    cash = double.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("\nОШИБКА!!!\n" +
                        "Некорректный ввод данных.\n" +
                        "Ввод копеек через запятую 100,10");
                    cash = 0.0;
                }

                if (cash < 100.0)
                {
                    Console.WriteLine("\nДля завершения открытия счета,\n" +
                        "Необходимо пополнить счет MIN сумма 100$\n");
                }

            } while (cash < 100.0);
            сorrectionCash = Math.Truncate(cash * 100) / 100;
            cash = сorrectionCash;

            clientBank.RefillAmount(ref clientBank, cash);

            Console.WriteLine("\n\t--------------------------------------------------");
            Console.WriteLine("\t\t\t=== ПОЗДРАВЛЯЕМ !!! ===\n" +
                                "\t+++ МЫ РАДЫ ЧТО ВЫ СТАЛИ КЛИЕНТОМ НАШЕГО БАНКА +++\n\n" +
                                $"\n\tВаш ПИН-код: {pin}\t\t<<<\n" +
                                $"\tВаш лицевой счет №{accountNumber}\t<<<\n" +
                                $"\tСумма на Вашем счету: {cash:f2}\t<<<\n\n" +
                                "Для продолжения нажмите любую клавишу...");
            Console.ReadKey();

            while (workОN)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\t\t=== II ===\n");
                    Console.Write("Введите ПИН-КОД ==> ");
                    checkPin = Convert.ToUInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nОШИБКА!!!\nРазрешен только ввод целых чисел.");
                    checkPin = 0;
                }

                if (checkPin == pin)
                {
                    while (workОN)
                    {
                        Console.Clear();
                        Console.WriteLine("\t          +++ АТМ +++\n");
                        Console.WriteLine("\t________| ГЛАВНОЕ МЕНЮ |_________");
                        Console.WriteLine("\tВыберите ПУНКТ меню для работы:");
                        Console.WriteLine("\t1 - Вывод баланса на экран");
                        Console.WriteLine("\t2 - Пополнение счёта");
                        Console.WriteLine("\t3 - Снять деньги со счёта");
                        Console.WriteLine("\t4 ---------|  ВыхоД  |---------");
                        switch (Console.ReadKey().KeyChar)
                        {
                            case '1':
                                {
                                    Console.Clear();
                                    Console.WriteLine("=== Выбран 1 пункт меню ===\n");
                                    Console.WriteLine(clientBank.Print());
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Для возврата в главное меню");
                                    Console.WriteLine("Нажмите любую клавишу...");
                                    Console.ReadKey();
                                }
                                break;

                            case '2':
                                {
                                    Console.Clear();
                                    Console.WriteLine("=== Выбран 2 пункт меню ===");
                                    do
                                    {
                                        try
                                        {
                                            Console.Write("\nВведите сумму которую хотите внести на счет:\n|-> ");
                                            cash = double.Parse(Console.ReadLine());

                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("\nОШИБКА!!!\n" +
                                                "Некорректный ввод данных.\n" +
                                                "Ввод копеек через запятую 100,10");
                                            cash = 0.0;
                                        }

                                        if (cash <= 0.0)
                                        {
                                            Console.WriteLine("\nСумма не может быть отрицательной,\n" +
                                                "Либо быть равной нулю\n");
                                        }

                                    } while (cash <= 0.0);
                                    сorrectionCash = Math.Truncate(cash * 100) / 100;
                                    cash = сorrectionCash;

                                    clientBank.RefillAmount(ref clientBank, cash);
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Для возврата в главное меню");
                                    Console.WriteLine("Нажмите любую клавишу...");
                                    Console.ReadKey();
                                }
                                break;

                            case '3':
                                {
                                    Console.Clear();
                                    Console.WriteLine("=== Выбран 3 пункт меню ===");
                                    do
                                    {
                                        try
                                        {
                                            Console.Write("\nВведите сумму которую хотите снять со счета:\n|-> ");
                                            cash = double.Parse(Console.ReadLine());

                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("\nОШИБКА!!!\n" +
                                                "Некорректный ввод данных.\n" +
                                                "Ввод копеек через запятую 100,10");
                                            cash = 0.0;
                                        }

                                        if (cash <= 0.0)
                                        {
                                            Console.WriteLine("\nСумма не может быть отрицательной,\n" +
                                                "Либо быть равной нулю\n");
                                        }

                                    } while (cash <= 0.0);
                                    сorrectionCash = Math.Truncate(cash * 100) / 100;
                                    cash = сorrectionCash;

                                    clientBank.TakeAmount(ref clientBank, cash);
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine("Для возврата в главное меню");
                                    Console.WriteLine("Нажмите любую клавишу...");
                                    Console.ReadKey();
                                }
                                break;

                            case '4':
                                workОN = false;
                                break;

                            default:
                                Console.WriteLine("\n>>> Неверный пункт меню.");
                                Console.WriteLine(">>> Будьте внимательны!!!");
                                Console.WriteLine(">>> Для продолжения - нажмите любую клавишу...");
                                Console.ReadKey();
                                break;
                        }
                    }
                }
                else
                {
                    numberAttempts--;
                    Console.WriteLine("\n");
                    Console.WriteLine("Введенный ПИН-КОД не верный!");
                    if (numberAttempts == 0)
                    {
                        Console.WriteLine("Попытки израсходованы.\nКарта заблокирована!!!\n" +
                            "Для возврата платежной карты обращайтесь в отделение своего Банка.");
                        workОN = false;
                    }
                    else if (numberAttempts == 1)
                        Console.WriteLine($"Осталось {numberAttempts} попытка!!!");
                    else if (numberAttempts < 5)
                        Console.WriteLine($"Осталось {numberAttempts} попытки!!!");
                    else
                        Console.WriteLine($"Осталось {numberAttempts} попыток!!!");

                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую кнлавишу...");
            //Console.ReadKey();
        }
    }
}
