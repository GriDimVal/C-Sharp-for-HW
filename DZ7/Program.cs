//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[] Prompt()
{
    int[] array = new int[4];
    Console.Write("Enter rows amount: ");
    array[row] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter columns amount: ");
    array[column] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter minimum index value: ");
    array[minValue] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter maximum index value: ");
    array[maxValue] = Convert.ToInt32(Console.ReadLine());
    return array;
}
double[,] Create2DRandomArray(int[] arr)
{
    double[,] array = new double[arr[row], arr[column]];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().Next(arr[minValue], arr[maxValue]) + new Random().NextDouble(), 2);
    return array;
}
void Prit2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
int[] array = Prompt();
double[,] randomArray = Create2DRandomArray(array);
Prit2DArray(randomArray);


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.


// int[,] Create2DRandomArray1()
// {
//     int[,] array = new int[5, 5];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
//     return array;
// }
// bool Check2DArray(int[,] arr, int row, int col) => row <= arr.GetLength(0) && col <= arr.GetLength(1);
// void Prit2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }
// Console.Write("Enter a row position: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a column position: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] arr = Create2DRandomArray1();
// Prit2DArray(arr);
// bool result = Check2DArray(arr, row, column);
// if (result) Console.WriteLine($"Значение индекса [{row},{column}] равно: {arr[row-1,column-1]}");
// else Console.WriteLine($"Указанная позиция отсутствует");


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:

// int[,] Create2DRandomArray(int row, int column, int minValue, int maxValue)
// {
//     int[,] array = new int[row, column];
    
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// double[] FindAverageInColumns(int[,] array)
// {
//     double[] newArray = new double[array.GetLength(1)];

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//             sum = sum + array[i, j];
//         newArray[j] = sum / array.GetLength(0);
//     }
//     return newArray;
// }

// void Prit2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// void PritArray(double[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         Console.Write(Math.Round(array[i], 2) + "  ");
// }

// Console.Write("Enter rows amount: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter columns amount: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter minimum index value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter maximum index value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();
// int[,] array = Create2DRandomArray(row, column, minValue, maxValue);
// double[] averageArray = FindAverageInColumns(array);
// Prit2DArray(array);
// Console.WriteLine();
// PritArray(averageArray);