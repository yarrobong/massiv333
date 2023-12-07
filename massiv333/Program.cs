using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Задаем размеры массива

        int n = 4;


        // Создаем двумерный массив заданного размера
        int[,] array = new int[n, n];

        // Заполняем массив случайными числами и выводим на экран
        Console.WriteLine("a)");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = i + 1; // случайные числа от 1 до 100
                Console.Write(array[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }

        Console.WriteLine();
        Console.WriteLine("б)");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = j + 1; 
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        Console.WriteLine("в)");
        int[,] array2 = new int[n * 2, n];
        for (int i = 0; i < n * 2; i += 2)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < array.GetLength(0) && j < array.GetLength(1))
                {
                    array[i, j] = j + 1;
                    Console.Write(array[i, j] + "\t");
                }
            }
            Console.WriteLine();

            for (int j = 0; j < n; j++)
            {
                if (i + 1 < array.GetLength(0) && j < array.GetLength(1))
                {
                    array[i + 1, j] = n - j;
                    Console.Write(array[i + 1, j] + "\t");
                }
            }
            Console.WriteLine();
        }

    }
}
