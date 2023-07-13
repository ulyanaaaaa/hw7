/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// double[,] CreateArray(int rows, int cols)
// {
//     return new double[rows, cols];
// }

// void FillArray(double[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max) + rnd.NextDouble();
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]:f2} ");
//         Console.WriteLine();
//     }
// }

// int rows = InputNum("Enter rows number: ");
// int columns = InputNum("Enter columns number: ");
// int minValue = InputNum("Enter minimum number: ");
// int maxValue = InputNum("Enter maximum value: ");

// double[,] myArray = CreateArray(rows, columns);
// FillArray(myArray, minValue, maxValue);
// PrintArray(myArray);

/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
*/

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] CreateArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }

// void FillArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");
//         Console.WriteLine();
//     }
// }

// void FindElement(int[,] array, int row, int column)
// {
//     if (row > array.GetLength(0)) 
//     {
//         Console.WriteLine("There is no such element in this array");
//     }
//     else if (column > array.GetLength(1))
//     {
//         Console.WriteLine("There is no such element in this array");
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         if (i == row && j == column)
//                 {
//                     Console.WriteLine($"This element: {array[i-1, j-1]}");
//                 }
//     }
// }

// int rows = InputNum("Enter rows number: ");
// int columns = InputNum("Enter columns number: ");
// int minValue = InputNum("Enter minimum number: ");
// int maxValue = InputNum("Enter maximum value: ");

// int[,] myArray = CreateArray(rows, columns);
// FillArray(myArray, minValue, maxValue);
// PrintArray(myArray);

// int elementRow = InputNum("Enter row you are looking for: ");
// int elementColumn = InputNum("Enter column you are looking for: ");

// FindElement(myArray, elementRow, elementColumn);




/* Задача 52. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateArray(int rows, int cols)
{
    return new int[rows, cols];
}

void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void FindAverage(int[,] array, int row)
{
    Console.Write("Avarages of columns: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
            Console.Write($"{sum/(row):F1}; ");
    }
}

int rows = InputNum("Enter rows number: ");
int columns = InputNum("Enter columns number: ");
int minValue = InputNum("Enter minimum number: ");
int maxValue = InputNum("Enter maximum value: ");

int[,] myArray = CreateArray(rows, columns);
FillArray(myArray, minValue, maxValue);
PrintArray(myArray);

Console.WriteLine();
FindAverage(myArray, rows);