using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №8 Задание 2 ===\n");

            Console.WriteLine("\t=== Покупка билета ===");

            Transport[] transport = new Transport[4];

            transport[0] = new Bus("123", "Гомель", "Минск", 58);
            transport[1] = new Bus("115", "Гомель", "Москва", 58);
            transport[2] = new Train("647Б", "Гомель", "Минск");
            transport[3] = new Train("076Б", "Гомель", "Москва");

            int direction;

            do
            {
                try
                {
                    Console.Write("\nЗадайте пункт назначения:\n" +
                        "Нажмите (Минск = 1) или (Москва = 2)\n-> ");
                    direction = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nОШИБКА!!!\n" +
                      "Некорректный ввод данных.\n" +
                      "Внимательно читайте условие что нажимать.");
                    direction = 0;
                }

            } while (direction <= 0 || direction > 2);

            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            switch (direction)
            {
                case 1:
                    {
                        bool trainON = false;
                        Console.WriteLine("Выбрано направление Гомель - Минск.");
                        foreach (var item in transport)
                        {
                            if (item.Destination == "Минск")
                            {
                                if (item.Count != 0)
                                {
                                    trainON = true;
                                    //item.Show();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    trainON = false;
                                    item.Show();
                                    Console.WriteLine("\n\tК сожалению выбранного типа мест не осталось.");
                                    Console.ResetColor();
                                }
                            }
                        }

                        if (trainON == true)
                        {
                            transport[2].Show();
                            Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                            Prace(transport, 2);
                        }
                        else
                        {
                            int ask;
                            Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                            do
                            {
                                try
                                {
                                    Console.WriteLine("\nЖелаете приобрести билет на автобус по данному направлению?");
                                    Console.Write("Нажмите: 1 - ДА или 2 - НЕТ.\n-> ");
                                    ask = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nОШИБКА!!!\n" +
                                      "Некорректный ввод данных.\n" +
                                      "Внимательно читайте условие что нажимать.");
                                    ask = 0;
                                }

                            } while (ask <= 0 || ask > 2);

                            if (ask == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                                transport[0].Show();
                                Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                                Prace(transport, 0);
                            }
                        }
                    }
                    break;

                case 2:
                    {
                        bool trainON = false;
                        Console.WriteLine("Выбрано направление Гомель - Москва.");
                        foreach (var item in transport)
                        {
                            if (item.Destination == "Москва")
                            {
                                if (item.Count != 0)
                                {
                                    trainON = true;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    trainON = false;
                                    item.Show();
                                    Console.WriteLine("\n\tК сожалению выбранного типа мест не осталось.");
                                    Console.ResetColor();
                                }
                            }
                        }

                        if (trainON == true)
                        {
                            transport[3].Show();
                            Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                            Prace(transport, 3);
                        }
                        else
                        {
                            int ask;
                            Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                            do
                            {
                                try
                                {
                                    Console.WriteLine("\nЖелаете приобрести билет на автобус по данному направлению?");
                                    Console.Write("Нажмите: 1 - ДА или 2 - НЕТ.\n-> ");
                                    ask = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nОШИБКА!!!\n" +
                                      "Некорректный ввод данных.\n" +
                                      "Внимательно читайте условие что нажимать.");
                                    ask = 0;
                                }

                            } while (ask <= 0 || ask > 2);

                            if (ask == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                                transport[1].Show();
                                Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                                Prace(transport, 1);
                            }
                        }
                    }
                    break;
            }

            Console.WriteLine("\n\n\t\t\t╔═════════════════╗");
            Console.WriteLine("\t\t\t║   До свидания   ║");
            Console.WriteLine("\t\t\t╚═════════════════╝\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
            //Console.ReadKey();
        }

        public static void Prace(Transport[] transport, int i)
        {
            int typeSeat = transport[i].Seat;
            if (typeSeat != 0)
            {
                Console.WriteLine("\t Информация билета поезда");
                if (typeSeat == 1)
                {
                    Console.WriteLine("\t╔══════════════╦═════════════╦═════════════╗");
                    Console.WriteLine("\t║ Номер поезда ║ Цена билета ║  Тип вагона ║");
                    Console.WriteLine("\t╠══════════════╬═════════════╬═════════════╣");
                    Console.WriteLine($"\t║{transport[i].IdVehicle,14}║{transport[i]["плацкартный"],13}║{"плацкартный",13}║");
                    Console.WriteLine("\t╚══════════════╩═════════════╩═════════════╝");
                }
                else if (typeSeat == 2)
                {
                    Console.WriteLine("\t╔══════════════╦═════════════╦═════════════╗");
                    Console.WriteLine("\t║ Номер поезда ║ Цена билета ║  Тип вагона ║");
                    Console.WriteLine("\t╠══════════════╬═════════════╬═════════════╣");
                    Console.WriteLine($"\t║{transport[i].IdVehicle,14}║{transport[i]["купейный"],13}║{"купейный",13}║");
                    Console.WriteLine("\t╚══════════════╩═════════════╩═════════════╝");
                }
                else
                {
                    Console.WriteLine("\t╔══════════════╦═════════════╦═════════════╗");
                    Console.WriteLine("\t║ Номер поезда ║ Цена билета ║  Тип вагона ║");
                    Console.WriteLine("\t╠══════════════╬═════════════╬═════════════╣");
                    Console.WriteLine($"\t║{transport[i].IdVehicle,14}║{transport[i]["люкс"],13}║{"люкс",13}║");
                    Console.WriteLine("\t╚══════════════╩═════════════╩═════════════╝");
                }
            }
            else
            {
                Console.WriteLine("\t Информация билета автобуса");
                if (transport[i].IdVehicle == "123")
                {
                    Console.WriteLine("\t╔════════════════╦═════════════╦═════════════╗");
                    Console.WriteLine("\t║ Номер автобуса ║ Цена билета ║   Тип мест  ║");
                    Console.WriteLine("\t╠════════════════╬═════════════╬═════════════╣");
                    Console.WriteLine($"\t║{transport[i].IdVehicle,16}║{transport[i]["обычные"],13}║{"обычные",13}║");
                    Console.WriteLine("\t╚════════════════╩═════════════╩═════════════╝");
                }
                else
                {
                    Console.WriteLine("\t╔════════════════╦═════════════╦═════════════╗");
                    Console.WriteLine("\t║ Номер автобуса ║ Цена билета ║   Тип мест  ║");
                    Console.WriteLine("\t╠════════════════╬═════════════╬═════════════╣");
                    Console.WriteLine($"\t║{transport[i].IdVehicle,16}║{transport[i]["люкс"],13}║{"люкс",13}║");
                    Console.WriteLine("\t╚════════════════╩═════════════╩═════════════╝");
                }
            }
        }
    }
}
