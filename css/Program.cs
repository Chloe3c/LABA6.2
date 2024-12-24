using System;
using classlib;

class Program
{
    static void Main()
    {
        double[,] matrix = new double[6, 4];

        Console.WriteLine("Введите элементы матрицы 6x4 (вещественные числа):");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Элемент [{i + 1}, {j + 1}]: ");
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        double[] maxElements = Class1.GetMaxElements(matrix);

        Console.WriteLine("Максимальные элементы строк:");
        for (int i = 0; i < maxElements.Length; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {maxElements[i]}");
        }
    }
}