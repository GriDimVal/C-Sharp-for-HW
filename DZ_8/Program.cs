//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
//     return array;
// }
// int[,] Sort2DArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//         for (int n = arr.GetLength(1); n > 0; n--)
//             for (int j = 1; j < n; j++)
//                 if (arr[i, j - 1] > arr[i, j])
//                 {
//                     int temp = arr[i, j];
//                     arr[i, j] = arr[i, j - 1];
//                     arr[i, j - 1] = temp;
//                 }
//     return arr;
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Enter row amount: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter columns amount: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter minimum value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter maximum value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(array);
// Print2DArray(Sort2DArray(array));


//Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.


// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
//     return array;
// }
// int[] CountRowSum(int[,] arr)
// {
//     int[] sumArray = new int[arr.GetLength(0)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//         for (int j = 0; j < arr.GetLength(1); j++)
//             sumArray[i] += arr[i, j];
//     return sumArray;
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         Console.WriteLine($"Сумма строки № {i + 1} = {array[i]} ");
//     Console.WriteLine();
// }
// int FindMinIndex(int[] arr)
// {
//     int minIndex = 0;
//     for (int i = 1; i < arr.Length; i++)
//         if (arr[i] < arr[minIndex])
//             minIndex = i;
//     return minIndex;
// }
// void Main(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = Create2DArray(rows, columns, minValue, maxValue);
//     Print2DArray(array);
//     int[] sumArr = CountRowSum(array);
//     PrintArray(sumArr);
//     int minRow = FindMinIndex(sumArr);
//     Console.WriteLine($"Строка с наименьшей суммой: {minRow + 1}");
// }
// Console.Write("Enter row amount: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter columns amount: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter minimum value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter maximum value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Main(rows, columns, minValue, maxValue);


//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//2 4 | 3 4
//3 2 | 3 3
//18 20
//15 18


// int[,] Create2DArray(int rows, int columns)
// {
//     int[,] arr = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             arr[i, j] = new Random().Next(1, 10);
//     return arr;
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//             if (arr[i, j] < 100) Console.Write($" |0{arr[i, j]}|");
//             else Console.Write($" |{arr[i, j]}|");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// bool CheckForMultiplication(int columns, int rows) => (columns == rows);
// int[,] Мult2Matrices(int[,] matr1, int[,] matr2)
// {
//     int[,] newMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
//     for (int row = 0; row < newMatr.GetLength(0); row++)
//         for (int column = 0; column < newMatr.GetLength(1); column++)
//             for (int j = 0; j < matr1.GetLength(1); j++)
//                 newMatr[row, column] += matr1[row, j] * matr2[j, column];
//     return newMatr;
// }
// void Processor(bool result, int rows1, int rows2, int col1, int col2)
// {
//     if (result)
//     {
//         int[,] firstMatrix = Create2DArray(rows1, col1);
//         PrintArray(firstMatrix);
//         int[,] secondMatrix = Create2DArray(rows2, col2);
//         PrintArray(secondMatrix);
//         int[,] newMatrix = Мult2Matrices(firstMatrix, secondMatrix);
//         PrintArray(newMatrix);
//     }
//     else Console.Write("Такие матрицы не умножаются!!!");
// }
// Console.WriteLine("Умножение двух матриц");
// Console.WriteLine("Введите данные первой матрицы...");
// Console.Write("Введите количество строк: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите данные второй матрицы...");
// Console.Write("Введите количество строк: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// bool result = CheckForMultiplication(columns1, rows2);
// Processor(result,rows1,rows2,columns1,columns2);


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.



// int[,,] Create3DArray(int depth, int height, int width)
// {
//     int[,,] arr3D = new int[depth, height, width];
//     int num = 0;
//     for (int i = 0; i < arr3D.GetLength(0); i++)
//         for (int j = 0; j < arr3D.GetLength(1); j++)
//             for (int k = 0; k < arr3D.GetLength(2); k++)
//                 if (CheckNumber(arr3D, num = new Random().Next(10, 100))) arr3D[i, j, k] = num;
//                 else k--;
//     return arr3D;
// }
// bool CheckNumber(int[,,] arr, int num)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//         for (int j = 0; j < arr.GetLength(1); j++)
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 if (arr[i, j, k] == 0) return true;
//                 else if (arr[i, j, k] == num) return false;
//             }
//     return true;
// }

// void Print3DArray(int[,,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.WriteLine($"Слой № {i + 1}");
//         System.Console.WriteLine();
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//                 Console.Write($"|{arr[i, j, k]}|");
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("трёхмерный массив из неповторяющихся двузначных чисел...");

// while (true)
// {
//     Console.Write("Введите высоту 3D массива: ");
//     int height = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите ширину 3D столбцов: ");
//     int width = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите глубину 3D массива: ");
//     int depth = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine();

//     if (height * width * depth < 90)
//     {
//         int[,,] array3D = Create3DArray(depth, height, width);
//         Print3DArray(array3D); break;
//     }
//     else Console.WriteLine("Превышен допустимый размер массива...");
// }



//Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,] FillArraySpirally(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    int upperBound = 0, leftBound = 0;
    int lowerBound = arr.GetLength(0) - 1;
    int rightBound = arr.GetLength(1) - 1;
    int printNum = 1, step = 1;
    int i = 0, j = 0;
    int sum = arr.Length - 1;
    while (sum != 0)
    {
        for (; j < rightBound; sum--, j++)
            if (arr[i, j + step] == 0)
                arr[i, j] = printNum++;
            else break;
        for (; i < lowerBound; sum--, i++)
            if (arr[i + step, j] == 0)
                arr[i, j] = printNum++;
            else break;
        for (; j > leftBound; sum--, j--)
            if (arr[i, j - step] == 0)
                arr[i, j] = printNum++;
            else break;
        for (; i > upperBound; sum--, i--)
            if (arr[i - step, j] == 0)
                arr[i, j] = printNum++;
            else break;
    }
    arr[i, j] = printNum;
    return arr;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
Console.WriteLine("Спиральное заполнение массива");
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillArraySpirally(rows, columns);
Print2DArray(arr);
*/