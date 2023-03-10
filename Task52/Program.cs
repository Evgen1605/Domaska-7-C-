// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;// эти 2 строчки заменяют Console. теперь на каждом вызове консоли можно не писать
Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

// int rows = 3;
// int colums = 4;
int[,] numbers = new int[rows, columns];
FillArray2D(numbers);
PrintArray2D(numbers);

double[] avgNumbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
  double result = 0.0;
  for (int j = 0; j < numbers.GetLength(0); j++)
  {
    result += numbers[j, i];
  }
  avgNumbers[i] = result / numbers.GetLength(0);
}
WriteLine();
Write($"Среднее арифметическое каждого столбца: ");
PrintArray(avgNumbers);

// Заполнение массива рандомными вещественными числами
void FillArray2D(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

//  Функция вывода двумерного массива в терминал
void PrintArray2D(int[,] inArray)// функция вывода 2-мерного массива в консоль
{
  for (int i = 0; i < inArray.GetLength(0); i++)// первым циклом проходим по массивам
  {
    for (int j = 0; j < inArray.GetLength(1); j++)// второй проходит по элементам
    {
      Write($"{inArray[i, j]} ");// сначала записываем все элементы перврго массива, потом все элементы второго массива и т.д
    }
    WriteLine();//переносим на новую строчку
  }
}

// Функция вывода массива в терминал 
void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Write($"{array[i]:f2} ");
  }
  WriteLine();
}
