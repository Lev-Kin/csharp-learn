using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\t\t=== Домашняя работа №9 Задание 1 ===\n\n");

                LigthFactory lighFactory = new LigthFactory();
                ChineBattery chineBattery = new ChineBattery();
                Duracell duracell = new Duracell();
                Random random = new Random();

                Console.Write("Введите количество фонариков для производства на фабрики:\n=> ");
                int quantity = int.Parse(Console.ReadLine());

                Illuminant[] illuminant = new Illuminant[quantity];

                for (int i = 0; i < quantity; ++i)
                {
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            illuminant[i] = lighFactory.GetFlashlight(chineBattery);
                            break;
                        case 2:
                            illuminant[i] = lighFactory.GetFlashlight(duracell);
                            break;
                    }
                }

                int times = 0;
                for (int i = 0; i < quantity; ++i)
                {
                    while (!illuminant[i].IsLigth())
                    {
                        if (illuminant[i].On())
                        {
                            illuminant[i].Off();
                            times++;
                        }
                        else
                            break;
                    }
                }

                Console.WriteLine("\n-------------------------------------------------------------------------------\n");
                Console.WriteLine("Результат:\n");
                Console.WriteLine("Количество включений фонариков = " + times);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n\t\t\t╔═════════════════╗");
            Console.WriteLine("\t\t\t║   До свидания   ║");
            Console.WriteLine("\t\t\t╚═════════════════╝\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
            //Console.ReadKey();
        }
    }
}
