// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] Create2DRandomArray(int rows, int colomns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Sorting(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i,k] < array[i,k+1])
//                 {
//                     int temp = array[i,k];
//                     array[i,k] = array[i,k+1];
//                     array[i,k+1] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(myArray);
// Console.WriteLine();
// Sorting(myArray);
// Show2DArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] Create2DRandomArray(int rows, int colomns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int Sum(int[,] array)
// {
//     int min = 0;
//     int sumElements = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sumElements += array[0, j];
//                 min = sumElements;
//             }

//     if (array.GetLength(0) != array.GetLength(1))
//         Console.WriteLine("Массив не прямоугольный");
//     else
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sumElements += array[i, j];
//             }

//             if (sumElements<min){
//             min = sumElements;
//             sumElements = 0;
//             }
//             else sumElements = 0;
//         }
//     return min;
// }


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(myArray);
// Console.WriteLine();
// int result = Sum(myArray);
// Console.WriteLine(result);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] Create2DRandomArray(int rows, int colomns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void Multiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] finalMatrix)
// {
//     for (int i = 0; i < finalMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < finalMatrix.GetLength(1); j++)
//         {
//             int result = 0;
//             for (int k = 0; k < firstMatrix.GetLength(1); k++)
//             {
//                 result += firstMatrix[i,k] * secondMatrix[k,j];
//             }
//             finalMatrix[i,j] = result;
//         }
//     }
// }

// Console.WriteLine($"Для умножения количество столбцов первой должно быть равно количеству строк второй");

// Console.WriteLine("Введите количество строк 1 матрицы");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 1 матрицы и строк 2-й:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 2 матрицы:");
// int p = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] firstMatrix = Create2DRandomArray(m, n, min, max);
// Console.WriteLine("Первая матрица:");
// Show2DArray(firstMatrix);

// int[,] secondMatrix = Create2DRandomArray(n, p, min, max);
// Console.WriteLine("Вторая матрица:");
// Show2DArray(secondMatrix);

// int[,] finalMatrix = new int[m, p];

// Multiplication(firstMatrix, secondMatrix, finalMatrix);
// Console.WriteLine($"Произведение матриц:");
// Show2DArray(finalMatrix);




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07