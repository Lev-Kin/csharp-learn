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
                Console.WriteLine("\t\t=== Домашняя работа №6 Задание 1 ===\n");

                Console.WriteLine("\t=== I ===");
                Console.WriteLine("Введите размеры одномерных массивов (A, B, C):");
                Console.Write("\n|Размер А[] (целые числа)\n'-> ");
                int sizeA = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[sizeA];
                for (int i = 0; i < sizeA; i++)
                {
                    Console.Write($"A[{i}] = ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                ArrayOneD A = new ArrayOneD(array);

                Console.Write("\n|Размер B[] (целые числа)\n'-> ");
                int sizeB = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref array, sizeB);
                for (int i = 0; i < sizeB; i++)
                {
                    Console.Write($"B[{i}] = ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                ArrayOneD B = new ArrayOneD(array);

                Console.Write("\n|Размер C[] (целые числа)\n'-> ");
                int sizeC = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref array, sizeC);
                for (int i = 0; i < sizeC; i++)
                {
                    Console.Write($"C[{i}] = ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                ArrayOneD C = new ArrayOneD(array);

                Console.WriteLine("\n------------------------------------------------\n");

                Console.Write($"A[{sizeA}] = " + "{");
                Console.WriteLine(A.ToString());
                Console.Write($"B[{sizeB}] = " + "{");
                Console.WriteLine(B.ToString());
                Console.Write($"C[{sizeB}] = " + "{");
                Console.WriteLine(C.ToString());

                Console.WriteLine("\t=== II ===");
                int sumAC = 0;
                int sumABC = 0;
                sumAC = ArrayOneD.NegativeSum((A * 5).Array) + ArrayOneD.NegativeSum(C.Array);
                sumABC = ArrayOneD.NegativeSum((-A).Array) + ArrayOneD.NegativeSum((C * 4).Array) +
                    ArrayOneD.NegativeSum((B * 2).Array);

                Console.WriteLine($"Сумма отрицательных элементов в массивах 5*A и С = {sumAC}");
                Console.WriteLine($"Сумма отрицательных элементов в массивах 2*В, -А и С*4 = {sumABC}");
                Console.WriteLine("Сумма отрицательных элементов в массиве -А = " + ArrayOneD.NegativeSum((-A).Array));
                Console.WriteLine("Сумма отрицательных элементов в массиве А = " + ArrayOneD.NegativeSum((A).Array));

                if (ArrayOneD.NegativeSum((-A).Array) < ArrayOneD.NegativeSum(A.Array))
                {
                    for (int i = 0; i < A.Count; ++i)
                    {
                        if (A.Array[i] < 0)
                        {
                            for (int j = 0; j < A.Count; ++j)
                            {
                                if (i != j)
                                {
                                    if (A.Array[i] != ArrayOneD.NegativeSum((-A).Array))
                                    {
                                        if (A.Array[i] == A.Array[j])
                                        {
                                            A.Array[i] = ArrayOneD.NegativeSum((-A).Array);
                                            A.Array[j] = ArrayOneD.NegativeSum((-A).Array);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                Console.Write($"A[{sizeA}] = " + "{");
                Console.WriteLine(A.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую клавишу...");
            //Console.ReadKey();
        }
    }
}
