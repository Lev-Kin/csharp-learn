using System;

namespace ProjectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\t=== Домашняя работа №5 Задание 2 ===\n");

            int[,] masA = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            //int[,] masA = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
            //int[,] masA = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            Matrix matrixA = new Matrix(masA);
            Matrix matrixB = new Matrix();

            Console.WriteLine("\nМатрица А:\n");
            Console.WriteLine(matrixA);
            Console.WriteLine("\nМатрица B:\n");
            Console.WriteLine(matrixB);

            if (matrixA.SumPosCol() > matrixB.SumPosCol())
            {
                Console.WriteLine("Сумма элементов столбцов матрицы А,\n" +
                    "состоящих из положительных элементов больше,\n" +
                    "чем такая же сумма матрицы В.\n");

                Console.WriteLine("!Заменяем все нулевые элементы матрицы В " +
                    "\nна значение суммы элементов диагоналей этой матрицы.\n");


                int sum = matrixB.SumDiagonalMatrix;
                for (int i = 0; i < matrixB.Row; i++)
                    for (int j = 0; j < matrixB.Col; j++)
                        if (matrixB[i, j] == 0)
                            matrixB[i, j] = sum;

                Console.WriteLine(matrixB);
            }
            else if (matrixA.SumPosCol() < matrixB.SumPosCol())
            {
                Console.WriteLine("Сумма элементов столбцов матрицы А,\n" +
                    "состоящих из положительных элементов меньше,\n" +
                    "чем такая же сумма матрицы В.\n");

                Console.WriteLine("Сумма элементов матрицы A = " + matrixA.SumPosCol() + "\n");
                Console.WriteLine("Сумма элементов матрицы B = " + matrixB.SumPosCol() + "\n");
            }
            else
            {
                Console.WriteLine("Сумма элементов столбцов матрицы А,\n" +
                   "состоящих из положительных элементов\n" +
                   "равна такой же сумме матрицы В.\n");

                Console.WriteLine("Сумма элементов матрицы A = " + matrixA.SumPosCol() + "\n");
                Console.WriteLine("Сумма элементов матрицы B = " + matrixB.SumPosCol() + "\n");
            }

            Console.WriteLine("\n\t| До свидания |\n");
            Console.WriteLine("================================================");
            Console.WriteLine("___ПРОГРАММА ЗАВЕРШЕНА___");
            //Console.WriteLine("Нажмите - любую клавишу...");
            //Console.ReadKey();
        }
    }
}
