using System;

namespace ProjectCSharp
{
    class Bus : Transport
    {
        private int[,] count;
        private int quantitySeat;

        public int QuantityFreeSeat { get; set; }
        public int TypeSeat { get; set; }

        public Bus(string idBus, string pointOfDeparture, string destination, int seat) : base(idBus, pointOfDeparture, destination)
        {
            quantitySeat = seat;
            count = new int[2, 1] { { 40 }, { 10 } };
            price = new int[2] { 2, 4 };
        }

        //public override int Count
        //{
        //    get
        //    {
        //        do
        //        {
        //            Console.WriteLine("\nКакой тип мест в вагоне предпочитаете?");
        //            Console.WriteLine("Нажмите:");
        //            Console.Write("1 - Люкс\n2 - Обычные\n-> ");
        //            try
        //            {
        //                TypeSeat = Convert.ToInt32(Console.ReadLine());
        //            }
        //            catch (FormatException)
        //            {
        //                Console.WriteLine("\nОШИБКА!!!\n" +
        //              "Некорректный ввод данных.\n" +
        //              "Внимательно читайте условие что нажимать.");

        //                TypeSeat = 0;
        //            }

        //        } while (TypeSeat <= 0 || TypeSeat > 3);
        //        Console.WriteLine("\n-------------------------------------------------------------------------------\n");

        //        QuantityFreeSeat = count[TypeSeat - 1, 0];

        //        return QuantityFreeSeat;
        //    }
        //}

        public override int this[string type]
        {
            get
            {
                for (int i = 0; i < price.Length; i++)
                {
                    if (type == "люкс")
                    {
                        return price[1];
                    }
                    if (type == "обычные")
                    {
                        return price[0];
                    }
                }
                return 0;
            }
        }

        public override int Count
        {
            get
            {
                return quantitySeat;
            }
        }

        public override int Seat
        {
            get
            {
                return TypeSeat;
            }
        }

        public override void Show()
        {
            Console.WriteLine("  Информация о автобусе согласно выбранному типу мест");
            Console.WriteLine(" ╔════════════════╦═══════════════════╦══════════════════╦════════════════╗");
            Console.WriteLine(" ║ Номер автобуса ║ Пункт отправления ║ Пункт назначения ║ Свободных мест ║");
            Console.WriteLine(" ╠════════════════╬═══════════════════╬══════════════════╬════════════════╣");
            Console.WriteLine($" ║{IdVehicle,16}║{PointOfDeparture,19}║{Destination,18}║{quantitySeat,16}║");
            Console.WriteLine(" ╚════════════════╩═══════════════════╩══════════════════╩════════════════╝");
        }
    }
}
