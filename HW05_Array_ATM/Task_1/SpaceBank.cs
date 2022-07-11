using System;

namespace АТМ
{
    namespace SpaceBank
    {
        class Bank
        {
            public АТМ.SpaceClient.Client objClient;

            public string Print()
            {
                return
                    $"Клиент:  {objClient.FirstName} {objClient.LastName}" +
                    $"\nНомер счета: {objClient.objAccount.accountNumber}" +
                    $"\nСумма на счете: {objClient.objAccount.amount}";
            }

            public void RefillAmount(ref Bank obj, double amountTemp)
            {
                obj.objClient.objAccount.amount += amountTemp;
                Console.WriteLine("Ваш счет успешно пополнен.");
                //Console.WriteLine("Для продолжения нажмите любую клавишу...");
                //Console.ReadKey();
            }

            public void TakeAmount(ref Bank obj, double amountTemp)
            {
                if (!(obj.objClient.objAccount.amount < amountTemp))
                {
                    obj.objClient.objAccount.amount -= amountTemp;
                    Console.WriteLine("Сумма со счета снята.");
                    //Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("На счете недостаточно средств.");
                    //Console.ReadKey();
                }
            }
        }
    }
}
