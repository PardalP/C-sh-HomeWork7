Console.Clear();

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] FillArray(int m, int n)
// {
//     double[,] array = new double[m, n]; 

//     Random random = new Random(); 

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             double randomNumber = Math.Round(random.NextDouble() * 20 - 10, 1); // генерация числа в диапазоне от -10 до 10 с одной цифрой после запятой
//             array[i, j] = randomNumber;
//         }
//     }

//     return array;
// }

// void PrintArray(double[,] array)
// {
//     int m = array.GetLength(0); 
//     int n = array.GetLength(1); 

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             System.Console.Write($"{array[i, j],4} \t");
//         }
//         Console.WriteLine();
//     }
// }


// System.Console.WriteLine("Введите количество строк:");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = FillArray(m, n); 

// PrintArray(array); 


// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void FillArray(int[,] array){
//     for (int i =0; i<array.GetLength(0);i++){
//         for (int j =0; j<array.GetLength(1);j++){
//             array[i, j] = new Random().Next(-30, 30);
//         }
//     }
// }

// void PrintArray(int[,] array){
//     for (int i =0; i<array.GetLength(0);i++){
//         for (int j =0; j<array.GetLength(1);j++){
//             System.Console.Write($"{array[i, j],3} \t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] FindElement(int[,] array, int element)
// {
//     int m = array.GetLength(0);
//     int n = array.GetLength(1);

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (array[i, j] == element)
//             {
//                 return new int[] { i, j };
//             }
//         }
//     }

//     return null;
// }

// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int [rows, cols];

// FillArray(array);
// PrintArray(array); 

// System.Console.WriteLine("Введите цифру для поиска в массиве:");
// int element = Convert.ToInt32(Console.ReadLine());

// int[] position = FindElement(array, element);

// if (position != null)
// {
//     Console.WriteLine("Элемент {0} найден на позиции ({1}, {2}).", element, position[0], position[1]);
// }
// else
// {
//     Console.WriteLine("Элемент {0} не найден в массиве.", element);
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array){
    for (int i =0; i<array.GetLength(0);i++){
        for (int j =0; j<array.GetLength(1);j++){
            array[i, j] = new Random().Next(-30, 30);
        }
    }
}

void PrintArray(int[,] array){
    for (int i =0; i<array.GetLength(0);i++){
        for (int j =0; j<array.GetLength(1);j++){
            System.Console.Write($"{array[i, j],3} \t");
        }
        System.Console.WriteLine();
    }
}

void CalculateAvr(int[,] array)
{
    int m = array.GetLength(0); // количество строк
    int n = array.GetLength(1); // количество столбцов

    double[] columnAverages = new double[n];

    for (int j = 0; j < n; j++)
    {
        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];
        }

        columnAverages[j] = (double)sum / m;
    }

    Console.WriteLine("Среднее арифметическое каждого столбца:");

    for (int j = 0; j < n; j++)
    {
        Console.Write(columnAverages[j].ToString("F1") + " ");
    }
}

System.Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows, cols];

FillArray(array);
PrintArray(array);

CalculateAvr(array);

System.Console.WriteLine();