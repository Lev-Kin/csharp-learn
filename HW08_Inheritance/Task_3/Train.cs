using System;

namespace ProjectCSharp
{
    class Train : Transport
    {
        private int[,] count;

        public int QuantityFreeSeat { get; set; }
        public int TypeSeat { get; set; }

        public Train(string idTrain, string pointOfDeparture, string destination) : base(idTrain, pointOfDeparture, destination)
        {
            Random random = new Random();
            // Cтандартный пассажирский поезд дальнего следования:
            // 15 вагонов: 
            // 1 - вагон ресторан, 1 - вагон спальный(24 места), 5 - плацкарт * (54 мест) = (270 мест), 8 - купе * (36 мест) = (288 мест)
            count = new int[3, 1] { { random.Next(0, 270) }, { random.Next(0, 288) }, { 0 } };
            price = new int[3] { 5, 8, 11 };
        }

        public override int Count
        {
            get
            {
                do
                {
                    Console.WriteLine("\nКакой тип мест в вагоне предпочитаете?");
                    Console.WriteLine("Нажмите:");
                    Console.Write("1 - Плацкарт\n2 - Купе\n3 - Люкс\n-> ");
                    try
                    {
                        TypeSeat = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nОШИБКА!!!\n" +
                      "Некорректный ввод данных.\n" +
                      "Внимательно читайте условие что нажимать.");

                        TypeSeat = 0;
                    }

                } while (TypeSeat <= 0 || TypeSeat > 3);
                Console.WriteLine("\n-------------------------------------------------------------------------------\n");

                QuantityFreeSeat = count[TypeSeat - 1, 0];

                return QuantityFreeSeat;
            }
        }

        public override int Seat
        {
            get
            {
                return TypeSeat;
            }
        }

        public override int this[string type]
        {
            get
            {
                for (int i = 0; i < price.Length; i++)
                {
                    if (type == "плацкартный")
                    {
                        return price[0];
                    }
                    if (type == "купейный")
                    {
                        return price[1];
                    }
                    if (type == "люкс")
                    {
                        return price[2];
                    }
                }
                return 0;
            }
        }

        public override void Show()
        {
            Console.WriteLine("  Информация о поезде согласно выбранному типу мест");
            Console.WriteLine(" ╔══════════════╦═══════════════════╦══════════════════╦════════════════╗");
            Console.WriteLine(" ║ Номер поезда ║ Пункт отправления ║ Пункт назначения ║ Свободных мест ║");
            Console.WriteLine(" ╠══════════════╬═══════════════════╬══════════════════╬════════════════╣");
            Console.WriteLine($" ║{IdVehicle,14}║{PointOfDeparture,19}║{Destination,18}║{QuantityFreeSeat,16}║");
            Console.WriteLine(" ╚══════════════╩═══════════════════╩══════════════════╩════════════════╝");
        }
    }
}
