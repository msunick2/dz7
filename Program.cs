// // Урок 7. Двумерные массивы
// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9

// double[,] CreateArray(int rows, int columns)
// {
//     double[,] newFilledArray = new double[rows, columns];
//     Random Randomizer = new Random();

//     for (int y = 0; y < rows; y++)
//     {
//         for (int x = 0; x < columns; x++)
//         {
//             newFilledArray[y, x] = Randomizer.NextDouble() * Math.Pow(10, Randomizer.Next(2, 5));
//         }
//     }
//     return newFilledArray;
// }

// void PrintArray(double[,] arrayForPrint)
// {
//     for (int y = 0; y < arrayForPrint.GetLength(0); y++)
//     {
//         for (int x = 0; x < arrayForPrint.GetLength(1); x++)
//         {
//             System.Console.Write(" {0,15:F4} ", arrayForPrint[y, x]);
//         }
//         System.Console.WriteLine();
//     }
// }

// int GetNumberInputFromUser()
// {
//     return int.Parse(Console.ReadLine()!);
// }

// void Main()
// {
//     System.Console.Write("Программа сгенерирует массив вещественных числе по заданным размерам.\nВведите количество строк: ");
//     int rowCount = GetNumberInputFromUser();
//     System.Console.Write("Введите количество столбцов: ");
//     int columnCount = GetNumberInputFromUser();
//     System.Console.WriteLine();
//     PrintArray(CreateArray(rowCount, columnCount));
// }

// Main();


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // 17 -> такого числа в массиве нет


// int[,] CreateArray(int rows, int columns)
// {
//     int[,] newFilledArray = new int[rows, columns];
//     Random Randomizer = new Random();

//     for (int y = 0; y < rows; y++)
//     {
//         for (int x = 0; x < columns; x++)
//         {
//             newFilledArray[y, x] = Randomizer.Next(1, 10);
//         }
//     }
//     return newFilledArray;
// }

// void PrintArrayAndX(int[,] arrayForPrint, int xSearch = -1, int ySearch = -1, bool search = false)
// {
//     int hight = arrayForPrint.GetLength(0);
//     int width = arrayForPrint.GetLength(1);
//     if (search)
//     {
//         System.Console.WriteLine($"Сгенерированный массив:\n");
//     }
//     for (int y = 0; y < hight; y++)
//     {
//         for (int x = 0; x < width; x++)
//         {
//             Console.ForegroundColor = (x == xSearch - 1 && ySearch - 1 == y) ? ConsoleColor.DarkRed : ConsoleColor.White;
//             System.Console.Write(" {0,3:F0} ", arrayForPrint[y, x]);
//         }
//         Console.ForegroundColor = ConsoleColor.White;
//         System.Console.WriteLine();
//     }

//     if (search)
//     {
//         if (xSearch - 1 < width && ySearch - 1 < hight && xSearch >= 0 && ySearch >= 0)
//         {
//             System.Console.WriteLine($"\nЗначение в указанной ячейке ({ySearch},{xSearch}) равно {arrayForPrint[ySearch - 1, xSearch - 1]}");
//         }
//         else
//         {
//             System.Console.WriteLine($"\nУказанной ячейки ({ySearch},{xSearch}) не существует в данном массиве");
//         }
//     }
// }

// void Main()
// {
//     System.Console.Write("Программа сгенерирует массив со случайными размерами. А далее найдет значение, хранящееся в указанной позиции. Нажмите любую клавишу:\n ");
//     Console.ReadKey();
//     int rowCount = new Random().Next(4, 10);
//     int columnCount = new Random().Next(4, 10);
//     System.Console.WriteLine();
//     int[,] ourArray = CreateArray(rowCount, columnCount);
//     PrintArrayAndX(ourArray);
//     System.Console.WriteLine();
//     System.Console.Write("Введите номер строки для поиска: "); int yRow = int.Parse(Console.ReadLine()!);
//     System.Console.Write($"Введите номер столбца для поиска: "); int xRow = int.Parse(Console.ReadLine()!);
//     Console.Clear();
//     PrintArrayAndX(ourArray, xRow, yRow, true);
// }

// Main();


// // Задача 52. Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreateArray(int rows, int columns)
// {
//     int[,] newFilledArray = new int[rows, columns];
//     Random Randomizer = new Random();

//     for (int y = 0; y < rows; y++)
//     {
//         for (int x = 0; x < columns; x++)
//         {
//             newFilledArray[y, x] = Randomizer.Next(1, 10);
//         }
//     }
//     return newFilledArray;
// }

// void PrintArray(int[,] arrayForPrint)
// {
//     for (int y = 0; y < arrayForPrint.GetLength(0); y++)
//     {
//         for (int x = 0; x < arrayForPrint.GetLength(1); x++)
//         {
//             System.Console.Write(" {0,6:F0} ", arrayForPrint[y, x]);
//         }
//         System.Console.WriteLine();
//     }
// }

// double[] takeAverageArray(int[,] arrayToSummary)
// {
//     int hight = arrayToSummary.GetLength(0);
//     int width = arrayToSummary.GetLength(1);
//     double[] averageLine = new double[width];
//     for (int x = 0; x < width; x++)
//     {
//         double tempSummColumn = 0;
//         for (int y = 0; y < hight; y++)
//         {
//             tempSummColumn += arrayToSummary[y, x];
//         }
//         averageLine[x] = tempSummColumn / hight;
//     }
//     return averageLine;
// }

// void PrintArrayLine(double[] arrayForPrint)
// {
//     Console.ForegroundColor = ConsoleColor.DarkGreen;
//     for (int i = 0; i < arrayForPrint.Length; i++)
//     {
//         System.Console.Write(" {0,6:F2} ", arrayForPrint[i]);
//     }
//     Console.ForegroundColor = ConsoleColor.White;
// }

// void Main()
// {
//     System.Console.Write("Программа сгенерирует массив со случайными размерами. А далее найдет среднее арифметическое в каждом столбце. Нажмите любую клавишу:\n ");
//     Console.ReadKey();
//     int rowCount = new Random().Next(4, 6);
//     int columnCount = new Random().Next(4, 8);
//     System.Console.WriteLine();
//     int[,] ourArray = CreateArray(rowCount, columnCount);
//     PrintArray(ourArray);
//     System.Console.WriteLine();
//     double[] takeAverageLine = takeAverageArray(ourArray);
//     PrintArrayLine(takeAverageLine);
// }

// Main();