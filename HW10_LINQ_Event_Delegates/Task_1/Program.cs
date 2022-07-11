using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №10 Задание 1 ===\n\n");

            Doctor[] doctor =
            {
                new Doctor("Петухов В.В.",DateTime.Now.ToLongTimeString(),2),
                new Doctor("Петренко А.С.",DateTime.Now.ToLongTimeString(),12)
            };

            Patient[] patient =
            {
                new Patient("Иванов","грипп","29.12.09",doctor[0].TimeOfReceipt,doctor[0].NumberOfCabinet),
                new Patient("Петров","пневмония","3.08.09",doctor[0].TimeOfReceipt,doctor[0].NumberOfCabinet),
                new Patient("Дибров","перелом","12.03.09",doctor[1].TimeOfReceipt,doctor[1].NumberOfCabinet),
                new Patient("Семёнов","растяжение","20.04.09",doctor[1].TimeOfReceipt,doctor[1].NumberOfCabinet),
            };

            doctor[0].NewNumberCabinet += patient[0].ChangeCabinetNumber;
            doctor[0].NewNumberCabinet += patient[1].ChangeCabinetNumber;
            doctor[1].NewNumberCabinet += patient[2].ChangeCabinetNumber;
            doctor[1].NewNumberCabinet += patient[3].ChangeCabinetNumber;

            Console.WriteLine("=== Информация о пациентах ===\n");
            Console.WriteLine(doctor[0]);
            Tablica();
            Console.WriteLine(patient[0]);
            Console.WriteLine(patient[1]);
            BottomTablica();

            Console.WriteLine(doctor[1]);
            Tablica();
            Console.WriteLine(patient[2]);
            Console.WriteLine(patient[3]);
            BottomTablica();

            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.Write("Введите фамилию врача: ");
            string surnameDoctor = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            bool flag = false;
            int indexOf = 0;
            for (int i = 0; i < doctor.Length; i++)
            {
                if (doctor[i].Surname.CompareTo(surnameDoctor) == 0)
                {
                    indexOf = i;
                    flag = true;
                }
            }

            if (flag)
            {
                doctor[indexOf].NumberOfCabinet = 7;
                Console.WriteLine("Изменения прошли успешно");
                RegistrationList(doctor, patient);
            }
            else
            {
                Console.WriteLine("Изменения не возможны, так как врача с фамилией " + surnameDoctor + " в больнице не числится");
                RegistrationList(doctor, patient);
            }

            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("\n\t\t\t╔═════════════════╗");
            Console.WriteLine("\t\t\t║   До свидания   ║");
            Console.WriteLine("\t\t\t╚═════════════════╝\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
            //Console.ReadKey();
        }

        static void Tablica()
        {
            Console.WriteLine("╔═════════╦═════════════╦═════════════╗");
            Console.WriteLine("║ Фамилия ║ Дата приёма ║   Диагноз   ║");
        }

        static void BottomTablica()
        {
            Console.WriteLine("╚═════════╩═════════════╩═════════════╝\n");
        }

        static void RegistrationList(Doctor[] doctor, Patient[] patient)
        {
            Console.WriteLine("╔═════════╦════════╦═════════════╦══════════════╦═══════════════╦═════════════╗");
            Console.WriteLine("║ Фамилия ║ № каб. ║ Дата приёма ║ Время приёма ║ Фамилия врача ║   Диагноз   ║");

            int j = 0;
            for (int i = 0; i < doctor.Length; i++)
            {
                for (int l = 0; l < patient.Length / 2; l++)
                {
                    Console.WriteLine("╠═════════╬════════╬═════════════╬══════════════╬═══════════════╬═════════════╣");
                    Console.WriteLine($"║{patient[j].Surname,9}║{patient[j].CabinetNumber,8}║{patient[j].Date,13}║" +
                        $"{patient[j].Time,14}║{doctor[i].Surname,15}║{patient[j].Diagnosis,13}║");
                    j++;
                }
            }
            Console.WriteLine("╚═════════╩════════╩═════════════╩══════════════╩═══════════════╩═════════════╝");
        }
    }
}

